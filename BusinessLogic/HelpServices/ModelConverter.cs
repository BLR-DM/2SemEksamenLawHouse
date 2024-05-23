using UIModels;
using EntityModels;
using Microsoft.Identity.Client;

namespace BusinessLogic.HelpServices
{
    public class ModelConverter
    {
        //
        //Entity til UI Converters
        //


        public CaseUI ConvertFromCaseEntity(Case caseE)
        {
            CaseUI caseUI = new CaseUI
            {
                CaseID = caseE.CaseID,
                Title = caseE.Title,
                Description = caseE.Description,
                CreationDate = caseE.CreationDate,
                EndDate = caseE.EndDate,
                EstimatedHours = caseE.EstimatedHours,
                Status = caseE.Status,
                TotalPrice = caseE.TotalPrice,

                //foreign keys
                LawyerID = caseE.LawyerID,
                ClientID = caseE.ClientID,
                CaseTypeID = caseE.CaseTypeID,
            };
            return caseUI;
        }

        public CaseUI ConvertFromCaseEntityWithAllCollections(Case caseE)
        {
            CaseUI caseUI = ConvertFromCaseEntity(caseE);
            caseUI.CaseServices = caseE.CaseServices.Select(ConvertFromCaseServiceWithNavEntity).ToList();

            // Nav props
            caseUI.Lawyer = ConvertFromLawyerEntity(caseE.Lawyer);
            caseUI.Client = ConvertFromClientEntity(caseE.Client);
            caseUI.CaseType = ConvertFromCaseTypeEntity(caseE.CaseType);
            return caseUI;
        }

        public CaseUI ConvertFromCaseEntityWithCollections(Case caseE)
        {
            CaseUI caseUI = ConvertFromCaseEntity(caseE);
            caseUI.CaseServices = caseE.CaseServices.Select(ConvertFromCaseServiceEntity).ToList();
            return caseUI;
        }

        public CaseTypeUI ConvertFromCaseTypeEntity(CaseType caseTypeE)
        {
            CaseTypeUI caseTypeUI = new CaseTypeUI
            {
                CaseTypeID = caseTypeE.CaseTypeID,
                Title = caseTypeE.Title,
            };
            return caseTypeUI;
        }

        public CaseServiceUI ConvertFromCaseServiceWithNavEntity(CaseService caseServiceE)
        {
            CaseServiceUI caseServiceUI = new CaseServiceUI
            {
                CaseServiceID = caseServiceE.CaseServiceID,
                Description = caseServiceE.Description,
                Units = caseServiceE.Units,
                HoursWorked = caseServiceE.HoursWorked,
                TotalPrice = caseServiceE.TotalPrice,
                Status = caseServiceE.Status,
                StartDate = caseServiceE.StartDate,
                EndDate = caseServiceE.EndDate,

                //kun i UI
                ServiceName = caseServiceE.Service.Name,
                PriceType = caseServiceE.Service.ServicePriceType.PriceType,


                //foreign key
                CaseID = caseServiceE.CaseID,
                ServiceID = caseServiceE.ServiceID,
                LawyerID = caseServiceE.LawyerID,

                // Nav props
                Lawyer = ConvertFromLawyerEntity(caseServiceE.Lawyer),
                Service = ConvertFromServiceEntity(caseServiceE.Service),
                ServiceEntries = caseServiceE.ServiceEntries.Select(ConvertFromServiceEntryEntity).ToList(),
            };
            return caseServiceUI;
        }

        public CaseServiceUI ConvertFromCaseServiceEntity(CaseService caseServiceE)
        {
            CaseServiceUI caseServiceUI = new CaseServiceUI
            {
                CaseServiceID = caseServiceE.CaseServiceID,
                Description = caseServiceE.Description,
                Units = caseServiceE.Units,
                HoursWorked = caseServiceE.HoursWorked,
                TotalPrice = caseServiceE.TotalPrice,
                Status = caseServiceE.Status,
                StartDate = caseServiceE.StartDate,
                EndDate = caseServiceE.EndDate,


                //foreign key
                CaseID = caseServiceE.CaseID,
                ServiceID = caseServiceE.ServiceID,
                LawyerID = caseServiceE.LawyerID
            };
            return caseServiceUI;
        }

