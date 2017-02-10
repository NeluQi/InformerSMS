namespace InformerSMS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SaveAcc = new MetroFramework.Controls.MetroButton();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Balance = new MetroFramework.Controls.MetroLabel();
            this.AutoRun = new MetroFramework.Controls.MetroButton();
            this.SendTest = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Phone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SavePhone = new MetroFramework.Controls.MetroButton();
            this.Status = new MetroFramework.Controls.MetroLabel();
            this.ShowPass = new MetroFramework.Controls.MetroCheckBox();
            this.UpdateBalance = new MetroFramework.Controls.MetroButton();
            this.info = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(13, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(218, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Данные от smsfeedback.ru";
            // 
            // SaveAcc
            // 
            this.SaveAcc.Location = new System.Drawing.Point(143, 160);
            this.SaveAcc.Name = "SaveAcc";
            this.SaveAcc.Size = new System.Drawing.Size(88, 23);
            this.SaveAcc.TabIndex = 1;
            this.SaveAcc.Text = "Сохранить";
            this.SaveAcc.UseSelectable = true;
            this.SaveAcc.Click += new System.EventHandler(this.SaveAcc_Click);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(93, 131);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(136, 23);
            this.password.TabIndex = 2;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login
            // 
            // 
            // 
            // 
            this.login.CustomButton.Image = null;
            this.login.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.login.CustomButton.Name = "";
            this.login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login.CustomButton.TabIndex = 1;
            this.login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login.CustomButton.UseSelectable = true;
            this.login.CustomButton.Visible = false;
            this.login.Lines = new string[0];
            this.login.Location = new System.Drawing.Point(93, 106);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(136, 23);
            this.login.TabIndex = 4;
            this.login.UseSelectable = true;
            this.login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(13, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Логин:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(13, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Пароль:";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Balance.Location = new System.Drawing.Point(247, 100);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(76, 25);
            this.Balance.TabIndex = 7;
            this.Balance.Text = "Баланс: ";
            // 
            // AutoRun
            // 
            this.AutoRun.Location = new System.Drawing.Point(198, 362);
            this.AutoRun.Name = "AutoRun";
            this.AutoRun.Size = new System.Drawing.Size(194, 39);
            this.AutoRun.TabIndex = 8;
            this.AutoRun.Text = "Включить уведомления";
            this.AutoRun.UseSelectable = true;
            this.AutoRun.Click += new System.EventHandler(this.AutoRun_Click);
            // 
            // SendTest
            // 
            this.SendTest.Location = new System.Drawing.Point(173, 310);
            this.SendTest.Name = "SendTest";
            this.SendTest.Size = new System.Drawing.Size(237, 23);
            this.SendTest.TabIndex = 9;
            this.SendTest.Text = "Отправить тестовое смс (Не бесплатное)";
            this.SendTest.UseSelectable = true;
            this.SendTest.Click += new System.EventHandler(this.SendTest_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(72, 218);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 25);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Ваш телефон:";
            // 
            // Phone
            // 
            // 
            // 
            // 
            this.Phone.CustomButton.Image = null;
            this.Phone.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.Phone.CustomButton.Name = "";
            this.Phone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Phone.CustomButton.TabIndex = 1;
            this.Phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Phone.CustomButton.UseSelectable = true;
            this.Phone.CustomButton.Visible = false;
            this.Phone.Lines = new string[0];
            this.Phone.Location = new System.Drawing.Point(198, 220);
            this.Phone.MaxLength = 32767;
            this.Phone.Name = "Phone";
            this.Phone.PasswordChar = '\0';
            this.Phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Phone.SelectedText = "";
            this.Phone.SelectionLength = 0;
            this.Phone.SelectionStart = 0;
            this.Phone.ShortcutsEnabled = true;
            this.Phone.Size = new System.Drawing.Size(212, 23);
            this.Phone.TabIndex = 10;
            this.Phone.UseSelectable = true;
            this.Phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(51, 258);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(480, 38);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Номер телефона в формате 71234567890 для РФ, 381234567890 для Украины,\r\n т.е. код" +
    " страны плюс номер мобильного телефона без пробелов.";
            // 
            // SavePhone
            // 
            this.SavePhone.Location = new System.Drawing.Point(416, 220);
            this.SavePhone.Name = "SavePhone";
            this.SavePhone.Size = new System.Drawing.Size(88, 23);
            this.SavePhone.TabIndex = 13;
            this.SavePhone.Text = "Сохранить";
            this.SavePhone.UseSelectable = true;
            this.SavePhone.Click += new System.EventHandler(this.SavePhone_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Status.Location = new System.Drawing.Point(198, 404);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(72, 25);
            this.Status.TabIndex = 14;
            this.Status.Text = "Статус: ";
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Location = new System.Drawing.Point(13, 168);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(116, 15);
            this.ShowPass.TabIndex = 15;
            this.ShowPass.Text = "Показать пароль";
            this.ShowPass.UseSelectable = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // UpdateBalance
            // 
            this.UpdateBalance.Location = new System.Drawing.Point(247, 74);
            this.UpdateBalance.Name = "UpdateBalance";
            this.UpdateBalance.Size = new System.Drawing.Size(88, 23);
            this.UpdateBalance.TabIndex = 16;
            this.UpdateBalance.Text = "Обновить";
            this.UpdateBalance.UseSelectable = true;
            this.UpdateBalance.Click += new System.EventHandler(this.UpdateBalance_Click);
            // 
            // info
            // 
            this.info.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.info.Location = new System.Drawing.Point(223, 27);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(88, 23);
            this.info.TabIndex = 17;
            this.info.Text = "Информация";
            this.info.UseSelectable = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 336);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(454, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Как настроили программу, не меняйте путь до нее и не переносите exe.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 441);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.info);
            this.Controls.Add(this.UpdateBalance);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.SavePhone);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.SendTest);
            this.Controls.Add(this.AutoRun);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.SaveAcc);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SMS уведомления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton SaveAcc;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel Balance;
        private MetroFramework.Controls.MetroButton AutoRun;
        private MetroFramework.Controls.MetroButton SendTest;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Phone;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton SavePhone;
        private MetroFramework.Controls.MetroLabel Status;
        private MetroFramework.Controls.MetroCheckBox ShowPass;
        private MetroFramework.Controls.MetroButton UpdateBalance;
        private MetroFramework.Controls.MetroButton info;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

