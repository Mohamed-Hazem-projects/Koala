namespace KoalaInventoryManagement.Services
{
    public class ReportViewModel
    {
        
            public string ReportId { get; set; }
            public DateTime ReportDate { get; set; }
            public string CompanyLogo { get; set; }
            public string CompanyName { get; set; }
            public List<Item> Items { get; set; }
        
      
    }
}
