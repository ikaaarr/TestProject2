namespace DemoEkzamenPrakrika
{
    partial class AddOrEditForm
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
            this.label_Name = new System.Windows.Forms.Label();
            this.lable_Post = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Post = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.White;
            this.Button_Back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Back.Location = new System.Drawing.Point(12, 411);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(102, 27);
            this.Button_Back.TabIndex = 29;
            this.Button_Back.Text = "Назад";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Accept
            // 
            this.Button_Accept.BackColor = System.Drawing.Color.White;
            this.Button_Accept.Enabled = false;
            this.Button_Accept.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Accept.Location = new System.Drawing.Point(292, 325);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(143, 28);
            this.Button_Accept.TabIndex = 18;
            this.Button_Accept.Text = "Принять";
            this.Button_Accept.UseVisualStyleBackColor = false;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(185, 38);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(60, 50);
            this.label_Name.TabIndex = 24;
            this.label_Name.Text = "Имя:";
            // 
            // lable_Post
            // 
            this.lable_Post.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable_Post.Location = new System.Drawing.Point(164, 277);
            this.lable_Post.Name = "lable_Post";
            this.lable_Post.Size = new System.Drawing.Size(86, 50);
            this.lable_Post.TabIndex = 22;
            this.lable_Post.Text = "Должность:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.White;
            this.textBox_Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(256, 228);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(221, 26);
            this.textBox_Password.TabIndex = 25;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // textBox_Post
            // 
            this.textBox_Post.BackColor = System.Drawing.Color.White;
            this.textBox_Post.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Post.Location = new System.Drawing.Point(256, 277);
            this.textBox_Post.Name = "textBox_Post";
            this.textBox_Post.Size = new System.Drawing.Size(221, 26);
            this.textBox_Post.TabIndex = 21;
            this.textBox_Post.TextChanged += new System.EventHandler(this.textBox_Role_TextChanged);
            // 
            // label_Password
            // 
            this.label_Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.Location = new System.Drawing.Point(173, 228);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(61, 29);
            this.label_Password.TabIndex = 26;
            this.label_Password.Text = "Пароль:";
            // 
            // label_Lastname
            // 
            this.label_Lastname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Lastname.Location = new System.Drawing.Point(170, 92);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(74, 50);
            this.label_Lastname.TabIndex = 20;
            this.label_Lastname.Text = "Фамилия:";
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.Color.White;
            this.textBox_Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(256, 185);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(221, 26);
            this.textBox_Login.TabIndex = 27;
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.BackColor = System.Drawing.Color.White;
            this.textBox_Lastname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Lastname.Location = new System.Drawing.Point(256, 89);
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(221, 26);
            this.textBox_Lastname.TabIndex = 19;
            this.textBox_Lastname.TextChanged += new System.EventHandler(this.textBox_Lastname_TextChanged);
            // 
            // label_Login
            // 
            this.label_Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.Location = new System.Drawing.Point(184, 185);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(60, 50);
            this.label_Login.TabIndex = 28;
            this.label_Login.Text = "Логин:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.White;
            this.textBox_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(256, 38);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(221, 26);
            this.textBox_Name.TabIndex = 23;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label_Surname
            // 
            this.label_Surname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname.Location = new System.Drawing.Point(170, 148);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(75, 26);
            this.label_Surname.TabIndex = 31;
            this.label_Surname.Text = "Отчество:";
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.BackColor = System.Drawing.Color.White;
            this.textBox_Surname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Surname.Location = new System.Drawing.Point(256, 133);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(221, 26);
            this.textBox_Surname.TabIndex = 30;
            this.textBox_Surname.TextChanged += new System.EventHandler(this.textBox_Surname_TextChanged);
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox_Lastname);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Post);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.lable_Post);
            this.Controls.Add(this.label_Name);
            this.Name = "AddOrEditForm";
            this.Text = "AddOrEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label lable_Post;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Post;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Lastname;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.TextBox textBox_Surname;
    }
}