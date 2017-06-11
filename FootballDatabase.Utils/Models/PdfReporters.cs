using System.IO;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using FootballDatabase.Data;

namespace FootballDatabase.Utils.Models
{
    public class PdfReporters
    {
        private const string ExportFilePaths = "../Team-report-{0}.pdf";
        private const string Player = "Player";
        private const string Nationality = "Nationality";
        private const string Salary = "Weekly Salary";
        private const string Contract = "Years of contract";
        private const string PdfFont = "Segoe UI";

        public void CreatePdfTable(string teamSelected)
        {
           
        //    using (FootballDbContext db = new FootballDbContext())
        //    {
        //        db.Players.Where(x => x.Team.Name == teamSelected)
        //            .Select(x => new
        //        {
        //            Player = x.Nationality,
        //            Nationality = x.Nationality,
        //            Salary = x.Salary,
        //            Contract = x.Contract,
        //            Team = x.Team
        //        });
        //    }

            string filePath = string.Format(ExportFilePaths, 1);
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            using (writer)
            {
                document.Open();

                PdfPTable table = new PdfPTable(4);
                PdfPCell playerCell = new PdfPCell(new Phrase(Player));
                playerCell.BackgroundColor = BaseColor.GRAY;

                PdfPCell nationalityCell = new PdfPCell(new Phrase(Nationality));
                nationalityCell.BackgroundColor = BaseColor.GRAY;

                PdfPCell salaryCell = new PdfPCell(new Phrase(Contract));
                salaryCell.BackgroundColor = BaseColor.GRAY;

                PdfPCell contractCell = new PdfPCell(new Phrase(Salary));
                contractCell.BackgroundColor = BaseColor.GRAY;

                table.AddCell(playerCell);
                table.AddCell(nationalityCell);
                table.AddCell(salaryCell);
                table.AddCell(contractCell);

                PdfPCell cell = new PdfPCell(new Phrase("Date: "));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;

                table.AddCell(cell);
                decimal totalSalariesForWeek = 0;


                Font font = FontFactory.GetFont(PdfFont, 12.0f, Font.BOLD);
                PdfPCell totalSumCell =
                    new PdfPCell(
                        new Phrase(
                            $"Total salaries for a week: {totalSalariesForWeek}",
                            font));
                totalSumCell.Colspan = 4;
                totalSumCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(totalSumCell);

                document.Add(table);
                document.Close();
            }
        }
    }
}
