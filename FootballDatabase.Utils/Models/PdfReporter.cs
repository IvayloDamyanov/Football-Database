using System.IO;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using FootballDatabase.Data;
using FootballDatabase.Models;

namespace FootballDatabase.Utils.Models
{
    public static class PdfReporter
    {
        private const string ExportFilePaths = "../../../PDFs/Team-report-{0}.pdf";
        private const string PdfFont = "Segoe UI";
        
        private static void CreatePDF(Player player)
        {
            string filePath = string.Format(ExportFilePaths, 1);
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            using (writer)
            {
                document.Open();

                PdfPTable table = new PdfPTable(1);

                table.AddCell(new PdfPCell(new Phrase("Player Dossier")));

                PdfPCell playerCell = new PdfPCell(new Phrase("Name: " + player.Name));
                playerCell.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell ageCell = new PdfPCell(new Phrase("Age: " + player.Age.ToString()));
                ageCell.BackgroundColor = BaseColor.GRAY;

                PdfPCell nationalityCell = new PdfPCell(new Phrase("Nationality: " + player.Nationality));
                nationalityCell.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell salaryCell = new PdfPCell(new Phrase("Salary: " + player.Salary.ToString() + " money"));
                salaryCell.BackgroundColor = BaseColor.GRAY;

                PdfPCell contractCell = new PdfPCell(new Phrase("Contract: " + player.Contract.ToString() + " years"));
                contractCell.BackgroundColor = BaseColor.LIGHT_GRAY;

                table.AddCell(playerCell);
                table.AddCell(ageCell);
                table.AddCell(nationalityCell);
                table.AddCell(salaryCell);
                table.AddCell(contractCell);

                //PdfPCell cell = new PdfPCell(new Phrase("Date: "));
                //cell.Colspan = 4;
                //cell.HorizontalAlignment = Element.ALIGN_CENTER;
                //cell.BackgroundColor = BaseColor.LIGHT_GRAY;

                //table.AddCell(cell);
                //decimal totalSalariesForWeek = 0;
                
                //Font font = FontFactory.GetFont(PdfFont, 12.0f, Font.BOLD);
                //PdfPCell totalSumCell =
                //    new PdfPCell(
                //        new Phrase(
                //            $"Total salaries for a week: {totalSalariesForWeek}",
                //            font));
                //totalSumCell.Colspan = 4;
                //totalSumCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                //table.AddCell(totalSumCell);

                document.Add(table);
                document.Close();
            }
        }

        public static void ExportPlayerToPDF(int playerId)
        {
            FootballDbContext dbcontext = new FootballDbContext();

            var selection = dbcontext.Players.Where(x => x.Id == playerId)
                .Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age,
                    Nationality = x.Nationality,
                    Salary = x.Salary,
                    Contract = x.Contract,
                    Team = x.Team
                })
                .ToArray();

            Player player = new Player()
            {
                Name = selection[0].Name,
                Age = selection[0].Age,
                Nationality = selection[0].Nationality,
                Salary = selection[0].Salary,
                Contract = selection[0].Contract,
                Team = selection[0].Team
            };

            CreatePDF(player);
        }
    }
}
