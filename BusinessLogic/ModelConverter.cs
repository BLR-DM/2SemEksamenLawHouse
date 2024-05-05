using UIModels;
using EntityModels;

namespace BusinessLogic
{
    public class ModelConverter
    {
        //
        //Entity til UI Converters
        //

        public CalculationUI ConvertFromCalculationEntity(Calculation calculationE)
        {
            CalculationUI  calculationUI = new CalculationUI 
            { 
                CalculationID = calculationE.CalculationID,
                Name = calculationE.Name
            };
            return calculationUI;
        }

        public CaseUI ConvertFromCaseEntity(Case caseE)
        {
            CaseUI caseUI = new CaseUI
            {
                CaseID = caseE.CaseID, 
                Title = caseE.Title, 
                //CaseType = caseE.CaseType,
                CreationDate = caseE.CreationDate,
                EndDate = caseE.EndDate,
                EstHours = caseE.EstimatedHours,
                Status = caseE.Status,
                TotalPrice = caseE.TotalPrice,

                //foreign keys
                LawyerID = caseE.LawyerID,
                ClientID = caseE.ClientID,
                CaseTypeID = caseE.CaseTypeID,
            };
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

        public CaseServiceUI ConvertFromCaseServiceEntity(CaseService caseServiceE)
        {
            CaseServiceUI caseServiceUI = new CaseServiceUI
            {
                CaseServiceID = caseServiceE.CaseServiceID,
                Units = caseServiceE.Units,
                TotalPrice = caseServiceE.TotalPrice,
                Date = caseServiceE.Date,

                //foreign key
                CaseID = caseServiceE.CaseID,
                ServiceID = caseServiceE.ServiceID,
                LawyerID = caseServiceE.LawyerID,
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
                ClientSub = clientE.ClientSub,
                MainPhone = clientE.Phones.FirstOrDefault()?.PhoneNumber ?? 0,

                //foreign keys
                LoginDetailsID = clientE.LoginDetailsID,
                
            };
            return clientUI;
        }

        public ClientFormularUI ConvertFromClientFormularEntity(ClientFormular clientFormularE)
        {
            ClientFormularUI clientFormularUI = new ClientFormularUI
            {
                ClientFormularID = clientFormularE.ClientFormularID,
                BuyDate = clientFormularE.BuyDate,

                //foreign keys
                ClientID = clientFormularE.ClientID,
                FormularID = clientFormularE.FormularID,
            };
            return clientFormularUI;
        }

        public ClientSubscriptionUI ConvertFromClientSubscriptionEntity(ClientSubscription clientSubscriptionE)
        {
            ClientSubscriptionUI clientSubscriptionUI = new ClientSubscriptionUI
            {
                ClientSubscriptionID = clientSubscriptionE.ClientSubscriptionID,
                StartDate = clientSubscriptionE.StartDate,
                EndDate = clientSubscriptionE.EndDate,

                //foreign keys
                ClientID = clientSubscriptionE.ClientID,
                SubscriptionID = clientSubscriptionE.SubscriptionID,
            };
            return clientSubscriptionUI;
        }

        public FormularUI ConvertFromFormularEntity(Formular formularE)
        {
            FormularUI formularUI = new FormularUI
            {
                FormularID = formularE.FormularID,
                Name = formularE.Name,
                Description = formularE.Description,
                Price = formularE.Price,

            };
            return formularUI;
        }

        public LawyerUI ConvertFromLawyerEntity(Lawyer lawyerE)
        {
            LawyerUI lawyerUI = new LawyerUI
            {
                PersonID = lawyerE.PersonID,
                Firstname = lawyerE.Firstname,
                Lastname = lawyerE.Lastname,
                PhoneNumber = lawyerE.PhoneNumber,
                Email = lawyerE.Email,
                AddressLine = lawyerE.AddressLine,
                PostalCode = lawyerE.PostalCode,
                City = lawyerE.City,
                HireDate = lawyerE.HireDate,


                //foreign keys
                LoginDetailsID = lawyerE.LoginDetailsID,
                LawyerTitleID = lawyerE.LawyerTitleID,
            };
            return lawyerUI;
        }

        public LawyerSpecialityUI ConvertFromLawyerSpecialityEntity(LawyerSpeciality lawyerSpecialityE)
        {
            LawyerSpecialityUI lawyerSpecialityUI = new LawyerSpecialityUI
            {
                LawyerID = lawyerSpecialityE.LawyerID,
                SpecialityID = lawyerSpecialityE.SpecialityID,
            };
            return lawyerSpecialityUI;
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
                //SecretaryID = secretaryE.SecretaryID,
                Firstname = secretaryE.Firstname,
                Lastname = secretaryE.Lastname,
                PhoneNumber = secretaryE.PhoneNumber,
                Email = secretaryE.Email,
                AddressLine = secretaryE.AddressLine,
                PostalCode = secretaryE.PostalCode,
                HireDate = secretaryE.HireDate,

                //foreign Key
                //UserID = secretaryE.UserID,
            };
            return secretaryUI;
        }

