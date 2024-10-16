using System.Runtime;
using System.ComponentModel;
using Inventory.Data.Models;
using Inventory.Data.Shared.Sales;
using Inventory.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Wkhtmltopdf.NetCore;

namespace KoalaInventoryManagement.Controllers
{

    public class ReportController : Controller
    {
        private readonly ILogger<ReportController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGeneratePdf _generatePdf;
        public ReportController(ILogger<ReportController> logger, IUnitOfWork unitOfWork, IGeneratePdf generatePdf)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _generatePdf = generatePdf;
        }


        public async Task<IActionResult> GenerateReportPdf()
        {
            var report = new ReportViewModel<Sales>
            {
                ReportId = Guid.NewGuid().ToString(),
                ReportDate = DateTime.Now,
                CompanyLogo = "/images/logo.png",
                CompanyName = "Your Company Name",
                Items = _unitOfWork.Sales.GetAll().ToList()
            };
            try
            {
                // var pdf = await _generatePdf.GetPdf("Views/Report/GenerateReport.cshtml", report);
                var pdf = await _generatePdf.GetByteArray("Views/Report/GenerateReport.cshtml", report);
                return File(pdf, "application/pdf", "Report.pdf");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PDF generation failed.");
                return View("Error");
            }
        }

        public IActionResult ViewReportHtml()
        {
            var report = new ReportViewModel<Sales>
            {
                ReportId = Guid.NewGuid().ToString(),
                ReportDate = DateTime.Now,
                CompanyLogo = "/images/logo.png",
                CompanyName = "Your Company Name",
                Items = _unitOfWork.Sales.GetAll().ToList()
            };
            return View("GenerateReport", report);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}