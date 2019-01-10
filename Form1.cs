using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Select10by10
{
    public partial class Form1 : Form
    {


        class TwoColorButton : Button
        {
            public int stateCounter = 0;
            public int index;
            public string subunit;
            public string unit;
            public int geo_order;

            private Color[] states = new Color[] { Color.LightSkyBlue, Color.IndianRed, Color.LightGray };

            public TwoColorButton()
                : base()
            {
                this.BackColor = states[stateCounter];
                this.Click += this.clickHandler;
            }

            protected void clickHandler(object sender, EventArgs e)
            {
                if (stateCounter < 2)
                {
                    stateCounter++;
                }
                else
                {
                    stateCounter = 0;
                }

                this.BackColor = states[stateCounter];
            }
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void MakeButtons(onesquare square1)
        {

            Color[] states = new Color[] { Color.LightSkyBlue, Color.IndianRed, Color.LightGray };
            int lef1 = 65;
            int top = 100;
            int left = lef1;
            int count = 35;
            int index = new int();
            List<TwoColorButton> buttons = new List<TwoColorButton>();
            for (int i = 0; i < 100; i++)
            {
                if (square1.geo_order.Contains(i + 1))
                {
                    index = Array.IndexOf(square1.geo_order, i + 1);
                    TwoColorButton newButton = new TwoColorButton();
                    newButton.Name = "added_button_" + index.ToString();
                    newButton.index = i;
                    newButton.geo_order = square1.geo_order[index];
                    newButton.stateCounter = square1.full[index];
                    newButton.BackColor = states[square1.full[index]];
                    newButton.Width = 34;
                    newButton.Height = 34;
                    newButton.Text = square1.subunit_name[index].Split('@')[3];
                    newButton.subunit = square1.subunit_name[index];
                    newButton.unit = square1.name;
                    newButton.Left = left;
                    newButton.Top = top;
                    buttons.Add(newButton);
                    this.Controls.Add(newButton);
                }
                if ((i + 1) % 10 == 0)
                {
                    top = top + count;
                    left = lef1;
                }
                else
                {
                    left = left + count;
                }
            }
        }
        private void RemoveButtons()
        {
            for (int i = 0; i < 100; i++)
            {
                TwoColorButton b1 = Controls.Find("added_button_" + i.ToString(), true).FirstOrDefault() as TwoColorButton;
                if (b1 != null)
                {
                    this.Controls.Remove(b1);
                    b1.Dispose();
                }
            }
        }

        private void count_click(object sende, EventArgs e)
        {
            int count = Convert.ToInt32(Counter.Value);
            if (count > Counter.Maximum)
            {
                Counter.Value = Counter.Maximum;
            }
            if (count < 0)
            {
                Counter.Value = 0;
            }
            //Debug.WriteLine("counter:" + t1);
        }

        private void upload_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //{
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                try
                {
                    //List<onesquare> tab1 = CreateOneSquares(filePath);
                    List<onesquare> all_squares = CreateOneSquares(filePath);

                    onesquare sq1 = all_squares[0];
                    Counter.Maximum = all_squares.Count - 1;
                    Progress.Maximum = all_squares.Count - 1;
                    MakeButtons(sq1);
                    NextSave.Enabled = true;
                    Counter.Enabled = true;
                    GoTo.Enabled = true;
                    Back.Enabled = true;
                    upload.Tag = filePath;
                    // LABEL
                    current.Text = sq1.name;

                }
                catch (System.ArgumentException ex)
                {
                    upload.Tag = String.Empty;
                    MessageBox.Show("Not a valid file.", "Not a valid file.", MessageBoxButtons.OK);
                }
            }
            else
            {
                upload.Tag = String.Empty;
            }
         
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string[] lines_array = ReadInLines("C:\\Users\\senic\\Desktop\\lilongwe_1k_sample_complete_with_100m.kml");
            Debug.WriteLine(lines_array[0]);
              NextSave.Enabled = true;
              Counter.Enabled = true;
              GoTo.Enabled = true;

              List<onesquare> all_squares = CreateOneSquares("C:\\lilongwe_100m_for_emptyness_check.csv");
              onesquare sq1 = all_squares[0];
              Counter.Maximum = all_squares.Count;
              Progress.Maximum = all_squares.Count;
              MakeButtons(sq1);
              */
        }
    
        private void next_Click(object sender, EventArgs e)
        {
            // SAVE
            string unit = "";
            List<string> subunit_list = new List<string>();
            List<int> geo_order_list = new List<int>();
            List<int> full_list = new List<int>();


            for (int i = 0; i < 100; i++)
            {
                TwoColorButton b1 = Controls.Find("added_button_" + i.ToString(), true).FirstOrDefault() as TwoColorButton;
                if (b1 != null)
                {
                    unit = b1.unit;
                    subunit_list.Add(b1.subunit);
                    geo_order_list.Add(b1.geo_order);
                    full_list.Add(b1.stateCounter);
                }
            }
           
            string subunit = string.Join(";", subunit_list.ToArray());
            string geo_order = string.Join(";", Array.ConvertAll(geo_order_list.ToArray(), x => x.ToString()));
            string full = string.Join(";", Array.ConvertAll(full_list.ToArray(), x => x.ToString()));
            Debug.WriteLine(unit);
          
            //string[] lines = ReadInLines("C:\\lilongwe_100m_for_emptyness_check.csv");
            string[] lines = ReadInLines(upload.Tag.ToString());

            int j = 1;
            while (lines[j].Split(new string[] { "\",\"" }, StringSplitOptions.None)[0].Substring(1) != unit)
            {
                j++;
            }
            string paste = "\"" + string.Join("\",\"", new string[] { unit, subunit, geo_order, full }) + "\"";
            lines[j] = paste;


            using (System.IO.StreamWriter file =
                //new System.IO.StreamWriter("C:\\Users\\senic\\Desktop\\lilongwe_100m_for_emptyness_check_written.csv"))
                new System.IO.StreamWriter(upload.Tag.ToString()))
            {
                foreach (string line in lines)
                {

                    file.WriteLine(line);

                }
            }
            // NEXT
            if (Convert.ToInt32(Counter.Value)  + 1 <= Counter.Maximum)
            {
                Counter.Value = Convert.ToInt32(Counter.Value) + 1;
            }
            List<onesquare> all_squares = CreateOneSquares(upload.Tag.ToString());
            onesquare sq1 = all_squares[Convert.ToInt32(Counter.Value)];
            RemoveButtons();
            MakeButtons(sq1);

            // PROGRESS
            Progress.Value = Convert.ToInt32(Counter.Value);

            // LABEL
            current.Text = sq1.name;


        }

        private void GoTo_click(object sender, EventArgs e)
        {
            //List<onesquare> all_squares = CreateOneSquares("C:\\lilongwe_100m_for_emptyness_check.csv");
            List<onesquare> all_squares = CreateOneSquares(upload.Tag.ToString());
            onesquare sq1 = all_squares[Convert.ToInt32(Counter.Value)];
            RemoveButtons();
            MakeButtons(sq1);

            // PROGRESS
            Progress.Value = Convert.ToInt32(Counter.Value);

            // LABEL
            current.Text = sq1.name;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            List<onesquare> all_squares = CreateOneSquares(upload.Tag.ToString());
            if (Convert.ToInt32(Counter.Value) - 1 >= 0)
            {
                Counter.Value = Convert.ToInt32(Counter.Value) - 1;
            }
            onesquare sq1 = all_squares[Convert.ToInt32(Counter.Value)];
            RemoveButtons();
            MakeButtons(sq1);

            // PROGRESS
            Progress.Value = Convert.ToInt32(Counter.Value);

            // LABEL
            current.Text = sq1.name;

        }
    }
}
