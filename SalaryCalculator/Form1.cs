using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExcuteButton_Click(object sender, EventArgs e)
        {
            //底薪
            decimal basicSalary = 2500;
            //激励
            decimal motivateSalary = 0;
            //工资
            decimal allMonery = 0;
            if (IsInternshipCheckBox.Checked)
            {
                basicSalary = 3600;
            }
            //0月薪1日薪
            var select = (int)IsMonthComboBox.SelectedValue;
            //正浮点数
            var regexStr = @"^[1-9]\d{0,13}(\.\d{0,4})?$";
            if (select == 0)
            {
                if (string.IsNullOrWhiteSpace(MonthTextBox.Text))
                {
                    MessageBox.Show("请输入工作时长数！");
                    return;
                }
                if (!Regex.IsMatch(MonthTextBox.Text, regexStr))
                {
                    MessageBox.Show("请输入正确的工作时长数！");
                    return;
                }
                decimal hour = Convert.ToDecimal(MonthTextBox.Text);
                if (hour >= 80 && IsInternshipCheckBox.Checked)
                {
                    motivateSalary = 500;
                }
                allMonery = basicSalary + motivateSalary + Program.GetMoneyByHour(hour);
                MessageBox.Show($"这个月已经赚了{allMonery}元啦，许老师棒棒哒~");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(DayTextBox1.Text) || string.IsNullOrWhiteSpace(DayTextBox2.Text))
                {
                    MessageBox.Show("请输入工作时长范围数！");
                    return;
                }
                if (!Regex.IsMatch(DayTextBox1.Text, regexStr) || !Regex.IsMatch(DayTextBox2.Text, regexStr))
                {
                    MessageBox.Show("请输入正确的工作时长范围数！");
                    return;
                }
                decimal hour1 = Convert.ToDecimal(DayTextBox1.Text);
                decimal hour2 = Convert.ToDecimal(DayTextBox2.Text);
                if (hour2 > 80 && IsInternshipCheckBox.Checked)
                {
                    motivateSalary = 500;
                }
                if (hour2 <= 50)
                {
                    MessageBox.Show($"这个月的工作时长还没满50小时，只有底薪{basicSalary}元哦，许老师继续加油~");
                }
                else
                {
                    allMonery = Program.GetMoneyByHour(hour2) - Program.GetMoneyByHour(hour1);
                    MessageBox.Show($"今天已经赚了{allMonery}元啦，许老师棒棒哒~");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var selectDic = new Dictionary<int, string>();
            selectDic.Add(0, "月薪");
            selectDic.Add(1, "日薪");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = selectDic;
            IsMonthComboBox.DataSource = bindingSource;
            IsMonthComboBox.ValueMember = "Key";
            IsMonthComboBox.DisplayMember = "Value";
            DayLabel1.Hide();
            DayLabel2.Hide();
            DayTextBox1.Hide();
            DayTextBox2.Hide();
            //默认未转正
            IsInternshipCheckBox.Checked = true;
        }

        private void IsMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //日薪/月薪切换
            var select = IsMonthComboBox.SelectedValue;
            if (select.GetType().Name == "Int32" && (int)select == 0)
            {
                MonthTextBox.Show();
                DayLabel1.Hide();
                DayLabel2.Hide();
                DayTextBox1.Hide();
                DayTextBox2.Hide();
                DayTextBox1.Text = "";
                DayTextBox2.Text = "";
            }
            else
            {
                MonthTextBox.Hide();
                MonthTextBox.Text = "";
                DayLabel1.Show();
                DayLabel2.Show();
                DayTextBox1.Show();
                DayTextBox2.Show();
            }
        }
    }
}
