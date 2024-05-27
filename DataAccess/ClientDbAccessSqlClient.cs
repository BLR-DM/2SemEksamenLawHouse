using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using Interfaces;

namespace DataAccess
{
    public class ClientDbAccessSqlClient : IClientDbAccess
    {
        ConnectionStringSettingsCollection conn = ConfigurationManager.ConnectionStrings;
        string connString;
        public ClientDbAccessSqlClient()
        {
            //connectionstring Simply fra app.config
            connString = ConfigurationManager.ConnectionStrings["Simply"].ToString();
        }

        public async Task<bool> CreateClientAsync(Client client)
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            {

                try
                {
                    //aabn db
                    await dbConn.OpenAsync();

                    //start transaction
                    using (DbTransaction transaction = await dbConn.BeginTransactionAsync())
                    {
                        try
                        {
                            //insert ind i login tabel
                            string insertLoginQuery = "INSERT INTO LoginDetails VALUES (@UN, @PW, @CD);" +
                                                      "SELECT SCOPE_IDENTITY()"; //selecter primary key

                            int loginDetailsID;

                            //opret command
                            using DbCommand createLoginCMD = new SqlCommand(insertLoginQuery, dbConn, (SqlTransaction)transaction);
                            {
                                createLoginCMD.Parameters.AddRange(new SqlParameter[]
                                {
                                    new SqlParameter("@UN", client.LoginDetails.Username),
                                    new SqlParameter("@PW", client.LoginDetails.Password),
                                    new SqlParameter("@CD", DateTime.Now),
                                });

                                //execute query
                                loginDetailsID = Convert.ToInt32(await createLoginCMD.ExecuteScalarAsync());

                            }


                            //INSERT ind i person tabellen
                            string insertPersonQuery = "INSERT INTO Persons VALUES (@FN, @LN, @EM, @AL, @PC, @C, @LDID);" +
                                                       "SELECT SCOPE_IDENTITY()"; //selecter primary key

                            int personID;

                            //cmd create person
                            using DbCommand createPersonCMD = new SqlCommand(insertPersonQuery, dbConn, (SqlTransaction)transaction);
                            {
                                createPersonCMD.Parameters.AddRange(new SqlParameter[]
                                {
                                    new SqlParameter("@FN", client.Firstname),
                                    new SqlParameter("@LN", client.Lastname),
                                    new SqlParameter("@EM", client.Email),
                                    new SqlParameter("@AL", client.AddressLine),
                                    new SqlParameter("@PC", client.PostalCode),
                                    new SqlParameter("@C", client.City),
                                    new SqlParameter("@LDID", loginDetailsID),
                                });

                                //execute query
                                personID = Convert.ToInt32(await createPersonCMD.ExecuteScalarAsync());
                            }

                            //INSERT ind i Client tabellen
                            string insertClientQuery = "INSERT INTO Clients VALUES (@PID);";

                            using DbCommand createClientCMD = new SqlCommand(insertClientQuery, dbConn, (SqlTransaction)transaction);
                            {
                                createClientCMD.Parameters.AddRange(new SqlParameter[]
                                {
                                    new SqlParameter("@PID", personID),
                                });

                                //execute query
                                await createClientCMD.ExecuteNonQueryAsync();
                            }

                            //INSERT ind i Phones tabellen
                            string insertPhonesQuery = "INSERT INTO Phones VALUES (@PN, @CID)"; //@CID = ClientID/PersonID

                            foreach (Phone phone in client.Phones)
                            {
                                using DbCommand createPhonesCMD = new SqlCommand(insertPhonesQuery, dbConn, (SqlTransaction)transaction);
                                {
                                    createPhonesCMD.Parameters.AddRange(new SqlParameter[]
                                    {
                                        new SqlParameter("@PN", phone.PhoneNumber),
                                        new SqlParameter("@CID", personID),
                                    });

                                    //execute query
                                    await createPhonesCMD.ExecuteNonQueryAsync();
                                }
                            }

                            //commit
                            await transaction.CommitAsync();
                            
                            return true;
                        }
                        catch (Exception)
                        {
                            //rollback
                            await transaction.RollbackAsync();
                            return false;
                        }
                    }
                }
                catch (Exception)
                {

                    return false;
                }
                finally
                {
                    //luk db
                    await dbConn.CloseAsync();
                }
            }
        }

        

