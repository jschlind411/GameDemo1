namespace AMSWindowApp
{
    partial class Form1
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
            this.btnOfficers = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnQuests = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.txbPlayName = new System.Windows.Forms.TextBox();
            this.picbxPlayerAvatar = new System.Windows.Forms.PictureBox();
            this.btnTroops = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOfficers
            // 
            this.btnOfficers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOfficers.Location = new System.Drawing.Point(60, 381);
            this.btnOfficers.Name = "btnOfficers";
            this.btnOfficers.Size = new System.Drawing.Size(126, 45);
            this.btnOfficers.TabIndex = 1;
            this.btnOfficers.Text = "Officers";
            this.btnOfficers.UseVisualStyleBackColor = true;
            this.btnOfficers.Click += new System.EventHandler(this.btnOfficers_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInventory.Location = new System.Drawing.Point(226, 381);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(126, 45);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnQuests
            // 
            this.btnQuests.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuests.Location = new System.Drawing.Point(395, 381);
            this.btnQuests.Name = "btnQuests";
            this.btnQuests.Size = new System.Drawing.Size(126, 45);
            this.btnQuests.TabIndex = 3;
            this.btnQuests.Text = "Quests";
            this.btnQuests.UseVisualStyleBackColor = true;
            this.btnQuests.Click += new System.EventHandler(this.btnQuests_Click);
            // 
            // btnMail
            // 
            this.btnMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMail.Location = new System.Drawing.Point(561, 381);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(126, 45);
            this.btnMail.TabIndex = 4;
            this.btnMail.Text = "Mail";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // txbPlayName
            // 
            this.txbPlayName.Location = new System.Drawing.Point(12, 125);
            this.txbPlayName.Name = "txbPlayName";
            this.txbPlayName.ReadOnly = true;
            this.txbPlayName.Size = new System.Drawing.Size(146, 20);
            this.txbPlayName.TabIndex = 5;
            this.txbPlayName.Text = "sarge7602";
            // 
            // picbxPlayerAvatar
            // 
            this.picbxPlayerAvatar.Location = new System.Drawing.Point(12, 12);
            this.picbxPlayerAvatar.Name = "picbxPlayerAvatar";
            this.picbxPlayerAvatar.Size = new System.Drawing.Size(146, 107);
            this.picbxPlayerAvatar.TabIndex = 6;
            this.picbxPlayerAvatar.TabStop = false;
            // 
            // btnTroops
            // 
            this.btnTroops.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTroops.Location = new System.Drawing.Point(254, 12);
            this.btnTroops.Name = "btnTroops";
            this.btnTroops.Size = new System.Drawing.Size(298, 23);
            this.btnTroops.TabIndex = 7;
            this.btnTroops.Text = "troops";
            this.btnTroops.UseVisualStyleBackColor = true;
            this.btnTroops.Click += new System.EventHandler(this.btnTroops_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 500;
            this.updateTimer.Tick += new System.EventHandler(this.update_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroops);
            this.Controls.Add(this.picbxPlayerAvatar);
            this.Controls.Add(this.txbPlayName);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnQuests);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOfficers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOfficers;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnQuests;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.TextBox txbPlayName;
        private System.Windows.Forms.PictureBox picbxPlayerAvatar;
        private System.Windows.Forms.Button btnTroops;
        private System.Windows.Forms.Timer updateTimer;
    }
}