        public CaseServiceUI ConvertFromCaseServiceAndServiceEntity(CaseService caseServiceE)
        {
            CaseServiceUI caseServiceUI = new CaseServiceUI
            {
                CaseServiceID = caseServiceE.CaseServiceID,
                Description = caseServiceE.Description,
                Units = caseServiceE.Units,
                HoursWorked = caseServiceE.HoursWorked,
                TotalPrice = caseServiceE.TotalPrice,
                Status = caseServiceE.Status,
                StartDate = caseServiceE.StartDate,
                EndDate = caseServiceE.EndDate,
                //
                ServiceName = caseServiceE.Service.Name,
                PriceType = caseServiceE.Service.ServicePriceType.PriceType,

                //foreign key
                CaseID = caseServiceE.CaseID,
                ServiceID = caseServiceE.ServiceID,
                LawyerID = caseServiceE.LawyerID,

                // Nav props
                Lawyer = ConvertFromLawyerEntity(caseServiceE.Lawyer),
                Service = ConvertFromServiceEntity(caseServiceE.Service)
            };
            return caseServiceUI;
        }

        public ClientUI ConvertFromClientEntity(Client clientE)
        {
            ClientUI clientUI = new ClientUI
            {
                PersonID = clientE.PersonID,
                Firstname = clientE.Firstname,
                Lastname = clientE.Lastname,
                Email = clientE.Email,
                AddressLine = clientE.AddressLine,
                PostalCode = clientE.PostalCode,
                City = clientE.City,
                MainPhone = clientE.Phones.FirstOrDefault()?.PhoneNumber ?? 0,

                //foreign keys
                LoginDetailsID = clientE.LoginDetailsID
            };
            return clientUI;
        }

        public ClientUI ConvertFromClientWithSubEntity(Client clientE)
        {
            ClientUI clientUI = new ClientUI
            {
                PersonID = clientE.PersonID,
                Firstname = clientE.Firstname,
                Lastname = clientE.Lastname,
                Email = clientE.Email,
                AddressLine = clientE.AddressLine,
                PostalCode = clientE.PostalCode,
                City = clientE.City,
                MainPhone = clientE.Phones.FirstOrDefault()?.PhoneNumber ?? 0, // remove?

                //foreign keys
                LoginDetailsID = clientE.LoginDetailsID
            };

            ClientSubscription? subscription = clientE.ClientSubscriptions
                .FirstOrDefault(cs => cs.EndDate >= DateTime.Now && cs.StartDate <= DateTime.Now);

            if (subscription != null)
            {
                clientUI.IsSubscribed = true;
            }
            else
            {
                clientUI.IsSubscribed = false;
            }

            return clientUI;
        }

        public ClientFormDocumentUI ConvertFromClientFormEntity(ClientFormDocument clientFormE)
        {
            ClientFormDocumentUI clientFormUI = new ClientFormDocumentUI
            {
                ClientFormDocumentID = clientFormE.ClientFormDocumentID,
                BuyDate = clientFormE.BuyDate,

                //foreign keys
                ClientID = clientFormE.ClientID,
                FormDocumentID = clientFormE.FormDocumentID,
            };
            return clientFormUI;
        }

        public EmployeeUI ConvertFromEmployeeEntity(Employee employeeE)
        {
            EmployeeUI employeeUI = new EmployeeUI
            {
                PersonID = employeeE.PersonID,
                Firstname = employeeE.Firstname,
                Lastname = employeeE.Lastname,
                PhoneNumber = employeeE.PhoneNumber,
                Email = employeeE.Email,
                AddressLine = employeeE.AddressLine,
                PostalCode = employeeE.PostalCode,
                City = employeeE.City,
                HireDate = employeeE.HireDate,
                LawyerTitle = employeeE.LawyerTitle.Title,

                //foreign keys
                LoginDetailsID = employeeE.LoginDetailsID,
                LawyerTitleID = employeeE.LawyerTitleID,
            };
            return employeeUI;
        }

