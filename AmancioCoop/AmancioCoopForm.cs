using AmancioCoop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmancioCoop
{
    public partial class AmancioCoopForm : Form
    {
        AmancioCoopEntities _context = new AmancioCoopEntities();
        public AmancioCoopForm()
        {
            InitializeComponent();
        }

        private void refreshDataGrid()
        {
            categoryBindingSource.DataSource = _context.Categories.ToList();
        }

        private void AmancioCoopForm_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = _context.Categories.ToList();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text.Trim())) {
                return;
            }

            Category category = new Category();
            category.CategoryName = textBox1.Text.Trim();
            _context.Categories.Add(category);
            _context.SaveChanges();
            textBox1.Text = "";
            refreshDataGrid();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var searchText = textBox2.Text.Trim();
            categoryBindingSource.DataSource = _context.Categories.Where(q => q.CategoryName.Contains(searchText)).ToList();
            textBox2.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                return;
            }

            var toBeDeleted = _context.Categories.Where(q => q.Id.ToString() == textBox3.Text.Trim()).FirstOrDefault();
            _context.Categories.Remove(toBeDeleted);
            textBox3.Text = "";
            _context.SaveChanges();
            refreshDataGrid();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            var toBeUpdated = _context.Categories.Where(q => q.Id == 1).FirstOrDefault();
            toBeUpdated.CategoryName = "Loan";
            _context.SaveChanges();
            refreshDataGrid();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
