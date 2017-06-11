namespace FootballDatabase
{
    using FootballDatabase.Contracts;
    using FootballDatabase.Core;
    using FootballDatabase.Utils.Models;

    public class Startup
    {
        // Use only to populate the database
        public static void Main()
        {
            //IEngine engine = new Engine();
            //engine.Start();
            PdfReporters report = new PdfReporters();
            report.CreatePdfTable();
        }
    }
}
