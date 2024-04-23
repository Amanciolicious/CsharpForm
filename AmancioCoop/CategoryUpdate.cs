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
    public partial class CategoryUpdate : Form
    {
        
        private int _Id;
        private BindingSource _BindingSource;
        private readonly AmancioCoopEntities _context = new AmancioCoopEntities();
        public CategoryUpdate()
        {
            InitializeComponent();
        }

        public CategoryUpdate(int Id, BindingSource bindingSource) : this()
        {
            _Id = Id;
            _BindingSource = bindingSource;
        }
        private void updateBtn2_Click(object sender, EventArgs e)
        {
            var category = _context.Categories.Where(q => q.Id == _Id).FirstOrDefault();
            category.CategoryName = textBox1.Text.Trim();
            _context.SaveChanges();
            _BindingSource.DataSource = _context.Categories.ToList();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