        public async Task<Client> GetClientAsync(int clientID)
        {
            Client client = new Client();
            List<Phone> phoneList = new();
            List<ClientSubscription> clientSubscriptonList = new();

            //dbconnection
            using SqlConnection dbConn = new SqlConnection(connString);

            try
            {
                //aabn db
                await dbConn.OpenAsync();

                //query
                string selectAllClientAndPersonQuery = "SELECT p.* FROM Clients c, Persons p WHERE c.PersonID = p.PersonID AND p.PersonID = @CID";

                //cmd
                using SqlCommand SelectClientCMD = new SqlCommand(selectAllClientAndPersonQuery, dbConn);
                {
                    SelectClientCMD.Parameters.AddWithValue("@CID", clientID);

                    //reader, exec reader
                    using SqlDataReader reader = await SelectClientCMD.ExecuteReaderAsync();
                    {
                        //gem read
                        if (await reader.ReadAsync())
                        {
                            client.PersonID = (int)reader["PersonID"];
                            client.Firstname = (string)reader["Firstname"];
                            client.Lastname = (string)reader["Lastname"];
                            client.Email = (string)reader["Email"];
                            client.AddressLine = (string)reader["AddressLine"];
                            client.PostalCode = (int)reader["PostalCode"];
                            client.City = (string)reader["City"];
                            client.LoginDetailsID = (int)reader["LoginDetailsID"];
                        }
                    }
                }


                //query
                string selectAllClientPhonesQuery = "SELECT * FROM Phones WHERE ClientID = @CID";

                //cmd
                using SqlCommand selectPhonesCMD = new SqlCommand(selectAllClientPhonesQuery, dbConn);
                {
                    selectPhonesCMD.Parameters.AddWithValue("@CID", clientID);

                    //reader, exec reader
                    using SqlDataReader phoneReader = await selectPhonesCMD.ExecuteReaderAsync();
                    {
                        //while data gem i phone
                        while (await phoneReader.ReadAsync())
                        {
                            Phone phone = new Phone()
                            {
                                PhoneID = (int)phoneReader["PhoneID"],
                                PhoneNumber = (int)phoneReader["PhoneNumber"],
                                ClientID = (int)phoneReader["ClientID"],
                            };
                            phoneList.Add(phone);

                        }
                    }

                }


                //query
                string selectAllClientSubscriptionQuery = "SELECT * FROM ClientSubscriptions WHERE ClientID = @CID";
                using SqlCommand selectClientSubCMD = new SqlCommand(selectAllClientSubscriptionQuery, dbConn);
                {
                    selectClientSubCMD.Parameters.AddWithValue("@CID", clientID);

                    //reader, exec reader
                    using SqlDataReader subReader = await selectClientSubCMD.ExecuteReaderAsync();
                    {
                        //while data gem clientsubscription
                        while (await subReader.ReadAsync())
                        {
                            ClientSubscription clientSubscription = new ClientSubscription()
                            {
                                ClientSubscriptionID = (int)subReader["ClientSubscriptionID"],
                                StartDate = (DateTime)subReader["StartDate"],
                                EndDate = (DateTime)subReader["EndDate"],
                                PaidPrice = (float)subReader["PaidPrice"],
                                ClientID = (int)subReader["ClientID"],
                                SubscriptionID = (int)subReader["SubscriptionID"]
                            };
                            clientSubscriptonList.Add(clientSubscription);
                        }
                    }
                }
            }
            catch (Exception)
            {

                return new Client();
            }
            finally
            {
                //luk db
                await dbConn.CloseAsync();
            }

            //saetter client icollection phones til telefoner
            client.Phones = phoneList; 

            //saetter client icollection clientsbuscriptions til subscriptions
            client.ClientSubscriptions = clientSubscriptonList;
            

            return client;
        }

