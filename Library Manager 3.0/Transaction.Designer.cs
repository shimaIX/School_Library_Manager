namespace Library_Manager
{
    partial class Transaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInBetweenVertical = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderStudentNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCYS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateBorrowed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnDescending = new System.Windows.Forms.RadioButton();
            this.rdBtnAscending = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnCategory = new System.Windows.Forms.RadioButton();
            this.rdBtnDateAdded = new System.Windows.Forms.RadioButton();
            this.rdBtnYear = new System.Windows.Forms.RadioButton();
            this.rdBtnAuthor = new System.Windows.Forms.RadioButton();
            this.rdBtnTitle = new System.Windows.Forms.RadioButton();
            this.rdBtnDDS = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.panelInBetweenHorizontal = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblEditList = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Location = new System.Drawing.Point(3, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(925, 452);
            this.panelContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panelInBetweenVertical);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 452);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(694, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 452);
            this.panel2.TabIndex = 0;
            // 
            // panelInBetweenVertical
            // 
            this.panelInBetweenVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.panelInBetweenVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInBetweenVertical.Location = new System.Drawing.Point(691, 0);
            this.panelInBetweenVertical.Name = "panelInBetweenVertical";
            this.panelInBetweenVertical.Size = new System.Drawing.Size(4, 452);
            this.panelInBetweenVertical.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStudentNumber,
            this.columnHeaderName,
            this.columnHeaderCYS,
            this.columnHeaderBook,
            this.columnHeaderDateBorrowed,
            this.columnHeaderDateReturned});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(691, 452);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStudentNumber
            // 
            this.columnHeaderStudentNumber.Text = "Student Number";
            this.columnHeaderStudentNumber.Width = 89;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name of Student";
            this.columnHeaderName.Width = 168;
            // 
            // columnHeaderCYS
            // 
            this.columnHeaderCYS.Text = "Course/Year/Section";
            this.columnHeaderCYS.Width = 115;
            // 
            // columnHeaderBook
            // 
            this.columnHeaderBook.Text = "Borrowed Book";
            this.columnHeaderBook.Width = 175;
            // 
            // columnHeaderDateBorrowed
            // 
            this.columnHeaderDateBorrowed.Text = "Date Borrowed";
            this.columnHeaderDateBorrowed.Width = 100;
            // 
            // columnHeaderDateReturned
            // 
            this.columnHeaderDateReturned.Text = "Date Returned";
            this.columnHeaderDateReturned.Width = 100;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.panelTitle.Controls.Add(this.btnFind);
            this.panelTitle.Controls.Add(this.groupBox2);
            this.panelTitle.Controls.Add(this.groupBox1);
            this.panelTitle.Controls.Add(this.btnSort);
            this.panelTitle.Controls.Add(this.panelInBetweenHorizontal);
            this.panelTitle.Controls.Add(this.btnCancel);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.textBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(231, 292);
            this.panelTitle.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnFind.Location = new System.Drawing.Point(179, 81);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(45, 23);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnDescending);
            this.groupBox2.Controls.Add(this.rdBtnAscending);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 46);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // rdBtnDescending
            // 
            this.rdBtnDescending.AutoSize = true;
            this.rdBtnDescending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnDescending.Location = new System.Drawing.Point(111, 19);
            this.rdBtnDescending.Name = "rdBtnDescending";
            this.rdBtnDescending.Size = new System.Drawing.Size(89, 20);
            this.rdBtnDescending.TabIndex = 1;
            this.rdBtnDescending.TabStop = true;
            this.rdBtnDescending.Text = "Descending";
            this.rdBtnDescending.UseVisualStyleBackColor = true;
            // 
            // rdBtnAscending
            // 
            this.rdBtnAscending.AutoSize = true;
            this.rdBtnAscending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnAscending.Location = new System.Drawing.Point(6, 19);
            this.rdBtnAscending.Name = "rdBtnAscending";
            this.rdBtnAscending.Size = new System.Drawing.Size(81, 20);
            this.rdBtnAscending.TabIndex = 0;
            this.rdBtnAscending.TabStop = true;
            this.rdBtnAscending.Text = "Ascending";
            this.rdBtnAscending.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnCategory);
            this.groupBox1.Controls.Add(this.rdBtnDateAdded);
            this.groupBox1.Controls.Add(this.rdBtnYear);
            this.groupBox1.Controls.Add(this.rdBtnAuthor);
            this.groupBox1.Controls.Add(this.rdBtnTitle);
            this.groupBox1.Controls.Add(this.rdBtnDDS);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            // 
            // rdBtnCategory
            // 
            this.rdBtnCategory.AutoSize = true;
            this.rdBtnCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnCategory.Location = new System.Drawing.Point(6, 65);
            this.rdBtnCategory.Name = "rdBtnCategory";
            this.rdBtnCategory.Size = new System.Drawing.Size(57, 20);
            this.rdBtnCategory.TabIndex = 5;
            this.rdBtnCategory.TabStop = true;
            this.rdBtnCategory.Text = "C/Y/S";
            this.rdBtnCategory.UseVisualStyleBackColor = true;
            // 
            // rdBtnDateAdded
            // 
            this.rdBtnDateAdded.AutoSize = true;
            this.rdBtnDateAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnDateAdded.Location = new System.Drawing.Point(111, 67);
            this.rdBtnDateAdded.Name = "rdBtnDateAdded";
            this.rdBtnDateAdded.Size = new System.Drawing.Size(105, 20);
            this.rdBtnDateAdded.TabIndex = 4;
            this.rdBtnDateAdded.TabStop = true;
            this.rdBtnDateAdded.Text = "Date Returned";
            this.rdBtnDateAdded.UseVisualStyleBackColor = true;
            // 
            // rdBtnYear
            // 
            this.rdBtnYear.AutoSize = true;
            this.rdBtnYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnYear.Location = new System.Drawing.Point(111, 44);
            this.rdBtnYear.Name = "rdBtnYear";
            this.rdBtnYear.Size = new System.Drawing.Size(106, 20);
            this.rdBtnYear.TabIndex = 3;
            this.rdBtnYear.TabStop = true;
            this.rdBtnYear.Text = "Date Borrowed";
            this.rdBtnYear.UseVisualStyleBackColor = true;
            // 
            // rdBtnAuthor
            // 
            this.rdBtnAuthor.AutoSize = true;
            this.rdBtnAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnAuthor.Location = new System.Drawing.Point(6, 42);
            this.rdBtnAuthor.Name = "rdBtnAuthor";
            this.rdBtnAuthor.Size = new System.Drawing.Size(58, 20);
            this.rdBtnAuthor.TabIndex = 2;
            this.rdBtnAuthor.TabStop = true;
            this.rdBtnAuthor.Text = "Name";
            this.rdBtnAuthor.UseVisualStyleBackColor = true;
            // 
            // rdBtnTitle
            // 
            this.rdBtnTitle.AutoSize = true;
            this.rdBtnTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnTitle.Location = new System.Drawing.Point(6, 19);
            this.rdBtnTitle.Name = "rdBtnTitle";
            this.rdBtnTitle.Size = new System.Drawing.Size(89, 20);
            this.rdBtnTitle.TabIndex = 1;
            this.rdBtnTitle.TabStop = true;
            this.rdBtnTitle.Text = "Student No.";
            this.rdBtnTitle.UseVisualStyleBackColor = true;
            // 
            // rdBtnDDS
            // 
            this.rdBtnDDS.AutoSize = true;
            this.rdBtnDDS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.rdBtnDDS.Location = new System.Drawing.Point(111, 20);
            this.rdBtnDDS.Name = "rdBtnDDS";
            this.rdBtnDDS.Size = new System.Drawing.Size(50, 20);
            this.rdBtnDDS.TabIndex = 0;
            this.rdBtnDDS.TabStop = true;
            this.rdBtnDDS.Text = "Book";
            this.rdBtnDDS.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnSort.Location = new System.Drawing.Point(135, 249);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(89, 23);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // panelInBetweenHorizontal
            // 
            this.panelInBetweenHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panelInBetweenHorizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInBetweenHorizontal.Location = new System.Drawing.Point(0, 289);
            this.panelInBetweenHorizontal.Name = "panelInBetweenHorizontal";
            this.panelInBetweenHorizontal.Size = new System.Drawing.Size(231, 3);
            this.panelInBetweenHorizontal.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnCancel.Location = new System.Drawing.Point(8, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Library_Manager.Properties.Resources.icons8_search_64;
            this.pictureBox1.Location = new System.Drawing.Point(8, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.lblTitle.Location = new System.Drawing.Point(78, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnChangeUpdate);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.lblEditList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 158);
            this.panel3.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnDelete.Location = new System.Drawing.Point(31, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChangeUpdate
            // 
            this.btnChangeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.btnChangeUpdate.FlatAppearance.BorderSize = 0;
            this.btnChangeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnChangeUpdate.Location = new System.Drawing.Point(31, 83);
            this.btnChangeUpdate.Name = "btnChangeUpdate";
            this.btnChangeUpdate.Size = new System.Drawing.Size(168, 23);
            this.btnChangeUpdate.TabIndex = 10;
            this.btnChangeUpdate.Text = "CHANGE / UPDATE";
            this.btnChangeUpdate.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.btnNew.Location = new System.Drawing.Point(31, 54);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // lblEditList
            // 
            this.lblEditList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditList.AutoSize = true;
            this.lblEditList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.lblEditList.Location = new System.Drawing.Point(58, 12);
            this.lblEditList.Name = "lblEditList";
            this.lblEditList.Size = new System.Drawing.Size(115, 23);
            this.lblEditList.TabIndex = 8;
            this.lblEditList.Text = "Transaction";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panelContainer);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(931, 461);
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInBetweenVertical;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCYS;
        private System.Windows.Forms.ColumnHeader columnHeaderBook;
        private System.Windows.Forms.ColumnHeader columnHeaderDateBorrowed;
        private System.Windows.Forms.ColumnHeader columnHeaderDateReturned;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnDescending;
        private System.Windows.Forms.RadioButton rdBtnAscending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnCategory;
        private System.Windows.Forms.RadioButton rdBtnDateAdded;
        private System.Windows.Forms.RadioButton rdBtnYear;
        private System.Windows.Forms.RadioButton rdBtnAuthor;
        private System.Windows.Forms.RadioButton rdBtnTitle;
        private System.Windows.Forms.RadioButton rdBtnDDS;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel panelInBetweenHorizontal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblEditList;
    }
}
