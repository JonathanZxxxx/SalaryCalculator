namespace SalaryCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IsInternshipCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IsMonthComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.DayTextBox1 = new System.Windows.Forms.TextBox();
            this.DayLabel1 = new System.Windows.Forms.Label();
            this.DayLabel2 = new System.Windows.Forms.Label();
            this.DayTextBox2 = new System.Windows.Forms.TextBox();
            this.ExcuteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者郑鑫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.邮箱zxjndxoutlookcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubJonathanZxxxxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本号V10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布日期2019年8月19日ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsInternshipCheckBox
            // 
            this.IsInternshipCheckBox.AutoSize = true;
            this.IsInternshipCheckBox.Location = new System.Drawing.Point(96, 310);
            this.IsInternshipCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IsInternshipCheckBox.Name = "IsInternshipCheckBox";
            this.IsInternshipCheckBox.Size = new System.Drawing.Size(75, 21);
            this.IsInternshipCheckBox.TabIndex = 0;
            this.IsInternshipCheckBox.Text = "是否转正";
            this.IsInternshipCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(93, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "工资计算规则";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(93, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "0~50h：未转正底薪2500元，转正底薪3600元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(93, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "51~80h：45元/h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "81~100h：55元/h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = ">100h：65元/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "额外激励：转正后满80h500元";
            // 
            // IsMonthComboBox
            // 
            this.IsMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsMonthComboBox.FormattingEnabled = true;
            this.IsMonthComboBox.Location = new System.Drawing.Point(160, 358);
            this.IsMonthComboBox.Name = "IsMonthComboBox";
            this.IsMonthComboBox.Size = new System.Drawing.Size(121, 25);
            this.IsMonthComboBox.TabIndex = 7;
            this.IsMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.IsMonthComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "月薪/日薪";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "已工作时间";
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(167, 409);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(100, 23);
            this.MonthTextBox.TabIndex = 10;
            // 
            // DayTextBox1
            // 
            this.DayTextBox1.Location = new System.Drawing.Point(119, 460);
            this.DayTextBox1.Name = "DayTextBox1";
            this.DayTextBox1.Size = new System.Drawing.Size(100, 23);
            this.DayTextBox1.TabIndex = 11;
            // 
            // DayLabel1
            // 
            this.DayLabel1.AutoSize = true;
            this.DayLabel1.Location = new System.Drawing.Point(93, 463);
            this.DayLabel1.Name = "DayLabel1";
            this.DayLabel1.Size = new System.Drawing.Size(20, 17);
            this.DayLabel1.TabIndex = 12;
            this.DayLabel1.Text = "从";
            // 
            // DayLabel2
            // 
            this.DayLabel2.AutoSize = true;
            this.DayLabel2.Location = new System.Drawing.Point(225, 463);
            this.DayLabel2.Name = "DayLabel2";
            this.DayLabel2.Size = new System.Drawing.Size(20, 17);
            this.DayLabel2.TabIndex = 13;
            this.DayLabel2.Text = "至";
            // 
            // DayTextBox2
            // 
            this.DayTextBox2.Location = new System.Drawing.Point(250, 460);
            this.DayTextBox2.Name = "DayTextBox2";
            this.DayTextBox2.Size = new System.Drawing.Size(100, 23);
            this.DayTextBox2.TabIndex = 14;
            // 
            // ExcuteButton
            // 
            this.ExcuteButton.Location = new System.Drawing.Point(408, 532);
            this.ExcuteButton.Name = "ExcuteButton";
            this.ExcuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExcuteButton.TabIndex = 15;
            this.ExcuteButton.Text = "Money!";
            this.ExcuteButton.UseVisualStyleBackColor = true;
            this.ExcuteButton.Click += new System.EventHandler(this.ExcuteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.版本信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者郑鑫ToolStripMenuItem,
            this.邮箱zxjndxoutlookcomToolStripMenuItem,
            this.gitHubJonathanZxxxxToolStripMenuItem,
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 作者郑鑫ToolStripMenuItem
            // 
            this.作者郑鑫ToolStripMenuItem.Name = "作者郑鑫ToolStripMenuItem";
            this.作者郑鑫ToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.作者郑鑫ToolStripMenuItem.Text = "作者:ZhengXin";
            // 
            // 邮箱zxjndxoutlookcomToolStripMenuItem
            // 
            this.邮箱zxjndxoutlookcomToolStripMenuItem.Name = "邮箱zxjndxoutlookcomToolStripMenuItem";
            this.邮箱zxjndxoutlookcomToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.邮箱zxjndxoutlookcomToolStripMenuItem.Text = "邮箱:zxjndx@outlook.com";
            // 
            // gitHubJonathanZxxxxToolStripMenuItem
            // 
            this.gitHubJonathanZxxxxToolStripMenuItem.Name = "gitHubJonathanZxxxxToolStripMenuItem";
            this.gitHubJonathanZxxxxToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.gitHubJonathanZxxxxToolStripMenuItem.Text = "GitHub:JonathanZxxxx";
            // 
            // bloghttpswwwcnblogscomzxxxxToolStripMenuItem
            // 
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem.Name = "bloghttpswwwcnblogscomzxxxxToolStripMenuItem";
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem.Text = "Blog:https://www.cnblogs.com/zxxxx";
            // 
            // 版本信息ToolStripMenuItem
            // 
            this.版本信息ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.版本信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本号V10ToolStripMenuItem,
            this.发布日期2019年8月19日ToolStripMenuItem});
            this.版本信息ToolStripMenuItem.Name = "版本信息ToolStripMenuItem";
            this.版本信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.版本信息ToolStripMenuItem.Text = "版本信息";
            // 
            // 版本号V10ToolStripMenuItem
            // 
            this.版本号V10ToolStripMenuItem.Name = "版本号V10ToolStripMenuItem";
            this.版本号V10ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.版本号V10ToolStripMenuItem.Text = "版本号:V1.1";
            this.版本号V10ToolStripMenuItem.Click += new System.EventHandler(this.版本号V10ToolStripMenuItem_Click);
            // 
            // 发布日期2019年8月19日ToolStripMenuItem
            // 
            this.发布日期2019年8月19日ToolStripMenuItem.Name = "发布日期2019年8月19日ToolStripMenuItem";
            this.发布日期2019年8月19日ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.发布日期2019年8月19日ToolStripMenuItem.Text = "发布日期:2019年9月30日";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 637);
            this.Controls.Add(this.ExcuteButton);
            this.Controls.Add(this.DayTextBox2);
            this.Controls.Add(this.DayLabel2);
            this.Controls.Add(this.DayLabel1);
            this.Controls.Add(this.DayTextBox1);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IsMonthComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsInternshipCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "工资计算器——For最可爱的小仙女~";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsInternshipCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IsMonthComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.TextBox DayTextBox1;
        private System.Windows.Forms.Label DayLabel1;
        private System.Windows.Forms.Label DayLabel2;
        private System.Windows.Forms.TextBox DayTextBox2;
        private System.Windows.Forms.Button ExcuteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者郑鑫ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邮箱zxjndxoutlookcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubJonathanZxxxxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloghttpswwwcnblogscomzxxxxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本号V10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布日期2019年8月19日ToolStripMenuItem;
    }
}

