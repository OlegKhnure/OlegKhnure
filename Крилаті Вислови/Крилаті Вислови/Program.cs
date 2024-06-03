using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крилаті_Вислови
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string curiositiesFilePath = "C:\\Users\\OLEG\\Desktop\\TRUE FORM OF HOMEWORK\\ООПro\\Курсова\\Крилаті Вислови\\Крилаті Вислови\\Курйози.txt";
            string historyFilePath = "C:\\Users\\OLEG\\Desktop\\TRUE FORM OF HOMEWORK\\ООПro\\Курсова\\Крилаті Вислови\\Крилаті Вислови\\Історія.txt";
            CuriositiesManager manager = new CuriositiesManager(curiositiesFilePath, historyFilePath);
            Application.Run(new MainForm(manager));
        }
    }
}
