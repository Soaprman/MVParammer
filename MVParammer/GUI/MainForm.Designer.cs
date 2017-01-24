namespace MVParammer
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
            this.btnOpenMap = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentlyOpen = new System.Windows.Forms.Label();
            this.btnMakeHardcodedEdits = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenMap
            // 
            this.btnOpenMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOpenMap.Location = new System.Drawing.Point(6, 19);
            this.btnOpenMap.Name = "btnOpenMap";
            this.btnOpenMap.Size = new System.Drawing.Size(112, 23);
            this.btnOpenMap.TabIndex = 0;
            this.btnOpenMap.Text = "Open Map...";
            this.btnOpenMap.UseVisualStyleBackColor = true;
            this.btnOpenMap.Click += new System.EventHandler(this.btnOpenMap_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(6, 49);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(112, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Map Folder...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currently open file or folder:";
            // 
            // lblCurrentlyOpen
            // 
            this.lblCurrentlyOpen.Location = new System.Drawing.Point(124, 32);
            this.lblCurrentlyOpen.Name = "lblCurrentlyOpen";
            this.lblCurrentlyOpen.Size = new System.Drawing.Size(338, 23);
            this.lblCurrentlyOpen.TabIndex = 3;
            this.lblCurrentlyOpen.Text = "(Nothing is open right now)";
            // 
            // btnMakeHardcodedEdits
            // 
            this.btnMakeHardcodedEdits.Location = new System.Drawing.Point(6, 19);
            this.btnMakeHardcodedEdits.Name = "btnMakeHardcodedEdits";
            this.btnMakeHardcodedEdits.Size = new System.Drawing.Size(161, 23);
            this.btnMakeHardcodedEdits.TabIndex = 4;
            this.btnMakeHardcodedEdits.Text = "Make hardcoded edits";
            this.btnMakeHardcodedEdits.UseVisualStyleBackColor = true;
            this.btnMakeHardcodedEdits.Click += new System.EventHandler(this.btnMakeHardcodedEdits_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenMap);
            this.groupBox1.Controls.Add(this.btnOpenFolder);
            this.groupBox1.Controls.Add(this.lblCurrentlyOpen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open file(s)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMakeHardcodedEdits);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save file(s)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 222);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MVParammer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMap;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentlyOpen;
        private System.Windows.Forms.Button btnMakeHardcodedEdits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

