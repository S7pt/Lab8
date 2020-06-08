using Lab8.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RealLab8
{
    public partial class Form3 : Form
    {
        List<StorageCamera> storages = new List<StorageCamera>();
        public Form3()
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
            storages.RemoveAt(int.Parse(textBox1.Text) - 1);
            File.WriteAllText("text.txt", string.Empty);
            using (StreamWriter sw = new StreamWriter("text.txt"))
            {
                foreach (StorageCamera storageCamera in storages)
                {
                    sw.WriteLine(storageCamera);
                }
            }
        }
    }
}
