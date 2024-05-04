using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskExplorer.Properties;

namespace TestTaskExplorer
{
    public partial class Form1 : Form
    {
        private readonly ManualResetEvent _busy = new(true);
        private readonly EnumerationOptions _inaccessible = new()
        {
            IgnoreInaccessible = true
        };
        private readonly EnumerationOptions _inaccessibleAndSubdirectories = new()
        {
            IgnoreInaccessible = true,
            RecurseSubdirectories = true
        };
        private const string _pauseText = "Пауза";
        private const string _resumeText = "Продолжить";
        private int _foundCount = 0;

        public Form1()
        {
            InitializeComponent();
            buttonPauseContinue.Text = _pauseText;
            textBoxRegex.DataBindings.Add(nameof(textBoxRegex.Text), Settings.Default, nameof(Settings.Default.Regex));
            textBoxPath.DataBindings.Add(nameof(textBoxPath.Text), Settings.Default, nameof(Settings.Default.SearchPath));
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                Settings.Default.SearchPath = folderBrowserDialog.SelectedPath;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            buttonSearch.Enabled = false;
            buttonPauseContinue.Enabled = true;
            buttonReset.Enabled = true;
            labelTotalFiles.Text = "0";
            labelFoundFiles.Text = "0";
            treeView1.Nodes.Clear();

            var totalTask = Task.Run(() =>
            {
                var total = Directory
                            .GetFiles(textBoxPath.Text, "*.*", _inaccessibleAndSubdirectories)
                            .Length
                            .ToString();
                labelTotalFiles.Invoke(() => labelTotalFiles.Text = total);
            });

            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();

            await totalTask;
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Recursion(textBoxPath.Text, (BackgroundWorker)sender, e, null);
        }
        private void Recursion(string searchPath, BackgroundWorker bw, DoWorkEventArgs e, TreeNode? parent)
        {
            _busy.WaitOne(Timeout.Infinite);

            if (bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            var foundDirectories = SearchFolders(searchPath);
            var foundFiles = SearchFiles(searchPath, textBoxRegex.Text);
            var current = new TreeNode(Path.GetFileName(searchPath.TrimEnd(Path.DirectorySeparatorChar)));

            if (!foundDirectories.Any() && !foundFiles.Any())
                return;

            _foundCount += foundFiles.Count();

            foreach (var file in foundFiles)
            {
                var fileNode = new TreeNode(file);
                current.Nodes.Add(fileNode);
            }

            _busy.WaitOne(Timeout.Infinite);

            if (bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            bw.ReportProgress(0, (parent, current));

            foreach (var path in foundDirectories)
            {
                Recursion(path, bw, e, current);
            }
        }
        private IEnumerable<string> SearchFolders(string path)
        {
            Thread.Sleep(1000);
            return Directory.EnumerateDirectories(path, "*", _inaccessible);
        }
        private IEnumerable<string?> SearchFiles(string path, string pattern)
        {
            var regex = new Regex(pattern);
            return Directory
                   .EnumerateFiles(path, "*.*", _inaccessible)
                   .Select(Path.GetFileName)
                   .Where(path => path is not null && regex.IsMatch(path));
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is (TreeNode, TreeNode) || (e.UserState is (null, TreeNode)))
            {
                treeView1.BeginUpdate();
                var nodePair = ((TreeNode, TreeNode))e.UserState;
                if (nodePair.Item1 is null)
                {
                    treeView1.Nodes.Add(nodePair.Item2);
                }
                else
                {
                    nodePair.Item1.Nodes.Add(nodePair.Item2);
                }
                labelCurrentFolder.Text = nodePair.Item2.Text;
                labelFoundFiles.Text = _foundCount.ToString();
                treeView1.ExpandAll();
                treeView1.EndUpdate();
            }
        }

        private void buttonPauseContinue_Click(object sender, EventArgs e)
        {
            if (buttonPauseContinue.Text == _pauseText)
            {
                _busy.Reset();
                buttonPauseContinue.Text = _resumeText;
            }
            else
            {
                _busy.Set();
                buttonPauseContinue.Text = _pauseText;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonSearch.Enabled = false;
            buttonPauseContinue.Enabled = false;
            buttonReset.Enabled = false;

            if (buttonPauseContinue.Text != _pauseText)
            {
                _busy.Set();
                buttonPauseContinue.Text = _pauseText;
            }

            backgroundWorker.CancelAsync();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                labelTotalFiles.Text = "0";
                labelFoundFiles.Text = "0";

                treeView1.Nodes.Clear();
            }
            else if (e.Error != null)
            {
                labelTotalFiles.Text = "0";
                labelFoundFiles.Text = "0";

                treeView1.Nodes.Clear();
            }

            labelCurrentFolder.Text = "-";
            _foundCount = 0;

            buttonSearch.Enabled = true;
            buttonPauseContinue.Enabled = false;
            buttonReset.Enabled = false;

        }
    }
}
