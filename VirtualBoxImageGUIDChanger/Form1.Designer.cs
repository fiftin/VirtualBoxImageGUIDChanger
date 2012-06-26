namespace VirtualBoxImageGUIDChanger
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldGuid = new System.Windows.Forms.TextBox();
            this.txtNewGuid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старый GUID";
            // 
            // txtOldGuid
            // 
            this.txtOldGuid.Location = new System.Drawing.Point(91, 63);
            this.txtOldGuid.Name = "txtOldGuid";
            this.txtOldGuid.ReadOnly = true;
            this.txtOldGuid.Size = new System.Drawing.Size(187, 20);
            this.txtOldGuid.TabIndex = 1;
            // 
            // txtNewGuid
            // 
            this.txtNewGuid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewGuid.Location = new System.Drawing.Point(91, 95);
            this.txtNewGuid.Name = "txtNewGuid";
            this.txtNewGuid.Size = new System.Drawing.Size(187, 20);
            this.txtNewGuid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новый GUID";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(203, 136);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "&Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(302, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "&Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(13, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(283, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(284, 92);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(93, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Генерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 171);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtNewGuid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldGuid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VirtualBoxImageGuidChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldGuid;
        private System.Windows.Forms.TextBox txtNewGuid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnGenerate;
    }
}

