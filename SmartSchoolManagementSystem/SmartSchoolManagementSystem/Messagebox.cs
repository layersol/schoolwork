using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolManagementSystem
{
    class Messagebox
    {
        public static void show()
        {
            System.Windows.Forms.MessageBox.Show("This Record Not Found.", "Warning",System.Windows.Forms.MessageBoxButtons.OKCancel);
        }
        public static void DB()
        {
            System.Windows.Forms.MessageBox.Show("Warning","Database Connectivity Error Please Check Cable And Database Server.", System.Windows.Forms.MessageBoxButtons.RetryCancel );

        }

    }
}
