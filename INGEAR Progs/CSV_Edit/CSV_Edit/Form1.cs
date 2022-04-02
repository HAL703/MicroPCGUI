using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Timers;
using System.Threading;



namespace CSV_Edit
{
    public partial class Form1 : Form
    {


        public static DataTable NitionExport = new DataTable();

        public int Nition_Indexs;
        public int Nition_Columns;
        public int Nition_Index_Last;
        public int Nition_Index_Next;
        public string[] Nition_CSV;
        public string[] Nition_CSV_items;
        public string Nition_CSV_Line;

        public string[] Irow1;


        public string CSV_Path = "C:\\Users\\MyPC\\Documents\\JOBS\\KSM_473\\002\\KSM_002_Beta\\FileHolder\\CSV\\Upload_Test_208.csv";
        public string CSV_Dest = "C:\\Users\\MyPC\\Documents\\JOBS\\KSM_473\\002\\KSM_002_Beta\\FileHolder\\Upload_Test_208.csv";




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            FileSystemWatcher CSV_Watch = new FileSystemWatcher();

            CSV_Watch.Path = "C:\\Users\\MyPC\\Documents\\JOBS\\KSM_473\\002\\KSM_002_Beta\\FileHolder\\CSV\\";


            CSV_Watch.NotifyFilter = NotifyFilters.LastWrite;
            CSV_Watch.Filter = "*.csv";


            CSV_Watch.Changed += new FileSystemEventHandler(CSV_Last_Line_TextChanged);
            CSV_Watch.EnableRaisingEvents = true;


            /*
             * 
             * 
             * fileSystemWatcher1.Path = "C:\\Users\\MyPC\\Documents\\JOBS\\KSM_473\\002\\KSM_002_Beta\\FileHolder\\CSV\\";
           fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;

           fileSystemWatcher1.Filter = "*.csv*";
          fileSystemWatcher1.Changed += new FileSystemEventHandler(CSV_Last_Line_TextChanged);
           fileSystemWatcher1.EnableRaisingEvents = true;
             * 
             * 
             */







            if (File.Exists(CSV_Path) == true)
            {
                NitionExport = FileHelpers.CsvEngine.CsvToDataTable(CSV_Path, ',');




                Nition_Indexs = NitionExport.Rows.Count;
                Nition_Columns = NitionExport.Columns.Count;

                // Nition_CSV_Line = File.ReadLines(CSV_Path).ToString();

                //  Nition_CSV = File.ReadAllLines(CSV_Path).Reverse().Take(1).ToArray();


                /*
                 * 
                 *  for (int i = 1; i < 15; i++)
                {
                    Irow1 = Nition_CSV[0].Split(',');



                    string Irow1_1 = Irow1[0]; // CSV INDEX
                    string Irow1_2 = Irow1[1]; // Test Internal Time
                    string Irow1_3 = Irow1[2]; // Test Reading Number
                    string Irow1_4 = Irow1[3]; // Cycle Duration
                    string Irow1_5 = Irow1[4]; // Sample Type
                    string Irow1_6 = Irow1[5]; // Units (%)
                    string Irow1_7 = Irow1[6]; // Sequence
                    string Irow1_8 = Irow1[7]; //Sample
                    string Irow1_9 = Irow1[8]; // HEAT
                    string Irow1_10 = Irow1[9]; // Lot #
                    string Irow1_11 = Irow1[10]; // Batch #
                    string Irow1_12 = Irow1[11]; // MISC #
                    string Irow1_13 = Irow1[12]; // NOTE #
                    string Irow1_14 = Irow1[13]; // Alloy 1
                    string Irow1_15 = Irow1[14]; // Alloy 2
                    string Irow1_16 = Irow1[15]; // Flags


                }
                 * 
                 */








                // FileSystemWatcher watcher = new FileSystemWatcher();

                // fileSystemWatcher1

                // C:\Users\MyPC\Documents\JOBS\KSM_473\002\KSM_002_Beta\FileHolder













                dataGridView1.DataSource = NitionExport;
                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = true;
                dataGridView1.Columns[14].Visible = true;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;

                for (int i = 15; i < 55; i++)
                {

                    dataGridView1.Columns[i].Visible = false;

                }
            }





            }

        private void CSV_Last_Line_TextChanged(object sender, FileSystemEventArgs e)
        {
            //throw new NotImplementedException();


            MessageBox.Show("CSV File Change");


        }
    }
    
}