        public ClientSubscriptionUI ConvertFromClientSubscriptionEntity(ClientSubscription clientSubscriptionE)
        {
            ClientSubscriptionUI clientSubscriptionUI = new ClientSubscriptionUI
            {
                ClientSubscriptionID = clientSubscriptionE.ClientSubscriptionID,
                StartDate = clientSubscriptionE.StartDate,
                EndDate = clientSubscriptionE.EndDate,
                PaidPrice = clientSubscriptionE.PaidPrice,

                //foreign keys
                ClientID = clientSubscriptionE.ClientID,
                SubscriptionID = clientSubscriptionE.SubscriptionID,
            };
            return clientSubscriptionUI;
        }

        public FormDocumentUI ConvertFromFormEntity(FormDocument formE)
        {
            FormDocumentUI formUI = new FormDocumentUI
            {
                FormDocumentID = formE.FormDocumentID,
                Name = formE.Name,
                Description = formE.Description,
                Price = formE.Price,

            };
            return formUI;
        }

        public LawyerUI ConvertFromLawyerEntity(Lawyer lawyerE)
        {
            LawyerUI lawyerUI = new LawyerUI
            {
                PersonID = lawyerE.PersonID,
                Admin = lawyerE.Admin,
                Firstname = lawyerE.Firstname,
                Lastname = lawyerE.Lastname,
                PhoneNumber = lawyerE.PhoneNumber,
                Email = lawyerE.Email,
                AddressLine = lawyerE.AddressLine,
                PostalCode = lawyerE.PostalCode,
                City = lawyerE.City,
                HireDate = lawyerE.HireDate,
                LawyerTitle = lawyerE.LawyerTitle.Title,

                //foreign keys
                LoginDetailsID = lawyerE.LoginDetailsID,
                LawyerTitleID = lawyerE.LawyerTitleID,
            };
            return lawyerUI;
        }

        public LawyerUI ConvertFromLawyerEntityWithAllCollections(Lawyer lawyerE)
        {
            LawyerUI lawyerUI = ConvertFromLawyerEntity(lawyerE);
            lawyerUI.Cases = lawyerE.Cases.Select(ConvertFromCaseEntity).ToList();
            lawyerUI.CaseServices = lawyerE.CaseServices.Select(ConvertFromCaseServiceAndServiceEntity).ToList();
            lawyerUI.LawyerSpecialities = lawyerE.LawyerSpecialities.Select(ConvertFromLawyerSpecialityEntity).ToList();
            //lawyerUI.OpenCases = lawyerUI.Cases.Count(c => c.Status == "Active");

            return lawyerUI;
        }

        public LawyerUI ConvertFromLawyerEntityWithCollections(Lawyer lawyerE)
        {
            LawyerUI lawyerUI = ConvertFromLawyerEntity(lawyerE);
            lawyerUI.Cases = lawyerE.Cases.Select(ConvertFromCaseEntity).ToList();
            lawyerUI.CaseServices = lawyerE.CaseServices.Select(ConvertFromCaseServiceEntity).ToList();
            lawyerUI.LawyerSpecialities = lawyerE.LawyerSpecialities.Select(ConvertFromLawyerSpecialityEntity).ToList();

            return lawyerUI;
        }

        public ServiceEntryUI ConvertFromServiceEntryEntity(ServiceEntry lawyerE)
        {
            ServiceEntryUI serviceEntryUI = new ServiceEntryUI()
            {
                ServiceEntryID = lawyerE.ServiceEntryID,
                HoursWorked = lawyerE.HoursWorked,
                Date = lawyerE.Date,
                CaseServiceID = lawyerE.CaseServiceID,
            };
            return serviceEntryUI;
        }

        public LawyerSpecialityUI ConvertFromLawyerSpecialityEntity(LawyerSpeciality lawyerSpecialityE)
        {
            LawyerSpecialityUI lawyerSpecialityUI = new LawyerSpecialityUI
            {
                LawyerID = lawyerSpecialityE.LawyerID,
                SpecialityID = lawyerSpecialityE.SpecialityID,

                //
                SpecialityName = lawyerSpecialityE.Speciality.SpecialityName
            };
            return lawyerSpecialityUI;
        }

        public LawyerTitleUI ConvertFromLawyerTitleEntity(LawyerTitle lawyerTitleE)
        {
            LawyerTitleUI lawyerTitleUI = new LawyerTitleUI
            {
                LawyerTitleID = lawyerTitleE.LawyerTitleID,
                Title = lawyerTitleE.Title
            };
            return lawyerTitleUI;
        }

