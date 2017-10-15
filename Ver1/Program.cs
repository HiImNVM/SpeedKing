using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using Ver1.GUI;
namespace Ver1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Format DateTime theo US
            CultureInfo culture = new CultureInfo("en-US", true);
            culture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd";
            culture.DateTimeFormat.LongDatePattern = "yyyy/MM/dd HH:mm:ss";
            culture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            culture.DateTimeFormat.DateSeparator = "/";
            Application.CurrentCulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangNhap());
        }
    }
}
