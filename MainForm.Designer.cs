namespace Bank_Account_Management
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
            this.accountsListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.requestLoanButton = new System.Windows.Forms.Button();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // accountsListView
            // 
            this.accountsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Balance,
            this.Created,
            this.Duration,
            this.Interest});
            this.accountsListView.GridLines = true;
            this.accountsListView.HideSelection = false;
            this.accountsListView.Location = new System.Drawing.Point(30, 93);
            this.accountsListView.Name = "accountsListView";
            this.accountsListView.Size = new System.Drawing.Size(673, 268);
            this.accountsListView.TabIndex = 0;
            this.accountsListView.UseCompatibleStateImageBehavior = false;
            this.accountsListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accounts";
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(84, 376);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(198, 23);
            this.transferButton.TabIndex = 2;
            this.transferButton.Text = "Transfer Funds";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // requestLoanButton
            // 
            this.requestLoanButton.Location = new System.Drawing.Point(429, 376);
            this.requestLoanButton.Name = "requestLoanButton";
            this.requestLoanButton.Size = new System.Drawing.Size(198, 23);
            this.requestLoanButton.TabIndex = 3;
            this.requestLoanButton.Text = "Request A Loan";
            this.requestLoanButton.UseVisualStyleBackColor = true;
            this.requestLoanButton.Click += new System.EventHandler(this.requestLoanButton_Click);
            // 
            // Type
            // 
            this.Type.Text = "Account Type";
            this.Type.Width = 93;
            // 
            // Balance
            // 
            this.Balance.Text = "Balance";
            this.Balance.Width = 81;
            // 
            // Created
            // 
            this.Created.Text = "Date Created";
            this.Created.Width = 96;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration (Years)";
            this.Duration.Width = 108;
            // 
            // Interest
            // 
            this.Interest.Text = "Interest Rate";
            this.Interest.Width = 99;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestLoanButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountsListView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView accountsListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button requestLoanButton;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Interest;
    }
}

