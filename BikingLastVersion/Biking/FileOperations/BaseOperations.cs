using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biking.FileOperations
{
    public class BaseOperations
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public static string _path;
        public string DirectoryClick()
        {
            ofd.Filter = "XLSX|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _path = ofd.FileName;
                return _path;
            }
            else
            {
                string message = "Devi selezionare un file!";
                MessageBox.Show(message);
                return DirectoryClick();
            }
        }

    }
}
