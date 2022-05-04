namespace SiteAnalyzer
{
    partial class SiteAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiteAnalyzer));
            this.urlInput = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlInput
            // 
            this.urlInput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlInput.Location = new System.Drawing.Point(61, 15);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(640, 30);
            this.urlInput.TabIndex = 0;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(12, 18);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(43, 23);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.goButton.ForeColor = System.Drawing.Color.White;
            this.goButton.Location = new System.Drawing.Point(707, 15);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(81, 31);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // SiteAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiteAnalyzer";
            this.Text = "Site Analyzer";
            this.Load += new System.EventHandler(this.siteAnalyzerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button goButton;
    }
}

