namespace SDtester
{
    partial class FAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.llGO = new System.Windows.Forms.LinkLabel();
            this.btOk = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.llIcon = new System.Windows.Forms.LinkLabel();
            this.lbTranslation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(146, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(157, 35);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Sd Tester 1.0";
            // 
            // llGO
            // 
            this.llGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llGO.AutoSize = true;
            this.llGO.Location = new System.Drawing.Point(301, 50);
            this.llGO.Name = "llGO";
            this.llGO.Size = new System.Drawing.Size(116, 16);
            this.llGO.TabIndex = 2;
            this.llGO.TabStop = true;
            this.llGO.Text = "By XWolf Override";
            this.llGO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGO_LinkClicked);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(342, 158);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 29);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.Location = new System.Drawing.Point(149, 79);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(268, 72);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.Text = "-";
            // 
            // llIcon
            // 
            this.llIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llIcon.AutoSize = true;
            this.llIcon.Location = new System.Drawing.Point(12, 174);
            this.llIcon.Name = "llIcon";
            this.llIcon.Size = new System.Drawing.Size(156, 16);
            this.llIcon.TabIndex = 5;
            this.llIcon.TabStop = true;
            this.llIcon.Text = "SD Icon by Lukasz Adam";
            this.llIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llIcon_LinkClicked);
            // 
            // lbTranslation
            // 
            this.lbTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(149, 156);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(11, 16);
            this.lbTranslation.TabIndex = 6;
            this.lbTranslation.Text = "-";
            // 
            // FAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 199);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.llIcon);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.llGO);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "-";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.LinkLabel llGO;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.LinkLabel llIcon;
        private System.Windows.Forms.Label lbTranslation;
    }
}