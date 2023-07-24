namespace VirtualContacts
{
    public partial class MainForm : Form
    {
        //create the necessary code for your program to run here
        internal static Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewContact_Click(object sender, EventArgs e)
        {
            NewContactForm newContactForm = new NewContactForm();
            newContactForm.ShowDialog();
        }
    }
}
