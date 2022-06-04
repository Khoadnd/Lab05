using System.Runtime.InteropServices;

namespace Bai03
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNewMail = new System.Windows.Forms.Button();
            this.userControl2 = new Bai03.ucView();
            this.userControl1 = new Bai03.ucList();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userControl1);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewMail);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1209, 538);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNewMail
            // 
            this.btnNewMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewMail.Location = new System.Drawing.Point(0, 0);
            this.btnNewMail.Name = "btnNewMail";
            this.btnNewMail.Size = new System.Drawing.Size(155, 23);
            this.btnNewMail.TabIndex = 1;
            this.btnNewMail.Text = "New mail";
            this.btnNewMail.UseVisualStyleBackColor = true;
            this.btnNewMail.Click += new System.EventHandler(this.btnNewMail_Click);
            // 
            // userControl2
            // 
            this.userControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl2.Location = new System.Drawing.Point(0, 0);
            this.userControl2.Name = "userControl2";
            this.userControl2.Size = new System.Drawing.Size(1050, 538);
            this.userControl2.TabIndex = 0;
            // 
            // userControl1
            // 
            this.userControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1.Location = new System.Drawing.Point(0, 23);
            this.userControl1.Name = "userControl1";
            this.userControl1.Node = null;
            this.userControl1.Size = new System.Drawing.Size(155, 515);
            this.userControl1.TabIndex = 2;
            this.userControl1.Users = ((System.Collections.Hashtable)(resources.GetObject("userControl1.Users")));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 548);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public ucView userControl2;
        private System.Windows.Forms.Button btnNewMail;
        public ucList userControl1;
    }
}

