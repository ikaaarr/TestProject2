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
    public partial class AddOrEditForm : Form
    {
        DBConnect connection = new DBConnect();
        public AddOrEditForm(int idDB)
        {
            InitializeComponent();
                id = idDB;
                FillDatatxt();
        }
        public AddOrEditForm()
        {
            InitializeComponent();
        }
        private int id;
        private void FillDatatxt()
        {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Login,Password,Name,Lastname,Surname,Post " 
                    + "FROM Workers WHERE idWorker = @id", connection.getCon()))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    sqlCommand.Parameters["@id"].Value = id;
                    try
                    {
                        connection.OpenOrClose();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                textBox_Login.Text = reader.GetValue(0).ToString();

                                textBox_Password.Text = reader.GetValue(1).ToString();

                                textBox_Name.Text = reader.GetValue(2).ToString();

                                textBox_Lastname.Text = reader.GetValue(3).ToString();

                                textBox_Surname.Text = reader.GetValue(4).ToString();

                                textBox_Post.Text = reader.GetValue(5).ToString();

                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка! Нет данных!");
                            reader.Close();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                    finally
                    {
                        connection.OpenOrClose();
                    }
                }
        }
        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button_Accept_Click(object sender, EventArgs e)
        {
            if (DataIsFills())
            {
                if (id != 0) EditData();
                else AddData();
                this.Close();
            }
        }
        private bool DataIsFills()
        {
            if (textBox_Login.Text != "" &&
                textBox_Password.Text != "" &&
                textBox_Name.Text != "" &&
                textBox_Lastname.Text != "" &&
                textBox_Post.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Заполните все данные!");
                return false;
            }
        }
        private void EditData()
        {
            using (SqlCommand sqlCommand = new SqlCommand(
                 "UPDATE Workers SET " +
                 "Login = @login, " +
                 "Password = @password," +
                 "Post = @Post," +
                 "name = @name," +
                 "lastname = @lastname," +
                 "Surname = @Surname " +
                 "WHERE idWorker = @idWorker;", connection.getCon()))
            {
                sqlCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
                sqlCommand.Parameters["@login"].Value = textBox_Login.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                sqlCommand.Parameters["@password"].Value = textBox_Password.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                sqlCommand.Parameters["@name"].Value = textBox_Name.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@lastname", SqlDbType.NVarChar));
                sqlCommand.Parameters["@lastname"].Value = textBox_Lastname.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Surname"].Value = textBox_Surname.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@Post", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Post"].Value = textBox_Post.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@idWorker", SqlDbType.Int));
                sqlCommand.Parameters["@idWorker"].Value = id;
                try
                {
                    connection.OpenOrClose();
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
                finally
                {
                    connection.OpenOrClose();
                    MessageBox.Show("Данные успешно изменены!");
                }
            }

        }
        private void AddData()
        {
            
                using (SqlCommand sqlCommand = new SqlCommand(
                     "INSERT INTO Workers (Login, Password,Post,Name,lastname,Surname) " +
                     "VALUES (@login, @password,@Post,@name,@lastname,@Surname);", connection.getCon()))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@login"].Value = textBox_Login.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@password"].Value = textBox_Password.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@name"].Value = textBox_Name.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@lastname", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@lastname"].Value = textBox_Lastname.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Surname"].Value = textBox_Surname.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@Post", SqlDbType.NVarChar));
                    sqlCommand.Parameters["@Post"].Value = textBox_Post.Text;
                    try
                    {
                        connection.OpenOrClose();
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                    finally
                    {
                        connection.OpenOrClose();
                        MessageBox.Show("Данные успешно добавлены!");
                    }
                }
        }
        private void OnAcceptButton()
        {
            if (textBox_Login.Text != "" &&
                textBox_Password.Text != "" &&
                textBox_Name.Text != "" &&
                textBox_Lastname.Text != "" &&
                textBox_Post.Text != "") Button_Accept.Enabled = true;
            else Button_Accept.Enabled = false;
        }
        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {
            OnAcceptButton();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            OnAcceptButton();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            OnAcceptButton();
        }

        private void textBox_Lastname_TextChanged(object sender, EventArgs e)
        {
            OnAcceptButton();
        }

        private void textBox_Surname_TextChanged(object sender, EventArgs e)
        {
            OnAcceptButton();
        }

        private void textBox_Role_TextChanged(object sender, EventArgs e)
        {
            OnAcceptButton();
        }
    }
}
