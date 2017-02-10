using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace InformerSMS
{
    static class Program
    {
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool onlyInstance;
            if (args.Length > 0 && args[0] == "SendSMS")
            {
                SendSMS();
                Application.Exit();
            }
            Mutex mtx = new Mutex(true, "СМС уведомления", out onlyInstance);
            if (onlyInstance)
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show(
                   "Приложение уже запущено",
                   "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
            
        }
        static string SendSMS()
        {
            var apiClient = new WebClient();
            string SendMessege = $"Выполнен вход. Пользователь: {Environment.UserName}. {DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss")}";
            string api = $"http://api.smsfeedback.ru/messages/v2/send/?phone={Properties.Settings.Default.numberPhone}&text={SendMessege}&login={Properties.Settings.Default.login}&password={Properties.Settings.Default.password}";
            string resoult = apiClient.DownloadString(api);
            return resoult;
        }
}
}