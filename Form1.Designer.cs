namespace ict_sba_1
{
    partial class Form1
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
			this.title = new System.Windows.Forms.Label();
			this.login = new System.Windows.Forms.Button();
			this.username1 = new System.Windows.Forms.TextBox();
			this.password1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.student1 = new System.Windows.Forms.CheckBox();
			this.teacher1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.title.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(0, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(800, 450);
			this.title.TabIndex = 0;
			this.title.Text = "ABC Secondary School Question Bank";
			this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.title.Click += new System.EventHandler(this.title_Click);
			// 
			// login
			// 
			this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.login.Location = new System.Drawing.Point(104, 103);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(89, 25);
			this.login.TabIndex = 5;
			this.login.Text = "Login";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.login_Click);
			// 
			// username1
			// 
			this.username1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.username1.Location = new System.Drawing.Point(99, 3);
			this.username1.Name = "username1";
			this.username1.Size = new System.Drawing.Size(100, 27);
			this.username1.TabIndex = 1;
			this.username1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// password1
			// 
			this.password1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.password1.Location = new System.Drawing.Point(99, 36);
			this.password1.Name = "password1";
			this.password1.PasswordChar = '*';
			this.password1.Size = new System.Drawing.Size(100, 25);
			this.password1.TabIndex = 2;
			this.password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(5, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.login, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.username1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.password1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.student1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.teacher1, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(294, 215);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 132);
			this.tableLayoutPanel1.TabIndex = 6;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// student1
			// 
			this.student1.AutoSize = true;
			this.student1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.student1.Location = new System.Drawing.Point(3, 69);
			this.student1.Name = "student1";
			this.student1.Size = new System.Drawing.Size(90, 23);
			this.student1.TabIndex = 5;
			this.student1.Text = "Student";
			this.student1.UseVisualStyleBackColor = true;
			this.student1.CheckedChanged += new System.EventHandler(this.student1_CheckedChanged);
			// 
			// teacher1
			// 
			this.teacher1.AutoSize = true;
			this.teacher1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.teacher1.Location = new System.Drawing.Point(99, 69);
			this.teacher1.Name = "teacher1";
			this.teacher1.Size = new System.Drawing.Size(93, 23);
			this.teacher1.TabIndex = 6;
			this.teacher1.Text = "Teacher";
			this.teacher1.UseVisualStyleBackColor = true;
			this.teacher1.CheckedChanged += new System.EventHandler(this.teacher1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(5, 103);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 25);
			this.button1.TabIndex = 7;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.title);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox student1;
        private System.Windows.Forms.CheckBox teacher1;
        private System.Windows.Forms.Button button1;
    }
}

