namespace currency_converter
{
    partial class currencyconvert
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
            this.btnconverter = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnconverter
            // 
            this.btnconverter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnconverter.BackColor = System.Drawing.Color.Teal;
            this.btnconverter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconverter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconverter.Location = new System.Drawing.Point(12, 12);
            this.btnconverter.Name = "btnconverter";
            this.btnconverter.Size = new System.Drawing.Size(1274, 43);
            this.btnconverter.TabIndex = 0;
            this.btnconverter.Text = "Learn IELTS Online";
            this.btnconverter.UseVisualStyleBackColor = false;
            this.btnconverter.Click += new System.EventHandler(this.btnconverter_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowser1.Location = new System.Drawing.Point(12, 61);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1274, 548);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // currencyconvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 621);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnconverter);
            this.HelpButton = true;
            this.Name = "currencyconvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IELTS";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconverter;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

