
namespace PayrollProj
{
    partial class DTR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DTR));
            panel1 = new Panel();
            TimeInPicker = new DateTimePicker();
            label13 = new Label();
            label4 = new Label();
            TimeOutPicker = new DateTimePicker();
            label11 = new Label();
            ExcuseTb = new TextBox();
            label8 = new Label();
            PresentTb = new TextBox();
            label10 = new Label();
            AbsentTb = new TextBox();
            label12 = new Label();
            EmpIdCb = new ComboBox();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            AttendanceDGV = new DataGridView();
            label9 = new Label();
            AttDate = new DateTimePicker();
            label7 = new Label();
            EmpNameTb = new TextBox();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox8 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(TimeInPicker);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TimeOutPicker);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(ExcuseTb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(PresentTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(AbsentTb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(EmpIdCb);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(AttendanceDGV);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(AttDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(228, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 739);
            panel1.TabIndex = 35;
            // 
            // TimeInPicker
            // 
            TimeInPicker.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeInPicker.Format = DateTimePickerFormat.Time;
            TimeInPicker.Location = new Point(407, 157);
            TimeInPicker.Name = "TimeInPicker";
            TimeInPicker.Size = new Size(133, 27);
            TimeInPicker.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(560, 130);
            label13.Name = "label13";
            label13.Size = new Size(83, 20);
            label13.TabIndex = 31;
            label13.Text = "Time Out";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(407, 130);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 30;
            label4.Text = "Time In";
            // 
            // TimeOutPicker
            // 
            TimeOutPicker.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeOutPicker.Format = DateTimePickerFormat.Time;
            TimeOutPicker.Location = new Point(560, 157);
            TimeOutPicker.Name = "TimeOutPicker";
            TimeOutPicker.Size = new Size(133, 27);
            TimeOutPicker.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(686, 68);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 27;
            label11.Text = "Excuse";
            // 
            // ExcuseTb
            // 
            ExcuseTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcuseTb.Location = new Point(686, 91);
            ExcuseTb.Name = "ExcuseTb";
            ExcuseTb.Size = new Size(81, 31);
            ExcuseTb.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(576, 68);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 25;
            label8.Text = "Present";
            label8.Click += label8_Click;
            // 
            // PresentTb
            // 
            PresentTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PresentTb.Location = new Point(576, 91);
            PresentTb.Name = "PresentTb";
            PresentTb.Size = new Size(81, 31);
            PresentTb.TabIndex = 24;
            PresentTb.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(459, 68);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 23;
            label10.Text = "Absent";
            // 
            // AbsentTb
            // 
            AbsentTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AbsentTb.Location = new Point(459, 91);
            AbsentTb.Name = "AbsentTb";
            AbsentTb.Size = new Size(81, 31);
            AbsentTb.TabIndex = 22;
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
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(554, 209);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 19;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(429, 207);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 29);
            EditBtn.TabIndex = 18;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(306, 207);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // AttendanceDGV
            // 
            AttendanceDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttendanceDGV.BackgroundColor = Color.White;
            AttendanceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceDGV.GridColor = Color.White;
            AttendanceDGV.Location = new Point(15, 244);
            AttendanceDGV.Name = "AttendanceDGV";
            AttendanceDGV.RowHeadersWidth = 51;
            AttendanceDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AttendanceDGV.Size = new Size(1054, 466);
            AttendanceDGV.TabIndex = 16;
            AttendanceDGV.CellContentClick += AttendanceDGV_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 129);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 11;
            label9.Text = "Period";
            // 
            // AttDate
            // 
            AttDate.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttDate.Location = new Point(41, 152);
            AttDate.Name = "AttDate";
            AttDate.Size = new Size(324, 28);
            AttDate.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(180, 68);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Enabled = false;
            EmpNameTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameTb.Location = new Point(180, 91);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(252, 31);
            EmpNameTb.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 68);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 36;
            label1.Text = "Home";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(131, 366);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 45;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 147);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 40;
            label2.Text = "Employee";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(131, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 220);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 42;
            label3.Text = "DTR";
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(131, 202);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 298);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 44;
            label5.Text = "Bonus";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(131, 279);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 43;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 379);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 46;
            label6.Text = "PayRoll";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(66, 244);
            panel4.Name = "panel4";
            panel4.Size = new Size(45, 5);
            panel4.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(24, 543);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(165, 196);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 47;
            pictureBox8.TabStop = false;
            pictureBox8.WaitOnLoad = true;
            // 
            // DTR
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
            Name = "DTR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DTR";
            Load += DTR_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceDGV).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Panel panel1;
        private Label label10;
        private TextBox AbsentTb;
        private Label label12;
        private ComboBox EmpIdCb;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private DataGridView AttendanceDGV;
        private Label label9;
        private DateTimePicker AttDate;
        private Label label7;
        private TextBox EmpNameTb;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Label label8;
        private TextBox PresentTb;
        private Label label11;
        private TextBox ExcuseTb;
        private DateTimePicker TimeOutPicker;
        private Label label13;
        private Label label4;
        private DateTimePicker TimeInPicker;
        private Label label1;
        private PictureBox pictureBox6;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox8;
    }
}