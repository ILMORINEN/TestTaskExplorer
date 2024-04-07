using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskExplorer.Properties;

namespace TestTaskExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void labelCurrentFolder_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
