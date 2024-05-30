namespace UI.Toolbox
{
    public partial class FilterSpeciality : UserControl
    {
        public string BtnText { get; set; }
        public FilterSpeciality(string speciality)
        {
            InitializeComponent();
            btnFilter.Text = speciality;
            BtnText = speciality;

            btnFilter.Click += (sender, e) => OnClick(e);
        }
    }
}
