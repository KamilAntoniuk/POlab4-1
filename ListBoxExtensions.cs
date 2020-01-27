using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POlab4
{
    public static class ListBoxExtensions
    {
        public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName)
        {
            System.IO.File.WriteAllLines(FileName, (from Row in sender.Cast<string>() select Row).ToArray());
        }
        public static void LoadFromFile(this ListBox.ObjectCollection sender, string FileName)
        {
            sender.AddRange(System.IO.File.ReadAllLines(FileName));
        }
    }
}
