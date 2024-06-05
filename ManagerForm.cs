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
using System.Net.Mail;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;


namespace DemoEkzamenPrakrika
{
    public partial class ManagerForm : Form
    {
        DBConnect connection = new DBConnect();
        public ManagerForm(int idDB)
        {
            globalid = idDB;
            InitializeComponent();
            FillDGV_Orders();
            FIllDGV_StatsOrder();
            SetParameters(true);
          
        }
        int globalid;
        bool globalflag = false;
        private void SetParameters(bool flag)
        {
            if (flag)
            {
                dateTimePicker_DeadLine.MinDate = DateTime.Today;
                dateTimePicker_DeadLine.Visible = false;
                comboBox_Workers.Visible = false;
                comboBox_StatusOrder.Visible = false;
                button_Save.Enabled = false;
                button_ShowDataClient.Enabled = false;
                comboBox_Workers.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox_StatusOrder.DropDownStyle = ComboBoxStyle.DropDownList;
                label_help.Visible = true;
            }
            else
            {
                dateTimePicker_DeadLine.Visible = false;
                comboBox_Workers.Visible = false;
                comboBox_StatusOrder.Visible = false;
                button_Save.Enabled = false;
                button_ShowDataClient.Text = "Показать данные заявок";
            }
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsNotNull()
        {
            if (comboBox_Workers.Text == "")
            {
                MessageBox.Show("Выберите работника!");
                return false;
            }
            else return true;
        }
        private void FillDGV_Orders()
        {
            using (SqlCommand sqlCommand = new SqlCommand(
                "SELECT * FROM Orders;", connection.getCon()))

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
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
                finally
                {
                    connection.OpenOrClose();
                    DataGridView_More.Columns[0].HeaderText = "Номер заявки";
                    DataGridView_More.Columns[1].HeaderText = "Дата добавления";
                    DataGridView_More.Columns[2].HeaderText = "Название оборудования";
                    DataGridView_More.Columns[3].HeaderText = "Описание проблемы";
                    DataGridView_More.Columns[4].HeaderText = "Статус заявки";
                    DataGridView_More.Columns[5].HeaderText = "Комментарии работника";
                    DataGridView_More.Columns[6].HeaderText = "Выполнить до";
                    DataGridView_More.Columns[7].HeaderText = "Тип поломки";
                    DataGridView_More.Columns[8].HeaderText = "Номер клиента";
                    DataGridView_More.Columns[9].HeaderText = "Номер исполнителя";
                }
            }
        }
        private void FIllDGV_StatsOrder()
        {
            using (SqlCommand sqlCommand = new SqlCommand(
                "SELECT * FROM StatisticsView;", connection.getCon()))
            {
                try
                {
                    connection.OpenOrClose();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();

                        dataTable.Load(dataReader);
                     
                  
                        this.dataGridView_StatsOrder.DataSource = dataTable;

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
                    dataGridView_StatsOrder.Columns[0].HeaderText = "Количество выполненных заявок";
                    dataGridView_StatsOrder.Columns[1].HeaderText = "Среднее время выполнения заявки(дней)";
                    dataGridView_StatsOrder.Columns[2].HeaderText = "Заявок с программными неисправностями"; 
                    dataGridView_StatsOrder.Columns[3].HeaderText = "Заявок с физическими неисправностями";
                }
            }
        }
        private bool FillIdNewWorker()
        {
            if (IsNotNull())
            {
                using (SqlCommand sqlCommand = new SqlCommand($"Update Orders set idWorker = " +
                $"(SELECT idWorker " +
                $"FROM Workers WHERE CONCAT(Name, ' ', LastName, ' ', SurName) " +
                $"LIKE N'%{comboBox_Workers.Text}%') WHERE idOrder = '{DataGridView_More.CurrentRow.Cells[0].Value}'", connection.getCon()))
                {
                    try
                    {
                        connection.OpenOrClose();
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                        return false;
                    }
                    finally
                    {
                        connection.OpenOrClose();
                    }
                }
            }
            else return false;
        }
        private bool FillNewDataDeadLine()
        {
            DateTime currentDate = DateTime.Today;

            // Установка выбранной даты из DateTimePicker
            DateTime selectedDate = dateTimePicker_DeadLine.Value;

            // Вычисление разницы между датами в днях
            TimeSpan difference = selectedDate - currentDate;

            using (SqlCommand sqlCommand = new SqlCommand($"Update Orders set DeadLine = " +
                $"(SELECT FORMAT(CONVERT(date, GETDATE() + {(int)difference.TotalDays}), 'd', 'en-gb')) " +
                $"WHERE idOrder = {DataGridView_More.CurrentRow.Cells[0].Value};", connection.getCon()))
            {
                try
                {
                    connection.OpenOrClose();
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Ошибка! Новая дата не добавилась!");
                    return false;
                }
                finally
                {
                    connection.OpenOrClose();
                }

            }
        }
        private bool FillNewStatusOrder()
        {
            using (SqlCommand sqlCommand = new SqlCommand($"Update Orders set OrderStatus = N'{comboBox_StatusOrder.Text}'" +
                $"WHERE IdOrder = '{DataGridView_More.CurrentRow.Cells[0].Value}'", connection.getCon()))
            {
                try
                {
                    connection.OpenOrClose();
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Ошибка! Статус заявки не обновился!");
                    return false;
                }
                finally
                {
                    connection.OpenOrClose();
                }

            }
        }
        private string GetNameManager()
        {
            string nameManager = "";

            using (SqlCommand sqlCommand = new SqlCommand(
                $"SELECT Name FROM Workers WHERE idWorker = {globalid};", connection.getCon()))
            {
                try
                {
                    connection.OpenOrClose();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        nameManager = reader["Name"].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка! Имя менеджера не найдено!");
                }
                finally
                {
                    connection.OpenOrClose();
                }
                return nameManager;
            }
        }
        private string GetEmailClient()
        {
            string email = "";

            using (SqlCommand sqlCommand = new SqlCommand(
                $"SELECT EmailAdres FROM Client WHERE idClient = {DataGridView_More.CurrentRow.Cells[8].Value};", connection.getCon()))
            {
                try
                {
                    connection.OpenOrClose();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        email = reader["EmailAdres"].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка! Почта не найдена!");
                }
                finally
                {
                    connection.OpenOrClose();
                }
                
            }
            return email;
        }
        private void SendMail()
        {
            if (GetNameManager() != "" && GetEmailClient() != "")
            {
                /*MailAddress from = new MailAddress("FRIF232@yandex.ru", GetNameManager());

                MailAddress to = new MailAddress(GetEmailClient());

                MailMessage m = new MailMessage(from, to);

                m.Subject = "Статус вашей заявки изменен!";

                m.Body = "<h2>Здравствуйте! Изменился статус вашей заявки на " + comboBox_StatusOrder.SelectedItem.ToString() + "!</h2>";

                m.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 465);

                smtp.Credentials = new NetworkCredential("FRIF232@yandex.ru", "nrpluwsjrcpcythe");
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Письмо успешно отправлено!");*/
            }
        }
        private void button_Save_Click(object sender, EventArgs e)
            {
                if (FillIdNewWorker() &&
                FillNewStatusOrder() &&
                FillNewDataDeadLine())
                    MessageBox.Show("Данные успешно добавились!");
                SendMail();
                FillDGV_Orders();
                SetParameters(true);
            }
        private void GetNLSWorkers()
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Name,Lastname,Surname "
                        + "FROM Workers WHERE Post = N'Работник';", connection.getCon()))
                {
                    try
                    {
                        connection.OpenOrClose();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string fullName = reader["Name"].ToString() + " " + reader["LastName"].ToString();
                                if (!string.IsNullOrEmpty(reader["Surname"].ToString()))
                                {
                                    fullName += " " + reader["Surname"].ToString();
                                }
                                comboBox_Workers.Items.Add(fullName);

                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка! Нет данных работников!");
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
        private void DataGridView_More_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                SetInvertParametetres(); //Установка инвертированных параметров
                GetNLSWorkers(); //Добавление работника в комбобокс
                if (DataGridView_More.CurrentRow.Cells[4].Value.ToString() == "В ожидании")
                {
                    comboBox_StatusOrder.Items.Add("В работе");
                    comboBox_StatusOrder.Items.Add("Выполнено");
                }
                else if (DataGridView_More.CurrentRow.Cells[4].Value.ToString() == "В работе")
                {
                    comboBox_StatusOrder.Items.Add("В ожидании");
                    comboBox_StatusOrder.Items.Add("Выполнено");
                }
                else
                {
                    comboBox_StatusOrder.Items.Add("В работе");
                    comboBox_StatusOrder.Items.Add("В ожидании");
                }
                comboBox_StatusOrder.SelectedIndex = 0;
            }
        private void SetInvertParametetres()
            {
                dateTimePicker_DeadLine.Value = DateTime.Today; //Взять сегодняшнюю дату
                comboBox_Workers.Items.Clear();
                comboBox_StatusOrder.Items.Clear();
                comboBox_Workers.Visible = true;
                comboBox_StatusOrder.Visible = true;
                button_Save.Enabled = true;
                button_ShowDataClient.Enabled = true;
                dateTimePicker_DeadLine.Visible = true;
                label_help.Visible = false;
            }
        private void button_ShowDataClient_Click(object sender, EventArgs e)
            { if (!globalflag)
                {
                    using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Client where idClient = '{DataGridView_More.CurrentRow.Cells[8].Value}';", connection.getCon()))
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
                        catch
                        {
                            MessageBox.Show("Ошибка!");
                        }
                        finally
                        {
                            connection.OpenOrClose();
                            DataGridView_More.Columns[0].HeaderText = "ID клиента";
                            DataGridView_More.Columns[1].HeaderText = "Имя";
                            DataGridView_More.Columns[2].HeaderText = "Фамилия";
                            DataGridView_More.Columns[3].HeaderText = "Отчество";
                            DataGridView_More.Columns[4].HeaderText = "Email";
                        }
                    }
                    SetParameters(false);
                    globalflag = !globalflag;
                    DataGridView_More.Enabled = false;
                }
                else
                {
                    button_ShowDataClient.Text = "Показать данные клиента";
                    FillDGV_Orders();
                    globalflag = !globalflag;
                    button_ShowDataClient.Enabled = false;
                    DataGridView_More.Enabled = true;
                }
            }
        private void DataGridView_More_SelectionChanged(object sender, EventArgs e)
            {
                DataGridView_More.ClearSelection();
            }

        private void button_ShowQR_Click(object sender, EventArgs e)
            {
                QRCodeForm qrcode = new QRCodeForm();
                qrcode.ShowDialog();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateChart2(dataGridView_StatsOrder, "My Chart", "Количество выполненных заявок", "Среднее время выполнения","Количество заявок с программными неисправностями", "Количество заявок с физическими неисправностями");
        }
        private void CreateChart2(DataGridView dataGridView_StatsOrder, string nameTitle, string seriesName, string seriesName1, string seriesName2, string seriesName3)
        {
            try
            {
                chart1.Series.Clear();
                chart1.Series.Add(seriesName);
                chart1.Series.Add(seriesName1);
                chart1.Series.Add(seriesName2);
                chart1.Series.Add(seriesName3);
                
                for (int i = 0; i < dataGridView_StatsOrder.Rows.Count; i++)
                {
                    var name = dataGridView_StatsOrder.Rows[i].Cells[1].Value?.ToString() ?? "";
                    var value = dataGridView_StatsOrder.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var name1 = dataGridView_StatsOrder.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var value1 = dataGridView_StatsOrder.Rows[i].Cells[1].Value?.ToString() ?? "";
                    var name2 = dataGridView_StatsOrder.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var value2 = dataGridView_StatsOrder.Rows[i].Cells[2].Value?.ToString() ?? "";
                    var name3 = dataGridView_StatsOrder.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var value3 = dataGridView_StatsOrder.Rows[i].Cells[3].Value?.ToString() ?? "";
                    chart1.Series[seriesName].Points.AddXY(name, value);
                    chart1.Series[seriesName1].Points.AddXY(name1, value1);
                    chart1.Series[seriesName2].Points.AddXY(name2, value2);
                    chart1.Series[seriesName3].Points.AddXY(name3, value3);
                   
                }
                chart1.Titles.Clear();
                chart1.Titles.Add(nameTitle);

                /*chart1.ChartAreas[0].AxisX.Title = dataGridView_StatsOrder.Columns[1].HeaderText;
                chart1.ChartAreas[0].AxisY.Title = dataGridView_StatsOrder.Columns[0].HeaderText;
                chart1.ChartAreas[0].AxisX.Title = dataGridView_StatsOrder.Columns[1].HeaderText;
                chart1.ChartAreas[0].AxisY.Title = dataGridView_StatsOrder.Columns[0].HeaderText;
                chart1.ChartAreas[0].AxisX.Title = dataGridView_StatsOrder.Columns[1].HeaderText;
                chart1.ChartAreas[0].AxisY.Title = dataGridView_StatsOrder.Columns[0].HeaderText;
                chart1.ChartAreas[0].AxisX.Title = dataGridView_StatsOrder.Columns[1].HeaderText;
                chart1.ChartAreas[0].AxisY.Title = dataGridView_StatsOrder.Columns[0].HeaderText;*/


            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("ошибка мало столбцов");

            }
            catch (FormatException)
            {
                MessageBox.Show("неаозможно считать данные");

            }
        }
    }
    }

