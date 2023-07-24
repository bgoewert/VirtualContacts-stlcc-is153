using System.Net.Mail;

namespace VirtualContacts
{
    public partial class NewContactForm : Form
    {
        public NewContactForm()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();

            try
            {
                // Set the contact name
                if (txtName.Text != "")
                    newContact.Name = txtName.Text;
                else throw new Exception("Please enter a Name.");

                // Set the age
                if (numAge.Value > 0)
                    newContact.Age = (int)numAge.Value;
                else throw new Exception("Please enter an Age greater than 0.");

                // Set the phone number
                if (txtPhone.Text != "")
                    newContact.PhoneNumber = txtPhone.Text;
                else throw new Exception("Please enter a Phone Number.");

                // Validate and set the contact email address
                if (IsValidEmail(txtEmail.Text))
                    newContact.EmailAddress = txtEmail.Text;
                else throw new Exception("Email Address is invalid. Please enter a valid Email Address.");

                // Set the preferred contact method
                if (cboPreferredContactMethod.SelectedItem is not null)
                {
                    string preferredContactMethod = cboPreferredContactMethod.SelectedItem.ToString() == "Email Address" ? "E" : "P";
                    newContact.PreferredContactMethod = preferredContactMethod;
                }
                else throw new Exception("Please selected a Preferred Contact Method.");

                // Set the day of birth
                if (cboDayOfBirth.SelectedItem is not null)
                {
                    DayOfWeek.TryParse(cboDayOfBirth.SelectedItem.ToString(), out DayOfWeek dayOfBirth);
                    newContact.DayOfBirth = dayOfBirth;
                }
                else throw new Exception("Please select a Day of Birth");

                // Set the street address
                if (txtStreetAddress.Text != "")
                    newContact.StreetAddress = txtStreetAddress.Text;
                else throw new Exception("Please enter a Street Address.");

                // Add to collection
                MainForm.Contacts.Add(newContact.Name, newContact);

                // Close form
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            /*
             * While researching email validation with .Net, I found this interseting and simple way to perform
             * validation using the MailAddress.TryCreate method.
             * Originaly found here: https://stackoverflow.com/a/1374644/5825414
             * Updated solution: https://stackoverflow.com/a/75486103/5825414
             * And all credit goes to the authors Cogwheel, for the original solution, and Ryan Penfold, for the updated solution.
             * 
             * Note that in this linked discussion, it's pointed out that a "valid" email can end without a TLD
             * extension or may contain an invalid domain. To further validate an email address, you could also perform a DNS lookup
             * to check that the domain has valid email-related records such as MX.
             * 
             * Documentation on MailAddress.TryCreate
             * https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress.trycreate?view=net-7.
             */
            string trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith(".")) return false;

            try
            {
                return MailAddress.TryCreate(email, out MailAddress emailAddress)
                    && emailAddress.Address == trimmedEmail;
            }
            catch { return false; }
        }
    }
}
