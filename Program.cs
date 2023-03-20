using ControlzEx.Standard;
using System.Globalization;
using System.Threading;

namespace atmApp
{



    internal static class Program
    {
        public static Account[] ac = new Account[3];

        public static void loadAccounts()
        {
            ac[0] = new Account(3, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void ThreadProc()
        {
            Application.Run(new Form1());
        }
        static void Main()
        {


            loadAccounts();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Summon());
            //Thread t = new Thread(ThreadProc);
            //Thread s = new Thread(ThreadProc);
            //t.Start();
            //s.Start();

        }





    }


}