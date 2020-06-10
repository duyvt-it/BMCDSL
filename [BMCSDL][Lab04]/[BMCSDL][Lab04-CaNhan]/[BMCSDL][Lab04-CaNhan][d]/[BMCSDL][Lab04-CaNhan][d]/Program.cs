using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BMCSDL__Lab04_CaNhan__d_ {
    static class Program {
        public static QuanLySinhVienDonGianEntities db = new QuanLySinhVienDonGianEntities();

        public static string username;
        public static string md5Pwd;
        public static string sha1Pwd;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
