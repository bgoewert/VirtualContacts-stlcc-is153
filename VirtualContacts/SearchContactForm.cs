using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                    string preferredContactMethod = match.PreferredContactMethod == "E" ? "Email Adddress" : "Phone Number";
                    MessageBox.Show(
                        $"Name: {match.Name}\n" +
                        $"Age: {match.Age}\n" +
                        $"Phone Number: {match.PhoneNumber}\n" +
                        $"Email Address: {match.EmailAddress}\n" +
                        $"Preferred Contact Method: {preferredContactMethod}\n" +
                        $"Day of Birth: {match.DayOfBirth}\n" +
                        $"Street Address: {match.StreetAddress}",
                        "Contact Found"
                    );
                }
                catch { MessageBox.Show("No Contact found matching that name."); }
            }
            else MessageBox.Show("Please enter a name to search for."); 
        }
    }
}
