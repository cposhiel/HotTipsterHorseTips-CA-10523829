namespace AddBet
{
    partial class AddBetUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBetUI));
            this.lblHorseName = new System.Windows.Forms.Label();
            this.lblRaceCourse = new System.Windows.Forms.Label();
            this.lblDateOfRace = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.tbHorseName = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbDateofRace = new System.Windows.Forms.TextBox();
            this.lstRaceCourses = new System.Windows.Forms.ListBox();
            this.cbRaceIsWon = new System.Windows.Forms.CheckBox();
            this.lblDetailsRequest = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbOutcome = new System.Windows.Forms.TextBox();
            this.btnAddBet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHorseName
            // 
            this.lblHorseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorseName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHorseName.Location = new System.Drawing.Point(54, 140);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(47, 17);
            this.lblHorseName.TabIndex = 70;
            this.lblHorseName.Text = "Horse:";
            // 
            // lblRaceCourse
            // 
            this.lblRaceCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaceCourse.AutoSize = true;
            this.lblRaceCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceCourse.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblRaceCourse.Location = new System.Drawing.Point(54, 175);
            this.lblRaceCourse.Name = "lblRaceCourse";
            this.lblRaceCourse.Size = new System.Drawing.Size(85, 17);
            this.lblRaceCourse.TabIndex = 71;
            this.lblRaceCourse.Text = "Race Course:";
            // 
            // lblDateOfRace
            // 
            this.lblDateOfRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateOfRace.AutoSize = true;
            this.lblDateOfRace.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfRace.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDateOfRace.Location = new System.Drawing.Point(54, 338);
            this.lblDateOfRace.Name = "lblDateOfRace";
            this.lblDateOfRace.Size = new System.Drawing.Size(87, 17);
            this.lblDateOfRace.TabIndex = 72;
            this.lblDateOfRace.Text = "Date of Race:";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAmount.Location = new System.Drawing.Point(54, 381);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(124, 17);
            this.lblAmount.TabIndex = 73;
            this.lblAmount.Text = "Amount Won/Lost:";
            // 
            // lblOutcome
            // 
            this.lblOutcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblOutcome.Location = new System.Drawing.Point(54, 423);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(99, 17);
            this.lblOutcome.TabIndex = 74;
            this.lblOutcome.Text = "Race Outcome:";
            // 
            // tbHorseName
            // 
            this.tbHorseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHorseName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHorseName.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbHorseName.Location = new System.Drawing.Point(311, 140);
            this.tbHorseName.Name = "tbHorseName";
            this.tbHorseName.Size = new System.Drawing.Size(289, 23);
            this.tbHorseName.TabIndex = 75;
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbAmount.Location = new System.Drawing.Point(311, 381);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(139, 23);
            this.tbAmount.TabIndex = 76;
            // 
            // tbDateofRace
            // 
            this.tbDateofRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDateofRace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateofRace.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbDateofRace.Location = new System.Drawing.Point(311, 338);
            this.tbDateofRace.Name = "tbDateofRace";
            this.tbDateofRace.Size = new System.Drawing.Size(139, 23);
            this.tbDateofRace.TabIndex = 77;
            this.tbDateofRace.Text = "DD/MM/YYYY";
            // 
            // lstRaceCourses
            // 
            this.lstRaceCourses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstRaceCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstRaceCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRaceCourses.ForeColor = System.Drawing.Color.SeaGreen;
            this.lstRaceCourses.FormattingEnabled = true;
            this.lstRaceCourses.ItemHeight = 15;
            this.lstRaceCourses.Location = new System.Drawing.Point(311, 175);
            this.lstRaceCourses.Name = "lstRaceCourses";
            this.lstRaceCourses.Size = new System.Drawing.Size(468, 154);
            this.lstRaceCourses.TabIndex = 78;
            // 
            // cbRaceIsWon
            // 
            this.cbRaceIsWon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRaceIsWon.AutoSize = true;
            this.cbRaceIsWon.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaceIsWon.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbRaceIsWon.Location = new System.Drawing.Point(311, 423);
            this.cbRaceIsWon.Name = "cbRaceIsWon";
            this.cbRaceIsWon.Size = new System.Drawing.Size(185, 17);
            this.cbRaceIsWon.TabIndex = 79;
            this.cbRaceIsWon.Text = "Please tick box if race was won.";
            this.cbRaceIsWon.UseVisualStyleBackColor = true;
            this.cbRaceIsWon.CheckedChanged += new System.EventHandler(this.cbRaceIsWon_CheckedChanged);
            // 
            // lblDetailsRequest
            // 
            this.lblDetailsRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetailsRequest.AutoSize = true;
            this.lblDetailsRequest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsRequest.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDetailsRequest.Location = new System.Drawing.Point(208, 71);
            this.lblDetailsRequest.Name = "lblDetailsRequest";
            this.lblDetailsRequest.Size = new System.Drawing.Size(407, 32);
            this.lblDetailsRequest.TabIndex = 80;
            this.lblDetailsRequest.Text = "Please Enter the Details of the Bet.";
            this.lblDetailsRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSelect.FlatAppearance.BorderSize = 6;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSelect.Location = new System.Drawing.Point(57, 490);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(146, 70);
            this.btnSelect.TabIndex = 81;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.FlatAppearance.BorderSize = 2;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.Location = new System.Drawing.Point(625, 490);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(154, 70);
            this.btnReturn.TabIndex = 82;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbOutcome
            // 
            this.tbOutcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOutcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutcome.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbOutcome.Location = new System.Drawing.Point(625, 423);
            this.tbOutcome.Name = "tbOutcome";
            this.tbOutcome.ReadOnly = true;
            this.tbOutcome.Size = new System.Drawing.Size(76, 23);
            this.tbOutcome.TabIndex = 83;
            this.tbOutcome.Text = "Lost.";
            // 
            // btnAddBet
            // 
            this.btnAddBet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBet.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBet.Enabled = false;
            this.btnAddBet.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAddBet.FlatAppearance.BorderSize = 2;
            this.btnAddBet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddBet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnAddBet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddBet.Location = new System.Drawing.Point(311, 519);
            this.btnAddBet.Name = "btnAddBet";
            this.btnAddBet.Size = new System.Drawing.Size(217, 109);
            this.btnAddBet.TabIndex = 84;
            this.btnAddBet.Text = "Add Bet";
            this.btnAddBet.UseVisualStyleBackColor = false;
            this.btnAddBet.Click += new System.EventHandler(this.btnAddBet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.lblDateOfRace);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblOutcome);
            this.panel1.Controls.Add(this.tbDateofRace);
            this.panel1.Controls.Add(this.cbRaceIsWon);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.tbOutcome);
            this.panel1.Controls.Add(this.btnAddBet);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.lblDetailsRequest);
            this.panel1.Controls.Add(this.lstRaceCourses);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.tbHorseName);
            this.panel1.Controls.Add(this.lblHorseName);
            this.panel1.Controls.Add(this.lblRaceCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 676);
            this.panel1.TabIndex = 85;
            // 
            // AddBetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 676);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(859, 715);
            this.Name = "AddBetUI";
            this.Text = "Add a Bet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHorseName;
        private System.Windows.Forms.Label lblRaceCourse;
        private System.Windows.Forms.Label lblDateOfRace;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.TextBox tbHorseName;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbDateofRace;
        private System.Windows.Forms.ListBox lstRaceCourses;
        private System.Windows.Forms.CheckBox cbRaceIsWon;
        private System.Windows.Forms.Label lblDetailsRequest;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbOutcome;
        private System.Windows.Forms.Button btnAddBet;
        private System.Windows.Forms.Panel panel1;
    }
}

