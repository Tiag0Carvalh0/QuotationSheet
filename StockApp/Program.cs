namespace StockApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Start the main forms
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());




        }
    }
}