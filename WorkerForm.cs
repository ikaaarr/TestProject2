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
    public partial class WorkerForm : Form
    {
        DBConnect connection = new DBConnect();
        public WorkerForm(int idDB)
        {
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV()
        {
            using (SqlCommand sqlCommand = new SqlCommand(
      "SELECT Orders.idOrder, Orders.DateAdding, Orders.TitleEquipment, Orders.DescriptionProblem, Orders.OrderStatus, Orders.CommentsWorker, Orders.DeadLine, Orders.Problemtype, Orders.idClientForeign, Client.Name,Client.LastName,Client.SurName, Client.EmailAdres " +
      "FROM Orders " +
      "INNER JOIN Client ON Orders.idClientForeign = Client.idClient;", connection.getCon()))
            {
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    connection.OpenOrClose();
                    DataGridView_More.Columns[0].HeaderText = "id заявки";
                    DataGridView_More.Columns[1].HeaderText = "Дата добавления";
                    DataGridView_More.Columns[2].HeaderText = "Название оборудования";
                    DataGridView_More.Columns[3].HeaderText = "Описание проблемы";
                    DataGridView_More.Columns[4].HeaderText = "Статус заявки";
                    DataGridView_More.Columns[5].HeaderText = "Комментарии работника";
                    DataGridView_More.Columns[6].HeaderText = "Выполнить до";
                    DataGridView_More.Columns[7].HeaderText = "Тип поломки";
                    DataGridView_More.Columns[8].HeaderText = "id клиента";
                    DataGridView_More.Columns[9].HeaderText = "Имя клиента";
                    DataGridView_More.Columns[10].HeaderText = "Фамилия клиента";
                    DataGridView_More.Columns[11].HeaderText = "Отчество клиента";
                    DataGridView_More.Columns[12].HeaderText = "Номер телефона";
                }
            }

        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            AddOrdersForm addOrdersForm = new AddOrdersForm();
            addOrdersForm.FormClosed += (object s, FormClosedEventArgs ev) => { FillDGV(); };
            addOrdersForm.ShowDialog();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
