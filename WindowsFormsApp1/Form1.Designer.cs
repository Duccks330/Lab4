namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.labelContacted = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listViewOutput = new System.Windows.Forms.ListView();
            this.Contacted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(251, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 16);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            this.toolTip1.SetToolTip(this.labelFirstName, "First name");
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(331, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxFirstName, "First name text box");
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(332, 38);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxLastName, "Last Name Text Box");
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(251, 41);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 16);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            this.toolTip1.SetToolTip(this.labelLastName, "Last name");
            this.labelLastName.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(331, 64);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxEmail, "Email address text box");
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(228, 67);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(98, 16);
            this.labelEmailAddress.TabIndex = 4;
            this.labelEmailAddress.Text = "Email Address:";
            this.toolTip1.SetToolTip(this.labelEmailAddress, "Email address");
            this.labelEmailAddress.Click += new System.EventHandler(this.labelEmailAddress_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(331, 90);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxPhone, "phone number text box");
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(226, 93);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(100, 16);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "Phone Number:";
            this.toolTip1.SetToolTip(this.labelPhoneNumber, "Phone number");
            this.labelPhoneNumber.Click += new System.EventHandler(this.labelPhoneNumber_Click);
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.AutoSize = true;
            this.checkBoxContacted.Location = new System.Drawing.Point(331, 120);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxContacted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxContacted.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBoxContacted, "Contacted check box");
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            this.checkBoxContacted.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelContacted
            // 
            this.labelContacted.AutoSize = true;
            this.labelContacted.Location = new System.Drawing.Point(251, 119);
            this.labelContacted.Name = "labelContacted";
            this.labelContacted.Size = new System.Drawing.Size(75, 16);
            this.labelContacted.TabIndex = 8;
            this.labelContacted.Text = "Contacted?";
            this.labelContacted.Click += new System.EventHandler(this.labelContacted_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(383, 394);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.buttonExit, "Exit button");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(221, 394);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "&Submit";
            this.toolTip1.SetToolTip(this.buttonSubmit, "Submit button");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(302, 394);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Reset button");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(13, 300);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(626, 82);
            this.listBoxResult.TabIndex = 11;
            this.toolTip1.SetToolTip(this.listBoxResult, "Error box");
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // listViewOutput
            // 
            this.listViewOutput.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contacted,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone,
            this.Date});
            this.listViewOutput.HideSelection = false;
            this.listViewOutput.Location = new System.Drawing.Point(13, 148);
            this.listViewOutput.Name = "listViewOutput";
            this.listViewOutput.Size = new System.Drawing.Size(626, 142);
            this.listViewOutput.TabIndex = 15;
            this.toolTip1.SetToolTip(this.listViewOutput, "Output box");
            this.listViewOutput.UseCompatibleStateImageBehavior = false;
            this.listViewOutput.View = System.Windows.Forms.View.Details;
            this.listViewOutput.SelectedIndexChanged += new System.EventHandler(this.listViewOutput_SelectedIndexChanged);
            // 
            // Contacted
            // 
            this.Contacted.Text = "Contacted";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 100;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.listViewOutput);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelContacted);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.CheckBox checkBoxContacted;
        private System.Windows.Forms.Label labelContacted;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listViewOutput;
        private System.Windows.Forms.ColumnHeader Contacted;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Date;
    }
}

