using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel; //버전 : 1.9, 파일버전 : 16
using Application = Microsoft.Office.Interop.Excel.Application;
using System.IO;
using System.IO.Ports;

namespace Excel_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            List<string> chunks = new List<string>();
            foreach (string line in lines)
            {
                string[] lineChunks = SplitIntoChunks(line, 8);
                chunks.AddRange(lineChunks);
            }
            Application excel = new Application();

            Workbook workbook = excel.Workbooks.Add();

            Worksheet worksheet = workbook.Sheets[1];

            int row = 1;
            int column = 1;
            foreach (string chunk in chunks)
            {
                worksheet.Cells[row, column].Value = string.Format("{0:0000 0000}", int.Parse(chunk));
                row++;
            }

            workbook.SaveAs(@"C:\temp\Test.xlsx");

            excel.Quit();

            workbook = null;
            excel = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            MessageBox.Show("Excel file created!");
        }
        private static string[] SplitIntoChunks(string text, int chunkSize)
        {
            List<string> chunks = new List<string>();
            for (int i = 0; i < text.Length; i += chunkSize)
            {
                chunks.Add(text.Substring(i, Math.Min(chunkSize, text.Length - i)));
            }
            return chunks.ToArray();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SerialPort serialPort = new SerialPort("COM3", 115200, Parity.None, 8, StopBits.One);
            serialPort.Open();
            string[] chunks = textBox1.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (string chunk in chunks)
            {
                serialPort.WriteLine(chunk);
            }
            serialPort.Close();
        }
    }
}


