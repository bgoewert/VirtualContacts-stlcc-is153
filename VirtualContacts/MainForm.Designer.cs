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
            SuspendLayout();
            // 
            // btnCreateNewContact
            // 
            btnCreateNewContact.Location = new Point(12, 12);
            btnCreateNewContact.Name = "btnCreateNewContact";
            btnCreateNewContact.Size = new Size(145, 23);
            btnCreateNewContact.TabIndex = 0;
            btnCreateNewContact.Text = "Create New Contact";
            btnCreateNewContact.UseVisualStyleBackColor = true;
            // 
            // btnViewAllContacts
            // 
            btnViewAllContacts.Location = new Point(12, 41);
            btnViewAllContacts.Name = "btnViewAllContacts";
            btnViewAllContacts.Size = new Size(145, 23);
            btnViewAllContacts.TabIndex = 1;
            btnViewAllContacts.Text = "View All Contacts";
            btnViewAllContacts.UseVisualStyleBackColor = true;
            // 
            // btnSearchContact
            // 
            btnSearchContact.Location = new Point(12, 70);
            btnSearchContact.Name = "btnSearchContact";
            btnSearchContact.Size = new Size(145, 23);
            btnSearchContact.TabIndex = 2;
            btnSearchContact.Text = "Search Contact";
            btnSearchContact.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 99);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 210);
            Controls.Add(btnExit);
            Controls.Add(btnSearchContact);
            Controls.Add(btnViewAllContacts);
            Controls.Add(btnCreateNewContact);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Virtual Contact Management System";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateNewContact;
        private Button btnViewAllContacts;
        private Button btnSearchContact;
        private Button btnExit;
    }
}