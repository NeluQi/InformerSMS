using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformerSMS
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            Phone.Text = Properties.Settings.Default.numberPhone;
            login.Text = Properties.Settings.Default.login;
            password.Text = Properties.Settings.Default.password;
            CheakReg();
            CheakBalance();
            if (!Properties.Settings.Default.FirstStart)
            {
                MessageBox.Show(this, Properties.Settings.Default.Info, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Properties.Settings.Default.FirstStart = true;
            Properties.Settings.Default.Save();
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked == true)
                password.PasswordChar = default(Char);
            if (ShowPass.Checked == false)
                password.PasswordChar = Char.Parse("*");
        }
        //сохр настр.
        private void SaveAcc_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = login.Text;
            Properties.Settings.Default.password = password.Text;
            var apiClient = new WebClient();
            string api = $"http://api.smsfeedback.ru/messages/v2/balance/?&login={login.Text}&password={password.Text}";
            try
            {
                string resoult = apiClient.DownloadString(api);
                MetroMessageBox.Show(this, "Авторизация успешна!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheakBalance();
            }
            catch { MetroMessageBox.Show(this, "Ошибка авторизации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Properties.Settings.Default.Save();
        }

        private void SavePhone_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numberPhone = Phone.Text;
            Properties.Settings.Default.Save();
            MetroMessageBox.Show(this, "Успешно!", "Сохранил!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CheakBalance() {
            if (Properties.Settings.Default.login == "" || Properties.Settings.Default.password == "")
                return;
            var apiClient = new WebClient();
            string api = $"http://api.smsfeedback.ru/messages/v2/balance/?&login={Properties.Settings.Default.login}&password={Properties.Settings.Default.password}";
            string resoult = "";
            try
            {
                resoult = apiClient.DownloadString(api);

            }
            catch { MetroMessageBox.Show(this, "Ошибка авторизации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            String[] substrings = resoult.Split(Char.Parse(";"));
            Balance.Text = "Баланс:" + substrings[1];
        }

        private void UpdateBalance_Click(object sender, EventArgs e)
        {
            Balance.Text = "Обновление...";
            CheakBalance();
        }

        private void SendTest_Click(object sender, EventArgs e)
        {
            try
            {
                var apiClient = new WebClient();
                string SendMessege = $"Тестовое сообщение! Проверка уведомлений!";
                string api = $"http://api.smsfeedback.ru/messages/v2/send/?phone={Properties.Settings.Default.numberPhone}&text={SendMessege}&login={Properties.Settings.Default.login}&password={Properties.Settings.Default.password}";
                string resoult = apiClient.DownloadString(api);
            }
            catch { MetroMessageBox.Show(this, "Ошибка авторизации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue("Informer SNS", ExePath + " SendSMS");
                else
                    reg.DeleteValue("Informer SNS");

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool CheakReg()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            if (reg.GetValue("Informer SNS") != null)
            {
                Status.Text = "Статус: Включено!";
                AutoRun.Text = "Отключить уведомления";
                return true;
            }
            else
                Status.Text = "Статус: Отключено!";
                AutoRun.Text = "Включить уведомления";
             return false;
        }
        private void AutoRun_Click(object sender, EventArgs e)
        {
            if (CheakReg())
                SetAutorunValue(false);
            else
                SetAutorunValue(true);
            CheakReg();
        }

        private void info_Click(object sender, EventArgs e)
        {
           MessageBox.Show(this, Properties.Settings.Default.Info, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
