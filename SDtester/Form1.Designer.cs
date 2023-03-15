namespace SDtester
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbDrive = new System.Windows.Forms.Label();
            this.lbHint = new System.Windows.Forms.Label();
            this.cbDrive = new System.Windows.Forms.ComboBox();
            this.btGo = new System.Windows.Forms.Button();
            this.lbProgress = new System.Windows.Forms.Label();
            this.pbTotal = new System.Windows.Forms.ProgressBar();
            this.ppbstatus = new SDtester.DrawPanel();
            this.pinfo = new System.Windows.Forms.Panel();
            this.lbReadSpeedValue = new System.Windows.Forms.Label();
            this.lbReadSpeed = new System.Windows.Forms.Label();
            this.lbWriteSpeedValue = new System.Windows.Forms.Label();
            this.lbWriteSpeed = new System.Windows.Forms.Label();
            this.btAbout = new System.Windows.Forms.Button();
            this.pinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDrive
            // 
            this.lbDrive.AutoSize = true;
            this.lbDrive.Location = new System.Drawing.Point(12, 15);
            this.lbDrive.Name = "lbDrive";
            this.lbDrive.Size = new System.Drawing.Size(11, 16);
            this.lbDrive.TabIndex = 0;
            this.lbDrive.Text = "-";
            // 
            // lbHint
            // 
            this.lbHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbHint.Location = new System.Drawing.Point(9, 46);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(288, 89);
            this.lbHint.TabIndex = 1;
            this.lbHint.Text = "-";
            this.lbHint.Resize += new System.EventHandler(this.lbHint_Resize);
            // 
            // cbDrive
            // 
            this.cbDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrive.FormattingEnabled = true;
            this.cbDrive.Location = new System.Drawing.Point(122, 12);
            this.cbDrive.Name = "cbDrive";
            this.cbDrive.Size = new System.Drawing.Size(98, 24);
            this.cbDrive.TabIndex = 2;
            // 
            // btGo
            // 
            this.btGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGo.Location = new System.Drawing.Point(378, 124);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(87, 50);
            this.btGo.TabIndex = 4;
            this.btGo.Text = "-";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // lbProgress
            // 
            this.lbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(12, 105);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(11, 16);
            this.lbProgress.TabIndex = 5;
            this.lbProgress.Text = "-";
            // 
            // pbTotal
            // 
            this.pbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTotal.Location = new System.Drawing.Point(12, 163);
            this.pbTotal.Name = "pbTotal";
            this.pbTotal.Size = new System.Drawing.Size(360, 10);
            this.pbTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTotal.TabIndex = 6;
            // 
            // ppbstatus
            // 
            this.ppbstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppbstatus.Location = new System.Drawing.Point(12, 125);
            this.ppbstatus.Name = "ppbstatus";
            this.ppbstatus.Size = new System.Drawing.Size(360, 31);
            this.ppbstatus.TabIndex = 7;
            this.ppbstatus.Paint += new System.Windows.Forms.PaintEventHandler(this.ppbstatus_Paint);
            // 
            // pinfo
            // 
            this.pinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pinfo.Controls.Add(this.lbReadSpeedValue);
            this.pinfo.Controls.Add(this.lbReadSpeed);
            this.pinfo.Controls.Add(this.lbWriteSpeedValue);
            this.pinfo.Controls.Add(this.lbWriteSpeed);
            this.pinfo.Location = new System.Drawing.Point(303, 12);
            this.pinfo.Name = "pinfo";
            this.pinfo.Size = new System.Drawing.Size(162, 92);
            this.pinfo.TabIndex = 8;
            // 
            // lbReadSpeedValue
            // 
            this.lbReadSpeedValue.AutoSize = true;
            this.lbReadSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadSpeedValue.Location = new System.Drawing.Point(3, 64);
            this.lbReadSpeedValue.Name = "lbReadSpeedValue";
            this.lbReadSpeedValue.Size = new System.Drawing.Size(12, 16);
            this.lbReadSpeedValue.TabIndex = 3;
            this.lbReadSpeedValue.Text = "-";
            // 
            // lbReadSpeed
            // 
            this.lbReadSpeed.AutoSize = true;
            this.lbReadSpeed.Location = new System.Drawing.Point(3, 44);
            this.lbReadSpeed.Name = "lbReadSpeed";
            this.lbReadSpeed.Size = new System.Drawing.Size(11, 16);
            this.lbReadSpeed.TabIndex = 2;
            this.lbReadSpeed.Text = "-";
            // 
            // lbWriteSpeedValue
            // 
            this.lbWriteSpeedValue.AutoSize = true;
            this.lbWriteSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteSpeedValue.Location = new System.Drawing.Point(3, 22);
            this.lbWriteSpeedValue.Name = "lbWriteSpeedValue";
            this.lbWriteSpeedValue.Size = new System.Drawing.Size(12, 16);
            this.lbWriteSpeedValue.TabIndex = 1;
            this.lbWriteSpeedValue.Text = "-";
            // 
            // lbWriteSpeed
            // 
            this.lbWriteSpeed.AutoSize = true;
            this.lbWriteSpeed.Location = new System.Drawing.Point(3, 2);
            this.lbWriteSpeed.Name = "lbWriteSpeed";
            this.lbWriteSpeed.Size = new System.Drawing.Size(11, 16);
            this.lbWriteSpeed.TabIndex = 0;
            this.lbWriteSpeed.Text = "-";
            // 
            // btAbout
            // 
            this.btAbout.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbout.Location = new System.Drawing.Point(438, 102);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(26, 22);
            this.btAbout.TabIndex = 9;
            this.btAbout.Text = "?";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 186);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.pinfo);
            this.Controls.Add(this.ppbstatus);
            this.Controls.Add(this.pbTotal);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.cbDrive);
            this.Controls.Add(this.lbHint);
            this.Controls.Add(this.lbDrive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sd Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pinfo.ResumeLayout(false);
            this.pinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDrive;
        private System.Windows.Forms.Label lbHint;
        private System.Windows.Forms.ComboBox cbDrive;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.ProgressBar pbTotal;
        private DrawPanel ppbstatus;
        private System.Windows.Forms.Panel pinfo;
        private System.Windows.Forms.Label lbWriteSpeed;
        private System.Windows.Forms.Label lbWriteSpeedValue;
        private System.Windows.Forms.Label lbReadSpeedValue;
        private System.Windows.Forms.Label lbReadSpeed;
        private System.Windows.Forms.Button btAbout;
    }
}

