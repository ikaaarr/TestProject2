namespace DemoEkzamenPrakrika
{
    partial class WorkerForm
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
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.DataGridView_More = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_More)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.White;
            this.Button_Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(24, 409);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(83, 29);
            this.Button_Exit.TabIndex = 7;
            this.Button_Exit.Text = "Назад";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.White;
            this.Button_Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Add.Location = new System.Drawing.Point(347, 232);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(106, 30);
            this.Button_Add.TabIndex = 6;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // DataGridView_More
            // 
            this.DataGridView_More.AllowUserToAddRows = false;
            this.DataGridView_More.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_More.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView_More.Location = new System.Drawing.Point(3, 9);
            this.DataGridView_More.Name = "DataGridView_More";
            this.DataGridView_More.ReadOnly = true;
            this.DataGridView_More.Size = new System.Drawing.Size(795, 217);
            this.DataGridView_More.TabIndex = 5;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.DataGridView_More);
            this.Name = "WorkerForm";
            this.Text = "Работник";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_More)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.DataGridView DataGridView_More;
    }
}