        public PhoneUI ConvertFromPhoneEntity(Phone phoneE)
        {
            PhoneUI phoneUI = new PhoneUI
            {
                PhoneID = phoneE.PhoneID,
                PhoneNumber = phoneE.PhoneNumber,
                ClientID = phoneE.ClientID,
            };
            return phoneUI;
        }

        public SecretaryUI ConvertFromSecretaryEntity(Secretary secretaryE)
        {
            SecretaryUI secretaryUI = new SecretaryUI
            {
                PersonID = secretaryE.PersonID,
                Firstname = secretaryE.Firstname,
                Lastname = secretaryE.Lastname,
                PhoneNumber = secretaryE.PhoneNumber,
                Email = secretaryE.Email,
                AddressLine = secretaryE.AddressLine,
                PostalCode = secretaryE.PostalCode,
                City = secretaryE.City,
                HireDate = secretaryE.HireDate,
                LawyerTitle = secretaryE.LawyerTitle.Title,

                //foreign keys
                LoginDetailsID = secretaryE.LoginDetailsID,
                LawyerTitleID = secretaryE.LawyerTitleID,
            };
            return secretaryUI;
        }

        public ServiceUI ConvertFromServiceEntity(Service serviceE)
        {
            ServiceUI serviceUI = new ServiceUI
            {
                ServiceID = serviceE.ServiceID,
                Name = serviceE.Name,
                Description = serviceE.Description,
                PriceType = serviceE.ServicePriceType.PriceType,
                Price = serviceE.Price,
                ServicePriceTypeID = serviceE.ServicePriceTypeID,
            };
            return serviceUI;
        }

        public ServicePriceTypeUI ConvertFromServicePriceTypeEntity(ServicePriceType servicePriceTypeE)
        {
            ServicePriceTypeUI servicePriceTypeUI = new ServicePriceTypeUI
            {
                ServicePriceTypeID = servicePriceTypeE.ServicePriceTypeID,
                PriceType = servicePriceTypeE.PriceType,
            };

            return servicePriceTypeUI;
        }

        public SpecialityUI ConvertFromSpecialityEntity(Speciality specialityE)
        {
            SpecialityUI specialityUI = new SpecialityUI
            {
                SpecialityID = specialityE.SpecialityID,
                SpecialityName = specialityE.SpecialityName,
            };
            return specialityUI;
        }


        public SubscriptionUI ConvertFromSubscriptionEntity(Subscription subscriptionE)
        {
            SubscriptionUI subscriptionUI = new SubscriptionUI
            {
                SubscriptionID = subscriptionE.SubscriptionID,
                Title = subscriptionE.Title,
                Price = subscriptionE.Price,
            };
            return subscriptionUI;
        }

        public PersonUI ConvertFromPersonEntity(Person personE)
        {
            PersonUI personUI = new PersonUI
            {
                PersonID = personE.PersonID,
                Firstname = personE.Firstname,
                Lastname = personE.Lastname,
                Email = personE.Email,
                AddressLine = personE.AddressLine,
                PostalCode = personE.PostalCode,
                City = personE.City,
                LoginDetailsID = personE.LoginDetailsID,
            };
            return personUI;
        }



        //
        //UI til Entity Converters
        //

        public Case ConvertFromCaseUI(CaseUI caseUI)
        {
            Case caseE = new Case
            {
                CaseID = caseUI.CaseID,
                Description = caseUI.Description,
                Title = caseUI.Title,
                CreationDate = caseUI.CreationDate,
                EndDate = caseUI.EndDate,
                EstimatedHours = caseUI.EstimatedHours,
                Status = caseUI.Status,
                TotalPrice = caseUI.TotalPrice,

                CaseTypeID = caseUI.CaseTypeID,
                LawyerID = caseUI.LawyerID,
                ClientID = caseUI.ClientID,
            };
            return caseE;
        }

        public CaseService ConvertFromCaseServiceUI(CaseServiceUI CaseServiceUI)
        {
            CaseService caseServiceE = new CaseService
            {
                CaseServiceID = CaseServiceUI.CaseServiceID,
                Status = CaseServiceUI.Status,
                Description = CaseServiceUI.Description,
                HoursWorked = CaseServiceUI.HoursWorked,
                Units = CaseServiceUI.Units,
                TotalPrice = CaseServiceUI.TotalPrice,
                StartDate = CaseServiceUI.StartDate, // test
                EndDate = CaseServiceUI.EndDate,



                //foreign keys
                CaseID = CaseServiceUI.CaseID,
                ServiceID = CaseServiceUI.ServiceID,
                LawyerID = CaseServiceUI.LawyerID,
            };
            return caseServiceE;
        }

