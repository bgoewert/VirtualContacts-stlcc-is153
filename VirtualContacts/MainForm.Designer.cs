namespace VirtualContacts
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
            btnCreateNewContact = new Button();
            btnViewAllContacts = new Button();
            btnSearchContact = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCreateNewContact
            // 
            btnCreateNewContact.Location = new Point(98, 62);
            btnCreateNewContact.Name = "btnCreateNewContact";
            btnCreateNewContact.Size = new Size(145, 23);
            btnCreateNewContact.TabIndex = 0;
            btnCreateNewContact.Text = "Create New Contact";
            btnCreateNewContact.UseVisualStyleBackColor = true;
            btnCreateNewContact.Click += btnCreateNewContact_Click;
            // 
            // btnViewAllContacts
            // 
            btnViewAllContacts.Location = new Point(98, 91);
            btnViewAllContacts.Name = "btnViewAllContacts";
            btnViewAllContacts.Size = new Size(145, 23);
            btnViewAllContacts.TabIndex = 1;
            btnViewAllContacts.Text = "View All Contacts";
            btnViewAllContacts.UseVisualStyleBackColor = true;
            btnViewAllContacts.Click += btnViewAllContacts_Click;
            // 
            // btnSearchContact
            // 
            btnSearchContact.Location = new Point(98, 120);
            btnSearchContact.Name = "btnSearchContact";
            btnSearchContact.Size = new Size(145, 23);
            btnSearchContact.TabIndex = 2;
            btnSearchContact.Text = "Search Contact";
            btnSearchContact.UseVisualStyleBackColor = true;
            btnSearchContact.Click += btnSearchContact_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(98, 149);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 25);
            label1.TabIndex = 4;
            label1.Text = "Virtual Contact Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 210);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnSearchContact);
            Controls.Add(btnViewAllContacts);
            Controls.Add(btnCreateNewContact);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "VCMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateNewContact;
        private Button btnViewAllContacts;
        private Button btnSearchContact;
        private Button btnExit;
        private Label label1;
    }
}