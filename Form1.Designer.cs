namespace FractalTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FractalPict = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CordXY = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mondelbrodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Draw = new System.Windows.Forms.Button();
            this.progressBarFractalDraw = new System.Windows.Forms.ProgressBar();
            this.Iterations = new System.Windows.Forms.TextBox();
            this.traclBarCnstReal = new System.Windows.Forms.TrackBar();
            this.trackBarCnstImg = new System.Windows.Forms.TrackBar();
            this.fractal1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPict)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traclBarCnstReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCnstImg)).BeginInit();
            this.SuspendLayout();
            // 
            // FractalPict
            // 
            this.FractalPict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FractalPict.BackgroundImage")));
            this.FractalPict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FractalPict.Location = new System.Drawing.Point(11, 38);
            this.FractalPict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FractalPict.Name = "FractalPict";
            this.FractalPict.Size = new System.Drawing.Size(874, 539);
            this.FractalPict.TabIndex = 1;
            this.FractalPict.TabStop = false;
            this.FractalPict.Paint += new System.Windows.Forms.PaintEventHandler(this.FractalPict_Paint);
            this.FractalPict.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FractalPict_MouseDown);
            this.FractalPict.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FractalPict_MouseMove);
            this.FractalPict.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FractalPict_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CordXY
            // 
            this.CordXY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CordXY.Location = new System.Drawing.Point(11, 581);
            this.CordXY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CordXY.Name = "CordXY";
            this.CordXY.Size = new System.Drawing.Size(117, 15);
            this.CordXY.TabIndex = 4;
            this.CordXY.TextChanged += new System.EventHandler(this.CordXY_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(898, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "R:";
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(898, 127);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(23, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "B:";
            this.textBox2.WordWrap = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(898, 100);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "G:";
            this.textBox3.WordWrap = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(925, 72);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "255";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(925, 127);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(41, 22);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "255";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(925, 100);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(41, 22);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "255";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(898, 163);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 22);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Constant:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(967, 163);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(32, 22);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "2";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1035, 100);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 22);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "12";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1035, 127);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(41, 22);
            this.textBox10.TabIndex = 18;
            this.textBox10.Text = "0";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1035, 72);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(41, 22);
            this.textBox11.TabIndex = 17;
            this.textBox11.Text = "12";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1007, 100);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(23, 22);
            this.textBox12.TabIndex = 16;
            this.textBox12.Text = "G:";
            this.textBox12.WordWrap = false;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1007, 127);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(23, 22);
            this.textBox13.TabIndex = 15;
            this.textBox13.Text = "B:";
            this.textBox13.WordWrap = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(1007, 72);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(23, 22);
            this.textBox14.TabIndex = 14;
            this.textBox14.Text = "R:";
            this.textBox14.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(895, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fractal Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(984, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Background Color";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1019, 216);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(57, 22);
            this.textBox15.TabIndex = 22;
            this.textBox15.Text = "0";
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(899, 216);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(57, 22);
            this.textBox16.TabIndex = 23;
            this.textBox16.Text = "0";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Constant Real";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1016, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Constant IMg";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Real Cord:";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Location = new System.Drawing.Point(213, 581);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(75, 15);
            this.textBox17.TabIndex = 29;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged_1);
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Location = new System.Drawing.Point(296, 581);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(75, 15);
            this.textBox18.TabIndex = 30;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(911, 542);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(98, 35);
            this.Reset.TabIndex = 31;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 27);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mondelbrodToolStripMenuItem,
            this.juliaToolStripMenuItem,
            this.fractal1ToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(124, 24);
            this.toolStripDropDownButton1.Text = "Possible Fractal";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // mondelbrodToolStripMenuItem
            // 
            this.mondelbrodToolStripMenuItem.Name = "mondelbrodToolStripMenuItem";
            this.mondelbrodToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.mondelbrodToolStripMenuItem.Text = "Mondelbrod";
            this.mondelbrodToolStripMenuItem.Click += new System.EventHandler(this.mondelbrodToolStripMenuItem_Click);
            // 
            // juliaToolStripMenuItem
            // 
            this.juliaToolStripMenuItem.Name = "juliaToolStripMenuItem";
            this.juliaToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.juliaToolStripMenuItem.Text = "Julia";
            this.juliaToolStripMenuItem.Click += new System.EventHandler(this.juliaToolStripMenuItem_Click);
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(1019, 542);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(98, 35);
            this.Draw.TabIndex = 33;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // progressBarFractalDraw
            // 
            this.progressBarFractalDraw.Location = new System.Drawing.Point(392, 580);
            this.progressBarFractalDraw.Name = "progressBarFractalDraw";
            this.progressBarFractalDraw.Size = new System.Drawing.Size(369, 15);
            this.progressBarFractalDraw.TabIndex = 34;
            this.progressBarFractalDraw.Click += new System.EventHandler(this.progressBarFractalDraw_Click);
            // 
            // Iterations
            // 
            this.Iterations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Iterations.Location = new System.Drawing.Point(767, 580);
            this.Iterations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(118, 15);
            this.Iterations.TabIndex = 35;
            this.Iterations.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // traclBarCnstReal
            // 
            this.traclBarCnstReal.AutoSize = false;
            this.traclBarCnstReal.Location = new System.Drawing.Point(899, 243);
            this.traclBarCnstReal.Name = "traclBarCnstReal";
            this.traclBarCnstReal.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.traclBarCnstReal.RightToLeftLayout = true;
            this.traclBarCnstReal.Size = new System.Drawing.Size(57, 250);
            this.traclBarCnstReal.TabIndex = 10;
            this.traclBarCnstReal.UseWaitCursor = true;
            this.traclBarCnstReal.Scroll += new System.EventHandler(this.traclBarCnstReal_Scroll);
            // 
            // trackBarCnstImg
            // 
            this.trackBarCnstImg.AutoSize = false;
            this.trackBarCnstImg.Location = new System.Drawing.Point(1019, 243);
            this.trackBarCnstImg.Name = "trackBarCnstImg";
            this.trackBarCnstImg.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarCnstImg.Size = new System.Drawing.Size(57, 250);
            this.trackBarCnstImg.TabIndex = 37;
            this.trackBarCnstImg.Scroll += new System.EventHandler(this.trackBarCnstImg_Scroll);
            // 
            // fractal1ToolStripMenuItem
            // 
            this.fractal1ToolStripMenuItem.Name = "fractal1ToolStripMenuItem";
            this.fractal1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fractal1ToolStripMenuItem.Text = "Fractal1";
            this.fractal1ToolStripMenuItem.Click += new System.EventHandler(this.fractal1ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 607);
            this.Controls.Add(this.trackBarCnstImg);
            this.Controls.Add(this.traclBarCnstReal);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.progressBarFractalDraw);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CordXY);
            this.Controls.Add(this.FractalPict);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FractalPict)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traclBarCnstReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCnstImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox FractalPict;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox CordXY;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.ProgressBar progressBarFractalDraw;
        private System.Windows.Forms.TextBox Iterations;
        private System.Windows.Forms.TrackBar traclBarCnstReal;
        private System.Windows.Forms.TrackBar trackBarCnstImg;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mondelbrodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fractal1ToolStripMenuItem;
    }
}