        public ServiceUI ConvertFromServiceEntity(Service serviceE)
        {
            ServiceUI serviceUI = new ServiceUI
            {
                ServiceID = serviceE.ServiceID,
                Description = serviceE.Description,
                //PriceType = serviceE.PriceType,
                Price = serviceE.Price,
            };
            return serviceUI;
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

        //public UserUI ConvertFromUserEntity(User userE)
        //{
        //    UserUI userUI = new UserUI
        //    {
        //        UserID = userE.UserID,
        //        Username = userE.Username,
        //        Password = userE.Password,
        //        //Type = userE.Type,
        //    };
        //    return userUI;
        //}



        //
        //UI til Entity Converters
        //
        
        public Calculation ConvertFromCalculationUI(CalculationUI calculationUI)
        {
            Calculation calculationE = new Calculation
            {
                CalculationID = calculationUI.CalculationID,
                Name = calculationUI.Name,
            };
            return calculationE;
        }

        public Case ConvertFromCaseUI(CaseUI caseUI)
        {
            Case caseE = new Case
            {
                CaseID = caseUI.CaseID,
                Title = caseUI.Title,
                //CaseType = caseUI.CaseType,
                CreationDate = caseUI.CreationDate,
                EndDate = caseUI.EndDate,
                EstimatedHours = caseUI.EstHours,
                Status = caseUI.Status,
                TotalPrice = caseUI.TotalPrice,
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
                Units = CaseServiceUI.Units,
                TotalPrice = CaseServiceUI.TotalPrice,
                Date = CaseServiceUI.Date,

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
                ClientSub = clientUI.ClientSub,

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

        public ClientFormular ConvertFromClientFormularUI(ClientFormularUI clientFormularUI)
        {
            ClientFormular clientFormularE = new ClientFormular
            {
                ClientFormularID = clientFormularUI.ClientFormularID,
                BuyDate = clientFormularUI.BuyDate,

                //foreign keys
                ClientID = clientFormularUI.ClientID,
                FormularID = clientFormularUI.FormularID,
            };
            return clientFormularE;
        }

        public ClientSubscription ConvertFromClientSubscriptionUI(ClientSubscriptionUI clientSubscriptionUI)
        {
            ClientSubscription clientSubcriptionE = new ClientSubscription
            {
                ClientSubscriptionID = clientSubscriptionUI.ClientSubscriptionID,
                StartDate = clientSubscriptionUI.StartDate,
                EndDate = clientSubscriptionUI.EndDate,

                //foriegn keys
                ClientID = clientSubscriptionUI.ClientID,
                SubscriptionID = clientSubscriptionUI.SubscriptionID,
            };
            return clientSubcriptionE;
        }

        public Formular ConvertFromFormularUI(FormularUI formularUI)
        {
            Formular formularE = new Formular
            {
                FormularID = formularUI.FormularID,
                Name = formularUI.Name,
                Description = formularUI.Description,
                Price = formularUI.Price,

            };
            return formularE;
        }
        
        public Lawyer ConvertFromLawyerUI(LawyerUI lawyerUI)
        {
            Lawyer lawyerE = new Lawyer
            {
                //LawyerID = lawyerUI.LawyerID,
                //Title = lawyerUI.Title,

                //employee attributter
                Firstname = lawyerUI.Firstname,
                Lastname = lawyerUI.Lastname,
                PhoneNumber = lawyerUI.PhoneNumber,
                Email = lawyerUI.Email,
                AddressLine = lawyerUI.AddressLine,
                PostalCode = lawyerUI.PostalCode,
                HireDate = lawyerUI.HireDate,

                //foreignKey
                //UserID = lawyerUI.UserID,
            };
            return lawyerE;
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

        public Secretary ConvertFromSecretaryUI(SecretaryUI secretaryUI)
        {
            Secretary secretaryE = new Secretary
            {
                //SecretaryID = secretaryUI.SecretaryID,

                //employee attributter
                Firstname = secretaryUI.Firstname,
                Lastname = secretaryUI.Lastname,
                PhoneNumber = secretaryUI.PhoneNumber,
                Email = secretaryUI.Email,
                AddressLine = secretaryUI.AddressLine,
                PostalCode = secretaryUI.PostalCode,
                HireDate = secretaryUI.HireDate,

                //foreign key
                //UserID = secretaryUI.UserID,
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
            };
            return serviceE;
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
