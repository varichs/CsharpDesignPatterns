namespace 观察者模式
{
    partial class TextFrm
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
            this.IsColors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IsColors
            // 
            this.IsColors.FormattingEnabled = true;
            this.IsColors.ItemHeight = 18;
            this.IsColors.Location = new System.Drawing.Point(72, 61);
            this.IsColors.Name = "IsColors";
            this.IsColors.Size = new System.Drawing.Size(307, 202);
            this.IsColors.TabIndex = 0;
            // 
            // TextFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 349);
            this.Controls.Add(this.IsColors);
            this.Name = "TextFrm";
            this.Text = "TextFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox IsColors;
    }
}