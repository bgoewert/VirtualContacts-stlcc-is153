﻿namespace VirtualContacts
{
    partial class ViewContactsForm
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
            lstContacts = new ListView();
            SuspendLayout();
            // 
            // lstContacts
            // 
            lstContacts.Dock = DockStyle.Fill;
            lstContacts.FullRowSelect = true;
            lstContacts.Location = new Point(0, 0);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(784, 241);
            lstContacts.TabIndex = 0;
            lstContacts.UseCompatibleStateImageBehavior = false;
            lstContacts.View = View.Details;
            lstContacts.KeyPress += lstContacts_KeyPress;
            // 
            // ViewContactsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 241);
            Controls.Add(lstContacts);
            Name = "ViewContactsForm";
            Text = "View All Contacts";
            Load += ViewContactsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstContacts;
    }
}