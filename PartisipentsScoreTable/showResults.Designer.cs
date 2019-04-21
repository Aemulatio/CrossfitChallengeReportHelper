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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // challengerDataGridView
            // 
            this.challengerDataGridView.AllowUserToAddRows = false;
            this.challengerDataGridView.AllowUserToDeleteRows = false;
            this.challengerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.challengerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.challengerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.challengerDataGridView.Location = new System.Drawing.Point(0, 30);
            this.challengerDataGridView.Name = "challengerDataGridView";
            this.challengerDataGridView.ReadOnly = true;
            this.challengerDataGridView.Size = new System.Drawing.Size(945, 549);
            this.challengerDataGridView.TabIndex = 1;
            this.challengerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.challengerDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(945, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
