namespace DemoEkzamenPrakrika
{
    partial class ManagerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPage_StatsOrd = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_StatsOrder = new System.Windows.Forms.DataGridView();
            this.tabPage_Orders_Clients = new System.Windows.Forms.TabPage();
            this.button_ShowQR = new System.Windows.Forms.Button();
            this.label_help = new System.Windows.Forms.Label();
            this.button_ShowDataClient = new System.Windows.Forms.Button();
            this.comboBox_StatusOrder = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DeadLine = new System.Windows.Forms.DateTimePicker();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_Workers = new System.Windows.Forms.ComboBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.DataGridView_More = new System.Windows.Forms.DataGridView();
            this.tabControl_Data = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_StatsOrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatsOrder)).BeginInit();
            this.tabPage_Orders_Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_More)).BeginInit();
            this.tabControl_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_StatsOrd
            // 
            this.tabPage_StatsOrd.BackColor = System.Drawing.Color.Gray;
            this.tabPage_StatsOrd.Controls.Add(this.button1);
            this.tabPage_StatsOrd.Controls.Add(this.chart1);
            this.tabPage_StatsOrd.Controls.Add(this.dataGridView_StatsOrder);
            this.tabPage_StatsOrd.Location = new System.Drawing.Point(4, 22);
            this.tabPage_StatsOrd.Name = "tabPage_StatsOrd";
            this.tabPage_StatsOrd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_StatsOrd.Size = new System.Drawing.Size(792, 424);
            this.tabPage_StatsOrd.TabIndex = 1;
            this.tabPage_StatsOrd.Text = "Статистика по заявкам";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(255, 103);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "series2";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series3";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series4";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(504, 265);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // dataGridView_StatsOrder
            // 
            this.dataGridView_StatsOrder.AllowUserToAddRows = false;
            this.dataGridView_StatsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StatsOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_StatsOrder.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_StatsOrder.Name = "dataGridView_StatsOrder";
            this.dataGridView_StatsOrder.ReadOnly = true;
            this.dataGridView_StatsOrder.Size = new System.Drawing.Size(786, 418);
            this.dataGridView_StatsOrder.TabIndex = 13;
            // 
            // tabPage_Orders_Clients
            // 
            this.tabPage_Orders_Clients.Controls.Add(this.button_ShowQR);
            this.tabPage_Orders_Clients.Controls.Add(this.label_help);
            this.tabPage_Orders_Clients.Controls.Add(this.button_ShowDataClient);
            this.tabPage_Orders_Clients.Controls.Add(this.comboBox_StatusOrder);
            this.tabPage_Orders_Clients.Controls.Add(this.dateTimePicker_DeadLine);
            this.tabPage_Orders_Clients.Controls.Add(this.button_Save);
            this.tabPage_Orders_Clients.Controls.Add(this.comboBox_Workers);
            this.tabPage_Orders_Clients.Controls.Add(this.Button_Exit);
            this.tabPage_Orders_Clients.Controls.Add(this.DataGridView_More);
            this.tabPage_Orders_Clients.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Orders_Clients.Name = "tabPage_Orders_Clients";
            this.tabPage_Orders_Clients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Orders_Clients.Size = new System.Drawing.Size(792, 424);
            this.tabPage_Orders_Clients.TabIndex = 0;
            this.tabPage_Orders_Clients.Text = "Данные по заявке и клиентам";
            // 
            // button_ShowQR
            // 
            this.button_ShowQR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ShowQR.Location = new System.Drawing.Point(287, 326);
            this.button_ShowQR.Name = "button_ShowQR";
            this.button_ShowQR.Size = new System.Drawing.Size(218, 69);
            this.button_ShowQR.TabIndex = 20;
            this.button_ShowQR.Text = "Показать QR-код";
            this.button_ShowQR.UseVisualStyleBackColor = true;
            this.button_ShowQR.Click += new System.EventHandler(this.button_ShowQR_Click);
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_help.Location = new System.Drawing.Point(173, 223);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(446, 42);
            this.label_help.TabIndex = 19;
            this.label_help.Text = "Выберите нужную заявку";
            // 
            // button_ShowDataClient
            // 
            this.button_ShowDataClient.BackColor = System.Drawing.Color.White;
            this.button_ShowDataClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ShowDataClient.Location = new System.Drawing.Point(629, 223);
            this.button_ShowDataClient.Name = "button_ShowDataClient";
            this.button_ShowDataClient.Size = new System.Drawing.Size(160, 51);
            this.button_ShowDataClient.TabIndex = 18;
            this.button_ShowDataClient.Text = "Показать данные клиента";
            this.button_ShowDataClient.UseVisualStyleBackColor = false;
            this.button_ShowDataClient.Click += new System.EventHandler(this.button_ShowDataClient_Click);
            // 
            // comboBox_StatusOrder
            // 
            this.comboBox_StatusOrder.FormattingEnabled = true;
            this.comboBox_StatusOrder.Location = new System.Drawing.Point(19, 249);
            this.comboBox_StatusOrder.Name = "comboBox_StatusOrder";
            this.comboBox_StatusOrder.Size = new System.Drawing.Size(157, 21);
            this.comboBox_StatusOrder.TabIndex = 17;
            // 
            // dateTimePicker_DeadLine
            // 
            this.dateTimePicker_DeadLine.Location = new System.Drawing.Point(19, 222);
            this.dateTimePicker_DeadLine.MinDate = new System.DateTime(2023, 9, 5, 0, 0, 0, 0);
            this.dateTimePicker_DeadLine.Name = "dateTimePicker_DeadLine";
            this.dateTimePicker_DeadLine.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker_DeadLine.TabIndex = 16;
            this.dateTimePicker_DeadLine.Value = new System.DateTime(2024, 2, 23, 23, 59, 59, 0);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.White;
            this.button_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(18, 303);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(157, 57);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_Workers
            // 
            this.comboBox_Workers.FormattingEnabled = true;
            this.comboBox_Workers.Location = new System.Drawing.Point(19, 276);
            this.comboBox_Workers.Name = "comboBox_Workers";
            this.comboBox_Workers.Size = new System.Drawing.Size(156, 21);
            this.comboBox_Workers.TabIndex = 14;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.White;
            this.Button_Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(42, 361);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(107, 57);
            this.Button_Exit.TabIndex = 13;
            this.Button_Exit.Text = "Назад";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // DataGridView_More
            // 
            this.DataGridView_More.AllowUserToAddRows = false;
            this.DataGridView_More.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_More.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_More.Name = "DataGridView_More";
            this.DataGridView_More.ReadOnly = true;
            this.DataGridView_More.Size = new System.Drawing.Size(786, 214);
            this.DataGridView_More.TabIndex = 12;
            this.DataGridView_More.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_More_CellClick);
            this.DataGridView_More.SelectionChanged += new System.EventHandler(this.DataGridView_More_SelectionChanged);
            // 
            // tabControl_Data
            // 
            this.tabControl_Data.Controls.Add(this.tabPage_Orders_Clients);
            this.tabControl_Data.Controls.Add(this.tabPage_StatsOrd);
            this.tabControl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Data.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Data.Name = "tabControl_Data";
            this.tabControl_Data.SelectedIndex = 0;
            this.tabControl_Data.Size = new System.Drawing.Size(800, 450);
            this.tabControl_Data.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_Data);
            this.Name = "ManagerForm";
            this.Text = "Менеджер";
            this.tabPage_StatsOrd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatsOrder)).EndInit();
            this.tabPage_Orders_Clients.ResumeLayout(false);
            this.tabPage_Orders_Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_More)).EndInit();
            this.tabControl_Data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_StatsOrd;
        private System.Windows.Forms.TabPage tabPage_Orders_Clients;
        private System.Windows.Forms.Button button_ShowDataClient;
        private System.Windows.Forms.ComboBox comboBox_StatusOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DeadLine;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox comboBox_Workers;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.DataGridView DataGridView_More;
        private System.Windows.Forms.TabControl tabControl_Data;
        private System.Windows.Forms.DataGridView dataGridView_StatsOrder;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.Button button_ShowQR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}