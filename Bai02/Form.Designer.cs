using System.Windows.Forms;

namespace Bai02
{
    partial class Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstListMail = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRecent = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pageSelector = new System.Windows.Forms.NumericUpDown();
            this.lblViews = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lstListMail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRecent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.pageSelector, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblViews, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstListMail
            // 
            this.lstListMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.From,
            this.Date});
            this.tableLayoutPanel1.SetColumnSpan(this.lstListMail, 5);
            this.lstListMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListMail.HideSelection = false;
            this.lstListMail.Location = new System.Drawing.Point(2, 83);
            this.lstListMail.Margin = new System.Windows.Forms.Padding(2);
            this.lstListMail.Name = "lstListMail";
            this.lstListMail.Size = new System.Drawing.Size(521, 355);
            this.lstListMail.TabIndex = 8;
            this.lstListMail.UseCompatibleStateImageBehavior = false;
            this.lstListMail.View = System.Windows.Forms.View.Details;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 154;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 176;
            // 
            // Date
            // 
            this.Date.Text = "Thời gian";
            this.Date.Width = 300;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(421, 3);
            this.btnLogin.MaximumSize = new System.Drawing.Size(97, 46);
            this.btnLogin.MinimumSize = new System.Drawing.Size(97, 46);
            this.btnLogin.Name = "btnLogin";
            this.tableLayoutPanel1.SetRowSpan(this.btnLogin, 2);
            this.btnLogin.Size = new System.Drawing.Size(97, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtEmail, 3);
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(109, 3);
            this.txtEmail.MaximumSize = new System.Drawing.Size(9999, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPassword, 3);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(109, 29);
            this.txtPassword.MaximumSize = new System.Drawing.Size(9999, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(306, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Location = new System.Drawing.Point(3, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 29);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRecent.Location = new System.Drawing.Point(109, 52);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(0, 29);
            this.lblRecent.TabIndex = 6;
            this.lblRecent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(421, 55);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(101, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // pageSelector
            // 
            this.pageSelector.Dock = System.Windows.Forms.DockStyle.Right;
            this.pageSelector.Location = new System.Drawing.Point(374, 55);
            this.pageSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Size = new System.Drawing.Size(41, 20);
            this.pageSelector.TabIndex = 10;
            this.pageSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.Visible = false;
            this.pageSelector.ValueChanged += new System.EventHandler(this.pageSelector_ValueChanged);
            // 
            // lblViews
            // 
            this.lblViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViews.Location = new System.Drawing.Point(213, 52);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(98, 29);
            this.lblViews.TabIndex = 11;
            this.lblViews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.ListView lstListMail;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Date;
        private ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private NumericUpDown pageSelector;
        private Label lblViews;
    }
}

