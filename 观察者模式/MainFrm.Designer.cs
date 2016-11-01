namespace 观察者模式
{
    partial class MainFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoBtnBlue = new System.Windows.Forms.RadioButton();
            this.RdoBtnGreen = new System.Windows.Forms.RadioButton();
            this.RdoBtnRed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoBtnBlue);
            this.groupBox1.Controls.Add(this.RdoBtnGreen);
            this.groupBox1.Controls.Add(this.RdoBtnRed);
            this.groupBox1.Location = new System.Drawing.Point(75, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "颜色选择";
            // 
            // RdoBtnBlue
            // 
            this.RdoBtnBlue.AutoSize = true;
            this.RdoBtnBlue.ForeColor = System.Drawing.Color.Blue;
            this.RdoBtnBlue.Location = new System.Drawing.Point(36, 128);
            this.RdoBtnBlue.Name = "RdoBtnBlue";
            this.RdoBtnBlue.Size = new System.Drawing.Size(69, 22);
            this.RdoBtnBlue.TabIndex = 2;
            this.RdoBtnBlue.TabStop = true;
            this.RdoBtnBlue.Text = "Blue";
            this.RdoBtnBlue.UseVisualStyleBackColor = true;
            // 
            // RdoBtnGreen
            // 
            this.RdoBtnGreen.AutoSize = true;
            this.RdoBtnGreen.ForeColor = System.Drawing.Color.Lime;
            this.RdoBtnGreen.Location = new System.Drawing.Point(36, 87);
            this.RdoBtnGreen.Name = "RdoBtnGreen";
            this.RdoBtnGreen.Size = new System.Drawing.Size(78, 22);
            this.RdoBtnGreen.TabIndex = 1;
            this.RdoBtnGreen.TabStop = true;
            this.RdoBtnGreen.Text = "Green";
            this.RdoBtnGreen.UseVisualStyleBackColor = true;
            // 
            // RdoBtnRed
            // 
            this.RdoBtnRed.AutoSize = true;
            this.RdoBtnRed.ForeColor = System.Drawing.Color.Red;
            this.RdoBtnRed.Location = new System.Drawing.Point(36, 47);
            this.RdoBtnRed.Name = "RdoBtnRed";
            this.RdoBtnRed.Size = new System.Drawing.Size(60, 22);
            this.RdoBtnRed.TabIndex = 0;
            this.RdoBtnRed.TabStop = true;
            this.RdoBtnRed.Text = "Red";
            this.RdoBtnRed.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 346);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrm";
            this.Text = "主窗口";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoBtnBlue;
        private System.Windows.Forms.RadioButton RdoBtnGreen;
        private System.Windows.Forms.RadioButton RdoBtnRed;
    }
}