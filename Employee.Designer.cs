namespace PayrollProj
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            pictureBox7 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            EmpSalTb = new TextBox();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            EmpDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            EmpBasSal = new DataGridViewTextBoxColumn();
            label11 = new Label();
            EmpAddTb = new TextBox();
            label10 = new Label();
            EmpContTb = new TextBox();
            label9 = new Label();
            EmpDOB = new DateTimePicker();
            label8 = new Label();
            EmpGenCb = new ComboBox();
            label7 = new Label();
            EmpNameTb = new TextBox();
            pictureBox6 = new PictureBox();
            panel4 = new Panel();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1033, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumOrchid;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 56);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EmpSalTb);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(EmpContTb);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(EmpDOB);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(EmpGenCb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(228, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 739);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 136);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 25;
            label4.Text = "Base Salary";
            // 
            // EmpSalTb
            // 
            EmpSalTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpSalTb.Location = new Point(230, 159);
            EmpSalTb.Name = "EmpSalTb";
            EmpSalTb.Size = new Size(194, 31);
            EmpSalTb.TabIndex = 24;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(478, 209);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 19;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(361, 207);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 29);
            EditBtn.TabIndex = 18;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(230, 207);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EmpDGV
            // 
            EmpDGV.AllowUserToAddRows = false;
            EmpDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmpDGV.BackgroundColor = Color.White;
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, EmpBasSal });
            EmpDGV.Location = new Point(26, 244);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersWidth = 51;
            EmpDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmpDGV.Size = new Size(1054, 359);
            EmpDGV.TabIndex = 16;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "EmpId";
            Column1.HeaderText = "Employee ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "EmpName";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "EmpGen";
            Column3.HeaderText = "Gender";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "EmpDOB";
            Column4.HeaderText = "Date of Birth";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "EmpCont";
            Column5.HeaderText = "Contact";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "EmpAdd";
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // EmpBasSal
            // 
            EmpBasSal.DataPropertyName = "EmpBasSal";
            EmpBasSal.HeaderText = "Base Salary";
            EmpBasSal.MinimumWidth = 6;
            EmpBasSal.Name = "EmpBasSal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(509, 68);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 15;
            label11.Text = "Address";
            // 
            // EmpAddTb
            // 
            EmpAddTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpAddTb.Location = new Point(509, 91);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(268, 31);
            EmpAddTb.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(315, 68);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 13;
            label10.Text = "Contact #";
            // 
            // EmpContTb
            // 
            EmpContTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpContTb.Location = new Point(315, 91);
            EmpContTb.Name = "EmpContTb";
            EmpContTb.Size = new Size(175, 31);
            EmpContTb.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(443, 136);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 11;
            label9.Text = "Date of Birth";
            // 
            // EmpDOB
            // 
            EmpDOB.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDOB.Location = new Point(443, 159);
            EmpDOB.Name = "EmpDOB";
            EmpDOB.Size = new Size(324, 28);
            EmpDOB.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 136);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 9;
            label8.Text = "Gender";
            // 
            // EmpGenCb
            // 
            EmpGenCb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpGenCb.FormattingEnabled = true;
            EmpGenCb.Items.AddRange(new object[] { "Male", "Female" });
            EmpGenCb.Location = new Point(41, 159);
            EmpGenCb.Name = "EmpGenCb";
            EmpGenCb.Size = new Size(175, 31);
            EmpGenCb.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 68);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameTb.Location = new Point(41, 91);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(252, 31);
            EmpNameTb.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(131, 366);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            pictureBox6.WaitOnLoad = true;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(26, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(88, 5);
            panel4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 379);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 20;
            label6.Text = "PayRoll";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(131, 279);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            pictureBox5.WaitOnLoad = true;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 298);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 18;
            label5.Text = "Bonus";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(131, 202);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.WaitOnLoad = true;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 220);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 14;
            label3.Text = "DTR";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(131, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 147);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 12;
            label2.Text = "Employee";
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 68);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 8;
            label1.Text = "Home";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(24, 543);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(165, 196);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            pictureBox8.WaitOnLoad = true;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MediumOrchid;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1320, 739);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(panel4);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox7;
        private Panel panel2;
        private Panel panel1;
        private ComboBox EmpGenCb;
        private Label label7;
        private TextBox EmpNameTb;
        private Label label9;
        private DateTimePicker EmpDOB;
        private Label label8;
        private Label label11;
        private TextBox EmpAddTb;
        private Label label10;
        private TextBox EmpContTb;
        private DataGridView EmpDGV;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private PictureBox pictureBox6;
        private Panel panel4;
        private Label label6;
        private PictureBox pictureBox5;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private TextBox EmpSalTb;
        private PictureBox pictureBox8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn EmpBasSal;
    }
}