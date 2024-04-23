using AmancioCoop.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AmancioCoop
{
    public partial class ClientInfo1 : Form
    {
        private int selectedClientId;
        AmancioCoopEntities _context = new AmancioCoopEntities();
        private BindingSource _BindingSource;

        public ClientInfo1()
        {
            InitializeComponent();
        }

        
        private void ClientInfo_Load(object sender, EventArgs e)
        {
            clientInfoBindingSource.DataSource = _context.ClientInfoes.ToList();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var searchText = textBox1.Text;
            clientInfoBindingSource.DataSource = _context.ClientInfoes.Where(q => (q.Firstname + q.Lastname + q.Residency + q.Age).Contains(searchText)).ToList();
            
            

            textBox1.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            clientAdd clientadd = new clientAdd(selectedClientId, clientInfoBindingSource);
            clientadd.Show();
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            clientUpdate clientUpd = new clientUpdate(selectedClientId, clientInfoBindingSource);
            clientUpd.Show();

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            clientDelete clientdele = new clientDelete(clientInfoBindingSource);
            clientdele.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            selectedClientId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
