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
    public partial class Form0 : Form
    {
        //ict_sba_1.Form1.user u;
        private OleDbConnection con = new OleDbConnection();
        public string s;
        public Form0()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Marco\Desktop\C++\ict_sba_1\sba_account1.mdb;Persist Security Info=False;";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            bool ufill, nfill, idfill, pwfill, cfill;
            if (string.IsNullOrEmpty(text_name.Text))
            {
                nfill = false;
            }
            else
            {
                nfill = true;
            }
            if (string.IsNullOrEmpty(text_id.Text))
            {
                idfill = false;
            }
            else
            {
                idfill = true;
            }
            if (string.IsNullOrEmpty(text_user.Text))
            {
                ufill = false;
            }
            else
            {
                ufill = true;
            }
            if (string.IsNullOrEmpty(text_password.Text))
            {
                pwfill = false;
            }
            else
            {
                pwfill = true;
            }
            if (string.IsNullOrEmpty(text_class.Text))
            {
                cfill = false;
            }
            else
            {
                cfill = true;
            }
            if (!(cfill && ufill && pwfill && idfill && nfill))
            {
                MessageBox.Show("Columns are not filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = con;
                    command.CommandText = "insert into [Table1]([Student name],[Student id],[username],[password],[Class]) values (?,?,?,?,?)";
                    command.Parameters.AddWithValue("Student name", text_name.Text);
                    command.Parameters.AddWithValue("Student id", text_id.Text);
                    command.Parameters.AddWithValue("username", text_user.Text);
                    command.Parameters.AddWithValue("password", text_password.Text);
                    command.Parameters.AddWithValue("Class", text_class.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created", "Congratulations",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception expect)
                {
                    MessageBox.Show("Error " + expect, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.Location = new Point(ClientSize.Width / 2 - tableLayoutPanel1.Size.Width / 2, ClientSize.Height / 2 - tableLayoutPanel1.Size.Height / 2);
        }
    }
}