        public Client ConvertFromClientUI(ClientUI clientUI)
        {
            Client clientE = new Client
            {
                PersonID = clientUI.PersonID,
                Firstname = clientUI.Firstname,
                Lastname = clientUI.Lastname,
                Email = clientUI.Email,
                AddressLine = clientUI.AddressLine,
                PostalCode = clientUI.PostalCode,
                City = clientUI.City,


                //foreign keys
                LoginDetailsID = clientUI.LoginDetailsID,
            };
            return clientE;
        }

        public Phone ConvertFromPhoneUI(PhoneUI phoneUI)
        {
            Phone phoneE = new Phone
            {
                PhoneID = phoneUI.PhoneID,
                PhoneNumber = phoneUI.PhoneNumber,

                //foreign key
                ClientID = phoneUI.ClientID,
            };
            return phoneE;
        }

        public LoginDetails ConvertFromLoginDetailsUI(LoginDetailsUI loginDetailsUI)
        {
            LoginDetails loginDetailsE = new LoginDetails
            {
                LoginDetailsID = loginDetailsUI.LoginDetailsID,
                Username = loginDetailsUI.Username,
                Password = loginDetailsUI.Password,
                CreationDate = loginDetailsUI.CreationDate,
            };
            return loginDetailsE;
        }

        public ClientFormDocument ConvertFromClientFormUI(ClientFormDocumentUI clientFormUI)
        {
            ClientFormDocument clientFormE = new ClientFormDocument
            {
                ClientFormDocumentID = clientFormUI.ClientFormDocumentID,
                BuyDate = clientFormUI.BuyDate,

                //foreign keys
                ClientID = clientFormUI.ClientID,
                FormDocumentID = clientFormUI.FormDocumentID,
            };
            return clientFormE;
        }

        public ClientSubscription ConvertFromClientSubscriptionUI(ClientSubscriptionUI clientSubscriptionUI)
        {
            ClientSubscription clientSubcriptionE = new ClientSubscription
            {
                ClientSubscriptionID = clientSubscriptionUI.ClientSubscriptionID,
                StartDate = clientSubscriptionUI.StartDate,
                EndDate = clientSubscriptionUI.EndDate,
                PaidPrice = clientSubscriptionUI.PaidPrice,

                //foriegn keys
                ClientID = clientSubscriptionUI.ClientID,
                SubscriptionID = clientSubscriptionUI.SubscriptionID,
            };
            return clientSubcriptionE;
        }

        public FormDocument ConvertFromFormUI(FormDocumentUI formUI)
        {
            FormDocument formE = new FormDocument
            {
                FormDocumentID = formUI.FormDocumentID,
                Name = formUI.Name,
                Description = formUI.Description,
                Price = formUI.Price,

            };
            return formE;
        }

        public Lawyer ConvertFromLawyerUI(LawyerUI lawyerUI)
        {
            Lawyer lawyerE = new Lawyer
            {
                //employee attributter
                PersonID = lawyerUI.PersonID,
                Firstname = lawyerUI.Firstname,
                Lastname = lawyerUI.Lastname,
                PhoneNumber = lawyerUI.PhoneNumber,
                Email = lawyerUI.Email,
                AddressLine = lawyerUI.AddressLine,
                PostalCode = lawyerUI.PostalCode,
                City = lawyerUI.City,
                LawyerTitleID = lawyerUI.LawyerTitleID,
                HireDate = lawyerUI.HireDate,
                Admin = lawyerUI.Admin,

                // foreign keys
                LoginDetailsID = lawyerUI.LoginDetailsID,

            };
            return lawyerE;
        }

        public LawyerTitle ConvertFromLawyerTitleUI(LawyerTitleUI lawyerTitleUI)
        {
            LawyerTitle lawyerTitleE = new LawyerTitle
            {
                Title = lawyerTitleUI.Title,
                LawyerTitleID = lawyerTitleUI.LawyerTitleID
            };
            return lawyerTitleE;
        }

