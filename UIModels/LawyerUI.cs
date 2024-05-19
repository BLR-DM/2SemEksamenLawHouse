namespace UIModels
{
    public class LawyerUI : EmployeeUI
    {
        public bool Admin { get; set; }
        public int OpenCases => Cases?.Count(c => c.Status == "Open") ?? 0;
        public int ClosedCases => Cases?.Count(c => c.Status == "Closed") ?? 0;

        public int SpecialityCount => LawyerSpecialities?.Count ?? 0;
        public int OpenCaseServices => CaseServices?.Count(cs => cs.Status == "Open") ?? 0;
        public int ClosedCaseServices => CaseServices?.Count(cs => cs.Status == "Closed") ?? 0;

        public virtual ICollection<LawyerSpecialityUI> LawyerSpecialities { get; set; }
        public virtual ICollection<CaseUI> Cases { get; set; }
        public virtual ICollection<CaseServiceUI> CaseServices { get; set; }
    }
}
