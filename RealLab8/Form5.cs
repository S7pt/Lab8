using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab8.models;
using System.IO;

namespace RealLab8
{
    public partial class Form5 : Form
    {
        List<StorageCamera> storages = new List<StorageCamera>();
        public Form5()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                string textFromFile;
                string[] splitStrings;
                while (!sr.EndOfStream)
                {
                    textFromFile = sr.ReadLine();
                    if (textFromFile != "" && textFromFile != " ")
                    {
                        splitStrings = textFromFile.Split('|');
                        storages.Add(new StorageCamera(splitStrings[0], int.Parse(splitStrings[1]), int.Parse(splitStrings[2]), splitStrings[3], splitStrings[4]));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storages[int.Parse(textBox6.Text) - 1].storeDate = textBox1.Text;
            storages[int.Parse(textBox6.Text) - 1].baggageWeight = int.Parse(textBox2.Text);
            storages[int.Parse(textBox6.Text) - 1].storingDuration = int.Parse(textBox3.Text);
            storages[int.Parse(textBox6.Text) - 1].ownerNameAndSurname = textBox4.Text;
            storages[int.Parse(textBox6.Text) - 1].specialNotes = textBox5.Text;
        }
    }
}
