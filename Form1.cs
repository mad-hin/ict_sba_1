using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ict_sba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class user
        {
            public string username;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
        private void login_Click(object sender, EventArgs e)
        {
            if (!teacher1.Checked && !student1.Checked)
            {
                MessageBox.Show("Please tick the column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (student1.Checked)
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\sba_account1.mdb;User Id=admin;Password=";
                string find = "select count(*) from Table1 where username =" + "? and [password]=?";
                OleDbCommand oleDbCommand = new OleDbCommand(find, con);
                {
                    con.Open();
                    oleDbCommand.Parameters.AddWithValue("@p1", username1.Text);
                    oleDbCommand.Parameters.AddWithValue("@p2", password1.Text);
                    int result = (int)oleDbCommand.ExecuteScalar();
                    if (result > 0)
                    {
                        this.Hide();
                        user u = new user();
                        u.username = username1.Text;
                        Form2 f2 = new Form2(u);
                        f2.ShowDialog();
                    }
                    else
                        MessageBox.Show("Username or password are wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else if (teacher1.Checked)
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|account2.mdb;Persist Security Info=False;";
                string find = "select count(*) from Table1 where username =" + "? and [password]=?";
                OleDbCommand oleDbCommand = new OleDbCommand(find, con);
                {
                    con.Open();
                    oleDbCommand.Parameters.AddWithValue("@p1", username1.Text);
                    oleDbCommand.Parameters.AddWithValue("@p2", password1.Text);
                    int result = (int)oleDbCommand.ExecuteScalar();
                    if (result > 0)
                    {
                        this.Hide();
                        user u = new user();
                        u.username = username1.Text;
                        Form2 f0 = new Form2(u);
                        f0.ShowDialog();
                    }
                    else
                        MessageBox.Show("Username or password are wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.Location = new Point(ClientSize.Width / 2 - tableLayoutPanel1.Size.Width / 2, ClientSize.Height / 2 - tableLayoutPanel1.Size.Height / 2);
        }

        private void student1_CheckedChanged(object sender, EventArgs e)
        {
            teacher1.Checked = false;
        }

        private void teacher1_CheckedChanged(object sender, EventArgs e)
        {
            student1.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
