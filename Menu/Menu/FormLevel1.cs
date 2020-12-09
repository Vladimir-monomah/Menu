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
    public partial class FormLevel1 : Form
    {
        int left_boxes;
        public FormLevel1()
        {
            InitializeComponent();
            
        }

        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen (point);
            left_boxes = 6;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            label_box6.Visible = true;
            Sound.play_Sound8425();
        }

        private void finish_game()
        {
            Sound.play_zvuk_volshebstva();
           DialogResult dr = MessageBox.Show("Вы проиграли, ещё разок попробуем?", "Сообщение", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if (left_boxes == 0)
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label_box6_MouseEnter(object sender, EventArgs e)
        {
            Sound.play__0dbd6cf6363a9a7056c350b7f8e6da8a();
            left_boxes--;
            ((Label)sender).Visible = false;

        }
    }
}
