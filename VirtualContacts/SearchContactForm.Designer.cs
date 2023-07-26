namespace VirtualContacts
{
    partial class SearchContactForm
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
            txtContactName = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(12, 12);
            txtContactName.Name = "txtContactName";
            txtContactName.PlaceholderText = "Search by Contact Name...";
            txtContactName.Size = new Size(210, 23);
            txtContactName.TabIndex = 0;
            txtContactName.KeyPress += txtContactName_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(228, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // SearchContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 46);
            Controls.Add(btnSearch);
            Controls.Add(txtContactName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchContactForm";
            Text = "Search Contact";
            TopMost = true;
            Load += SearchContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContactName;
        private Button btnSearch;
    }
}