        public LawyerSpeciality ConvertFromLawyerSpecialityUI(LawyerSpecialityUI lawyerSpecialityUI)
        {
            LawyerSpeciality lawyerSpecialityE = new LawyerSpeciality
            {
                LawyerID = lawyerSpecialityUI.LawyerID,
                SpecialityID = lawyerSpecialityUI.SpecialityID,
            };
            return lawyerSpecialityE;
        }

        public Employee ConvertFromEmployeeUI(EmployeeUI employeeUI)
        {
            Employee employeeE = new Employee
            {
                PersonID = employeeUI.PersonID,
                Firstname = employeeUI.Firstname,
                Lastname = employeeUI.Lastname,
                PhoneNumber = employeeUI.PhoneNumber,
                Email = employeeUI.Email,
                AddressLine = employeeUI.AddressLine,
                PostalCode = employeeUI.PostalCode,
                City = employeeUI.City,
                HireDate = employeeUI.HireDate,
                LawyerTitleID = employeeUI.LawyerTitleID,

                //foreign keys
                LoginDetailsID = employeeUI.LoginDetailsID
            };
            return employeeE;
        }

        public Secretary ConvertFromSecretaryUI(SecretaryUI secretaryUI)
        {
            Secretary secretaryE = new Secretary
            {
                //employee attributter
                PersonID = secretaryUI.PersonID,
                Firstname = secretaryUI.Firstname,
                Lastname = secretaryUI.Lastname,
                PhoneNumber = secretaryUI.PhoneNumber,
                Email = secretaryUI.Email,
                AddressLine = secretaryUI.AddressLine,
                PostalCode = secretaryUI.PostalCode,
                City = secretaryUI.City,
                LawyerTitleID = secretaryUI.LawyerTitleID,
                HireDate = secretaryUI.HireDate,

                // foreign keys
                LoginDetailsID = secretaryUI.LoginDetailsID,

            };
            return secretaryE;
        }

        public Service ConvertFromServiceUI(ServiceUI serviceUI)
        {
            Service serviceE = new Service
            {
                ServiceID = serviceUI.ServiceID,
                Name = serviceUI.Name,
                Description = serviceUI.Description,
                //PriceType = serviceUI.PriceType,
                Price = serviceUI.Price,
                ServicePriceTypeID = serviceUI.ServicePriceTypeID,
            };
            return serviceE;
        }

        public ServiceEntry ConvertFromServiceEntryUI(ServiceEntryUI serviceEntryUI)
        {
            ServiceEntry serviceEntryE = new ServiceEntry
            {
                ServiceEntryID = serviceEntryUI.ServiceEntryID,
                Date = serviceEntryUI.Date,
                HoursWorked = serviceEntryUI.HoursWorked,
                CaseServiceID = serviceEntryUI.CaseServiceID,

            };
            return serviceEntryE;
        }

        public ServicePriceType ConvertFromServicePriceTypeUI(ServicePriceTypeUI servicePriceTypeUI)
        {
            ServicePriceType servicePriceTypeE = new ServicePriceType
            {
                ServicePriceTypeID = servicePriceTypeUI.ServicePriceTypeID,
                PriceType = servicePriceTypeUI.PriceType,
            };

            return servicePriceTypeE;
        }

        public Speciality ConvertFromSpecialityUI(SpecialityUI specialityUI)
        {
            Speciality specialityE = new Speciality
            {

                SpecialityID = specialityUI.SpecialityID,
                SpecialityName = specialityUI.SpecialityName,
            };
            return specialityE;
        }

        public Subscription ConvertFromSubscriptionUI(SubscriptionUI subscriptionUI)
        {
            Subscription subscriptionE = new Subscription
            {
                SubscriptionID = subscriptionUI.SubscriptionID,
                Title = subscriptionUI.Title,
                Price = subscriptionUI.Price,
            };
            return subscriptionE;
        }

        //public User ConvertFromUserUI(UserUI userUI)
        //{
        //    User userE = new User
        //    {
        //        UserID = userUI.UserID,
        //        Username = userUI.Username,
        //        Password = userUI.Password,
        //        Type = userUI.Type,
        //    };
        //    return userE;
        //}







    }
}
