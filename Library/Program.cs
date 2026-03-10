using Library.Data;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}