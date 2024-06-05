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
    public partial class AddOrdersForm : Form
    {
        DBConnect connection = new DBConnect();
        public AddOrdersForm()
        {
            InitializeComponent();
            comboBox_Problemtype.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        int idClient;
        private void AddDataClient()
        {

            using (SqlCommand sqlCommand = new SqlCommand(
                 "INSERT INTO Client (Name,lastname,Surname,EmailAdres) " +
                 "VALUES (@Name, @lastname,@Surname,@EmailAdres);" +
                 "SELECT SCOPE_IDENTITY() AS Client;", connection.getCon()))
            {
                sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Name"].Value = textBox_Name.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@lastname", SqlDbType.NVarChar));
                sqlCommand.Parameters["@lastname"].Value = textBox_LastName.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Surname"].Value = textBox_Surname.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@EmailAdres", SqlDbType.NVarChar));
                sqlCommand.Parameters["@EmailAdres"].Value = textBox_Email.Text;
                try
                {
                    connection.OpenOrClose();
                    idClient = Int32.Parse((sqlCommand.ExecuteScalar().ToString()));

                }
                catch
                {
                    MessageBox.Show("Ошибка! Данные клиента не добавлены!");
                }
                finally
                {
                    connection.OpenOrClose();
                }
            }
        }
        private void AddDataOrder()
        {
            using (SqlCommand sqlCommand = new SqlCommand(
                 "INSERT INTO Orders (DateAdding,TitleEquipment,DescriptionProblem," +
                 "OrderStatus,CommentsWorker,DeadLine,Problemtype,idClientForeign) " +
                 "VALUES ((SELECT FORMAT(CONVERT ( date, GETDATE()),'d', 'en-gb')), " +
                 "@TitleEquipment,@DescriptionProblem,N'В ожидании',@CommentsWorker," +
                 "(SELECT FORMAT(CONVERT ( date, GETDATE() + 3),'d', 'en-gb'))," +
                 "@problemtype,@idClientForeign);", connection.getCon()))
            {
                sqlCommand.Parameters.Add(new SqlParameter("@TitleEquipment", SqlDbType.NVarChar));
                sqlCommand.Parameters["@TitleEquipment"].Value = textBox_TitleEquipment.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@DescriptionProblem", SqlDbType.NVarChar));
                sqlCommand.Parameters["@DescriptionProblem"].Value = textBox_ProblemDescript.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@CommentsWorker", SqlDbType.NVarChar));
                sqlCommand.Parameters["@CommentsWorker"].Value = textBox_CommWork.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@problemtype", SqlDbType.NVarChar));
                sqlCommand.Parameters["@problemtype"].Value = comboBox_Problemtype.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@idClientForeign", SqlDbType.Int));
                sqlCommand.Parameters["@idClientForeign"].Value = idClient;

                try
                {
                    connection.OpenOrClose();
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка! Данные заявки не добавилены!");
                }
                finally
                {
                    connection.OpenOrClose();
                }
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            OnAcceptButton();
        }
        private void OnAcceptButton()
        {
            if (textBox_Email.Text != "" &&
                textBox_LastName.Text != "" &&
                textBox_Name.Text != "" &&
                textBox_ProblemDescript.Text != "" &&
                textBox_TitleEquipment.Text != "" &&
                comboBox_Problemtype.Text != "") Button_Accept.Enabled = true;
            else Button_Accept.Enabled = false;
        }
        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button_Accept_Click(object sender, EventArgs e)
        {
            AddDataClient();
            AddDataOrder();
            MessageBox.Show("Заявка успешно создана!");
            this.Close();
        }
        private void comboBox_Problemtype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OnAcceptButton();
        }

       

       
    }
}
