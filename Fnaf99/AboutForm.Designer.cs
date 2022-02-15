
namespace Fnaf99
{
    partial class AboutForm
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
            this.donateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.youtubeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // donateBtn
            // 
            this.donateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateBtn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.donateBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.donateBtn.Location = new System.Drawing.Point(480, 184);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(178, 40);
            this.donateBtn.TabIndex = 0;
            this.donateBtn.Text = "Donate";
            this.donateBtn.UseVisualStyleBackColor = true;
            this.donateBtn.Click += new System.EventHandler(this.donateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "udump 1.0\r\nmade by 1987kostya\r\nspecial release for TechnicalFNaF discord server\r\n" +
    "";
            // 
            // youtubeBtn
            // 
            this.youtubeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtubeBtn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.youtubeBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.youtubeBtn.Location = new System.Drawing.Point(296, 184);
            this.youtubeBtn.Name = "youtubeBtn";
            this.youtubeBtn.Size = new System.Drawing.Size(178, 40);
            this.youtubeBtn.TabIndex = 2;
            this.youtubeBtn.Text = "My Youtube";
            this.youtubeBtn.UseVisualStyleBackColor = true;
            this.youtubeBtn.Click += new System.EventHandler(this.youtubeBtn_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(670, 236);
            this.Controls.Add(this.youtubeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.donateBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button donateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button youtubeBtn;
    }
}