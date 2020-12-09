using System;
using System.Data;
using System.Windows.Forms;


namespace Menu
{
    using System.Collections.Generic;
    using Microsoft.Office.Interop.Word;

    public partial class Подать_документы : Form
    {
        public Подать_документы()
        {
            this.InitializeComponent();
        }

        private void Подать_документы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "абитуриенты_БМТDataSet.Абитуриенты". При необходимости она может быть перемещена или удалена.
            this.абитуриентыTableAdapter.Fill(this.абитуриенты_БМТDataSet.Абитуриенты);

            // Установим пол первого абитуриента после загрузки данных
            this.comboBox1_SelectedIndexChanged(this.comboBox1, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string пол = "";
            if (this.radioButton1.Checked)
            {
                пол = "м";
            }
            else if (this.radioButton2.Checked)
            {
                пол = "ж";
            }

            var абитуриенты = this.абитуриентыTableAdapter.GetData();
            for (int i = 0; i < абитуриенты.Count; i++)
            {
                if (абитуриенты[i].Имя == this.comboBox2.Text && абитуриенты[i].Фамилия == this.comboBox1.Text &&
                    абитуриенты[i].Отчество == this.comboBox3.Text && абитуриенты[i].Пол == пол &&
                    абитуриенты[i].Телефон == Convert.ToInt32(this.comboBox4.Text))
                {
                    MessageBox.Show("Такой абитуриент уже существует!");
                    return;
                }
            }

            var новый_абитуриент = this.абитуриенты_БМТDataSet.Абитуриенты.NewАбитуриентыRow();
            новый_абитуриент.Фамилия = this.comboBox1.Text;
            новый_абитуриент.Имя = this.comboBox2.Text;
            новый_абитуриент.Отчество = this.comboBox3.Text;
            новый_абитуриент.Пол = пол;
            новый_абитуриент.Телефон = Convert.ToInt32(this.comboBox4.Text);

            this.абитуриенты_БМТDataSet.Абитуриенты.AddАбитуриентыRow(новый_абитуриент);

            // Фиксируем изменения в бд
            this.абитуриентыTableAdapter.Adapter.Update(this.абитуриенты_БМТDataSet.Абитуриенты);

            // Ставим курсор на только что созданную запись
            this.comboBox1.SelectedItem = this.comboBox1.Items[this.comboBox1.Items.Count - 1];
        }

        private void editModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton1.Enabled = this.radioButton2.Enabled = this.button1.Enabled = this.editModeCheckBox.Checked;

            var comboBoxArray = new[] { this.comboBox1, this.comboBox2, this.comboBox3, this.comboBox4 };

            if (this.editModeCheckBox.Checked)
            {
                // В режиме редактирования даем возможность вводить текст
                for (int i = 0; i < comboBoxArray.Length; i++)
                {
                    comboBoxArray[i].DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
            else
            {
                // Выход из режима редактирования
                ComboBox comboBoxNotEmptySelectedObject = null;
                for (int i = 0; i < comboBoxArray.Length; i++)
                {
                    if (comboBoxArray[i].SelectedItem != null)
                    {
                        comboBoxNotEmptySelectedObject = comboBoxArray[i];
                    }

                    comboBoxArray[i].DropDownStyle = ComboBoxStyle.DropDownList;
                }

                // Если мы у всех введем значение, и отключим редактирование, то должны вернуться к нулевой записи
                if (comboBoxNotEmptySelectedObject == null)
                {
                    for (int i = 0; i < comboBoxArray.Length; i++)
                    {
                        comboBoxArray[i].SelectedIndex = 0;
                    }
                }
                else
                {
                    // Если хотя бы один дропбокс не изменился, все остальные дропбоксы должны встать на такой же индекс, что у неизмененного
                    for (int i = 0; i < comboBoxArray.Length; i++)
                    {
                        comboBoxArray[i].SelectedIndex = comboBoxNotEmptySelectedObject.SelectedIndex;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Установка пола в зависимости от выбранного абитуриента
            ComboBox senderCombobox = (ComboBox)sender;

            this.radioButton2.Checked = this.radioButton1.Checked = false;
            if (senderCombobox.SelectedValue is DataRowView)
            {
                Абитуриенты_БМТDataSet.АбитуриентыRow selectedRow =
                    (Абитуриенты_БМТDataSet.АбитуриентыRow)((DataRowView)senderCombobox.SelectedValue).Row;
                if (!string.IsNullOrWhiteSpace(selectedRow.Пол))
                    if (selectedRow.Пол.ToLower()[0] == 'ж')
                    {
                        this.radioButton2.Checked = true;
                    }
                    else if (selectedRow.Пол.ToLower()[0] == 'м')
                    {
                        this.radioButton1.Checked = true;
                    }
            }
            else
            {
                MessageBox.Show("Не удалось получить данные");
            }
        }
    }
}