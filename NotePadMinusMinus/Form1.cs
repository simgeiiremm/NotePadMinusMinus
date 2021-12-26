using NotePadMinusMinus.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadMinusMinus
{
    public partial class Form1 : Form
    {
        FileService fileService = new FileService();
        string path = Application.StartupPath + @"\textdosyasi.txt";
        //C:\Users\Administrator\source\repos\NotePadMinusMinus\NotePadMinusMinus\NotePadMinusMinus\bin\Debug\textdosyasi.txt
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
            toolStripStatusLabel1.Text = "Length: 0";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string content = fileService.Open();
            //rtbText.Text = content;
            rtbText.Text = fileService.Open(path);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileService.Save(path, rtbText.Text);
            toolStripStatusLabel1.Text = "Length: " + fileService.GetTextLength(rtbText.Text);
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
            toolStripStatusLabel1.Text = "Length: 0";

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                rtbText.Text = fileService.Open(openFileDialog1.FileName);
                toolStripStatusLabel1.Text = "Length: " + fileService.GetTextLength(rtbText.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                fileService.Save(saveFileDialog1.FileName, rtbText.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Length: 0";
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Length: " + fileService.GetTextLength(rtbText.Text);
        }
    }
}
