using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static decimal GetMoneyByHour(decimal hour)
        {
            decimal allMoney = 0;
            if (hour == 0) return allMoney;
            //50小时内为底薪
            if (hour <= 50) return allMoney;
            if (hour > 50)
            {
                if (hour <= 80)//51~80
                {
                    allMoney += (hour - 50) * 45;
                }
                else//大于80
                {
                    if (hour <= 100)//81~100
                    {
                        allMoney += 30 * 45 + (hour - 80) * 55;
                    }
                    else//大于100
                    {
                        allMoney += 30 * 45 + 20 * 55 + (hour - 100) * 65;
                    }
                }
            }
            return allMoney;
        }
    }
}
