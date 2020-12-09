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
    public partial class Задание_4 : Form
    {
        public Задание_4()
        {
            InitializeComponent();
        }

        private void Задание_4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "туристы_турбазыDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.туристы_турбазыDataSet.Город);

        }

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            городBindingSource.Filter = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.городTableAdapter.Update(this.туристы_турбазыDataSet.Город);
        }

        private void FindBox_TextChanged(object sender, EventArgs e)
        {
            городBindingSource.Filter = "[Город] LIKE '" + FindBox.Text + "%'";
        }
    }
 }
        

