namespace PartisipentsScoreTable
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.showResults = new System.Windows.Forms.Button();
            this.addResultBtn = new System.Windows.Forms.Button();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.createDocBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homePage1 = new PartisipentsScoreTable.homePage();
            this.showResults1 = new PartisipentsScoreTable.showResults();
            this.addResultPage1 = new PartisipentsScoreTable.addResultPage();
            this.addPersonPage1 = new PartisipentsScoreTable.addPersonPage();
            this.filePage1 = new PartisipentsScoreTable.filePage();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Silver;
            this.panelHeader.Controls.Add(this.minimizeBtn);
            this.panelHeader.Controls.Add(this.closeBtn);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1170, 47);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Silver;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBtn.Location = new System.Drawing.Point(1058, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(47, 30);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Silver;
            this.closeBtn.Location = new System.Drawing.Point(1111, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(47, 30);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Controls.Add(this.showResults);
            this.panel2.Controls.Add(this.addResultBtn);
            this.panel2.Controls.Add(this.addPersonBtn);
            this.panel2.Controls.Add(this.createDocBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 579);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "© Степан Свечников";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(13)))), ((int)(((byte)(61)))));
            this.sidePanel.Location = new System.Drawing.Point(7, 46);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(19, 59);
            this.sidePanel.TabIndex = 2;
            // 
            // showResults
            // 
            this.showResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.showResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showResults.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResults.ForeColor = System.Drawing.Color.Black;
            this.showResults.Location = new System.Drawing.Point(25, 382);
            this.showResults.Name = "showResults";
            this.showResults.Size = new System.Drawing.Size(193, 59);
            this.showResults.TabIndex = 0;
            this.showResults.Text = "Show Results";
            this.showResults.UseVisualStyleBackColor = false;
            this.showResults.Click += new System.EventHandler(this.showResults_Click);
            // 
            // addResultBtn
            // 
            this.addResultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.addResultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResultBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResultBtn.ForeColor = System.Drawing.Color.Black;
            this.addResultBtn.Location = new System.Drawing.Point(25, 298);
            this.addResultBtn.Name = "addResultBtn";
            this.addResultBtn.Size = new System.Drawing.Size(193, 59);
            this.addResultBtn.TabIndex = 0;
            this.addResultBtn.Text = "Add Result";
            this.addResultBtn.UseVisualStyleBackColor = false;
            this.addResultBtn.Click += new System.EventHandler(this.addResultBtn_Click);
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.addPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersonBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonBtn.ForeColor = System.Drawing.Color.Black;
            this.addPersonBtn.Location = new System.Drawing.Point(25, 214);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(193, 59);
            this.addPersonBtn.TabIndex = 0;
            this.addPersonBtn.Text = "Add Person";
            this.addPersonBtn.UseVisualStyleBackColor = false;
            this.addPersonBtn.Click += new System.EventHandler(this.addPersonBtn_Click);
            // 
            // createDocBtn
            // 
            this.createDocBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.createDocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createDocBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDocBtn.ForeColor = System.Drawing.Color.Black;
            this.createDocBtn.Location = new System.Drawing.Point(25, 130);
            this.createDocBtn.Name = "createDocBtn";
            this.createDocBtn.Size = new System.Drawing.Size(193, 59);
            this.createDocBtn.TabIndex = 0;
            this.createDocBtn.Text = "File";
            this.createDocBtn.UseVisualStyleBackColor = false;
            this.createDocBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.Location = new System.Drawing.Point(26, 46);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(193, 59);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homePage1);
            this.panel1.Controls.Add(this.showResults1);
            this.panel1.Controls.Add(this.addResultPage1);
            this.panel1.Controls.Add(this.addPersonPage1);
            this.panel1.Controls.Add(this.filePage1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(225, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 579);
            this.panel1.TabIndex = 2;
            // 
            // homePage1
            // 
            this.homePage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage1.BackgroundImage")));
            this.homePage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePage1.Location = new System.Drawing.Point(0, 0);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(945, 579);
            this.homePage1.TabIndex = 0;
            // 
            // showResults1
            // 
            this.showResults1.Location = new System.Drawing.Point(0, 0);
            this.showResults1.Name = "showResults1";
            this.showResults1.Size = new System.Drawing.Size(945, 579);
            this.showResults1.TabIndex = 4;
            // 
            // addResultPage1
            // 
            this.addResultPage1.Location = new System.Drawing.Point(0, 0);
            this.addResultPage1.Name = "addResultPage1";
            this.addResultPage1.Size = new System.Drawing.Size(945, 579);
            this.addResultPage1.TabIndex = 3;
            // 
            // addPersonPage1
            // 
            this.addPersonPage1.Location = new System.Drawing.Point(0, 0);
            this.addPersonPage1.Name = "addPersonPage1";
            this.addPersonPage1.Size = new System.Drawing.Size(945, 579);
            this.addPersonPage1.TabIndex = 2;
            // 
            // filePage1
            // 
            this.filePage1.Location = new System.Drawing.Point(0, 0);
            this.filePage1.Name = "filePage1";
            this.filePage1.Size = new System.Drawing.Size(945, 579);
            this.filePage1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button addResultBtn;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.Button createDocBtn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private homePage homePage1;
        private filePage filePage1;
        private System.Windows.Forms.Button showResults;
        private addPersonPage addPersonPage1;
        private addResultPage addResultPage1;
        private showResults showResults1;
    }
}

