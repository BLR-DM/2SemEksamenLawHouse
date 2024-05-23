using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class PrintCaseDetailsView : Form
    {
        List<string> textToWrite;

        CaseUI caseUI;
        List<CaseTypeUI> caseTypes;
        LawyerUI lawyer;
        ClientUI client;
        List<CaseServiceUI> caseServices;
        List<ServiceUI> services;
        List<LawyerUI> lawyers;
        CaseBL caseBL;

        ServiceBL serviceBL;
        LawyerBL lawyerBL;
        ServiceEntryBL serviceEntryBL;
        CaseUI caseUItest;

        public PrintCaseDetailsView(CaseUI caseUI, List<CaseTypeUI> caseTypes, LawyerUI lawyer,
                                    ClientUI client, List<CaseServiceUI> caseServices,
                                    ServiceBL serviceBL, LawyerBL lawyerBL, ServiceEntryBL serviceEntryBL)
        {
            serviceBL = new ServiceBL();
            caseBL = new CaseBL();

            this.caseUI = caseUI;
            this.caseTypes = caseTypes;
            this.lawyer = lawyer;
            this.client = client;
            this.caseServices = caseServices;
            this.serviceBL = serviceBL;
            this.lawyerBL = lawyerBL;
            this.serviceEntryBL = serviceEntryBL;

            services = new List<ServiceUI>();
            lawyers = new List<LawyerUI>();

            InitializeComponent();
            textToWrite = new List<string>();
            btnBrowse.Click += BtnBrowse_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            Load += PrintCaseDetailsView_Load;
        }

        private async void PrintCaseDetailsView_Load(object? sender, EventArgs e)
        {
            caseUItest = await caseBL.GetCaseWithAllCollectionsAsync(caseUI.CaseID);
            await GetServicesAsync();
            await GetLawyersAsync();
        }

        private async void BtnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;

            caseUItest.PrintDetails(txtPath.Text);

            //BuildHeader(caseUI, lawyer, client);

            //foreach(CaseServiceUI caseService in caseServices)
            //{
            //    if(caseService.PriceType == "Kilometer")
            //    {
            //        BuildKilometerServiceText(caseService);
            //    }
            //    else if(caseService.PriceType == "Hourly")
            //    {
            //        await BuildHourlyServiceTextAsync(caseService);
            //    }
            //    else if(caseService.PriceType == "Fixed")
            //    {
            //        await BuildFixedServiceTextAsync(caseService);
            //    }
            //}


            //try
            //{
            //    File.WriteAllLines(txtPath.Text, textToWrite);
            //}
            //catch (Exception)
            //{

            //    System.Windows.Forms.MessageBox.Show("Error!, File wasnt made");
            //    return;

            //}
            //finally
            //{
            //    btnSave.Enabled = true;
            //}

            //System.Windows.Forms.MessageBox.Show("File was succesfully created!");
            //this.Close();

        }

        private void BuildHeader(CaseUI caseUI, LawyerUI lawyer, ClientUI client)
        {
            string caseType = caseTypes.FirstOrDefault(ct => ct.CaseTypeID == caseUI.CaseTypeID).Title;

            List<string> header = new List<string>()
            {
                $"Case Number: {caseUI.CaseID}",
                $"Case Type: {caseType}",
                $"",
                $"Lawyer: {lawyer.Firstname} {lawyer.Lastname}",
                $"Client: {client.Firstname} {client.Lastname}",
                $"Client Number: {client.PersonID}",
                $"",
                $"Title: {caseUI.Title}",
                $"",
                $"Description: {caseUI.Description}",
                $"",
                $"Status: {caseUI.Status}",
                $"",
                $"Start Date: {caseUI.CreationDate.ToString("d")}",
                $"End Date  : {caseUI.EndDate.ToString("d")}",
                $"",
                $"Total Price: {caseUI.TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            foreach (string txt in header)
            {
                textToWrite.Add(txt);
            }

        }

        private void BuildKilometerServiceText(CaseServiceUI caseService)
        {
            ServiceUI service = services.FirstOrDefault(s => s.ServiceID == caseService.ServiceID);
            LawyerUI lawyer = lawyers.FirstOrDefault(l => l.PersonID == caseService.LawyerID);

            List<string> kilometerServiceText = new List<string>()
            {
                $"",
                $"Service number: {caseService.ServiceID}",
                $"Service name  : {service.Name}",
                $"",
                $"Lawyer: {lawyer.Firstname} {lawyer.Lastname}",
                $"",
                $"Description: {caseService.Description}",
                $"",
                $"Date: {caseService.EndDate?.ToString("d")}",
                $"",
                $"Total Hours: {caseService.HoursWorked}",
                $"",
                $"Kilometers : {caseService.Units}",
                $"Price pr km: {service.Price}",
                $"Total price: {caseService.TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            //tilfoojer hele HourlyService teksten til listen den skal udskrive til txt
            foreach (string txt in  kilometerServiceText)
            {
                textToWrite.Add(txt);
            }


        }

        private async Task BuildHourlyServiceTextAsync(CaseServiceUI caseService)
        {
            ServiceUI service = services.FirstOrDefault(s => s.ServiceID == caseService.ServiceID);
            LawyerUI lawyer = lawyers.FirstOrDefault(l => l.PersonID == caseService.LawyerID);
            List<ServiceEntryUI> serviceEntryUIs = await serviceEntryBL.GetServiceEntryUIAsync(caseService.CaseServiceID);


            List<string> hourlyServiceText = new List<string>()
            {
                $"",
                $"Service number: {caseService.ServiceID}",
                $"Service name  : {service.Name}",
                $"",
                $"Lawyer: {lawyer.Firstname} {lawyer.Lastname}",
                $"",
                $"Description: {caseService.Description}",
                $"",
                $"Start Date: {caseService.StartDate.ToString("d")}",
                $"End Date  : {caseService.EndDate?.ToString("d")}",
                $"",
                $"Entries:",
            };

            //tilføjer entries til Service text
            foreach(ServiceEntryUI entry in serviceEntryUIs)
            {
                hourlyServiceText.Add($"{entry.Date.ToString("d")}: {entry.HoursWorked} Hours");
            }

            //text der skal staa under entries
            List<string> hourlyServiceBottomText = new List<string>()
            {
                $"",
                $"Price pr hour: {service.Price}",
                $"Total Hours: {caseService.HoursWorked}",
                $"Total Price: {caseService.TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            //tilfoojer teksten efter entries til hovedteksten for HourlyService
            foreach(string txt in hourlyServiceBottomText)
            {
                hourlyServiceText.Add(txt);
            }

            //tilfoojer hele HourlyService teksten til listen den skal udskrive til txt
            foreach(string txt in hourlyServiceText)
            {
                textToWrite.Add(txt);
            }


        }

        private async Task BuildFixedServiceTextAsync(CaseServiceUI caseService)
        {
            ServiceUI service = services.FirstOrDefault(s => s.ServiceID == caseService.ServiceID);
            LawyerUI lawyer = lawyers.FirstOrDefault(l => l.PersonID == caseService.LawyerID);
            List<ServiceEntryUI> serviceEntryUIs = await serviceEntryBL.GetServiceEntryUIAsync(caseService.CaseServiceID);



            List<string> fixedServiceText = new List<string>()
            {
                $"",
                $"Service number: {caseService.ServiceID}",
                $"Service name  : {service.Name}",
                $"",
                $"Lawyer: {lawyer.Firstname} {lawyer.Lastname}",
                $"",
                $"Description: {caseService.Description}",
                $"",
                $"Start Date: {caseService.StartDate.ToString("d")}",
                $"End Date  : {caseService.EndDate?.ToString("d")}",
                $"",
                $"Entries:",
            };

            //tilføjer entries til Service text
            foreach (ServiceEntryUI entry in serviceEntryUIs)
            {
                fixedServiceText.Add($"{entry.Date.ToString("d")}: {entry.HoursWorked} Hours");
            }

            //text der skal staa under entries
            List<string> fixedServiceBottomText = new List<string>()
            {
                $"",
                $"Total Hours: {caseService.HoursWorked}",
                $"",
                $"FixedPrice: {service.Price}",
                $"Agreed Price: {caseService.TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            //tilfoojer teksten efter entries til hovedteksten for HourlyService
            foreach (string txt in fixedServiceBottomText)
            {
                fixedServiceText.Add(txt);
            }

            //tilfoojer hele HourlyService teksten til listen den skal udskrive til txt
            foreach (string txt in fixedServiceText)
            {
                textToWrite.Add(txt);
            }
        }

        private async Task GetLawyersAsync()
        {
            lawyers = await lawyerBL.GetLawyersAsync();
        }

        private async Task GetServicesAsync()
        {
            services = await serviceBL.GetServicesAsync();
        }


        private void BtnBrowse_Click(object? sender, EventArgs e)
        {
            // opret savefiledialog til at gemme fil
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Only save as .csv
                saveFileDialog.Filter = "Textfile (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt"; // default exit sat til txt

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = saveFileDialog.FileName;      // Filepath
                }
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
