namespace Library_Manager
{
    partial class MainUI
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
            this.panelMainPage = new System.Windows.Forms.Panel();
            this.panelContents = new System.Windows.Forms.Panel();
            this.panelInBetween2 = new System.Windows.Forms.Panel();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelNavBarHelp = new System.Windows.Forms.Panel();
            this.panelNavBarHome = new System.Windows.Forms.Panel();
            this.panelNavBarSchedule = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelNavBarTransaction = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.panelNavBarBooks = new System.Windows.Forms.Panel();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelInBetween1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home1 = new Library_Manager.Home();
            this.books1 = new Library_Manager.Books();
            this.transaction1 = new Library_Manager.Transaction();
            this.shift1 = new Library_Manager.Schedule();
            this.help1 = new Library_Manager.Help();
            this.panelMainPage.SuspendLayout();
            this.panelContents.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainPage
            // 
            this.panelMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.panelMainPage.Controls.Add(this.panelContents);
            this.panelMainPage.Controls.Add(this.panelNavBar);
            this.panelMainPage.Controls.Add(this.panelTitle);
            this.panelMainPage.Location = new System.Drawing.Point(12, 33);
            this.panelMainPage.Name = "panelMainPage";
            this.panelMainPage.Size = new System.Drawing.Size(931, 575);
            this.panelMainPage.TabIndex = 0;
            // 
            // panelContents
            // 
            this.panelContents.BackColor = System.Drawing.Color.White;
            this.panelContents.Controls.Add(this.panelInBetween2);
            this.panelContents.Controls.Add(this.home1);
            this.panelContents.Controls.Add(this.books1);
            this.panelContents.Controls.Add(this.transaction1);
            this.panelContents.Controls.Add(this.shift1);
            this.panelContents.Controls.Add(this.help1);
            this.panelContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContents.Location = new System.Drawing.Point(0, 114);
            this.panelContents.Name = "panelContents";
            this.panelContents.Size = new System.Drawing.Size(931, 461);
            this.panelContents.TabIndex = 2;
            // 
            // panelInBetween2
            // 
            this.panelInBetween2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.panelInBetween2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInBetween2.Location = new System.Drawing.Point(0, 0);
            this.panelInBetween2.Name = "panelInBetween2";
            this.panelInBetween2.Size = new System.Drawing.Size(931, 3);
            this.panelInBetween2.TabIndex = 1;
            // 
            // panelNavBar
            // 
            this.panelNavBar.Controls.Add(this.panelNavBarHelp);
            this.panelNavBar.Controls.Add(this.panelNavBarHome);
            this.panelNavBar.Controls.Add(this.panelNavBarSchedule);
            this.panelNavBar.Controls.Add(this.btnHelp);
            this.panelNavBar.Controls.Add(this.panelNavBarTransaction);
            this.panelNavBar.Controls.Add(this.btnSchedule);
            this.panelNavBar.Controls.Add(this.panelNavBarBooks);
            this.panelNavBar.Controls.Add(this.btnTransaction);
            this.panelNavBar.Controls.Add(this.btnBooks);
            this.panelNavBar.Controls.Add(this.btnHome);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 59);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(931, 55);
            this.panelNavBar.TabIndex = 1;
            // 
            // panelNavBarHelp
            // 
            this.panelNavBarHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panelNavBarHelp.Location = new System.Drawing.Point(749, 49);
            this.panelNavBarHelp.Name = "panelNavBarHelp";
            this.panelNavBarHelp.Size = new System.Drawing.Size(176, 3);
            this.panelNavBarHelp.TabIndex = 2;
            // 
            // panelNavBarHome
            // 
            this.panelNavBarHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panelNavBarHome.Location = new System.Drawing.Point(7, 49);
            this.panelNavBarHome.Name = "panelNavBarHome";
            this.panelNavBarHome.Size = new System.Drawing.Size(176, 3);
            this.panelNavBarHome.TabIndex = 0;
            // 
            // panelNavBarSchedule
            // 
            this.panelNavBarSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panelNavBarSchedule.Location = new System.Drawing.Point(563, 49);
            this.panelNavBarSchedule.Name = "panelNavBarSchedule";
            this.panelNavBarSchedule.Size = new System.Drawing.Size(176, 3);
            this.panelNavBarSchedule.TabIndex = 2;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnHelp.Location = new System.Drawing.Point(747, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(180, 49);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelNavBarTransaction
            // 
            this.panelNavBarTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panelNavBarTransaction.Location = new System.Drawing.Point(377, 49);
            this.panelNavBarTransaction.Name = "panelNavBarTransaction";
            this.panelNavBarTransaction.Size = new System.Drawing.Size(176, 3);
            this.panelNavBarTransaction.TabIndex = 2;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnSchedule.Location = new System.Drawing.Point(561, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(180, 49);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // panelNavBarBooks
            // 
            this.panelNavBarBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panelNavBarBooks.Location = new System.Drawing.Point(191, 49);
            this.panelNavBarBooks.Name = "panelNavBarBooks";
            this.panelNavBarBooks.Size = new System.Drawing.Size(176, 3);
            this.panelNavBarBooks.TabIndex = 1;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnTransaction.Location = new System.Drawing.Point(375, 3);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(180, 49);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnBooks.Location = new System.Drawing.Point(189, 3);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(180, 49);
            this.btnBooks.TabIndex = 3;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 49);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.panelTitle.Controls.Add(this.panelInBetween1);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(931, 59);
            this.panelTitle.TabIndex = 0;
            // 
            // panelInBetween1
            // 
            this.panelInBetween1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.panelInBetween1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInBetween1.Location = new System.Drawing.Point(0, 56);
            this.panelInBetween1.Name = "panelInBetween1";
            this.panelInBetween1.Size = new System.Drawing.Size(931, 3);
            this.panelInBetween1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.lblTitle.Location = new System.Drawing.Point(46, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "School Library Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Library_Manager.Properties.Resources.icons8_close_48;
            this.pictureBox1.Location = new System.Drawing.Point(918, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(931, 461);
            this.home1.TabIndex = 4;
            // 
            // books1
            // 
            this.books1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.books1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.books1.Location = new System.Drawing.Point(0, 0);
            this.books1.Name = "books1";
            this.books1.Size = new System.Drawing.Size(931, 461);
            this.books1.TabIndex = 3;
            // 
            // transaction1
            // 
            this.transaction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction1.Location = new System.Drawing.Point(0, 0);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(931, 461);
            this.transaction1.TabIndex = 2;
            // 
            // shift1
            // 
            this.shift1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shift1.Location = new System.Drawing.Point(0, 0);
            this.shift1.Name = "shift1";
            this.shift1.Size = new System.Drawing.Size(931, 461);
            this.shift1.TabIndex = 1;
            // 
            // help1
            // 
            this.help1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.help1.Location = new System.Drawing.Point(0, 0);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(931, 461);
            this.help1.TabIndex = 0;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(954, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panelMainPage.ResumeLayout(false);
            this.panelContents.ResumeLayout(false);
            this.panelNavBar.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelContents;
        private System.Windows.Forms.Panel panelNavBarHome;
        private System.Windows.Forms.Panel panelNavBarHelp;
        private System.Windows.Forms.Panel panelNavBarSchedule;
        private System.Windows.Forms.Panel panelNavBarTransaction;
        private System.Windows.Forms.Panel panelNavBarBooks;
        private Help help1;
        private Home home1;
        private Books books1;
        private Transaction transaction1;
        private Schedule shift1;
        private System.Windows.Forms.Panel panelInBetween1;
        private System.Windows.Forms.Panel panelInBetween2;
    }
}

