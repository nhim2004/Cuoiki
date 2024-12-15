namespace C_CuoiKi
{
    partial class FormQLDH
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            productBindingSource = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4 });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(465, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ProductID";
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn giá";
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lượng";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng";
            Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(96, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 303);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(607, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.OIP__4_1;
            button1.Location = new Point(406, 43);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(6, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 36);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(607, 288);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(447, 282);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 375);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 0;
            label3.Text = "Tổng hoá đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(300, 370);
            label4.Name = "label4";
            label4.Size = new Size(25, 30);
            label4.TabIndex = 6;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(121, 420);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 7;
            label5.Text = "Số tiền khách trả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(134, 466);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 8;
            label6.Text = "Tiền thối";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(301, 466);
            label7.Name = "label7";
            label7.Size = new Size(23, 25);
            label7.TabIndex = 9;
            label7.Text = "0";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(301, 420);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 34);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(237, 508);
            button2.Name = "button2";
            button2.Size = new Size(87, 38);
            button2.TabIndex = 11;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(723, 248);
            label8.Name = "label8";
            label8.Size = new Size(207, 22);
            label8.TabIndex = 12;
            label8.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(780, 101);
            label9.Name = "label9";
            label9.Size = new Size(73, 22);
            label9.TabIndex = 12;
            label9.Text = "BỘ LỌC";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Image = Properties.Resources.OIP__3_;
            button3.Location = new Point(1070, 374);
            button3.Name = "button3";
            button3.Size = new Size(26, 26);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormQLDH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 582);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormQLDH";
            Text = "FormQLDH";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Button button2;
        private Label label8;
        private Label label9;
        private BindingSource productBindingSource;
        private Button button3;
    }
}