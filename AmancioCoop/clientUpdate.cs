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
    public partial class clientUpdate : Form
    {
        private int _Id;
        private BindingSource _BindingSource;
        private readonly AmancioCoopEntities _context = new AmancioCoopEntities();
        public clientUpdate()
        {
            InitializeComponent();
        }
        public clientUpdate(int Id, BindingSource bindingSource) : this()
        {
            _Id = Id;
            _BindingSource = bindingSource;
        }



        private void updateBtn_Click(object sender, EventArgs e)
        {
            string clientupdateee = textBox5.Text.Trim();
            if (!string.IsNullOrEmpty(clientupdateee))
            {
                int clientId;
                if (int.TryParse(clientupdateee, out clientId))
                {
                    var clientupd = _context.ClientInfoes.FirstOrDefault(q => q.Id == clientId);
                    if (clientupd != null)
                    {
                        if (string.IsNullOrEmpty(textBox1.Text.Trim()))
                        {
                            MessageBox.Show("Please input Firstname.");
                            return;
                        }
                        else if (string.IsNullOrEmpty(textBox2.Text.Trim()))
                        {
                            MessageBox.Show("Please input Lastname.");
                            return;
                        }
                        else if (string.IsNullOrEmpty(textBox3.Text.Trim()))
                        {
                            MessageBox.Show("Please input Residency.");
                            return;
                        }
                        else if (string.IsNullOrEmpty(textBox4.Text.Trim()))
                        {
                            MessageBox.Show("Please input Age.");
                            return;
                        }




                        clientupd.Firstname = textBox1.Text.Trim();
                        clientupd.Lastname = textBox2.Text.Trim();
                        clientupd.Residency = textBox3.Text.Trim();
                        int age;
                        if (Int32.TryParse(textBox4.Text.Trim(), out age))
                        {
                            clientupd.Age = age;
                            _context.SaveChanges();
                            _BindingSource.DataSource = _context.ClientInfoes.ToList();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid age format. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


              
                private void clientUpdate_Load(object sender, EventArgs e)
                {
                    var clientinfo = _context.ClientInfoes.Where(q => q.Id == _Id).FirstOrDefault();
                    textBox1.Text = clientinfo.Firstname;
                    textBox2.Text = clientinfo.Lastname;
                    textBox3.Text = clientinfo.Residency;
                    textBox4.Text = clientinfo.Age.ToString();
                }
            }
        }
    