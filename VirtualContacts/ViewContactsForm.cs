﻿using System;
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
    public partial class ViewContactsForm : Form
    {
        public ViewContactsForm()
        {
            InitializeComponent();

            if (MainForm.Contacts.Count > 0)
            {
                // Create columns
                lstContacts.Columns.Add("Name", 150);
                lstContacts.Columns.Add("Age");
                lstContacts.Columns.Add("PhoneNumber", 100);
                lstContacts.Columns.Add("EmailAddress", 100);
                lstContacts.Columns.Add("PreferredContactMethod", 180);
                lstContacts.Columns.Add("DayOfBirth", 80);
                lstContacts.Columns.Add("StreetAddress", 100);

                // Add list items
                foreach (Contact contact in MainForm.Contacts.Values)
                {
                    ListViewItem item = new ListViewItem(contact.Name);

                    string[] subItems = {
                    contact.Age.ToString(),
                    contact.PhoneNumber,
                    contact.EmailAddress,
                    contact.PreferredContactMethod == "E" ? "Email Address" : "Phone Number",
                    contact.DayOfBirth.ToString(),
                    contact.StreetAddress
                };

                    item.SubItems.AddRange(subItems);
                    lstContacts.Items.Add(item);
                }
            }
            else {
                lstContacts.Columns.Add("Name", 150);
                lstContacts.Items.Add(new ListViewItem("No Saved Contacts"));
            }
        }
    }
}
