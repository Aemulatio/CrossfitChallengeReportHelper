namespace PartisipentsScoreTable
{
    partial class showResults
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
            this.challengerDataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // challengerDataGridView
            // 
            this.challengerDataGridView.AllowUserToAddRows = false;
            this.challengerDataGridView.AllowUserToDeleteRows = false;
            this.challengerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.challengerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.challengerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.chName,
            this.w25,
            this.w35,
            this.w45,
            this.w60,
            this.w70,
            this.w80,
            this.w100,
            this.sumOfAll});
            this.challengerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.challengerDataGridView.Location = new System.Drawing.Point(0, 30);
            this.challengerDataGridView.Name = "challengerDataGridView";
            this.challengerDataGridView.ReadOnly = true;
            this.challengerDataGridView.Size = new System.Drawing.Size(945, 549);
            this.challengerDataGridView.TabIndex = 1;
            this.challengerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.challengerDataGridView_CellContentClick);
            // 
            // number
            // 
            this.number.FillWeight = 50F;
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // chName
            // 
            this.chName.FillWeight = 150F;
            this.chName.HeaderText = "Name";
            this.chName.Name = "chName";
            this.chName.ReadOnly = true;
            // 
            // w25
            // 
            this.w25.FillWeight = 83.9467F;
            this.w25.HeaderText = "25";
            this.w25.Name = "w25";
            this.w25.ReadOnly = true;
            // 
            // w35
            // 
            this.w35.FillWeight = 83.9467F;
            this.w35.HeaderText = "35";
            this.w35.Name = "w35";
            this.w35.ReadOnly = true;
            // 
            // w45
            // 
            this.w45.FillWeight = 83.9467F;
            this.w45.HeaderText = "45";
            this.w45.Name = "w45";
            this.w45.ReadOnly = true;
            // 
            // w60
            // 
            this.w60.FillWeight = 83.9467F;
            this.w60.HeaderText = "60";
            this.w60.Name = "w60";
            this.w60.ReadOnly = true;
            // 
            // w70
            // 
            this.w70.FillWeight = 83.9467F;
            this.w70.HeaderText = "70";
            this.w70.Name = "w70";
            this.w70.ReadOnly = true;
            // 
            // w80
            // 
            this.w80.FillWeight = 83.9467F;
            this.w80.HeaderText = "80";
            this.w80.Name = "w80";
            this.w80.ReadOnly = true;
            // 
            // w100
            // 
            this.w100.FillWeight = 83.9467F;
            this.w100.HeaderText = "100";
            this.w100.Name = "w100";
            this.w100.ReadOnly = true;
            // 
            // sumOfAll
            // 
            this.sumOfAll.HeaderText = "Sum";
            this.sumOfAll.Name = "sumOfAll";
            this.sumOfAll.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(472, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(473, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.challengerDataGridView);
            this.Name = "showResults";
            this.Size = new System.Drawing.Size(945, 579);
            this.Load += new System.EventHandler(this.showResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.challengerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView challengerDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn chName;
        private System.Windows.Forms.DataGridViewTextBoxColumn w25;
        private System.Windows.Forms.DataGridViewTextBoxColumn w35;
        private System.Windows.Forms.DataGridViewTextBoxColumn w45;
        private System.Windows.Forms.DataGridViewTextBoxColumn w60;
        private System.Windows.Forms.DataGridViewTextBoxColumn w70;
        private System.Windows.Forms.DataGridViewTextBoxColumn w80;
        private System.Windows.Forms.DataGridViewTextBoxColumn w100;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOfAll;
        private System.Windows.Forms.Button button2;
    }
}