        public async Task<List<Phone>> GetClientPhonesAsync(int ClientID)
        {
            List<Phone> phoneList = new();

            //dbconnection
            using SqlConnection dbConn = new SqlConnection(connString);

            try
            {
                //aabn db
                await dbConn.OpenAsync();

                //query
                string selectAllPhonesOnMatchQuery = "SELECT * FROM Phones WHERE ClientID = @CID";

                //cmd
                using SqlCommand selectPhonesCMD = new SqlCommand(selectAllPhonesOnMatchQuery, dbConn);
                {
                    selectPhonesCMD.Parameters.AddWithValue("@CID", ClientID);

                    //reader, exec read
                    using SqlDataReader reader = await selectPhonesCMD.ExecuteReaderAsync();
                    {
                        //while data gem phone
                        while (await reader.ReadAsync())
                        {
                            Phone phone = new Phone()
                            {
                                PhoneID = (int)reader["PhoneID"],
                                PhoneNumber = (int)reader["PhoneNumber"],
                                ClientID = (int)reader["ClientID"],
                            };
                            phoneList.Add(phone);
                        }
                    }
                }
            }
            catch (Exception)
            {

                return new List<Phone>();
            }
            finally
            {
                //luk db
                await dbConn.CloseAsync();
            }
            return phoneList;

        }

        public async Task<List<Client>> GetClientsAsync()
        {
            List<Client> clientList = new();
            List<Phone> phoneList = new();
            List<ClientSubscription> clientSubscriptonList = new();

            //dbconnection
            using SqlConnection dbConn = new SqlConnection(connString);

            try
            {
                //aabn db
                await dbConn.OpenAsync();

                //query
                string selectAllClientAndPersonQuery = "SELECT p.* FROM Clients c, Persons p WHERE c.PersonID = p.PersonID";

                //cmd
                using SqlCommand selectClientCMD = new SqlCommand(selectAllClientAndPersonQuery, dbConn);
                {
                    //reader, exec reac
                    using SqlDataReader reader = await selectClientCMD.ExecuteReaderAsync();
                    {
                        //while read gem client data
                        while (await reader.ReadAsync())
                        {
                            Client client = new Client()
                            {
                                PersonID = (int)reader["PersonID"],
                                Firstname = (string)reader["Firstname"],
                                Lastname = (string)reader["Lastname"],
                                Email = (string)reader["Email"],
                                AddressLine = (string)reader["AddressLine"],
                                PostalCode = (int)reader["PostalCode"],
                                City = (string)reader["City"],
                                LoginDetailsID = (int)reader["LoginDetailsID"],
                            };
                            clientList.Add(client);
                        }
                    }
                }


                //query
                string selectAllClientPhonesQuery = "SELECT * FROM Phones";

                //cmd
                using SqlCommand selectPhonesCMD = new SqlCommand(selectAllClientPhonesQuery, dbConn);
                {
                    //reader, exec read
                    using SqlDataReader phoneReader = await selectPhonesCMD.ExecuteReaderAsync();
                    {
                        //while data gem phone
                        while (await phoneReader.ReadAsync())
                        {
                            Phone phone = new Phone()
                            {
                                PhoneID = (int)phoneReader["PhoneID"],
                                PhoneNumber = (int)phoneReader["PhoneNumber"],
                                ClientID = (int)phoneReader["ClientID"],
                            };
                            phoneList.Add(phone);

                        }
                    }

                }


                //query
                string selectAllClientSubscriptionQuery = "SELECT * FROM ClientSubscriptions";

                //cmd
                using SqlCommand selectClientSubCMD = new SqlCommand(selectAllClientSubscriptionQuery, dbConn);
                {
                    //reader, exec read
                    using SqlDataReader subReader = await selectClientSubCMD.ExecuteReaderAsync();
                    {
                        //while read gem data
                        while (await subReader.ReadAsync())
                        {
                            ClientSubscription clientSubscription = new ClientSubscription()
                            {
                                ClientSubscriptionID = (int)subReader["ClientSubscriptionID"],
                                StartDate = (DateTime)subReader["StartDate"],
                                EndDate = (DateTime)subReader["EndDate"],
                                PaidPrice = (float)subReader["PaidPrice"],
                                ClientID = (int)subReader["ClientID"],
                                SubscriptionID = (int)subReader["SubscriptionID"]
                            };
                            clientSubscriptonList.Add(clientSubscription);
                        }
                    }
                }
            }
            catch (Exception)
            {

                return new List<Client>();
            }
            finally
            {
                //luk db
                await dbConn.CloseAsync();
            }
            
            //for hver klient tilføj telefoner og clientsubs hvor id matcher
            foreach (Client c in clientList)
            {
                c.Phones = phoneList.Where(p => p.ClientID == c.PersonID).ToList();
                c.ClientSubscriptions = clientSubscriptonList.Where(cs => cs.ClientID == c.PersonID).ToList();
            }

            return clientList;
        }

