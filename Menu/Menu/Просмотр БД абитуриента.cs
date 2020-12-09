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
    public partial class Просмотр_БД_абитуриента : Form
    {
        public Просмотр_БД_абитуриента()
        {
            InitializeComponent();
        }

        private void Просмотр_БД_абитуриента_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "абитуриенты_БМТDataSet.Абитуриенты". При необходимости она может быть перемещена или удалена.
            this.абитуриентыTableAdapter.Fill(this.абитуриенты_БМТDataSet.Абитуриенты);

            // Добавляем все поля из таблицы в список полей, по которм пользователь сможет выбрать, по какому полю фильтровать
            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                this.поляПоискаCombobox.Items.Add(this.dataGridView1.Columns[i].HeaderText);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (this.поляПоискаCombobox.SelectedItem == null)
            {
                MessageBox.Show("Выберите поле для поиска");
                return;
            }

            // Формируем сложный фильтр для поиска по нескольким полям одновременно
            if (this.абитуриентыBindingSource.Filter == null)
            {
                this.абитуриентыBindingSource.Filter = string.Format(
                    "([{0}]=\'{1}\')",
                    this.поляПоискаCombobox.SelectedItem,
                    this.FindBox.Text);
            }
            else
            {
                this.абитуриентыBindingSource.Filter = string.Format(
                    "{0} and ([{1}]=\'{2}\')",
                    this.абитуриентыBindingSource.Filter,
                    this.поляПоискаCombobox.SelectedItem,
                    this.FindBox.Text);
            }
        }

        private void ButtonBox_Click(object sender, EventArgs e)
        {
            this.абитуриентыBindingSource.Filter = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.абитуриентыTableAdapter.Update(this.абитуриенты_БМТDataSet.Абитуриенты);
        }
    }
}
