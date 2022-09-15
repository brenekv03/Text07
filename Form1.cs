using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                StreamWriter streamWriter = new StreamWriter("pomocnik.txt");
                while (!streamReader.EndOfStream)
                {
                    streamWriter.WriteLine(streamReader.ReadLine());
                    listBox1.Items.Add(streamReader.ReadLine());
                }
                streamReader.Close();
                streamWriter.Close();
                //File.Delete(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("pomocnik.txt");
            while(!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                line = line.ToLower();
                listBox2.Items.Add(line);
            }
        }
    }
}
