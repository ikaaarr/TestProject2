namespace DemoEkzamenPrakrika
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.DarkGray;
            this.login_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(461, 324);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(94, 32);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(385, 205);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(256, 29);
            this.password_textBox.TabIndex = 1;
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(385, 145);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(256, 29);
            this.login_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(285, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(285, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
         
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_button);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

