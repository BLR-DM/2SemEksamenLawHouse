using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class CasePageView : Form
    {
        CaseTypeBL caseTypeBL;
        LawyerBL lawyerBL;
        List<CaseTypeUI> caseTypeList;
        List<LawyerUI> lawyerList;
        public CasePageView()
        {
            InitializeComponent();
            caseTypeBL = new CaseTypeBL();
            lawyerBL = new LawyerBL();

            SetComboBox();

        }

        public async Task SetComboBox()
        {
            caseTypeList = await caseTypeBL.GetCaseTypeAsync();

            cboCaseType.DisplayMember = "Title";

            foreach(CaseTypeUI caseTypeUI in caseTypeList)
            {
                cboCaseType.Items.Add(caseTypeUI);
            }

            lawyerList = await lawyerBL.GetLawyersAsync();

            cboLawyers.DisplayMember = "Firstname" + "Lastname";

            foreach(LawyerUI lawyerUI in lawyerList)
            {
                cboLawyers.Items.Add(lawyerUI);
            }
        }
    }
}
