using AmancioCoop.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AmancioCoop
{
    public partial class clientDelete : Form
    {

        private int _Id;
        private BindingSource _BindingSource;
      
        private BindingSource clientInfoBindingSource;
        private readonly AmancioCoopEntities _context = new AmancioCoopEntities();
        public clientDelete()
        {
            InitializeComponent();
        }

      

        public clientDelete(BindingSource clientInfoBindingSource) : this()
        {
            this.clientInfoBindingSource = clientInfoBindingSource;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {


            string clientdelete = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(clientdelete))
            {
                var clientdelete2 = _context.ClientInfoes.FirstOrDefault(q => q.Id.ToString() == clientdelete);
                if (clientdelete2 != null)
                {
                    _context.ClientInfoes.Remove(clientdelete2);
                    _context.SaveChanges();
                    clientInfoBindingSource.DataSource = _context.ClientInfoes.ToList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Client ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Client ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
