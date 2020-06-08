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

namespace RealLab8
{
    public partial class Form4 : Form
    {
        List<StorageCamera> storages = new List<StorageCamera>();
        public Form4()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                string str;
                string[] a;
                while (sr.EndOfStream == false)
                {
                    str = sr.ReadLine();
                    if (str != "" && str != " ")
                    {
                        a = str.Split('|');
                        storages.Add(new StorageCamera(a[0], int.Parse(a[1]), int.Parse(a[2]), a[3], a[4]));
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (storages.Count == 0)
            {
                MessageBox.Show("There is no information right now");
            }
            else
            {
                dataGridView1.RowCount = storages.Count;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[0, j].Value = storages[j].storeDate;
                    dataGridView1[1, j].Value = storages[j].baggageWeight;
                    dataGridView1[2, j].Value = storages[j].storingDuration;
                    dataGridView1[3, j].Value = storages[j].ownerNameAndSurname;
                    dataGridView1[4, j].Value = storages[j].specialNotes;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
