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
using System.IO;

namespace QuizPrg282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbMain.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = @".\Untitled.txt";
            string details;
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((details = sr.ReadLine()) != null)
                    {
                        lbMain.Items.Add(details);
                    }
                }
            }
            else MessageBox.Show("File does not exist");
        }
    }
}
