namespace 奥运会
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumCountry = new System.Windows.Forms.Label();
            this.lblNumMen = new System.Windows.Forms.Label();
            this.lblNumWomen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtNumMen = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumWomen = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumCountry = new System.Windows.Forms.MaskedTextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumAward5 = new System.Windows.Forms.NumericUpDown();
            this.NumAward4 = new System.Windows.Forms.NumericUpDown();
            this.NumAward3 = new System.Windows.Forms.NumericUpDown();
            this.NumAward2 = new System.Windows.Forms.NumericUpDown();
            this.NumAward1 = new System.Windows.Forms.NumericUpDown();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblAward5 = new System.Windows.Forms.Label();
            this.lblAward4 = new System.Windows.Forms.Label();
            this.lblAward3 = new System.Windows.Forms.Label();
            this.lblAward2 = new System.Windows.Forms.Label();
            this.lblAward1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnAwardNUm5 = new System.Windows.Forms.RadioButton();
            this.rbtnAwardNum3 = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSportNum = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FindNumEvent2 = new System.Windows.Forms.NumericUpDown();
            this.gpx4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FindNumCountry1 = new System.Windows.Forms.NumericUpDown();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindNumEvent1 = new System.Windows.Forms.NumericUpDown();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.cboxPrintAccord = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindNumEvent2)).BeginInit();
            this.gpx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindNumCountry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindNumEvent1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCountry
            // 
            this.lblNumCountry.AutoSize = true;
            this.lblNumCountry.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumCountry.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNumCountry.Location = new System.Drawing.Point(22, 21);
            this.lblNumCountry.Name = "lblNumCountry";
            this.lblNumCountry.Size = new System.Drawing.Size(69, 20);
            this.lblNumCountry.TabIndex = 0;
            this.lblNumCountry.Text = "国家数";
            // 
            // lblNumMen
            // 
            this.lblNumMen.AutoSize = true;
            this.lblNumMen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumMen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNumMen.Location = new System.Drawing.Point(22, 52);
            this.lblNumMen.Name = "lblNumMen";
            this.lblNumMen.Size = new System.Drawing.Size(109, 20);
            this.lblNumMen.TabIndex = 2;
            this.lblNumMen.Text = "男子项目数";
            // 
            // lblNumWomen
            // 
            this.lblNumWomen.AutoSize = true;
            this.lblNumWomen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumWomen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNumWomen.Location = new System.Drawing.Point(22, 87);
            this.lblNumWomen.Name = "lblNumWomen";
            this.lblNumWomen.Size = new System.Drawing.Size(109, 20);
            this.lblNumWomen.TabIndex = 4;
            this.lblNumWomen.Text = "女子项目数";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.mtxtNumMen);
            this.groupBox1.Controls.Add(this.mtxtNumWomen);
            this.groupBox1.Controls.Add(this.mtxtNumCountry);
            this.groupBox1.Controls.Add(this.btnNum);
            this.groupBox1.Controls.Add(this.lblNumCountry);
            this.groupBox1.Controls.Add(this.lblNumWomen);
            this.groupBox1.Controls.Add(this.lblNumMen);
            this.groupBox1.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "比赛规模";
            // 
            // mtxtNumMen
            // 
            this.mtxtNumMen.Location = new System.Drawing.Point(156, 43);
            this.mtxtNumMen.Mask = "99999";
            this.mtxtNumMen.Name = "mtxtNumMen";
            this.mtxtNumMen.Size = new System.Drawing.Size(100, 29);
            this.mtxtNumMen.TabIndex = 9;
            this.mtxtNumMen.ValidatingType = typeof(int);
            // 
            // mtxtNumWomen
            // 
            this.mtxtNumWomen.Location = new System.Drawing.Point(156, 78);
            this.mtxtNumWomen.Mask = "99999";
            this.mtxtNumWomen.Name = "mtxtNumWomen";
            this.mtxtNumWomen.Size = new System.Drawing.Size(100, 29);
            this.mtxtNumWomen.TabIndex = 8;
            this.mtxtNumWomen.ValidatingType = typeof(int);
            // 
            // mtxtNumCountry
            // 
            this.mtxtNumCountry.Location = new System.Drawing.Point(156, 12);
            this.mtxtNumCountry.Mask = "99999";
            this.mtxtNumCountry.Name = "mtxtNumCountry";
            this.mtxtNumCountry.Size = new System.Drawing.Size(100, 29);
            this.mtxtNumCountry.TabIndex = 7;
            this.mtxtNumCountry.ValidatingType = typeof(int);
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNum.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum.Location = new System.Drawing.Point(87, 113);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(79, 29);
            this.btnNum.TabIndex = 6;
            this.btnNum.Text = "Submit";
            this.btnNum.UseVisualStyleBackColor = false;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.NumAward5);
            this.groupBox2.Controls.Add(this.NumAward4);
            this.groupBox2.Controls.Add(this.NumAward3);
            this.groupBox2.Controls.Add(this.NumAward2);
            this.groupBox2.Controls.Add(this.NumAward1);
            this.groupBox2.Controls.Add(this.btnPre);
            this.groupBox2.Controls.Add(this.btnFinished);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.lblAward5);
            this.groupBox2.Controls.Add(this.lblAward4);
            this.groupBox2.Controls.Add(this.lblAward3);
            this.groupBox2.Controls.Add(this.lblAward2);
            this.groupBox2.Controls.Add(this.lblAward1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rbtnAwardNUm5);
            this.groupBox2.Controls.Add(this.rbtnAwardNum3);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.lblSportNum);
            this.groupBox2.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(11, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 427);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "比赛结果";
            // 
            // NumAward5
            // 
            this.NumAward5.Location = new System.Drawing.Point(127, 237);
            this.NumAward5.Name = "NumAward5";
            this.NumAward5.Size = new System.Drawing.Size(91, 29);
            this.NumAward5.TabIndex = 27;
            // 
            // NumAward4
            // 
            this.NumAward4.Location = new System.Drawing.Point(127, 202);
            this.NumAward4.Name = "NumAward4";
            this.NumAward4.Size = new System.Drawing.Size(91, 29);
            this.NumAward4.TabIndex = 26;
            // 
            // NumAward3
            // 
            this.NumAward3.Location = new System.Drawing.Point(126, 167);
            this.NumAward3.Name = "NumAward3";
            this.NumAward3.Size = new System.Drawing.Size(92, 29);
            this.NumAward3.TabIndex = 25;
            // 
            // NumAward2
            // 
            this.NumAward2.Location = new System.Drawing.Point(127, 132);
            this.NumAward2.Name = "NumAward2";
            this.NumAward2.Size = new System.Drawing.Size(91, 29);
            this.NumAward2.TabIndex = 24;
            // 
            // NumAward1
            // 
            this.NumAward1.Location = new System.Drawing.Point(126, 97);
            this.NumAward1.Name = "NumAward1";
            this.NumAward1.Size = new System.Drawing.Size(92, 29);
            this.NumAward1.TabIndex = 23;
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPre.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPre.Location = new System.Drawing.Point(35, 277);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(78, 29);
            this.btnPre.TabIndex = 22;
            this.btnPre.Text = "Pre";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFinished.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFinished.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFinished.Location = new System.Drawing.Point(87, 317);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(93, 29);
            this.btnFinished.TabIndex = 21;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(119, 277);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 29);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblAward5
            // 
            this.lblAward5.AutoSize = true;
            this.lblAward5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAward5.Location = new System.Drawing.Point(6, 245);
            this.lblAward5.Name = "lblAward5";
            this.lblAward5.Size = new System.Drawing.Size(59, 21);
            this.lblAward5.TabIndex = 19;
            this.lblAward5.Text = "第5名";
            // 
            // lblAward4
            // 
            this.lblAward4.AutoSize = true;
            this.lblAward4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAward4.Location = new System.Drawing.Point(6, 210);
            this.lblAward4.Name = "lblAward4";
            this.lblAward4.Size = new System.Drawing.Size(59, 21);
            this.lblAward4.TabIndex = 17;
            this.lblAward4.Text = "第4名";
            // 
            // lblAward3
            // 
            this.lblAward3.AutoSize = true;
            this.lblAward3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAward3.Location = new System.Drawing.Point(6, 175);
            this.lblAward3.Name = "lblAward3";
            this.lblAward3.Size = new System.Drawing.Size(60, 21);
            this.lblAward3.TabIndex = 15;
            this.lblAward3.Text = "第3名";
            // 
            // lblAward2
            // 
            this.lblAward2.AutoSize = true;
            this.lblAward2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAward2.Location = new System.Drawing.Point(6, 140);
            this.lblAward2.Name = "lblAward2";
            this.lblAward2.Size = new System.Drawing.Size(59, 21);
            this.lblAward2.TabIndex = 13;
            this.lblAward2.Text = "第2名";
            // 
            // lblAward1
            // 
            this.lblAward1.AutoSize = true;
            this.lblAward1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAward1.Location = new System.Drawing.Point(6, 105);
            this.lblAward1.Name = "lblAward1";
            this.lblAward1.Size = new System.Drawing.Size(55, 21);
            this.lblAward1.TabIndex = 11;
            this.lblAward1.Text = "第1名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "获奖国家";
            // 
            // rbtnAwardNUm5
            // 
            this.rbtnAwardNUm5.AutoSize = true;
            this.rbtnAwardNUm5.Location = new System.Drawing.Point(126, 49);
            this.rbtnAwardNUm5.Name = "rbtnAwardNUm5";
            this.rbtnAwardNUm5.Size = new System.Drawing.Size(40, 25);
            this.rbtnAwardNUm5.TabIndex = 4;
            this.rbtnAwardNUm5.Text = "5";
            this.rbtnAwardNUm5.UseVisualStyleBackColor = true;
            this.rbtnAwardNUm5.CheckedChanged += new System.EventHandler(this.rbtnAwardNUm2_CheckedChanged);
            // 
            // rbtnAwardNum3
            // 
            this.rbtnAwardNum3.AutoSize = true;
            this.rbtnAwardNum3.Location = new System.Drawing.Point(50, 49);
            this.rbtnAwardNum3.Name = "rbtnAwardNum3";
            this.rbtnAwardNum3.Size = new System.Drawing.Size(41, 25);
            this.rbtnAwardNum3.TabIndex = 3;
            this.rbtnAwardNum3.Text = "3";
            this.rbtnAwardNum3.UseVisualStyleBackColor = true;
            this.rbtnAwardNum3.CheckedChanged += new System.EventHandler(this.rbtnAwardNum_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblGender.Location = new System.Drawing.Point(122, 25);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 21);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "男子项目";
            // 
            // lblSportNum
            // 
            this.lblSportNum.AutoSize = true;
            this.lblSportNum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSportNum.Location = new System.Drawing.Point(6, 25);
            this.lblSportNum.Name = "lblSportNum";
            this.lblSportNum.Size = new System.Drawing.Size(95, 21);
            this.lblSportNum.TabIndex = 0;
            this.lblSportNum.Text = "比赛项目1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.gpx4);
            this.groupBox3.Controls.Add(this.txtPrint);
            this.groupBox3.Controls.Add(this.cboxPrintAccord);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(291, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 606);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出结果";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtScore2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.FindNumEvent2);
            this.groupBox4.Location = new System.Drawing.Point(7, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 137);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "按项目编号查询";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(173, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "项目成绩";
            // 
            // txtScore2
            // 
            this.txtScore2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtScore2.Location = new System.Drawing.Point(133, 33);
            this.txtScore2.Multiline = true;
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScore2.Size = new System.Drawing.Size(357, 98);
            this.txtScore2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "项目编号";
            // 
            // FindNumEvent2
            // 
            this.FindNumEvent2.Location = new System.Drawing.Point(4, 67);
            this.FindNumEvent2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FindNumEvent2.Name = "FindNumEvent2";
            this.FindNumEvent2.Size = new System.Drawing.Size(92, 29);
            this.FindNumEvent2.TabIndex = 30;
            this.FindNumEvent2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FindNumEvent2.ValueChanged += new System.EventHandler(this.FindNumEvent2_ValueChanged);
            // 
            // gpx4
            // 
            this.gpx4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gpx4.Controls.Add(this.label3);
            this.gpx4.Controls.Add(this.label5);
            this.gpx4.Controls.Add(this.FindNumCountry1);
            this.gpx4.Controls.Add(this.txtScore1);
            this.gpx4.Controls.Add(this.label4);
            this.gpx4.Controls.Add(this.FindNumEvent1);
            this.gpx4.Location = new System.Drawing.Point(7, 357);
            this.gpx4.Name = "gpx4";
            this.gpx4.Size = new System.Drawing.Size(490, 100);
            this.gpx4.TabIndex = 33;
            this.gpx4.TabStop = false;
            this.gpx4.Text = "按国家编号查询";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "国家编号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(279, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "项目成绩";
            // 
            // FindNumCountry1
            // 
            this.FindNumCountry1.Location = new System.Drawing.Point(11, 68);
            this.FindNumCountry1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FindNumCountry1.Name = "FindNumCountry1";
            this.FindNumCountry1.Size = new System.Drawing.Size(92, 29);
            this.FindNumCountry1.TabIndex = 28;
            this.FindNumCountry1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FindNumCountry1.ValueChanged += new System.EventHandler(this.FindNumCountry1_ValueChanged);
            // 
            // txtScore1
            // 
            this.txtScore1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtScore1.Location = new System.Drawing.Point(283, 68);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(192, 29);
            this.txtScore1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(147, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "项目编号";
            // 
            // FindNumEvent1
            // 
            this.FindNumEvent1.Location = new System.Drawing.Point(151, 68);
            this.FindNumEvent1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FindNumEvent1.Name = "FindNumEvent1";
            this.FindNumEvent1.Size = new System.Drawing.Size(92, 29);
            this.FindNumEvent1.TabIndex = 30;
            this.FindNumEvent1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FindNumEvent1.ValueChanged += new System.EventHandler(this.FindNumEvent1_ValueChanged);
            // 
            // txtPrint
            // 
            this.txtPrint.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrint.Location = new System.Drawing.Point(24, 68);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrint.Size = new System.Drawing.Size(458, 283);
            this.txtPrint.TabIndex = 3;
            // 
            // cboxPrintAccord
            // 
            this.cboxPrintAccord.FormattingEnabled = true;
            this.cboxPrintAccord.Items.AddRange(new object[] {
            "按国家编号排序输出",
            "按国家总分排序输出",
            "按国家男子团体总分排序输出",
            "按国家女子团体总分排序输出"});
            this.cboxPrintAccord.Location = new System.Drawing.Point(205, 23);
            this.cboxPrintAccord.Name = "cboxPrintAccord";
            this.cboxPrintAccord.Size = new System.Drawing.Size(277, 29);
            this.cboxPrintAccord.TabIndex = 2;
            this.cboxPrintAccord.SelectedIndexChanged += new System.EventHandler(this.cboxPrintAccord_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "输出顺序依照：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAward1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindNumEvent2)).EndInit();
            this.gpx4.ResumeLayout(false);
            this.gpx4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindNumCountry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindNumEvent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumCountry;
        private System.Windows.Forms.Label lblNumMen;
        private System.Windows.Forms.Label lblNumWomen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.MaskedTextBox mtxtNumMen;
        private System.Windows.Forms.MaskedTextBox mtxtNumWomen;
        private System.Windows.Forms.MaskedTextBox mtxtNumCountry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSportNum;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnAwardNum3;
        private System.Windows.Forms.RadioButton rbtnAwardNUm5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAward1;
        private System.Windows.Forms.Label lblAward5;
        private System.Windows.Forms.Label lblAward4;
        private System.Windows.Forms.Label lblAward3;
        private System.Windows.Forms.Label lblAward2;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxPrintAccord;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.NumericUpDown NumAward1;
        private System.Windows.Forms.NumericUpDown NumAward5;
        private System.Windows.Forms.NumericUpDown NumAward4;
        private System.Windows.Forms.NumericUpDown NumAward3;
        private System.Windows.Forms.NumericUpDown NumAward2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FindNumCountry1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.NumericUpDown FindNumEvent1;
        private System.Windows.Forms.GroupBox gpx4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown FindNumEvent2;
    }
}

