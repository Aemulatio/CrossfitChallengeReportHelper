namespace PartisipentsScoreTable
{
    partial class addPersonPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.personNumberLbl = new System.Windows.Forms.Label();
            this.personNumberBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.busyNumbersList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(91, 138);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(151, 38);
            this.lastNameLbl.TabIndex = 0;
            this.lastNameLbl.Text = "Фамилия";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(91, 213);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(81, 38);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "Имя";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(248, 135);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(371, 47);
            this.lastNameBox.TabIndex = 1;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(248, 210);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(371, 47);
            this.firstNameBox.TabIndex = 2;
            // 
            // personNumberLbl
            // 
            this.personNumberLbl.AutoSize = true;
            this.personNumberLbl.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNumberLbl.Location = new System.Drawing.Point(91, 288);
            this.personNumberLbl.Name = "personNumberLbl";
            this.personNumberLbl.Size = new System.Drawing.Size(120, 38);
            this.personNumberLbl.TabIndex = 0;
            this.personNumberLbl.Text = "Номер";
            // 
            // personNumberBox
            // 
            this.personNumberBox.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNumberBox.Location = new System.Drawing.Point(248, 285);
            this.personNumberBox.Name = "personNumberBox";
            this.personNumberBox.Size = new System.Drawing.Size(371, 47);
            this.personNumberBox.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(278, 389);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(245, 47);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "OK";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Занятые номера";
            // 
            // busyNumbersList
            // 
            this.busyNumbersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busyNumbersList.Enabled = false;
            this.busyNumbersList.Font = new System.Drawing.Font("Modern No. 20", 27.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busyNumbersList.Location = new System.Drawing.Point(698, 116);
            this.busyNumbersList.Name = "busyNumbersList";
            this.busyNumbersList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.busyNumbersList.Size = new System.Drawing.Size(217, 352);
            this.busyNumbersList.TabIndex = 10;
            this.busyNumbersList.Text = "";
            // 
            // addPersonPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.busyNumbersList);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.personNumberBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.personNumberLbl);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameLbl);
            this.Name = "addPersonPage";
            this.Size = new System.Drawing.Size(945, 579);
            this.Load += new System.EventHandler(this.addPersonPage_Load);
            this.Enter += new System.EventHandler(this.addPersonPage_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label personNumberLbl;
        private System.Windows.Forms.TextBox personNumberBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox busyNumbersList;
    }
}