        public async Task<bool> UpdateClientAsync(Client client)
        {
            using SqlConnection dbConn = new SqlConnection(connString);

            try
            {
                //aabn db
                await dbConn.OpenAsync();

                //start transaction
                using (DbTransaction transaction = await dbConn.BeginTransactionAsync())
                {
                    try
                    {
                        //Update i person tabel
                        string updatePersonQuery = "UPDATE Persons SET Firstname = @FN, Lastname = @LN, Email = @EM, AddressLine = @AL, PostalCode = @PC, City = @C, LoginDetailsID = @LDID WHERE PersonID = @PID";

                        using (DbCommand updatePersonsCMD = new SqlCommand(updatePersonQuery, dbConn, (SqlTransaction)transaction))
                        {
                            updatePersonsCMD.Parameters.AddRange(new SqlParameter[]
                            {
                                new SqlParameter("@FN", client.Firstname),
                                new SqlParameter("@LN", client.Lastname),
                                new SqlParameter("@EM", client.Email),
                                new SqlParameter("@AL", client.AddressLine),
                                new SqlParameter("@PC", client.PostalCode),
                                new SqlParameter("@C", client.City),
                                new SqlParameter("@LDID", client.LoginDetailsID),
                                new SqlParameter("@PID", client.PersonID)
                            });
                            //exec cmd
                            await updatePersonsCMD.ExecuteNonQueryAsync();
                        }

                        //Get phone
                        List<int> existingPhoneList = new List<int>();

                        //query
                        string selectAllClientPhonesQuery = "SELECT * FROM Phones WHERE ClientID = @CID";

                        //cmd
                        using SqlCommand selectPhonesCMD = new SqlCommand(selectAllClientPhonesQuery, dbConn, (SqlTransaction)transaction);
                        {
                            selectPhonesCMD.Parameters.AddWithValue("@CID", client.PersonID);

                            //reader, exec read
                            using SqlDataReader phoneReader = await selectPhonesCMD.ExecuteReaderAsync();
                            {
                                //while data save data
                                while (await phoneReader.ReadAsync())
                                {
                                    existingPhoneList.Add((int)phoneReader["PhoneNumber"]);
                                }
                            }

                        }

                        //Insert new phones
                        
                        //query
                        string insertPhonesQuery = "INSERT INTO Phones VALUES (@PN, @CID)"; //@CID = ClientID/PersonID

                        //for hver telefon i client phone list hvis ikke allerede oprettet i databasen "existingphonelist" så opret
                        foreach (Phone phone in client.Phones)
                        {
                            if (!existingPhoneList.Contains(phone.PhoneNumber))
                            {
                                using DbCommand createPhonesCMD = new SqlCommand(insertPhonesQuery, dbConn, (SqlTransaction)transaction);
                                {
                                    createPhonesCMD.Parameters.AddRange(new SqlParameter[]
                                    {
                                        new SqlParameter("@PN", phone.PhoneNumber),
                                        new SqlParameter("@CID", client.PersonID),
                                    });

                                    //exec cmd
                                    await createPhonesCMD.ExecuteNonQueryAsync();
                                }
                            }
                        }

                        //commit
                        await transaction.CommitAsync();
                        return true;
                    }
                    catch (Exception)
                    {
                        //rollback
                        await transaction.RollbackAsync();
                        return false;
                    }

                }
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                //luk db
                dbConn.CloseAsync();
            }

        }

        public async Task<bool> DeleteClientPhoneNumbersAsync(List<Phone> phones)
        {
            using SqlConnection dbConn = new SqlConnection(connString);

            try
            {
                //aabn db
                await dbConn.OpenAsync();

                //DELETE fra phones tabellen
                
                //query
                string insertPhonesQuery = "DELETE FROM Phones WHERE PhoneID = @PHID";

                //for hver phone slet i db hvor id matcher
                foreach (Phone phone in phones)
                {
                    using SqlCommand createPhonesCMD = new SqlCommand(insertPhonesQuery, dbConn);
                    {
                        createPhonesCMD.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@PHID", phone.PhoneID),
                        });

                        //exec cmd
                        await createPhonesCMD.ExecuteNonQueryAsync();
                    }
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                //luk db
               await dbConn.CloseAsync();
            }

            


        }
    }
}
