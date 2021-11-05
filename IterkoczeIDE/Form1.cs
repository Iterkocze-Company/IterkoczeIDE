using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastColoredTextBoxNS;
using System.Windows.Forms;

namespace IterkoczeIDE
{
    public partial class Form1 : Form
    {
        private static bool isSaved;
        public static string fileName;
        public static string filePath;
        public static bool isOpened = false;

        public Form1()
        {
            InitializeComponent();
            Style s = new TextStyle(Brushes.Green, Brushes.Silver, FontStyle.Bold);
            Code.AddStyle(s);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fileName = fd.FileName;
                filePath = Path.GetDirectoryName(fileName);
                isSaved = true;
                isOpened = true;
                
                string buffer = "";
                foreach (string line in Code.Lines)
                {
                    if (line.StartsWith(" "))
                    {
                        buffer += line.TrimStart().Insert(0, "\t") + "\n";
                    }
                    else
                        buffer += line + "\n";
                }
                File.WriteAllText(filePath, buffer);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fileName = fd.FileName;
                filePath = Path.GetDirectoryName(fileName);
                isSaved = false;
                isOpened = true;
                Code.Text = File.ReadAllText(fd.FileName);
            }
        }

        private void kompilujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new();
            info.WorkingDirectory = filePath;
            info.FileName = "ippCompiler.exe";
            info.Arguments = fileName;

            Process.Start(info);
        }

        private void kompilujIUruchomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new();
            info.WorkingDirectory = filePath;
            info.FileName = "ippCompiler.exe";
            info.Arguments = fileName + " -run";

            Process.Start(info);
        }

        private void interpretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new();
            info.WorkingDirectory = filePath;
            info.FileName = "ippScriptInterpreter";
            info.Arguments = fileName;

            Process.Start(info);
        }
    }
}
