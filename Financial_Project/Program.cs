
namespace Financial_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MultiFormContext context = new MultiFormContext(new Main_Menu_Form()))
            {
                Application.Run(context);
            }
        }
    }
}