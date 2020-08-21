namespace AddBet
{
    partial class ListBetsUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBetsUI));
            this.tableListDesign = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDateOrder = new System.Windows.Forms.Button();
            this.btnTotalWinLossPA = new System.Windows.Forms.Button();
            this.btnSuccRate = new System.Windows.Forms.Button();
            this.btnHighestAmountBet = new System.Windows.Forms.Button();
            this.btnPopCourse = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.listEnquirerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableListDesign.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEnquirerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableListDesign
            // 
            this.tableListDesign.BackColor = System.Drawing.Color.MintCream;
            this.tableListDesign.ColumnCount = 3;
            this.tableListDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.222222F));
            this.tableListDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.74074F));
            this.tableListDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001853F));
            this.tableListDesign.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableListDesign.Controls.Add(this.rtbDisplay, 1, 1);
            this.tableListDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableListDesign.Location = new System.Drawing.Point(0, 0);
            this.tableListDesign.Name = "tableListDesign";
            this.tableListDesign.RowCount = 3;
            this.tableListDesign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableListDesign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.42514F));
            this.tableListDesign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5841F));
            this.tableListDesign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableListDesign.Size = new System.Drawing.Size(1053, 845);
            this.tableListDesign.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.84052F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.79741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.81466F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.65948F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.81513F));
            this.tableLayoutPanel1.Controls.Add(this.btnDateOrder, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTotalWinLossPA, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSuccRate, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHighestAmountBet, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPopCourse, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWriteFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReadFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(68, 640);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.98507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.01493F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 202);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnDateOrder
            // 
            this.btnDateOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDateOrder.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnDateOrder.FlatAppearance.BorderSize = 2;
            this.btnDateOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateOrder.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDateOrder.Location = new System.Drawing.Point(390, 135);
            this.btnDateOrder.Margin = new System.Windows.Forms.Padding(10);
            this.btnDateOrder.Name = "btnDateOrder";
            this.btnDateOrder.Size = new System.Drawing.Size(120, 39);
            this.btnDateOrder.TabIndex = 17;
            this.btnDateOrder.Text = "Bets in Date Order";
            this.btnDateOrder.UseVisualStyleBackColor = true;
            this.btnDateOrder.Click += new System.EventHandler(this.btnDateOrder_Click);
            // 
            // btnTotalWinLossPA
            // 
            this.btnTotalWinLossPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTotalWinLossPA.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnTotalWinLossPA.FlatAppearance.BorderSize = 2;
            this.btnTotalWinLossPA.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalWinLossPA.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTotalWinLossPA.Location = new System.Drawing.Point(588, 137);
            this.btnTotalWinLossPA.Margin = new System.Windows.Forms.Padding(10);
            this.btnTotalWinLossPA.Name = "btnTotalWinLossPA";
            this.btnTotalWinLossPA.Size = new System.Drawing.Size(146, 35);
            this.btnTotalWinLossPA.TabIndex = 16;
            this.btnTotalWinLossPA.Text = "Win/Loss Totals Per Year";
            this.btnTotalWinLossPA.UseVisualStyleBackColor = true;
            this.btnTotalWinLossPA.Click += new System.EventHandler(this.btnTotalWinLossPA_Click);
            // 
            // btnSuccRate
            // 
            this.btnSuccRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuccRate.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSuccRate.FlatAppearance.BorderSize = 2;
            this.btnSuccRate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSuccRate.Location = new System.Drawing.Point(797, 36);
            this.btnSuccRate.Name = "btnSuccRate";
            this.btnSuccRate.Size = new System.Drawing.Size(95, 35);
            this.btnSuccRate.TabIndex = 15;
            this.btnSuccRate.Text = "Success Rate";
            this.btnSuccRate.UseVisualStyleBackColor = true;
            this.btnSuccRate.Click += new System.EventHandler(this.btnSuccRate_Click);
            // 
            // btnHighestAmountBet
            // 
            this.btnHighestAmountBet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHighestAmountBet.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnHighestAmountBet.FlatAppearance.BorderSize = 2;
            this.btnHighestAmountBet.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighestAmountBet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHighestAmountBet.Location = new System.Drawing.Point(588, 39);
            this.btnHighestAmountBet.Margin = new System.Windows.Forms.Padding(10);
            this.btnHighestAmountBet.Name = "btnHighestAmountBet";
            this.btnHighestAmountBet.Size = new System.Drawing.Size(146, 28);
            this.btnHighestAmountBet.TabIndex = 14;
            this.btnHighestAmountBet.Text = "Get Highest Amounts Bet";
            this.btnHighestAmountBet.UseVisualStyleBackColor = true;
            this.btnHighestAmountBet.Click += new System.EventHandler(this.btnHighestAmountBet_Click);
            // 
            // btnPopCourse
            // 
            this.btnPopCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPopCourse.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPopCourse.FlatAppearance.BorderSize = 2;
            this.btnPopCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopCourse.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPopCourse.Location = new System.Drawing.Point(390, 33);
            this.btnPopCourse.Margin = new System.Windows.Forms.Padding(10);
            this.btnPopCourse.Name = "btnPopCourse";
            this.btnPopCourse.Size = new System.Drawing.Size(120, 41);
            this.btnPopCourse.TabIndex = 13;
            this.btnPopCourse.Text = "Most Popular Course";
            this.btnPopCourse.UseVisualStyleBackColor = true;
            this.btnPopCourse.Click += new System.EventHandler(this.btnPopCourse_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWriteFile.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnWriteFile.FlatAppearance.BorderSize = 2;
            this.btnWriteFile.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFile.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnWriteFile.Location = new System.Drawing.Point(30, 139);
            this.btnWriteFile.Margin = new System.Windows.Forms.Padding(10);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(86, 30);
            this.btnWriteFile.TabIndex = 12;
            this.btnWriteFile.Text = "Write to File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReadFile.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnReadFile.FlatAppearance.BorderSize = 2;
            this.btnReadFile.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReadFile.Location = new System.Drawing.Point(27, 39);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(10);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(93, 28);
            this.btnReadFile.TabIndex = 9;
            this.btnReadFile.Text = "Read from File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBack.Location = new System.Drawing.Point(800, 138);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 32);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(68, 45);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(928, 589);
            this.rtbDisplay.TabIndex = 5;
            this.rtbDisplay.Text = "";
            // 
            // listEnquirerBindingSource
            // 
            this.listEnquirerBindingSource.DataSource = typeof(HorseTipRepository.ListEnquirer);
            // 
            // ListBetsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 845);
            this.Controls.Add(this.tableListDesign);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(859, 715);
            this.Name = "ListBetsUI";
            this.Text = "HotTipsterBets";
            this.tableListDesign.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEnquirerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableListDesign;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnDateOrder;
        private System.Windows.Forms.Button btnTotalWinLossPA;
        private System.Windows.Forms.Button btnSuccRate;
        private System.Windows.Forms.Button btnHighestAmountBet;
        private System.Windows.Forms.Button btnPopCourse;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.BindingSource listEnquirerBindingSource;
    }
}