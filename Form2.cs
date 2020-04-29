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
    public partial class Form2 : Form
    {
        ict_sba_1.Form1.user u;
        private OleDbConnection con = new OleDbConnection();
        public string s, connectionString;

        public Form2(ict_sba_1.Form1.user user1)
        {
            InitializeComponent();
            u = user1;
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\sba_account1.mdb;User Id=admin;Password=";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            welcome.Text = "Welcome " + u.username;
            s = u.username;
            try
            {
                con.Open();
                string input = "select * from Subject";
                OleDbCommand com = new OleDbCommand(input, con);
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    subject1.Items.Add(read["Subject"].ToString());
                }
                read.Close();
                con.Close();
            }
            catch (Exception expect)
            {
                MessageBox.Show("Error " + expect, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (s[0] == 's')
            {
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel5.Visible = false;
                teacherReportToolStripMenuItem.Visible = false;
                editToolStripMenuItem.Visible = false;
                teacherReportToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                createNewAccountToolStripMenuItem.Visible = false;
                createNewAccountToolStripMenuItem.Enabled = false;
            }
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel2.Location = new Point(ClientSize.Width / 2 - tableLayoutPanel2.Size.Width / 2, ClientSize.Height / 2 - tableLayoutPanel2.Size.Height / 2);
            editQuestionToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            newQuestionToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tableLayoutPanel3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f0 = new Form1();
            f0.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form0 form0 = new Form0();
            form0.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tableLayoutPanel2.Visible = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f0 = new Form1();
            f0.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form0 form0 = new Form0();
            form0.ShowDialog();
        }

        private void newQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pw_save_Click(object sender, EventArgs e)
        {
            if (text_pw1.Text != text_pw2.Text)
            {
                MessageBox.Show("New password and Confirm not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(text_opw.Text) || string.IsNullOrEmpty(text_pw1.Text) || string.IsNullOrEmpty(text_pw2.Text))
            {
                MessageBox.Show("Columns are not filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string find = "select count(*) from Table1 where username = " + " ? and[password] =? ";
                    using (OleDbCommand connect = new OleDbCommand())
                    {
                        OleDbCommand command = new OleDbCommand(find, con);
                        con.Open();
                        command.Parameters.AddWithValue("@p1", u.username);
                        command.Parameters.AddWithValue("@p2", text_opw.Text);
                        int result = (int)command.ExecuteScalar();
                        if (result > 0)
                        {
                            try
                            {
                                string update = "update [Table1] set [password] = ? where [username] = ?";
                                OleDbCommand ole = new OleDbCommand(update, con);
                                ole.Parameters.AddWithValue("password", text_pw1.Text);
                                ole.Parameters.AddWithValue("username", u.username);
                                ole.ExecuteNonQuery();
                                MessageBox.Show("Password changed", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Old password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch (Exception expect)
                {
                    MessageBox.Show("Error " + expect, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
