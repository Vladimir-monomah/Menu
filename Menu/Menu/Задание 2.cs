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
    public partial class Задание_2 : Form
    {
        string s;
        double a;
        double b;
        double c;
        public Задание_2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            while (x.Length > 1 && x[0] == '0' && x[1] >= '0' && x[1] <= '9')
                x = x.Substring(1);
            if (string.IsNullOrWhiteSpace(x))
                x = "0";
            textBox1.Text = x;
            textBox1.Select(x.Length, 0);
            s = textBox1.Text;
            a = Convert.ToDouble(s);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string x = textBox2.Text;
            while (x.Length > 1 && x[0] == '0' && x[1] >= '0' && x[1] <= '9')
                x = x.Substring(1);
            if (string.IsNullOrWhiteSpace(x))
                x = "0";
            textBox2.Text = x;
            textBox2.Select(x.Length, 0);
            s = textBox2.Text;
            b = Convert.ToDouble(s);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            while (x.Length > 1 && x[0] == '0' && x[1] >= '0' && x[1] <= '9')
                x = x.Substring(1);
            if (string.IsNullOrWhiteSpace(x))
                x = "0";
            textBox1.Text = x;
            textBox1.Select(x.Length, 0);
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            c = a + b;
            textBox3.Text = Convert.ToString(c);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar != 22)
                e.Handled = !Char.IsDigit(e.KeyChar) && (e.KeyChar != ',' || (((TextBox)sender).Text.Contains(",") && !((TextBox)sender).SelectedText.Contains(","))) && e.KeyChar != (char)Keys.Back && (e.KeyChar != '-' || ((TextBox)sender).SelectionStart != 0 || (((TextBox)sender).Text.Contains("-") && !((TextBox)sender).SelectedText.Contains("-")));
            else
            {
                double d;
                e.Handled = !double.TryParse(Clipboard.GetText(), out d) || (d < 0 && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).Text.Contains("-") && !((TextBox)sender).SelectedText.Contains("-"))) || ((d - (int)d) != 0 && ((TextBox)sender).Text.Contains(",") && !((TextBox)sender).SelectedText.Contains(","));
                MessageBox.Show("Не удалось вставить содержимое буфера обмена");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar != 22)
                e.Handled = !Char.IsDigit(e.KeyChar) && (e.KeyChar != ',' || (((TextBox)sender).Text.Contains(",") && !((TextBox)sender).SelectedText.Contains(","))) && e.KeyChar != (char)Keys.Back && (e.KeyChar != '-' || ((TextBox)sender).SelectionStart != 0 || (((TextBox)sender).Text.Contains("-") && !((TextBox)sender).SelectedText.Contains("-")));
            else
            {
                double d;
                e.Handled = !double.TryParse(Clipboard.GetText(), out d) || (d < 0 && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).Text.Contains("-") && !((TextBox)sender).SelectedText.Contains("-"))) || ((d - (int)d) != 0 && ((TextBox)sender).Text.Contains(",") && !((TextBox)sender).SelectedText.Contains(","));
                MessageBox.Show("Не удалось вставить содержимое буфера обмена");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar != 22)
                e.Handled = !Char.IsDigit(e.KeyChar) && (e.KeyChar != ',' || (((TextBox)sender).Text.Contains(",") && !((TextBox)sender).SelectedText.Contains(","))) && e.KeyChar != (char)Keys.Back && (e.KeyChar != '-' || ((TextBox)sender).SelectionStart != 0 || (((TextBox)sender).Text.Contains("-") && !((TextBox)sender).SelectedText.Contains("-")));
            else
            {
                double d;
                e.Handled = !double.TryParse(Clipboard.GetText(), out d) || (d < 0 && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).Text.Contains("-") && !((TextBox)sender).SelectedText.Contains("-"))) || ((d - (int)d) != 0 && ((TextBox)sender).Text.Contains(",") && !((TextBox)sender).SelectedText.Contains(","));
                MessageBox.Show("Не удалось вставить содержимое буфера обмена");
            }
        }
    }
}
