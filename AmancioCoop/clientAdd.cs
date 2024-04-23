using AmancioCoop.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AmancioCoop
{
    public partial class clientAdd : Form
    {
        private int _Id;
        private BindingSource _BindingSource;
        private readonly AmancioCoopEntities _context = new AmancioCoopEntities();

        public clientAdd()
        {
            InitializeComponent();
        }

        public clientAdd(int Id, BindingSource bindingSource) : this()
        {
            _Id = Id;
            _BindingSource = bindingSource;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClientInfo client = new ClientInfo();
            client.Firstname = textBox1.Text.Trim();
            client.Lastname = textBox2.Text.Trim();
            client.Residency = textBox3.Text.Trim();
            client.Age = Int32.Parse(textBox4.Text.Trim());
            _context.ClientInfoes.Add(client);
            _context.SaveChanges();
            _BindingSource.DataSource = _context.ClientInfoes.ToList();
            this.Close();
        }

       
    }
}
