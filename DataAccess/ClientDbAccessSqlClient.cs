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
                    await dbConn.OpenAsync();

                    using (DbTransaction transaction = await dbConn.BeginTransactionAsync())
                    {
                        try
                        {
                            //insert ind i login tabel
                            string insertLoginQuery = "INSERT INTO LoginDetails VALUES (@UN, @PW, @CD);" +
                                                      "SELECT SCOPE_IDENTITY()";

                            int loginDetailsID;

                            using DbCommand createLoginCMD = new SqlCommand(insertLoginQuery, dbConn, (SqlTransaction)transaction);
                            {
                                createLoginCMD.Parameters.AddRange(new SqlParameter[]
                                {
                                    new SqlParameter("@UN", client.LoginDetails.Username),
                                    new SqlParameter("@PW", client.LoginDetails.Password),
                                    new SqlParameter("@CD", DateTime.Now),
                                });

                                loginDetailsID = Convert.ToInt32(await createLoginCMD.ExecuteScalarAsync());

                            }


                            //INSERT ind i person tabellen
                            string insertPersonQuery = "INSERT INTO Persons VALUES (@FN, @LN, @EM, @AL, @PC, @C, @LDID);" +
                                                       "SELECT SCOPE_IDENTITY()";

                            int personID;

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


                                    await createPhonesCMD.ExecuteNonQueryAsync();
                                }
                            }

                            await transaction.CommitAsync();
                            
                            return true;
                        }
                        catch (Exception)
                        {

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
                    await dbConn.CloseAsync();
                }
            }
        }

        

        public async Task<Client> GetClientAsync(int ClientID)
        {
            Client client = new Client();
            List<Phone> phoneList = new();
            List<ClientSubscription> clientSubscriptonList = new();

            //dbconnection
            using SqlConnection dbConn = new SqlConnection(connString);

            try
            {
                await dbConn.OpenAsync();

                string selectAllClientAndPersonQuery = "SELECT p.* FROM Clients c, Persons p WHERE c.PersonID = p.PersonID";

                using SqlCommand SelectClientCMD = new SqlCommand(selectAllClientAndPersonQuery, dbConn);
                {

                    using SqlDataReader reader = await SelectClientCMD.ExecuteReaderAsync();
                    {
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



                string selectAllClientPhonesQuery = "SELECT * FROM Phones WHERE ClientID = @CID";

                using SqlCommand selectPhonesCMD = new SqlCommand(selectAllClientPhonesQuery, dbConn);
                {
                    selectPhonesCMD.Parameters.AddWithValue("@CID", ClientID);
                    using SqlDataReader phoneReader = await selectPhonesCMD.ExecuteReaderAsync();
                    {
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



                string selectAllClientSubscriptionQuery = "SELECT * FROM ClientSubscriptions WHERE ClientID = @CID";
                using SqlCommand selectClientSubCMD = new SqlCommand(selectAllClientSubscriptionQuery, dbConn);
                {
                    selectClientSubCMD.Parameters.AddWithValue("@CID", ClientID);
                    using SqlDataReader subReader = await selectClientSubCMD.ExecuteReaderAsync();
                    {

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
                await dbConn.CloseAsync();
            }


            client.Phones = phoneList; 
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
                await dbConn.OpenAsync();

                string selectAllPhonesOnMatchQuery = "SELECT * FROM Phones WHERE ClientID = @CID";

                using SqlCommand selectPhonesCMD = new SqlCommand(selectAllPhonesOnMatchQuery, dbConn);
                {
                    selectPhonesCMD.Parameters.AddWithValue("@CID", ClientID);
                    using SqlDataReader reader = await selectPhonesCMD.ExecuteReaderAsync();
                    {
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
                await dbConn.OpenAsync();

                string selectAllClientAndPersonQuery = "SELECT p.* FROM Clients c, Persons p WHERE c.PersonID = p.PersonID";

                using SqlCommand selectClientCMD = new SqlCommand(selectAllClientAndPersonQuery, dbConn);
                {

                    using SqlDataReader reader = await selectClientCMD.ExecuteReaderAsync();
                    {
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



                string selectAllClientPhonesQuery = "SELECT * FROM Phones";

                using SqlCommand selectPhonesCMD = new SqlCommand(selectAllClientPhonesQuery, dbConn);
                {
                    using SqlDataReader phoneReader = await selectPhonesCMD.ExecuteReaderAsync();
                    {
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



                string selectAllClientSubscriptionQuery = "SELECT * FROM ClientSubscriptions";
                using SqlCommand selectClientSubCMD = new SqlCommand(selectAllClientSubscriptionQuery, dbConn);
                {
                    using SqlDataReader subReader = await selectClientSubCMD.ExecuteReaderAsync();
                    {
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
                await dbConn.CloseAsync();
            }
            

            foreach (Client c in clientList)
            {
                c.Phones = phoneList.Where(p => p.ClientID == c.PersonID).ToList();
                c.ClientSubscriptions = clientSubscriptonList.Where(cs => cs.ClientID == c.PersonID).ToList();
            }

            return clientList;
        }

        public async Task<bool> UpdateClientAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteClientPhoneNumbersAsync(List<Phone> phones)
        {
            throw new NotImplementedException();
        }
    }
}
