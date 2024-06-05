namespace DemoEkzamenPrakrika
{
    partial class AdmForm
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
            this.DataGridView_More = new System.Windows.Forms.DataGridView();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Editing = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_More)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_More
            // 
            this.DataGridView_More.AllowUserToAddRows = false;
            this.DataGridView_More.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_More.Location = new System.Drawing.Point(2, 5);
            this.DataGridView_More.Name = "DataGridView_More";
            this.DataGridView_More.ReadOnly = true;
            this.DataGridView_More.Size = new System.Drawing.Size(795, 217);
            this.DataGridView_More.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.White;
            this.Button_Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Add.Location = new System.Drawing.Point(12, 241);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(99, 26);
            this.Button_Add.TabIndex = 1;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Editing
            // 
            this.Button_Editing.BackColor = System.Drawing.Color.White;
            this.Button_Editing.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Editing.Location = new System.Drawing.Point(136, 239);
            this.Button_Editing.Name = "Button_Editing";
            this.Button_Editing.Size = new System.Drawing.Size(109, 30);
            this.Button_Editing.TabIndex = 2;
            this.Button_Editing.Text = "Изменить";
            this.Button_Editing.UseVisualStyleBackColor = false;
            this.Button_Editing.Click += new System.EventHandler(this.Button_Editing_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.White;
            this.Button_Delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Delete.Location = new System.Drawing.Point(281, 239);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(107, 30);
            this.Button_Delete.TabIndex = 3;
            this.Button_Delete.Text = "Удалить";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.White;
            this.Button_Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(12, 408);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(80, 30);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "Назад";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Editing);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.DataGridView_More);
            this.Name = "AdmForm";
            this.Text = "Администратор";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_More)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_More;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Editing;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Exit;
    }
}