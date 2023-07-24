namespace VirtualContacts
{
    partial class NewContactForm
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
            btnAddContact = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            cboPreferredContactMethod = new ComboBox();
            numAge = new NumericUpDown();
            txtPhone = new MaskedTextBox();
            label6 = new Label();
            txtStreetAddress = new TextBox();
            cboDayOfBirth = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(12, 329);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(114, 23);
            btnAddContact.TabIndex = 6;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 23);
            txtEmail.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 10;
            label5.Text = "Preferred Contact Method";
            // 
            // cboPreferredContactMethod
            // 
            cboPreferredContactMethod.FormattingEnabled = true;
            cboPreferredContactMethod.Items.AddRange(new object[] { "Email Address", "Phone Number" });
            cboPreferredContactMethod.Location = new Point(12, 203);
            cboPreferredContactMethod.Name = "cboPreferredContactMethod";
            cboPreferredContactMethod.Size = new Size(145, 23);
            cboPreferredContactMethod.TabIndex = 5;
            // 
            // numAge
            // 
            numAge.Location = new Point(12, 71);
            numAge.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(53, 23);
            numAge.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 115);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(145, 23);
            txtPhone.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 273);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "Street Address";
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(12, 291);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.Size = new Size(227, 23);
            txtStreetAddress.TabIndex = 11;
            // 
            // cboDayOfBirth
            // 
            cboDayOfBirth.FormattingEnabled = true;
            cboDayOfBirth.Items.AddRange(new object[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cboDayOfBirth.Location = new Point(12, 247);
            cboDayOfBirth.Name = "cboDayOfBirth";
            cboDayOfBirth.Size = new Size(145, 23);
            cboDayOfBirth.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 229);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 14;
            label7.Text = "Day of Birth";
            // 
            // NewContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 364);
            Controls.Add(cboDayOfBirth);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtStreetAddress);
            Controls.Add(txtPhone);
            Controls.Add(numAge);
            Controls.Add(cboPreferredContactMethod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnAddContact);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewContactForm";
            ShowInTaskbar = false;
            Text = "Add a New Contact";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddContact;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private ComboBox cboPreferredContactMethod;
        private NumericUpDown numAge;
        private MaskedTextBox txtPhone;
        private Label label6;
        private TextBox txtStreetAddress;
        private ComboBox cboDayOfBirth;
        private Label label7;
    }
}