namespace AddBet
{
    partial class HotTipsterMainMenuUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotTipsterMainMenuUI));
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnListBets = new System.Windows.Forms.Button();
            this.btnCreateBet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMainMenu.BackgroundImage")));
            this.pnlMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMainMenu.Controls.Add(this.btnClose);
            this.pnlMainMenu.Controls.Add(this.btnListBets);
            this.pnlMainMenu.Controls.Add(this.btnCreateBet);
            this.pnlMainMenu.Controls.Add(this.label1);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.MinimumSize = new System.Drawing.Size(859, 715);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(859, 715);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(649, 552);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 49);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnListBets
            // 
            this.btnListBets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListBets.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnListBets.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBets.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnListBets.Location = new System.Drawing.Point(253, 552);
            this.btnListBets.Name = "btnListBets";
            this.btnListBets.Size = new System.Drawing.Size(120, 49);
            this.btnListBets.TabIndex = 2;
            this.btnListBets.Text = "View Bet History";
            this.btnListBets.UseVisualStyleBackColor = true;
            this.btnListBets.Click += new System.EventHandler(this.btnListBets_Click);
            // 
            // btnCreateBet
            // 
            this.btnCreateBet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateBet.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCreateBet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCreateBet.Location = new System.Drawing.Point(73, 552);
            this.btnCreateBet.Name = "btnCreateBet";
            this.btnCreateBet.Size = new System.Drawing.Size(116, 49);
            this.btnCreateBet.TabIndex = 1;
            this.btnCreateBet.Text = "Create a Bet";
            this.btnCreateBet.UseVisualStyleBackColor = true;
            this.btnCreateBet.Click += new System.EventHandler(this.btnCreateBet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(247, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HotTipster Horse Betting";
            // 
            // HotTipsterMainMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 676);
            this.Controls.Add(this.pnlMainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(859, 715);
            this.Name = "HotTipsterMainMenuUI";
            this.Text = "HotTipsterMainMenuUI";
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnListBets;
        private System.Windows.Forms.Button btnCreateBet;
        private System.Windows.Forms.Label label1;
    }
}