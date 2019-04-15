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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personNumber,
            this.personName,
            this.weight,
            this.weightSum});
            this.dataGridView1.Location = new System.Drawing.Point(134, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // personNumber
            // 
            this.personNumber.HeaderText = "№";
            this.personNumber.Name = "personNumber";
            // 
            // personName
            // 
            this.personName.HeaderText = "Имя участника";
            this.personName.Name = "personName";
            // 
            // weight
            // 
            this.weight.HeaderText = "Вес";
            this.weight.Name = "weight";
            // 
            // weightSum
            // 
            this.weightSum.HeaderText = "Сумма";
            this.weightSum.Name = "weightSum";
            // 
            // showResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "showResults";
            this.Size = new System.Drawing.Size(945, 579);
            this.Load += new System.EventHandler(this.showResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightSum;
    }
}
