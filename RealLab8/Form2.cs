using Lab8.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RealLab8
{
    public partial class Form2 : Form
    {
        List<StorageCamera> storages = new List<StorageCamera>();
        public Form2()
        {
            InitializeComponent();
            using(StreamReader sr=new StreamReader("text.txt"))
            {
                string textFromFile;
                string[] splitStrings;
                while (!sr.EndOfStream)
                {
                    textFromFile = sr.ReadLine();
                    if(textFromFile!=""&&textFromFile!=" ")
                    {
                        splitStrings = textFromFile.Split('|');
                        storages.Add(new StorageCamera(splitStrings[0], int.Parse(splitStrings[1]), int.Parse(splitStrings[2]), splitStrings[3], splitStrings[4]));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storages.Add(new StorageCamera(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text, textBox5.Text));
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
