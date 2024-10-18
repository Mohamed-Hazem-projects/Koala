using DinkToPdf;
using DinkToPdf.Contracts;
using Inventory.Data.Shared.Sales;
using Inventory.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Wkhtmltopdf.NetCore;

namespace KoalaInventoryManagement.Controllers
{

    public class ReportController : Controller
    {
        private readonly ILogger<ReportController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGeneratePdf _generatePdf;
        private readonly IConverter _converter;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IRazorViewEngine _razorViewEngine;
        public ReportController(ILogger<ReportController> logger, IUnitOfWork unitOfWork, IGeneratePdf generatePdf, IWebHostEnvironment webHostEnvironment, IConverter converter, IRazorViewEngine razorViewEngine)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _generatePdf = generatePdf;
            _webHostEnvironment = webHostEnvironment;
            _converter = converter;
            _razorViewEngine = razorViewEngine;
        }


        public IActionResult DownloadPdf()
        {
            var report = new ReportViewModel<SalesViewModel>
            {
                ReportId = Guid.NewGuid().ToString(),
                ReportDate = DateTime.Now,
                CompanyLogo = "dsada",
                CompanyName = "Your Company Name",
                Items = _unitOfWork.Sales.GetProdcutAndWareHouse()!
                .OrderByDescending(x => x.SaleDate)
                .ToList()
            };
            try
            {
                // return await _generatePdf.GetPdf("Views/Report/GenerateReport.cshtml", report);
                // var pdf = await _generatePdf.GetByteArray("Views/Report/GenerateReport.cshtml", report);
                // return File(pdf, "application/pdf", $"SalesReport{DateTime.Now.ToString("dd-MM-yy hh:mm:ss tt")}.pdf", true);
                var html = RenderRazorViewToString("GenerateReport", report);
                var doc = new HtmlToPdfDocument()
                {
                    GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 10, Bottom = 10 },
                },
                    Objects = {
                    new ObjectSettings {
                        HtmlContent = html,
                        WebSettings = { DefaultEncoding = "utf-8" }
                        }
                    }
                };
                var pdf = _converter.Convert(doc);
                return File(pdf, "application/pdf", "Invoice.pdf");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PDF generation failed.");
                return View("Error");
            }
        }
        private string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var writer = new StringWriter())
            {
                var viewResult = _razorViewEngine.FindView(ControllerContext, viewName, false);
                var viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    ViewData,
                    TempData,
                    writer,
                    new HtmlHelperOptions()
                );
                viewResult.View.RenderAsync(viewContext).Wait();
                return writer.ToString();
            }
        }

        private string ConvertToBase64(string relativePath)
        {
            var absolutePath = Path.Combine(_webHostEnvironment.WebRootPath, relativePath.TrimStart('~').Replace("/", Path.DirectorySeparatorChar.ToString()));
            byte[] imageArray = System.IO.File.ReadAllBytes(absolutePath);
            return $"data:image/svg+xml;base64,{Convert.ToBase64String(imageArray)}";
        }

        public IActionResult GenerateReport()
        {
            var report = new ReportViewModel<SalesViewModel>
            {
                ReportId = Guid.NewGuid().ToString(),
                ReportDate = DateTime.Now,
                CompanyLogo = "/images/logo.png",
                CompanyName = "Koala Company",
                Items = _unitOfWork.Sales.GetProdcutAndWareHouse()!
                .OrderByDescending(x => x.SaleDate)
                .ToList()
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

// var reportAsJSON = JsonConvert.SerializeObject(report);
// ViewBag.Report = reportAsJSON;
//ConvertToBase64("~/Images/Report/Sales/koala.svg")