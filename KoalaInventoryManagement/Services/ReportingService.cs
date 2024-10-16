using KoalaInventoryManagement.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp;
using PdfSharp.Pdf;
//using System.Drawing;



namespace KoalaInventoryManagement.Services
{

    public class ReportingService
    {
        public PdfDocument GetReport(List<Product> products)
        {
            var document = new Document();

            // Create a new section
            var section = document.AddSection();

            // Clone the default page setup and modify orientation
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.Orientation = Orientation.Landscape;

            BuidDocument(section, products);

            var pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            return pdfRenderer.PdfDocument;
        }

        private void BuidDocument(Section section, List<Product> products)
        {

            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "2.png");
            double pageWidth = section.PageSetup.PageWidth - section.PageSetup.LeftMargin - section.PageSetup.RightMargin;

            // Add the logo centered in the middle of the section
            Paragraph logoParagraph = section.AddParagraph();
            logoParagraph.Format.Alignment = ParagraphAlignment.Center; 

            Image logo = logoParagraph.AddImage(imagePath);  
            logo.Width = pageWidth;  
            logo.LockAspectRatio = true;
            logoParagraph.Format.SpaceAfter = "1cm";


            var paragraph = section.AddParagraph();

            
            paragraph.AddLineBreak();
            paragraph.Format.SpaceAfter = 20;
            paragraph.AddText("Koala Inventory System");
         
            paragraph.AddLineBreak();
            paragraph.AddText("Admin Report");
            paragraph.Format.SpaceAfter = 20;
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            // Table setup
            var table = section.AddTable();
            table.Borders.Width = 0.5;

            table.AddColumn("1cm");   // No
            table.AddColumn("5cm");   // Product Name
            table.AddColumn("9cm");   // Product DESC
            table.AddColumn("5cm");   // Supplier
            table.AddColumn("5cm");   // Category

            // Header Row
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Font.Bold = true;
            row.Cells[0].AddParagraph("No");
            row.Cells[1].AddParagraph("Product Name");
            row.Cells[2].AddParagraph("Product Desc");
            row.Cells[3].AddParagraph("Supplier");
            row.Cells[4].AddParagraph("Category");

            // Populate Table with Product Data
            for (int i = 0; i < products.Count; i++)
            {
                row = table.AddRow();
                row.Cells[0].AddParagraph((i + 1).ToString());
                row.Cells[1].AddParagraph(products[i].Name);
                row.Cells[2].AddParagraph(products[i].Description);
                row.Cells[3].AddParagraph(products[i].Supplier?.Name);
                row.Cells[4].AddParagraph(products[i].Category?.Name);
            }


            //// Footer Section
            var footer = section.Footers.Primary;
            Paragraph footerParagraph = footer.AddParagraph();
            //footerParagraph.AddText("Generated on: " + DateTime.Now.ToString("dd MMMM yyyy"));
            footerParagraph.Format.Alignment = ParagraphAlignment.Center;
            //footerParagraph.Format.SpaceBefore = 10;

            //// Optional: Add page numbers in the footer
            //footerParagraph.AddLineBreak();
            //footerParagraph.AddText("Page ");
            //footerParagraph.AddPageField(); // Will automatically add page numbers
            //footerParagraph.AddText(" of ");
            //footerParagraph.AddNumPagesField();
            //footerParagraph.AddLineBreak();
            footerParagraph.AddText("all rights reserved © 2024  ");
        }
    }
}
