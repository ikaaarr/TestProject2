namespace DemoEkzamenPrakrika
{
    partial class AddOrdersForm
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
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.lable_Post = new System.Windows.Forms.Label();
            this.textBox_TitleEquipment = new System.Windows.Forms.TextBox();
            this.label_TitleEquipment = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.textBox_ProblemDescript = new System.Windows.Forms.TextBox();
            this.label_ProblemType = new System.Windows.Forms.Label();
            this.comboBox_Problemtype = new System.Windows.Forms.ComboBox();
            this.textBox_CommWork = new System.Windows.Forms.TextBox();
            this.label_CommWork = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_DataEquipment = new System.Windows.Forms.Label();
            this.label_DataClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.White;
            this.Button_Back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Back.Location = new System.Drawing.Point(28, 404);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(105, 34);
            this.Button_Back.TabIndex = 33;
            this.Button_Back.Text = "Назад";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Accept
            // 
            this.Button_Accept.BackColor = System.Drawing.Color.White;
            this.Button_Accept.Enabled = false;
            this.Button_Accept.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Accept.Location = new System.Drawing.Point(293, 263);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(126, 42);
            this.Button_Accept.TabIndex = 30;
            this.Button_Accept.Text = "Создать заявку";
            this.Button_Accept.UseVisualStyleBackColor = false;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.White;
            this.textBox_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(611, 93);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(145, 26);
            this.textBox_Name.TabIndex = 31;
            this.textBox_Name.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lable_Post
            // 
            this.lable_Post.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable_Post.Location = new System.Drawing.Point(443, 99);
            this.lable_Post.Name = "lable_Post";
            this.lable_Post.Size = new System.Drawing.Size(144, 21);
            this.lable_Post.TabIndex = 32;
            this.lable_Post.Text = "Имя:";
            // 
            // textBox_TitleEquipment
            // 
            this.textBox_TitleEquipment.BackColor = System.Drawing.Color.White;
            this.textBox_TitleEquipment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_TitleEquipment.Location = new System.Drawing.Point(186, 59);
            this.textBox_TitleEquipment.Name = "textBox_TitleEquipment";
            this.textBox_TitleEquipment.Size = new System.Drawing.Size(221, 26);
            this.textBox_TitleEquipment.TabIndex = 34;
            this.textBox_TitleEquipment.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_TitleEquipment
            // 
            this.label_TitleEquipment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleEquipment.Location = new System.Drawing.Point(12, 59);
            this.label_TitleEquipment.Name = "label_TitleEquipment";
            this.label_TitleEquipment.Size = new System.Drawing.Size(168, 26);
            this.label_TitleEquipment.TabIndex = 35;
            this.label_TitleEquipment.Text = "Название оборудования:";
            // 
            // label_
            // 
            this.label_.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_.Location = new System.Drawing.Point(12, 96);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(149, 26);
            this.label_.TabIndex = 36;
            this.label_.Text = "Описание проблемы:";
            // 
            // textBox_ProblemDescript
            // 
            this.textBox_ProblemDescript.BackColor = System.Drawing.Color.White;
            this.textBox_ProblemDescript.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ProblemDescript.Location = new System.Drawing.Point(186, 96);
            this.textBox_ProblemDescript.Name = "textBox_ProblemDescript";
            this.textBox_ProblemDescript.Size = new System.Drawing.Size(221, 26);
            this.textBox_ProblemDescript.TabIndex = 37;
            this.textBox_ProblemDescript.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_ProblemType
            // 
            this.label_ProblemType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ProblemType.Location = new System.Drawing.Point(12, 142);
            this.label_ProblemType.Name = "label_ProblemType";
            this.label_ProblemType.Size = new System.Drawing.Size(106, 26);
            this.label_ProblemType.TabIndex = 38;
            this.label_ProblemType.Text = "Тип проблемы:";
            // 
            // comboBox_Problemtype
            // 
            this.comboBox_Problemtype.FormattingEnabled = true;
            this.comboBox_Problemtype.Items.AddRange(new object[] {
            "Физический",
            "Программный"});
            this.comboBox_Problemtype.Location = new System.Drawing.Point(186, 142);
            this.comboBox_Problemtype.Name = "comboBox_Problemtype";
            this.comboBox_Problemtype.Size = new System.Drawing.Size(221, 21);
            this.comboBox_Problemtype.TabIndex = 39;
            this.comboBox_Problemtype.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Problemtype_SelectionChangeCommitted);
            // 
            // textBox_CommWork
            // 
            this.textBox_CommWork.BackColor = System.Drawing.Color.White;
            this.textBox_CommWork.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CommWork.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_CommWork.Location = new System.Drawing.Point(186, 194);
            this.textBox_CommWork.Name = "textBox_CommWork";
            this.textBox_CommWork.Size = new System.Drawing.Size(221, 26);
            this.textBox_CommWork.TabIndex = 41;
            // 
            // label_CommWork
            // 
            this.label_CommWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_CommWork.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CommWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_CommWork.Location = new System.Drawing.Point(41, 414);
            this.label_CommWork.Name = "label_CommWork";
            this.label_CommWork.Size = new System.Drawing.Size(10, 10);
            this.label_CommWork.TabIndex = 40;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.BackColor = System.Drawing.Color.White;
            this.textBox_LastName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LastName.Location = new System.Drawing.Point(611, 56);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(145, 26);
            this.textBox_LastName.TabIndex = 42;
            this.textBox_LastName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Lastname
            // 
            this.label_Lastname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Lastname.Location = new System.Drawing.Point(443, 59);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(131, 23);
            this.label_Lastname.TabIndex = 43;
            this.label_Lastname.Text = "Фамилия:";
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.BackColor = System.Drawing.Color.White;
            this.textBox_Surname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Surname.Location = new System.Drawing.Point(611, 137);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(145, 26);
            this.textBox_Surname.TabIndex = 44;
            // 
            // label_Surname
            // 
            this.label_Surname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname.Location = new System.Drawing.Point(443, 140);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(181, 23);
            this.label_Surname.TabIndex = 45;
            this.label_Surname.Text = "Отчество (при наличии):";
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.White;
            this.textBox_Email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Email.Location = new System.Drawing.Point(611, 182);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(142, 26);
            this.textBox_Email.TabIndex = 46;
            this.textBox_Email.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Email
            // 
            this.label_Email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Email.Location = new System.Drawing.Point(443, 185);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(131, 23);
            this.label_Email.TabIndex = 47;
            this.label_Email.Text = "Номер телефона:";
            // 
            // label_DataEquipment
            // 
            this.label_DataEquipment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DataEquipment.Location = new System.Drawing.Point(41, 9);
            this.label_DataEquipment.Name = "label_DataEquipment";
            this.label_DataEquipment.Size = new System.Drawing.Size(298, 38);
            this.label_DataEquipment.TabIndex = 48;
            this.label_DataEquipment.Text = "Информация об оборудовании:";
            // 
            // label_DataClient
            // 
            this.label_DataClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_DataClient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DataClient.Location = new System.Drawing.Point(108, 414);
            this.label_DataClient.Name = "label_DataClient";
            this.label_DataClient.Size = new System.Drawing.Size(10, 10);
            this.label_DataClient.TabIndex = 49;
            this.label_DataClient.Text = "Данные клиента:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 50;
            this.label1.Text = "Информация о клиенте:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 52;
            this.label3.Text = "Комментарий работника:";
            // 
            // AddOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_DataClient);
            this.Controls.Add(this.label_DataEquipment);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.textBox_CommWork);
            this.Controls.Add(this.label_CommWork);
            this.Controls.Add(this.comboBox_Problemtype);
            this.Controls.Add(this.label_ProblemType);
            this.Controls.Add(this.textBox_ProblemDescript);
            this.Controls.Add(this.label_);
            this.Controls.Add(this.textBox_TitleEquipment);
            this.Controls.Add(this.label_TitleEquipment);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.lable_Post);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AddOrdersForm";
            this.Text = "Добавление заявки";
       
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label lable_Post;
        private System.Windows.Forms.TextBox textBox_TitleEquipment;
        private System.Windows.Forms.Label label_TitleEquipment;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.TextBox textBox_ProblemDescript;
        private System.Windows.Forms.Label label_ProblemType;
        private System.Windows.Forms.ComboBox comboBox_Problemtype;
        private System.Windows.Forms.TextBox textBox_CommWork;
        private System.Windows.Forms.Label label_CommWork;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_DataEquipment;
        private System.Windows.Forms.Label label_DataClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}