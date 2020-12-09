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
    public partial class Лабиринт : Form
    {
        public Лабиринт()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (box_sound.Checked)
            {
                Sound.sound_on();
                box_sound.Text = "Звук есть";
                Sound.play_zvuki_dlya_igry();
            }
            else
            {
                Sound.sound_off();
                box_sound.Text = "Звука нет";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
           DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level2();

        }
        private void start_level2()
        {

            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_0dbd6cf6363a9a7056c350b7f8e6da8a();
            }
        }

            private void start_0dbd6cf6363a9a7056c350b7f8e6da8a()
        {
            Sound.play__0dbd6cf6363a9a7056c350b7f8e6da8a();
            MessageBox.Show("Вы прошли все лабиринты!", "Поздравляем");
        }



        }
    }


