using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace курсовая_работа
{
    static class Program
    {
        public static int user_id;
        public static MySqlConnection connection_appDB;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Подключение к базе данных
                string connectionstring_appDB = "server=localhost;user=root;database=appDB;password=zxcvbnm987;";
                connection_appDB = new MySqlConnection(connectionstring_appDB);
                connection_appDB.Open();
            }
            catch (Exception ex)    // Обработка ошибок любого типа
            {
                MessageBox.Show($"Возникло исключение: {ex.Message}", "Ошибка. Нет подключения к базам данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Authorization auth = new Authorization();
            auth.ShowDialog();
            if (auth.DialogResult == DialogResult.OK)
            {
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
        }
    }

    class User
    {
        public string sex;
        public double weight;
        public int height;
        public int age;
        public string lvl_of_physical_activity;
        public string login;

        public void LoadInfAbout()
        {
            sex = GetStringFromDB(Program.user_id, "sex");
            weight = Convert.ToDouble(GetStringFromDB(Program.user_id, "weight"));
            height = Convert.ToInt32(GetStringFromDB(Program.user_id, "height"));
            age = Convert.ToInt32(GetStringFromDB(Program.user_id, "age"));
            lvl_of_physical_activity = GetStringFromDB(Program.user_id, "lvl_of_physical_activity");
            login = GetStringFromDB(Program.user_id, "login");
        }

        private string GetStringFromDB(int id, string val)
        {
            string command = $"SELECT {val} FROM appDB.users WHERE id={id}";
            MySqlCommand comm = new MySqlCommand(command, Program.connection_appDB);
            MySqlDataReader r = comm.ExecuteReader();
            r.Read();
            string str = r.GetString(0);
            return str;
        }

        private void Add(string sex, double weight, int height, int age, string lvl_of_ph_act, string login, string password, int id)
        {
            string command = $"INSERT INTO appDB.users (id, login, password) VALUES (@id, @login, @password)";
            MySqlCommand comm = new MySqlCommand(command, Program.connection_appDB);
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@login", login);
            comm.Parameters.AddWithValue("@password", password);
            comm.ExecuteNonQuery();

            string command_inf = $"INSERT INTO appDB.users (id, sex, weight, height, age, lvl_of_physical_activity) " +
                $"VALUES (@id, @sex, @weight, @height, @age, @lvl_of_ph_act)";
            MySqlCommand comm_inf = new MySqlCommand(command_inf, Program.connection_appDB);
            comm_inf.Parameters.AddWithValue("@id", id);
            comm_inf.Parameters.AddWithValue("@sex", sex);
            comm_inf.Parameters.AddWithValue("@weight", weight);
            comm_inf.Parameters.AddWithValue("@height", height);
            comm_inf.Parameters.AddWithValue("@age", age);
            comm_inf.Parameters.AddWithValue("@lvl_of_ph_act", lvl_of_ph_act);
            comm_inf.ExecuteNonQuery();

            MessageBox.Show($"Учетная запись создана. Для продолжения пройдите авторизацию", "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void AddUser(string sex, double weight, int height, int age, string lvl_of_ph_act, string login, string password, int id)
        {
            Add(sex, weight, height, age, lvl_of_ph_act, login, password, id);
        }


        ~User() { }  // Деструктор
    }

    class Slimming
    {
        public double BMI;
        public double daily_calorie_intake;
        public double lack_calorie;

        public void SetValuesForProgram(string sex, double weight, int height, int age, string lvl_of_physical_activity)
        {
            BMI = CountBMI(weight, height);
            daily_calorie_intake = CountDailyCalorieIntake(weight, height, age, sex, lvl_of_physical_activity);
            lack_calorie = Math.Round(daily_calorie_intake * 0.8, 1);
        }

        private double CountBMI(double weight, int height)
        {
            try
            {
                double hei = height / 100.0;
                double BMI = weight / (hei * hei);
                return Math.Round(BMI, 1);
            }
            catch (DivideByZeroException)      // Обработка деления на ноль
            {
                MessageBox.Show("Возникло исключение: деление на 0", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private int CountDailyCalorieIntake(double weight, int height, int age, string sex, string lvl_of_ph_act)
        {
            double calories;
            if (sex == "ж")
            {
                calories = 447.6 + (9.2 * weight) + (3.1 * height) - (4.3 * age);  // формула Харриса-Бенедикта
            }
            else
            {
                calories = 88.36 + (13.4 * weight) + (4.8 * height) - (5.7 * age);
            }

            if (lvl_of_ph_act == "низкий")
            {
                calories *= 1.2;
                return Convert.ToInt32(calories);
            }
            else if (lvl_of_ph_act == "умеренный")
            {
                calories *= 1.35;
                return Convert.ToInt32(calories);
            }
            else
            {
                calories *= 1.7;
                return Convert.ToInt32(calories);
            }
        }

        private double CountWaterIntake(double weight, string sex)
        {
            double intake = 0;
            if (sex == "ж") intake = weight * 31.0;
            else intake = weight * 35.0;
            return Math.Round(intake, 1);
        }

        public double GetWaterIntake(double weight, string sex)
        {
            return CountWaterIntake(weight, sex);
        }
    }

    class Diet
    {

        public void FillDataGridView(DataGridView dgv)
        {
            LoadData(dgv);
        }

        private void LoadData(DataGridView dgv)
        {
            string command = $"SELECT * FROM appDB.food";
            MySqlCommand comm = new MySqlCommand(command, Program.connection_appDB);
            MySqlDataReader r = comm.ExecuteReader();

            List<string[]> data = new List<string[]>();   // Считывание и запись в список строк из БД
            while (r.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = r[0].ToString();
                data[data.Count - 1][1] = r[1].ToString();
                data[data.Count - 1][2] = r[2].ToString();
                data[data.Count - 1][3] = r[3].ToString();
                data[data.Count - 1][4] = r[4].ToString();
                data[data.Count - 1][5] = r[5].ToString();
                data[data.Count - 1][6] = r[6].ToString();
            }
            r.Close();

            foreach (string[] s in data) dgv.Rows.Add(s);
        }

        public void Delete(int id)
        {
            try
            {
                string command = $"DELETE FROM appDB.food WHERE id = {id}";
                MySqlCommand comm = new MySqlCommand(command, Program.connection_appDB);
                comm.ExecuteNonQuery();
                MessageBox.Show($"Продукт под номером {id} удалено", "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Удаление невозможно", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        public void Add(string name, int proteins, int fats, int carbohydrates, int calories, int gram)
        {
            string command_maxID = $"SELECT MAX(id) FROM appDB.food";
            MySqlCommand cmid = new MySqlCommand(command_maxID, Program.connection_appDB);
            MySqlDataReader read = cmid.ExecuteReader();
            read.Read();
            int maxID = read.GetInt32(0);
            read.Close();

            string command = $"INSERT INTO diet.food (id, name, proteins, fats, carbohydrates, calories, gram) " +
                $"VALUES (@id, @name, @proteins, @fats, @carbohydrates, @calories, @gram)";
            MySqlCommand comm = new MySqlCommand(command, Program.connection_appDB);
            comm.Parameters.AddWithValue("@id", ++maxID);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@proteins", proteins);
            comm.Parameters.AddWithValue("@fats", fats);
            comm.Parameters.AddWithValue("@carbohydrates", carbohydrates);
            comm.Parameters.AddWithValue("@calories", calories);
            comm.Parameters.AddWithValue("@gram", gram);
            comm.ExecuteNonQuery();

            MessageBox.Show($"Блюдо добавлено. Обновите страницу", "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void Search(string val, DataGridView dgv)
        {
            string search;

            for (int j = 0; j < dgv.Rows.Count; j++)
            {
                for (int i = 0; i < dgv.Rows[j].Cells.Count; i++)
                {
                    search = Convert.ToString(dgv.Rows[j].Cells[i].Value);
                    if (search.Contains(val))
                    {
                        dgv.Rows[j].Selected = true;
                        break;
                    }
                    dgv.Rows[j].Cells[i].Selected = false;
                }
            }
        }
    }
}