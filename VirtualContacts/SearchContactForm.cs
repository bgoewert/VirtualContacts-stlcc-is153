using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualContacts
{
    public partial class SearchContactForm : Form
    {
        public SearchContactForm()
        {
            InitializeComponent();
        }

        private void txtContactName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the Enter or Space key is pressed, try searching.
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space)
                SearchContact();

            // If the Escape key is pressed, close form.
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }

        private void btnSearch_Click(object sender, EventArgs e) { SearchContact(); }

        private void SearchContact()
        {
            if (txtContactName.Text != "")
            {
                try
                {
                    Contact match = MainForm.Contacts.Values.First(c => c.Name.Contains(txtContactName.Text));
                    ShowContact(match);
                }
                catch { MessageBox.Show("No Contact found matching that name."); }
            }
            else MessageBox.Show("Please enter a name to search for.");
        }

        private void ShowContact(Contact contact)
        {
            string preferredContactMethod = contact.PreferredContactMethod == "E" ? "Email Adddress" : "Phone Number";
            MessageBox.Show(
                $"Name: {contact.Name}\n" +
                $"Age: {contact.Age}\n" +
                $"Phone Number: {contact.PhoneNumber}\n" +
                $"Email Address: {contact.EmailAddress}\n" +
                $"Preferred Contact Method: {preferredContactMethod}\n" +
                $"Day of Birth: {contact.DayOfBirth}\n" +
                $"Street Address: {contact.StreetAddress}",
                "Contact Found"
            );
        }

        private void SearchContactForm_Load(object sender, EventArgs e)
        {
            if (MainForm.Contacts.Count == 0)
            {
                MessageBox.Show("There are no contacts saved.");
                Close();
            }

            if (MainForm.Contacts.Count == 1)
            {
                MessageBox.Show("There is only one contact saved.");
                ShowContact(MainForm.Contacts.ElementAt(0).Value);
            }
        }
    }
}
