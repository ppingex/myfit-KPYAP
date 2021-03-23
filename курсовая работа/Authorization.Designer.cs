namespace курсовая_работа
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorization_button = new System.Windows.Forms.Button();
            this.registration_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.repeatPassword_textBox = new System.Windows.Forms.TextBox();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.weight_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.phAct_comboBox = new System.Windows.Forms.ComboBox();
            this.entry_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorization_button
            // 
            this.authorization_button.BackColor = System.Drawing.Color.White;
            this.authorization_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorization_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorization_button.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorization_button.ForeColor = System.Drawing.Color.Black;
            this.authorization_button.Location = new System.Drawing.Point(12, 12);
            this.authorization_button.Name = "authorization_button";
            this.authorization_button.Size = new System.Drawing.Size(111, 32);
            this.authorization_button.TabIndex = 0;
            this.authorization_button.Text = "Авторизация";
            this.authorization_button.UseVisualStyleBackColor = false;
            this.authorization_button.Click += new System.EventHandler(this.authorization_button_Click);
            // 
            // registration_button
            // 
            this.registration_button.BackColor = System.Drawing.Color.Indigo;
            this.registration_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration_button.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_button.ForeColor = System.Drawing.Color.White;
            this.registration_button.Location = new System.Drawing.Point(243, 12);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(111, 32);
            this.registration_button.TabIndex = 1;
            this.registration_button.Text = "Регистрация";
            this.registration_button.UseVisualStyleBackColor = false;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(184, 71);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(170, 20);
            this.login_textBox.TabIndex = 4;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(184, 97);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(170, 20);
            this.password_textBox.TabIndex = 5;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // repeatPassword_textBox
            // 
            this.repeatPassword_textBox.Location = new System.Drawing.Point(184, 123);
            this.repeatPassword_textBox.Name = "repeatPassword_textBox";
            this.repeatPassword_textBox.Size = new System.Drawing.Size(170, 20);
            this.repeatPassword_textBox.TabIndex = 6;
            this.repeatPassword_textBox.UseSystemPasswordChar = true;
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(184, 206);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(133, 20);
            this.age_textBox.TabIndex = 7;
            this.age_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Повторите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Рост";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Вес";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Физическая активность";
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_radioButton.Location = new System.Drawing.Point(184, 179);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(37, 21);
            this.male_radioButton.TabIndex = 17;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "М";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_radioButton.Location = new System.Drawing.Point(278, 179);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(39, 21);
            this.female_radioButton.TabIndex = 18;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Ж";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "лет";
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(184, 232);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(133, 20);
            this.height_textBox.TabIndex = 20;
            this.height_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_textBox_KeyPress);
            // 
            // weight_textBox
            // 
            this.weight_textBox.Location = new System.Drawing.Point(184, 258);
            this.weight_textBox.Name = "weight_textBox";
            this.weight_textBox.Size = new System.Drawing.Size(133, 20);
            this.weight_textBox.TabIndex = 21;
            this.weight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "кг";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(323, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "см";
            // 
            // phAct_comboBox
            // 
            this.phAct_comboBox.FormattingEnabled = true;
            this.phAct_comboBox.Items.AddRange(new object[] {
            "сидячий образ жизни",
            "умеренная",
            "средняя",
            "высокая",
            "спортсмен"});
            this.phAct_comboBox.Location = new System.Drawing.Point(184, 284);
            this.phAct_comboBox.Name = "phAct_comboBox";
            this.phAct_comboBox.Size = new System.Drawing.Size(133, 21);
            this.phAct_comboBox.TabIndex = 24;
            this.phAct_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phAct_comboBox_KeyPress);
            // 
            // entry_button
            // 
            this.entry_button.BackColor = System.Drawing.Color.Indigo;
            this.entry_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entry_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entry_button.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_button.ForeColor = System.Drawing.Color.White;
            this.entry_button.Location = new System.Drawing.Point(15, 325);
            this.entry_button.Name = "entry_button";
            this.entry_button.Size = new System.Drawing.Size(339, 32);
            this.entry_button.TabIndex = 25;
            this.entry_button.Text = "Зарегистрироваться и войти";
            this.entry_button.UseVisualStyleBackColor = false;
            this.entry_button.Click += new System.EventHandler(this.entry_button_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 373);
            this.Controls.Add(this.entry_button);
            this.Controls.Add(this.phAct_comboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.weight_textBox);
            this.Controls.Add(this.height_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.female_radioButton);
            this.Controls.Add(this.male_radioButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.repeatPassword_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.authorization_button);
            this.Name = "Authorization";
            this.Text = "Добро пожаловать";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorization_button;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox repeatPassword_textBox;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.TextBox weight_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox phAct_comboBox;
        private System.Windows.Forms.Button entry_button;
    }
}