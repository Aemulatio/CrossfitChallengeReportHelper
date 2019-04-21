namespace PartisipentsScoreTable
{
    partial class addResultPage
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
            this.challengerNumberCB = new System.Windows.Forms.ComboBox();
            this.challengerNameCB = new System.Windows.Forms.ComboBox();
            this.weightsBox = new System.Windows.Forms.ComboBox();
            this.repeatsBox = new System.Windows.Forms.TextBox();
            this.challengerNumberLbl = new System.Windows.Forms.Label();
            this.challengerNameLbl = new System.Windows.Forms.Label();
            this.challengerWeightLbl = new System.Windows.Forms.Label();
            this.challengerRepeatsLbl = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // challengerNumberCB
            // 
            this.challengerNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.challengerNumberCB.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengerNumberCB.FormatString = "N0";
            this.challengerNumberCB.FormattingEnabled = true;
            this.challengerNumberCB.Location = new System.Drawing.Point(181, 105);
            this.challengerNumberCB.Name = "challengerNumberCB";
            this.challengerNumberCB.Size = new System.Drawing.Size(107, 37);
            this.challengerNumberCB.TabIndex = 0;
            this.challengerNumberCB.SelectedIndexChanged += new System.EventHandler(this.challengerNumberCB_SelectedIndexChanged);
            // 
            // challengerNameCB
            // 
            this.challengerNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.challengerNameCB.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengerNameCB.FormattingEnabled = true;
            this.challengerNameCB.Location = new System.Drawing.Point(294, 105);
            this.challengerNameCB.Name = "challengerNameCB";
            this.challengerNameCB.Size = new System.Drawing.Size(241, 37);
            this.challengerNameCB.TabIndex = 0;
            this.challengerNameCB.SelectedIndexChanged += new System.EventHandler(this.challengerNameCB_SelectedIndexChanged);
            // 
            // weightsBox
            // 
            this.weightsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightsBox.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightsBox.FormattingEnabled = true;
            this.weightsBox.Items.AddRange(new object[] {
            "25",
            "35",
            "45",
            "60",
            "70",
            "80",
            "100"});
            this.weightsBox.Location = new System.Drawing.Point(634, 105);
            this.weightsBox.Name = "weightsBox";
            this.weightsBox.Size = new System.Drawing.Size(107, 37);
            this.weightsBox.TabIndex = 0;
            this.weightsBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // repeatsBox
            // 
            this.repeatsBox.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatsBox.Location = new System.Drawing.Point(747, 106);
            this.repeatsBox.Name = "repeatsBox";
            this.repeatsBox.Size = new System.Drawing.Size(112, 36);
            this.repeatsBox.TabIndex = 1;
            this.repeatsBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // challengerNumberLbl
            // 
            this.challengerNumberLbl.AutoSize = true;
            this.challengerNumberLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengerNumberLbl.Location = new System.Drawing.Point(181, 254);
            this.challengerNumberLbl.Name = "challengerNumberLbl";
            this.challengerNumberLbl.Size = new System.Drawing.Size(26, 29);
            this.challengerNumberLbl.TabIndex = 2;
            this.challengerNumberLbl.Text = "#";
            // 
            // challengerNameLbl
            // 
            this.challengerNameLbl.AutoSize = true;
            this.challengerNameLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengerNameLbl.Location = new System.Drawing.Point(289, 254);
            this.challengerNameLbl.Name = "challengerNameLbl";
            this.challengerNameLbl.Size = new System.Drawing.Size(81, 29);
            this.challengerNameLbl.TabIndex = 2;
            this.challengerNameLbl.Text = "Name";
            // 
            // challengerWeightLbl
            // 
            this.challengerWeightLbl.AutoSize = true;
            this.challengerWeightLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengerWeightLbl.Location = new System.Drawing.Point(629, 254);
            this.challengerWeightLbl.Name = "challengerWeightLbl";
            this.challengerWeightLbl.Size = new System.Drawing.Size(116, 29);
            this.challengerWeightLbl.TabIndex = 2;
            this.challengerWeightLbl.Text = "CWeight";
            // 
            // challengerRepeatsLbl
            // 
            this.challengerRepeatsLbl.AutoSize = true;
            this.challengerRepeatsLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengerRepeatsLbl.Location = new System.Drawing.Point(742, 254);
            this.challengerRepeatsLbl.Name = "challengerRepeatsLbl";
            this.challengerRepeatsLbl.Size = new System.Drawing.Size(116, 29);
            this.challengerRepeatsLbl.TabIndex = 2;
            this.challengerRepeatsLbl.Text = "CWeight";
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(344, 410);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(277, 71);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // addResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.challengerRepeatsLbl);
            this.Controls.Add(this.challengerWeightLbl);
            this.Controls.Add(this.challengerNameLbl);
            this.Controls.Add(this.challengerNumberLbl);
            this.Controls.Add(this.repeatsBox);
            this.Controls.Add(this.challengerNameCB);
            this.Controls.Add(this.weightsBox);
            this.Controls.Add(this.challengerNumberCB);
            this.Name = "addResultPage";
            this.Size = new System.Drawing.Size(945, 579);
            this.Load += new System.EventHandler(this.addResultPage_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox challengerNumberCB;
        private System.Windows.Forms.ComboBox challengerNameCB;
        private System.Windows.Forms.ComboBox weightsBox;
        private System.Windows.Forms.TextBox repeatsBox;
        private System.Windows.Forms.Label challengerNumberLbl;
        private System.Windows.Forms.Label challengerNameLbl;
        private System.Windows.Forms.Label challengerWeightLbl;
        private System.Windows.Forms.Label challengerRepeatsLbl;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentStatus;
    }
}
