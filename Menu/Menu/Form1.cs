using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            открыть открыть = new открыть();
                открыть.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes) 
            {
                Close();
            }
           
        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Задание_1 открыть = new Задание_1();
            открыть.ShowDialog();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Задание_2 открыть = new Задание_2();
            открыть.ShowDialog();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elculator.Задание_3 открыть = new Elculator.Задание_3();
            открыть.ShowDialog();
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Задание_4 открыть = new Задание_4();
            открыть.ShowDialog();
        }

        private void задание5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Задание_5 открыть = new Задание_5();
            открыть.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpFilePath = Application.StartupPath + "\\frame\\фрейм.html";
            System.Diagnostics.Process.Start("file://" + helpFilePath);
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчиком данного программного продукта является студент Бугульминского машиностроительного техникума специальности09.02.05 527 группы 527Быков Владимир Олегович");
        }

        private void задание6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Лабиринт открыть = new Лабиринт();
            открыть.ShowDialog();
        }
    }
}
