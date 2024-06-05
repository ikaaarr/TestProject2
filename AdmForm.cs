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
    public partial class AdmForm : Form
    {
        DBConnect connection = new DBConnect();
        public AdmForm(int idDB)
        {
            InitializeComponent();
            id = idDB;
            FillDGV();
        }
        private int id;
        private bool flag;
        private void FillDGV()
        {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Workers WHERE idWorker NOT LIKE @id;", connection.getCon()))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    sqlCommand.Parameters["@id"].Value = id;
                    try
                    {
                        connection.OpenOrClose();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();

                            dataTable.Load(dataReader);

                            this.DataGridView_More.DataSource = dataTable;

                            dataReader.Close();

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                    finally
                    {
                        connection.OpenOrClose();
                        DataGridView_More.Columns[0].HeaderText = "Номер сотрудника";
                        DataGridView_More.Columns[1].HeaderText = "Имя";
                        DataGridView_More.Columns[2].HeaderText = "Фамилия";
                        DataGridView_More.Columns[3].HeaderText = "Отчество";
                        DataGridView_More.Columns[4].HeaderText = "Должность";
                        DataGridView_More.Columns[5].HeaderText = "Логин";
                        DataGridView_More.Columns[6].HeaderText = "Пароль";
                    }
                }
            

        }
        private void ShowAddorEditForm()
        {
            
                if (flag)
                {
                    AddOrEditForm editformAdm = new AddOrEditForm(int.Parse(DataGridView_More.CurrentRow.Cells[0].Value.ToString()));
                    editformAdm.FormClosed += (object s, FormClosedEventArgs ev) => { FillDGV(); };
                    editformAdm.ShowDialog();
                }
                else
                {
                    AddOrEditForm addformAdm = new AddOrEditForm();
                    addformAdm.FormClosed += (object s, FormClosedEventArgs ev) => { FillDGV(); };
                    addformAdm.ShowDialog();
                }
            
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Workers where idWorker = @id", connection.getCon()))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    sqlCommand.Parameters["@id"].Value = DataGridView_More.CurrentRow.Cells[0].Value;
                    try
                    {
                        connection.OpenOrClose();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Пользователь успешно удалён!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                    finally
                    {
                        connection.OpenOrClose();
                        FillDGV();
                    }
                }
            
        }

        private void Button_Editing_Click(object sender, EventArgs e)
        {
            flag = true;
            ShowAddorEditForm();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            flag = false;
            ShowAddorEditForm();
        }
    }
}
