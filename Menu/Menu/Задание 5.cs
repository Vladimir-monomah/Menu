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
    public partial class Задание_5 : Form
    {
        public Задание_5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Просмотр_БД_абитуриента открыть = new Просмотр_БД_абитуриента();
            открыть.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Подать_документы открыть = new Подать_документы();
            открыть.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var helpFilePath = Application.StartupPath + "\\frame\\фрейм.html";
            System.Diagnostics.Process.Start("file://" + helpFilePath);

        }



    }
}
