namespace elect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            label8 = new Label();
            button3 = new Button();
            tbNew = new TextBox();
            label7 = new Label();
            tbOld = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbTien = new TextBox();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.CausesValidation = false;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 789);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(862, 748);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tính theo số điện";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(tbNew);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tbOld);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(tbTien);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(856, 742);
            panel2.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 468);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(0, 28);
            label8.TabIndex = 18;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(351, 623);
            button3.Name = "button3";
            button3.Size = new Size(119, 55);
            button3.TabIndex = 17;
            button3.Text = "Lưu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tbNew
            // 
            tbNew.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNew.Location = new Point(477, 393);
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(239, 38);
            tbNew.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(154, 393);
            label7.Name = "label7";
            label7.Size = new Size(108, 31);
            label7.TabIndex = 15;
            label7.Text = "Số kí mới";
            // 
            // tbOld
            // 
            tbOld.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOld.Location = new Point(477, 286);
            tbOld.Name = "tbOld";
            tbOld.Size = new Size(239, 38);
            tbOld.TabIndex = 14;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(351, 533);
            button2.Name = "button2";
            button2.Size = new Size(119, 55);
            button2.TabIndex = 13;
            button2.Text = "Tính toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(216, 59);
            label3.Name = "label3";
            label3.Size = new Size(459, 46);
            label3.TabIndex = 12;
            label3.Text = "TÍNH TIỀN THEO HÓA ĐƠN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 286);
            label5.Name = "label5";
            label5.Size = new Size(92, 31);
            label5.TabIndex = 11;
            label5.Text = "Số kí cũ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(154, 184);
            label6.Name = "label6";
            label6.Size = new Size(157, 31);
            label6.TabIndex = 10;
            label6.Text = "Tổng tiền nộp";
            // 
            // tbTien
            // 
            tbTien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTien.Location = new Point(477, 184);
            tbTien.Name = "tbTien";
            tbTien.Size = new Size(239, 38);
            tbTien.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(862, 748);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tính theo hóa đơn";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 742);
            panel1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(477, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 38);
            textBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(367, 460);
            button1.Name = "button1";
            button1.Size = new Size(119, 55);
            button1.TabIndex = 13;
            button1.Text = "Tính toán";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(216, 59);
            label4.Name = "label4";
            label4.Size = new Size(459, 46);
            label4.TabIndex = 12;
            label4.Text = "TÍNH TIỀN THEO HÓA ĐƠN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 320);
            label2.Name = "label2";
            label2.Size = new Size(292, 31);
            label2.TabIndex = 11;
            label2.Text = "Số kí điện người thuê dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 184);
            label1.Name = "label1";
            label1.Size = new Size(157, 31);
            label1.TabIndex = 10;
            label1.Text = "Tổng tiền nộp";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(477, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 38);
            textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(870, 789);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính tiền điện";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        public TextBox textBox2;
        private Label label4;
        private Label label2;
        private Label label1;
        public TextBox textBox1;
        private Panel panel2;
        public TextBox tbOld;
        private Button button2;
        private Label label3;
        private Label label5;
        private Label label6;
        public TextBox tbTien;
        private Label label7;
        public TextBox tbNew;
        private Button button1;
        private Button button3;
        private Label label8;
    }
}
