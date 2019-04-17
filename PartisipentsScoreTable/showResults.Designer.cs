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
            this.components = new System.ComponentModel.Container();
            this.challengerDBDataSet = new PartisipentsScoreTable.ChallengerDBDataSet();
            this.challengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.challengerTableAdapter = new PartisipentsScoreTable.ChallengerDBDataSetTableAdapters.ChallengerTableAdapter();
            this.tableAdapterManager = new PartisipentsScoreTable.ChallengerDBDataSetTableAdapters.TableAdapterManager();
            this.challengerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // challengerDBDataSet
            // 
            this.challengerDBDataSet.DataSetName = "ChallengerDBDataSet";
            this.challengerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // challengerBindingSource
            // 
            this.challengerBindingSource.DataMember = "Challenger";
            this.challengerBindingSource.DataSource = this.challengerDBDataSet;
            // 
            // challengerTableAdapter
            // 
            this.challengerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChallengerTableAdapter = this.challengerTableAdapter;
            this.tableAdapterManager.UpdateOrder = PartisipentsScoreTable.ChallengerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // challengerDataGridView
            // 
            this.challengerDataGridView.AllowUserToAddRows = false;
            this.challengerDataGridView.AllowUserToDeleteRows = false;
            this.challengerDataGridView.AutoGenerateColumns = false;
            this.challengerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.challengerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.challengerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.challengerDataGridView.DataSource = this.challengerBindingSource;
            this.challengerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.challengerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.challengerDataGridView.Name = "challengerDataGridView";
            this.challengerDataGridView.ReadOnly = true;
            this.challengerDataGridView.Size = new System.Drawing.Size(945, 579);
            this.challengerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "25";
            this.dataGridViewTextBoxColumn3.HeaderText = "25";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "35";
            this.dataGridViewTextBoxColumn4.HeaderText = "35";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "45";
            this.dataGridViewTextBoxColumn5.HeaderText = "45";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "60";
            this.dataGridViewTextBoxColumn6.HeaderText = "60";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "70";
            this.dataGridViewTextBoxColumn7.HeaderText = "70";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "80";
            this.dataGridViewTextBoxColumn8.HeaderText = "80";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "100";
            this.dataGridViewTextBoxColumn9.HeaderText = "100";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // showResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.challengerDataGridView);
            this.Name = "showResults";
            this.Size = new System.Drawing.Size(945, 579);
            this.Load += new System.EventHandler(this.showResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChallengerDBDataSet challengerDBDataSet;
        private System.Windows.Forms.BindingSource challengerBindingSource;
        private ChallengerDBDataSetTableAdapters.ChallengerTableAdapter challengerTableAdapter;
        private ChallengerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView challengerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
