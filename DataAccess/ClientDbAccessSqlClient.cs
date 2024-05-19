using System;
using System.Collections.Generic;
using System.Configuration;
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
            throw new NotImplementedException();
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

                using SqlCommand sqlCommandClient = new SqlCommand(selectAllClientAndPersonQuery, dbConn);
                {

                    using SqlDataReader reader = await sqlCommandClient.ExecuteReaderAsync();
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

                using SqlCommand sqlCommandPhones = new SqlCommand(selectAllClientPhonesQuery, dbConn);
                {
                    sqlCommandPhones.Parameters.AddWithValue("@CID", ClientID);
                    using SqlDataReader phoneReader = await sqlCommandPhones.ExecuteReaderAsync();
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
                using SqlCommand sqlCommandClientSubscriptions = new SqlCommand(selectAllClientSubscriptionQuery, dbConn);
                {
                    sqlCommandClientSubscriptions.Parameters.AddWithValue("@CID", ClientID);
                    using SqlDataReader subReader = await sqlCommandClientSubscriptions.ExecuteReaderAsync();
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

                using SqlCommand sqlCommand = new SqlCommand(selectAllPhonesOnMatchQuery, dbConn);
                {
                    sqlCommand.Parameters.AddWithValue("@CID", ClientID);
                    using SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
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

                using SqlCommand sqlCommandClient = new SqlCommand(selectAllClientAndPersonQuery, dbConn);
                {

                    using SqlDataReader reader = await sqlCommandClient.ExecuteReaderAsync();
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

                using SqlCommand sqlCommandPhones = new SqlCommand(selectAllClientPhonesQuery, dbConn);
                {
                    using SqlDataReader phoneReader = await sqlCommandPhones.ExecuteReaderAsync();
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
                using SqlCommand sqlCommandClientSubscriptions = new SqlCommand(selectAllClientSubscriptionQuery, dbConn);
                {
                    using SqlDataReader subReader = await sqlCommandClientSubscriptions.ExecuteReaderAsync();
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
