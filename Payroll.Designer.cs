namespace PayrollProj
{
    partial class Payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll));
            DeleteBtn = new Button();
            SaveBtn = new Button();
            SalaryDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            EmpNameTb = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            MonthYearCb = new ComboBox();
            BonusId2 = new TextBox();
            label16 = new Label();
            HoursWorkedTb = new TextBox();
            ComputeBtn = new Button();
            label14 = new Label();
            label15 = new Label();
            label13 = new Label();
            PresentTb = new TextBox();
            ExcuseTb = new TextBox();
            AbsentTb = new TextBox();
            AttNumCb = new ComboBox();
            label4 = new Label();
            BonusTb = new TextBox();
            BonusIdCb = new ComboBox();
            label8 = new Label();
            BalanceTb = new TextBox();
            label11 = new Label();
            label10 = new Label();
            BaseSalaryTb = new TextBox();
            label12 = new Label();
            EmpIdCb = new ComboBox();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
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
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(482, 272);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 19;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(368, 272);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // SalaryDGV
            // 
            SalaryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalaryDGV.BackgroundColor = Color.White;
            SalaryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            SalaryDGV.Location = new Point(43, 307);
            SalaryDGV.Name = "SalaryDGV";
            SalaryDGV.RowHeadersWidth = 51;
            SalaryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalaryDGV.Size = new Size(1016, 405);
            SalaryDGV.TabIndex = 16;
            SalaryDGV.CellContentClick += SalaryDGV_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SalNum";
            Column1.HeaderText = "Salary ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "EmpId";
            Column2.HeaderText = "Employee ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BId";
            Column3.HeaderText = "Bonus ID";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "AttNum";
            Column4.HeaderText = "DTR ID";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "EmpName";
            Column5.HeaderText = "Name";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "EmpBasSal";
            Column6.HeaderText = "Base Salary";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "EmpBonus";
            Column7.HeaderText = "Bonus";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "EmpTax";
            Column8.HeaderText = "Tax";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.DataPropertyName = "EmpBalance";
            Column9.HeaderText = "Balance";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.DataPropertyName = "SalPeriod";
            Column10.HeaderText = "Salary Period";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Enabled = false;
            EmpNameTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameTb.Location = new Point(169, 91);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(195, 31);
            EmpNameTb.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(185, 147);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 11;
            label9.Text = "Period";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(MonthYearCb);
            panel1.Controls.Add(BonusId2);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(HoursWorkedTb);
            panel1.Controls.Add(ComputeBtn);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(PresentTb);
            panel1.Controls.Add(ExcuseTb);
            panel1.Controls.Add(AbsentTb);
            panel1.Controls.Add(AttNumCb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BonusTb);
            panel1.Controls.Add(BonusIdCb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(BalanceTb);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(BaseSalaryTb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(EmpIdCb);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(SalaryDGV);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(228, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 739);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // MonthYearCb
            // 
            MonthYearCb.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonthYearCb.FormattingEnabled = true;
            MonthYearCb.Location = new Point(185, 170);
            MonthYearCb.Name = "MonthYearCb";
            MonthYearCb.Size = new Size(314, 29);
            MonthYearCb.TabIndex = 42;
            MonthYearCb.SelectionChangeCommitted += MonthYearCb_SelectionChangeCommitted;
            // 
            // BonusId2
            // 
            BonusId2.Enabled = false;
            BonusId2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BonusId2.Location = new Point(555, 128);
            BonusId2.Name = "BonusId2";
            BonusId2.Size = new Size(130, 31);
            BonusId2.TabIndex = 41;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(907, 220);
            label16.Name = "label16";
            label16.Size = new Size(126, 20);
            label16.TabIndex = 40;
            label16.Text = "Hours Worked";
            // 
            // HoursWorkedTb
            // 
            HoursWorkedTb.Enabled = false;
            HoursWorkedTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoursWorkedTb.Location = new Point(907, 244);
            HoursWorkedTb.Name = "HoursWorkedTb";
            HoursWorkedTb.Size = new Size(127, 31);
            HoursWorkedTb.TabIndex = 39;
            // 
            // ComputeBtn
            // 
            ComputeBtn.Location = new Point(591, 272);
            ComputeBtn.Name = "ComputeBtn";
            ComputeBtn.Size = new Size(94, 29);
            ComputeBtn.TabIndex = 38;
            ComputeBtn.Text = "Compute";
            ComputeBtn.UseVisualStyleBackColor = true;
            ComputeBtn.Click += ComputeBtn_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(766, 147);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 37;
            label14.Text = "Present";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(907, 147);
            label15.Name = "label15";
            label15.Size = new Size(67, 20);
            label15.TabIndex = 36;
            label15.Text = "Absent";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(907, 68);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 35;
            label13.Text = "Excused";
            // 
            // PresentTb
            // 
            PresentTb.Enabled = false;
            PresentTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PresentTb.Location = new Point(766, 171);
            PresentTb.Name = "PresentTb";
            PresentTb.Size = new Size(127, 31);
            PresentTb.TabIndex = 34;
            // 
            // ExcuseTb
            // 
            ExcuseTb.Enabled = false;
            ExcuseTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcuseTb.Location = new Point(907, 92);
            ExcuseTb.Name = "ExcuseTb";
            ExcuseTb.Size = new Size(127, 31);
            ExcuseTb.TabIndex = 33;
            // 
            // AbsentTb
            // 
            AbsentTb.Enabled = false;
            AbsentTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AbsentTb.Location = new Point(907, 171);
            AbsentTb.Name = "AbsentTb";
            AbsentTb.Size = new Size(127, 31);
            AbsentTb.TabIndex = 32;
            // 
            // AttNumCb
            // 
            AttNumCb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttNumCb.FormattingEnabled = true;
            AttNumCb.Location = new Point(764, 92);
            AttNumCb.Name = "AttNumCb";
            AttNumCb.Size = new Size(127, 31);
            AttNumCb.TabIndex = 31;
            AttNumCb.SelectionChangeCommitted += AttNumCb_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(764, 68);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 30;
            label4.Text = "Attendance";
            // 
            // BonusTb
            // 
            BonusTb.Enabled = false;
            BonusTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BonusTb.Location = new Point(555, 170);
            BonusTb.Name = "BonusTb";
            BonusTb.Size = new Size(130, 31);
            BonusTb.TabIndex = 29;
            // 
            // BonusIdCb
            // 
            BonusIdCb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BonusIdCb.FormattingEnabled = true;
            BonusIdCb.Items.AddRange(new object[] { "Male", "Female" });
            BonusIdCb.Location = new Point(555, 91);
            BonusIdCb.Name = "BonusIdCb";
            BonusIdCb.Size = new Size(190, 31);
            BonusIdCb.TabIndex = 28;
            BonusIdCb.SelectionChangeCommitted += BonusIdCb_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 147);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 27;
            label8.Text = "Balance";
            // 
            // BalanceTb
            // 
            BalanceTb.Enabled = false;
            BalanceTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BalanceTb.Location = new Point(43, 170);
            BalanceTb.Name = "BalanceTb";
            BalanceTb.Size = new Size(127, 31);
            BalanceTb.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(557, 67);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 25;
            label11.Text = "Bonus";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(382, 68);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 23;
            label10.Text = "Base Salary";
            // 
            // BaseSalaryTb
            // 
            BaseSalaryTb.Enabled = false;
            BaseSalaryTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BaseSalaryTb.Location = new Point(382, 91);
            BaseSalaryTb.Name = "BaseSalaryTb";
            BaseSalaryTb.Size = new Size(153, 31);
            BaseSalaryTb.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(41, 68);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 21;
            label12.Text = "EmpId";
            // 
            // EmpIdCb
            // 
            EmpIdCb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpIdCb.FormattingEnabled = true;
            EmpIdCb.Items.AddRange(new object[] { "Male", "Female" });
            EmpIdCb.Location = new Point(41, 91);
            EmpIdCb.Name = "EmpIdCb";
            EmpIdCb.Size = new Size(112, 31);
            EmpIdCb.TabIndex = 20;
            EmpIdCb.SelectionChangeCommitted += EmpIdCb_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(169, 68);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumOrchid;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(pictureBox7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 56);
            panel2.TabIndex = 0;
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
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(131, 366);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(45, 402);
            panel4.Name = "panel4";
            panel4.Size = new Size(67, 5);
            panel4.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 379);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 32;
            label6.Text = "PayRoll";
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
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
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
            label5.TabIndex = 30;
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
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
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
            label3.TabIndex = 28;
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
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 147);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 26;
            label2.Text = "Employee";
            label2.Click += label2_Click;
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
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
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
            label1.TabIndex = 22;
            label1.Text = "Home";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(24, 543);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(165, 196);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 33;
            pictureBox8.TabStop = false;
            pictureBox8.WaitOnLoad = true;
            // 
            // Payroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Payroll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll";
            Load += Payroll_Load;
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private Button DeleteBtn;
        private Button SaveBtn;
        private DataGridView SalaryDGV;
        private TextBox EmpNameTb;
        private Label label9;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Label label11;
        private Label label10;
        private TextBox BaseSalaryTb;
        private Label label12;
        private ComboBox EmpIdCb;
        private Label label8;
        private TextBox BalanceTb;
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
        private ComboBox BonusIdCb;
        private TextBox BonusTb;
        private TextBox PresentTb;
        private TextBox ExcuseTb;
        private TextBox AbsentTb;
        private ComboBox AttNumCb;
        private Label label4;
        private Label label14;
        private Label label15;
        private Label label13;
        private Button ComputeBtn;
        private Label label16;
        private TextBox HoursWorkedTb;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox8;
        private TextBox BonusId2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private ComboBox MonthYearCb;
    }
}