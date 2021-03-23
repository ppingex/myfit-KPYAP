using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_работа
{
    public partial class Authorization : Form
    {
        bool registration = true;
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void authorization_button_Click(object sender, EventArgs e)
        {
            registration = false;
            authorization_button.BackColor = Color.Indigo;
            authorization_button.ForeColor = Color.White;
            registration_button.BackColor = Color.White;
            registration_button.ForeColor = Color.Black;
            repeatPassword_textBox.Hide();
            male_radioButton.Hide();
            female_radioButton.Hide();
            age_textBox.Hide();
            height_textBox.Hide();
            weight_textBox.Hide();
            phAct_comboBox.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label12.Hide();
            label11.Hide();
            entry_button.Text = "Войти";
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            registration = true;
            registration_button.BackColor = Color.Indigo;
            registration_button.ForeColor = Color.White;
            authorization_button.BackColor = Color.White;
            authorization_button.ForeColor = Color.Black;
            repeatPassword_textBox.Show();
            male_radioButton.Show();
            female_radioButton.Show();
            age_textBox.Show();
            height_textBox.Show();
            weight_textBox.Show();
            phAct_comboBox.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label12.Show();
            label11.Show();
            entry_button.Text = "Зарегистрироваться и войти";
        }

        private void entry_button_Click(object sender, EventArgs e)
        {
            if (registration)
            {
                try
                {
                    string login = login_textBox.Text;
                }
                catch
                {
                    MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("aut");
        }

        private void age_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void height_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void weight_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void phAct_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
