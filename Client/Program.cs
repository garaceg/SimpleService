using SimpleService;

namespace Client
{
    internal static class Program
    {
        public static ProductService productService;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            productService = new ProductService();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmClient());
        }
    }
}