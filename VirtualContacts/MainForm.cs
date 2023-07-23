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
    public partial class MainForm : Form
    {
        //create the necessary code for your program to run here
        internal static Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
