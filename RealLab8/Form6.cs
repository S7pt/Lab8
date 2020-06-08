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
using Lab8.models;
using lab8._2.finale;

namespace RealLab8
{
    public partial class Form6 : Form
    {
        List<StorageCamera> storages = new List<StorageCamera>();
        public Form6()
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

        private void SortByDuration_Click(object sender, EventArgs e)
        {
            SortByDuration sorter = new SortByDuration();
            storages.Sort(sorter);
            File.WriteAllText("text.txt", string.Empty);
            using (StreamWriter sw = new StreamWriter("text.txt"))
            {
                foreach (StorageCamera storageCamera in storages)
                {
                    sw.WriteLine(storageCamera);
                }
            }
            MessageBox.Show("Your list was successfully sorted by duration");
        }

        private void SortByWeight_Click(object sender, EventArgs e)
        {
            SortByWeight sorter = new SortByWeight();
            storages.Sort(sorter);
            File.WriteAllText("text.txt", string.Empty);
            using (StreamWriter sw = new StreamWriter("text.txt"))
            {
                foreach (StorageCamera storageCamera in storages)
                {
                    sw.WriteLine(storageCamera);
                }
            }
            MessageBox.Show("Your list was successfully sorted by weight");
        }

        private void SortByInitials_Click(object sender, EventArgs e)
        {
            SortByNameAndSurname sorter = new SortByNameAndSurname();
            storages.Sort(sorter);
            File.WriteAllText("text.txt", string.Empty);
            using (StreamWriter sw = new StreamWriter("text.txt"))
            {
                foreach (StorageCamera storageCamera in storages)
                {
                    sw.WriteLine(storageCamera);
                }
            }
            MessageBox.Show("Your list was successfully sorted by initials");
        }
    }
}
