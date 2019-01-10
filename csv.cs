using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Select10by10
{
    public partial class Form1 : Form
    {
        public class onesquare
        {
            public string name;
            public string[] subunit_name;
            public int[] geo_order;
            public int[] full;

        }
        public class onesquare_help
        {
            public string name;
            public string subunit_name;
            public int geo_order;

        }


        private static string[] ReadInLines(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            List<string> lines_list = new List<string>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {

                string last_char = line.Substring(line.Length - 1, 1);
                string line2;
                while (last_char != "\"")
                {
                    line2 = sr.ReadLine();
                    line = line + "\n" + line2;
                    last_char = line.Substring(line.Length - 1, 1);
                }

                lines_list.Add(line);

            }
            sr.Close();
            string[] lines_array = lines_list.ToArray();
            return lines_array;
        }

        private List<onesquare> CreateOneSquares(string filepath)
        {
            string[] lines_array = ReadInLines(filepath);
            List<onesquare> square_list = new List<onesquare>();
            if (lines_array[0] != "\"Topname\",\"Name\",\"geo_order\",\"Full\"")
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index");
                throw argEx;
            }

            for (int i = 1;i<lines_array.Length;i++)
            {
                lines_array[i] = lines_array[i].Substring(1, lines_array[i].Length - 2);
                string[] row = lines_array[i].Split(new string[] { "\",\"" }, StringSplitOptions.None);

                onesquare square1 = new onesquare();
                square1.name = row[0];
                square1.subunit_name = row[1].ToString().Split(';');

                square1.geo_order = Array.ConvertAll<string, int>(row[2].ToString().Split(';'), int.Parse);
               
                square1.full = Array.ConvertAll<string, int>(row[3].ToString().Split(';'), int.Parse);
                square_list.Add(square1);
            }
            return (square_list);
           
        }
    }
}
