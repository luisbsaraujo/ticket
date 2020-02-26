namespace TicketSystem
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
            this.transactionNameTextBox = new System.Windows.Forms.TextBox();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.addOneRegButton = new System.Windows.Forms.Button();
            this.addOnePreButton = new System.Windows.Forms.Button();
            this.removeOneRegButton = new System.Windows.Forms.Button();
            this.removeOnePreButton = new System.Windows.Forms.Button();
            this.addCurrentTransactionButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionNameTextBox
            // 
            this.transactionNameTextBox.Location = new System.Drawing.Point(391, 13);
            this.transactionNameTextBox.Name = "transactionNameTextBox";
            this.transactionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionNameTextBox.TabIndex = 0;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(285, 16);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(100, 13);
            this.transactionLabel.TabIndex = 1;
            this.transactionLabel.Text = "Transaction Name: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create Current Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(44, 105);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(433, 121);
            this.ListBox.TabIndex = 3;
            // 
            // addOneRegButton
            // 
            this.addOneRegButton.Location = new System.Drawing.Point(525, 116);
            this.addOneRegButton.Name = "addOneRegButton";
            this.addOneRegButton.Size = new System.Drawing.Size(234, 23);
            this.addOneRegButton.TabIndex = 4;
            this.addOneRegButton.Text = "Add 1 Regular Seat To Current Transaction";
            this.addOneRegButton.UseVisualStyleBackColor = true;
            this.addOneRegButton.Click += new System.EventHandler(this.addOneRegButton_Click);
            // 
            // addOnePreButton
            // 
            this.addOnePreButton.Location = new System.Drawing.Point(525, 145);
            this.addOnePreButton.Name = "addOnePreButton";
            this.addOnePreButton.Size = new System.Drawing.Size(234, 23);
            this.addOnePreButton.TabIndex = 5;
            this.addOnePreButton.Text = "Add 1 Premium Seat To Current Transaction";
            this.addOnePreButton.UseVisualStyleBackColor = true;
            this.addOnePreButton.Click += new System.EventHandler(this.addOnePreButton_Click);
            // 
            // removeOneRegButton
            // 
            this.removeOneRegButton.Location = new System.Drawing.Point(525, 192);
            this.removeOneRegButton.Name = "removeOneRegButton";
            this.removeOneRegButton.Size = new System.Drawing.Size(234, 23);
            this.removeOneRegButton.TabIndex = 6;
            this.removeOneRegButton.Text = "Remove 1 Regular Seat From Current Transaction";
            this.removeOneRegButton.UseVisualStyleBackColor = true;
            this.removeOneRegButton.Click += new System.EventHandler(this.removeOneRegButton_Click);
            // 
            // removeOnePreButton
            // 
            this.removeOnePreButton.Location = new System.Drawing.Point(525, 221);
            this.removeOnePreButton.Name = "removeOnePreButton";
            this.removeOnePreButton.Size = new System.Drawing.Size(234, 23);
            this.removeOnePreButton.TabIndex = 7;
            this.removeOnePreButton.Text = "Remove 1 Premium Seat From Current Transaction";
            this.removeOnePreButton.UseVisualStyleBackColor = true;
            this.removeOnePreButton.Click += new System.EventHandler(this.removeOnePreButton_Click);
            // 
            // addCurrentTransactionButton
            // 
            this.addCurrentTransactionButton.Location = new System.Drawing.Point(154, 242);
            this.addCurrentTransactionButton.Name = "addCurrentTransactionButton";
            this.addCurrentTransactionButton.Size = new System.Drawing.Size(182, 23);
            this.addCurrentTransactionButton.TabIndex = 8;
            this.addCurrentTransactionButton.Text = "Add Current Transaction To List";
            this.addCurrentTransactionButton.UseVisualStyleBackColor = true;
            this.addCurrentTransactionButton.Click += new System.EventHandler(this.addCurrentTransactionButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(322, 303);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save All Transactions to Ouput File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addCurrentTransactionButton);
            this.Controls.Add(this.removeOnePreButton);
            this.Controls.Add(this.removeOneRegButton);
            this.Controls.Add(this.addOnePreButton);
            this.Controls.Add(this.addOneRegButton);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.transactionNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox transactionNameTextBox;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button addOneRegButton;
        private System.Windows.Forms.Button addOnePreButton;
        private System.Windows.Forms.Button removeOneRegButton;
        private System.Windows.Forms.Button removeOnePreButton;
        private System.Windows.Forms.Button addCurrentTransactionButton;
        private System.Windows.Forms.Button saveButton;
    }
}

