using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Menu
{
    public partial class открыть : Form
    {
        public открыть()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Word |*.docx";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LinkLabel label = new LinkLabel();
                    label.AutoSize = true;
                    label.Text = "Click me";
                    string link = dialog.FileName;

                    label.Links.Add(new LinkLabel.Link(0, label.Text.Length, dialog.FileName));
                    label.LinkClicked += OnLinkClick;
                    label.Left = label.Top = 20;
                    this.Controls.Add(label);
                }
            }
        }

        private void OnLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;
            System.Diagnostics.Process.Start((string)e.Link.LinkData);
        }
    }
    }

