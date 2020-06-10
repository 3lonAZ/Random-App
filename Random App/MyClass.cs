using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Random_App
{
    public class MyClass
    {
        public string[] ReadTextFile(string filename)
        {
            return File.ReadAllLines(filename);
        }
        public string RandomItems(ListBox.ObjectCollection items)
        {
            Random rdm = new Random();
            int index = rdm.Next(0, items.Count);
            return items[index].ToString();
        }
        public int RandomNumber(int min,int max)
        {
            Random rdm = new Random();
            return rdm.Next(min,max); 
        }
        // Thanks for watching :)
    }
}
