
namespace Fnaf99
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Levels = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reconnectToProc = new System.Windows.Forms.Button();
            this.isConnected = new System.Windows.Forms.Label();
            this.dumpButton = new System.Windows.Forms.Button();
            this.mapsToDump = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.actortodumplabel = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.umodelInsts = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "udump 1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Levels
            // 
            this.Levels.BackColor = System.Drawing.Color.Black;
            this.Levels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Levels.ForeColor = System.Drawing.Color.DarkRed;
            this.Levels.FormattingEnabled = true;
            this.Levels.Location = new System.Drawing.Point(17, 143);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(175, 403);
            this.Levels.TabIndex = 1;
            this.Levels.SelectedIndexChanged += new System.EventHandler(this.Levels_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(200, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maps loaded:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reconnectToProc
            // 
            this.reconnectToProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reconnectToProc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reconnectToProc.ForeColor = System.Drawing.Color.DarkRed;
            this.reconnectToProc.Location = new System.Drawing.Point(577, 12);
            this.reconnectToProc.Name = "reconnectToProc";
            this.reconnectToProc.Size = new System.Drawing.Size(195, 34);
            this.reconnectToProc.TabIndex = 3;
            this.reconnectToProc.Text = "Connect to game";
            this.reconnectToProc.UseVisualStyleBackColor = true;
            this.reconnectToProc.Click += new System.EventHandler(this.reconnectToProc_Click);
            // 
            // isConnected
            // 
            this.isConnected.AutoSize = true;
            this.isConnected.BackColor = System.Drawing.Color.Black;
            this.isConnected.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isConnected.ForeColor = System.Drawing.Color.DarkRed;
            this.isConnected.Location = new System.Drawing.Point(375, 14);
            this.isConnected.Name = "isConnected";
            this.isConnected.Size = new System.Drawing.Size(194, 27);
            this.isConnected.TabIndex = 4;
            this.isConnected.Text = "Not connected";
            // 
            // dumpButton
            // 
            this.dumpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dumpButton.ForeColor = System.Drawing.Color.DarkRed;
            this.dumpButton.Location = new System.Drawing.Point(577, 512);
            this.dumpButton.Name = "dumpButton";
            this.dumpButton.Size = new System.Drawing.Size(195, 34);
            this.dumpButton.TabIndex = 5;
            this.dumpButton.Text = "Dump selected";
            this.dumpButton.UseVisualStyleBackColor = true;
            this.dumpButton.Click += new System.EventHandler(this.dumpButton_Click);
            // 
            // mapsToDump
            // 
            this.mapsToDump.BackColor = System.Drawing.Color.Black;
            this.mapsToDump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mapsToDump.ForeColor = System.Drawing.Color.DarkRed;
            this.mapsToDump.FormattingEnabled = true;
            this.mapsToDump.Location = new System.Drawing.Point(198, 142);
            this.mapsToDump.Name = "mapsToDump";
            this.mapsToDump.Size = new System.Drawing.Size(175, 364);
            this.mapsToDump.TabIndex = 6;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.clearBtn.Location = new System.Drawing.Point(198, 512);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(175, 34);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maps to dump:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actortodumplabel
            // 
            this.actortodumplabel.AutoSize = true;
            this.actortodumplabel.BackColor = System.Drawing.Color.Black;
            this.actortodumplabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actortodumplabel.ForeColor = System.Drawing.Color.DarkRed;
            this.actortodumplabel.Location = new System.Drawing.Point(572, 483);
            this.actortodumplabel.Name = "actortodumplabel";
            this.actortodumplabel.Size = new System.Drawing.Size(178, 18);
            this.actortodumplabel.TabIndex = 9;
            this.actortodumplabel.Text = "Meshes to dump: 0";
            this.actortodumplabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingBtn
            // 
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.settingBtn.Location = new System.Drawing.Point(379, 512);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(175, 34);
            this.settingBtn.TabIndex = 10;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // umodelInsts
            // 
            this.umodelInsts.AutoSize = true;
            this.umodelInsts.BackColor = System.Drawing.Color.Black;
            this.umodelInsts.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umodelInsts.ForeColor = System.Drawing.Color.DarkRed;
            this.umodelInsts.Location = new System.Drawing.Point(572, 456);
            this.umodelInsts.Name = "umodelInsts";
            this.umodelInsts.Size = new System.Drawing.Size(198, 18);
            this.umodelInsts.TabIndex = 11;
            this.umodelInsts.Text = "UModel Instances: 0";
            this.umodelInsts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aboutBtn
            // 
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.aboutBtn.Location = new System.Drawing.Point(12, 51);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(78, 32);
            this.aboutBtn.TabIndex = 12;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.umodelInsts);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.actortodumplabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.mapsToDump);
            this.Controls.Add(this.dumpButton);
            this.Controls.Add(this.isConnected);
            this.Controls.Add(this.reconnectToProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Levels);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Levels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reconnectToProc;
        private System.Windows.Forms.Label isConnected;
        private System.Windows.Forms.Button dumpButton;
        private System.Windows.Forms.ListBox mapsToDump;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label actortodumplabel;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Label umodelInsts;
        private System.Windows.Forms.Button aboutBtn;
    }
}