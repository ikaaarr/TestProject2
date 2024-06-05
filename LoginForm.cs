using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoEkzamenPrakrika
{
    public partial class LoginForm : Form
    {
        DBConnect connection = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        /// Создаём 2 переменные для Пароля и Логина, 
        /// чтобы в них записать данные из бд
        private string parsedPassword;
        private string parsedLogin;


        ///Переменные для записи роли и айди
        private string post;
        private int id;
      

        ///Метод для выяснения роли и создания формы по выбранной роли
        void IsRole(string formrole, int idDB)
        {
            ///обнуляем переменные
            post = null;
            password_textBox.Text = null;
            login_textBox.Text = null;
            id = 0;

            /// проверяем чему равна переменная formrole
            if(formrole == "Менеджер")
            {
                this.Hide();
                Form manager = new ManagerForm(idDB);
                manager.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                manager.Show();
            }
            else if (formrole == "Администратор")
            {
                this.Hide();
                Form admForm = new AdmForm(idDB);
                admForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                admForm.Show();
            }
            else if(formrole == "Работник")
            {
                this.Hide();
                Form workerform = new WorkerForm(idDB);
                workerform.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                workerform.Show();
            }
            else
            {
                ///Если у данного работника нет нужной роли для этой программы, будет следующее сообщение:
                MessageBox.Show("Для вас нет работы!");
                return;
            }
           
        }
        ///Метод проверки введён ли логин и запоминаем логин в переменную parsedLogin
        ///возвращает true или false
        private bool IsLoginValid()
        {
            if (login_textBox.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return false;
            }
            else
            {
                parsedLogin = login_textBox.Text;
                return true;
            }

        }
        ///Метод проверки введён ли пароль и запоминаем пароль в переменную parsedPassword
        ///возвращает true или false
        private bool IsPasswordValid()
        {
            if (password_textBox.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return false;
            }
            else
            {
                parsedPassword = password_textBox.Text;
                return true;
            }

        }
        ///Метод при нажатии кнопки ВОЙТИ
        private void login_button_Click(object sender, EventArgs e)
        {
            ///Вызов методов для проверки логина и пароля на наличие значений
            if (IsLoginValid() && IsPasswordValid())

            {
                ///Создаём переменную с подключением к БД
                using (SqlConnection connStr = new SqlConnection(Properties.Settings.Default.connection))
                {
                    ///Создаём запрос на получение role(РОЛИ) и id(АЙДИ) по введённому паролю и логину
                    const string sqlcom = "Select Post,IdWorker from Workers where Password = @password and Login = @login; ";
                    using (SqlCommand sqlCommand = new SqlCommand(sqlcom, connStr))
                    {
                        ///Добавляем вместо @login наше значение parsedLogin и даём ему тип данных NVarChar
                        sqlCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
                        sqlCommand.Parameters["@login"].Value = parsedLogin;

                        ///Добавляем вместо @password наше значение parsedPassword и даём ему тип данных NVarChar
                        sqlCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                        sqlCommand.Parameters["@password"].Value = parsedPassword;

                        ///Если запрос выполняется без ошибок,
                        ///то всё что в try{...} выполнится, иначе код в catch выведет "Ошибка!" на экран
                        try
                        {
                            connStr.Open(); /// открываем подключение к БД
                            SqlDataReader reader = sqlCommand.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    post = reader.GetValue(0).ToString();
                                    id = (Int32)reader.GetValue(1);
                                }
                                reader.Close();
                                IsRole(post, id);
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!");
                                reader.Close();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Ошибка!");
                        }
                        finally
                        {
                            connStr.Close();
                        }
                    }
                }
            }
        }
    }
}
