
namespace Fnaf99
{
    partial class SettingsForm
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
            this.aes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exeName = new System.Windows.Forms.TextBox();
            this.unrealVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pakPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aes
            // 
            this.aes.BackColor = System.Drawing.Color.Black;
            this.aes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aes.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aes.ForeColor = System.Drawing.Color.DarkRed;
            this.aes.Location = new System.Drawing.Point(138, 12);
            this.aes.Name = "aes";
            this.aes.Size = new System.Drawing.Size(975, 29);
            this.aes.TabIndex = 0;
            this.aes.Text = "AESKey";
            this.aes.TextChanged += new System.EventHandler(this.aes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "AES Key";
            // 
            // exeName
            // 
            this.exeName.BackColor = System.Drawing.Color.Black;
            this.exeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exeName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exeName.ForeColor = System.Drawing.Color.DarkRed;
            this.exeName.Location = new System.Drawing.Point(138, 47);
            this.exeName.Name = "exeName";
            this.exeName.Size = new System.Drawing.Size(975, 29);
            this.exeName.TabIndex = 2;
            this.exeName.Text = "AESKey";
            // 
            // unrealVersion
            // 
            this.unrealVersion.BackColor = System.Drawing.Color.Black;
            this.unrealVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unrealVersion.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unrealVersion.ForeColor = System.Drawing.Color.DarkRed;
            this.unrealVersion.Location = new System.Drawing.Point(171, 82);
            this.unrealVersion.Name = "unrealVersion";
            this.unrealVersion.Size = new System.Drawing.Size(942, 29);
            this.unrealVersion.TabIndex = 3;
            this.unrealVersion.Text = "AESKey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exe Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "UE4 Version";
            // 
            // pakPath
            // 
            this.pakPath.BackColor = System.Drawing.Color.Black;
            this.pakPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pakPath.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pakPath.ForeColor = System.Drawing.Color.DarkRed;
            this.pakPath.Location = new System.Drawing.Point(171, 117);
            this.pakPath.Name = "pakPath";
            this.pakPath.Size = new System.Drawing.Size(942, 29);
            this.pakPath.TabIndex = 6;
            this.pakPath.Text = "AESKey";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Path to pak";
            // 
            // settingBtn
            // 
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.settingBtn.Location = new System.Drawing.Point(938, 404);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(175, 34);
            this.settingBtn.TabIndex = 11;
            this.settingBtn.Text = "Apply";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pakPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unrealVersion);
            this.Controls.Add(this.exeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exeName;
        private System.Windows.Forms.TextBox unrealVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pakPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button settingBtn;
    }
}