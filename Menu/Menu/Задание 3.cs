using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Elculator
{
    public partial class Задание_3 : Form
    {

        private struct MARGINS
        {
            public int m_Left;
            public int m_Right;
            public int m_Top;
            public int m_Buttom;
        };

        [DllImport("dwmapi.dll")]
        private static extern void DwmIsCompositionEnabled(ref int enabledptr);
        [DllImport("dwmapi.dll")]
        private static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margin);

        public Задание_3()
        {
            InitializeComponent();
            
            int en=1;
            MARGINS mg=new MARGINS();
            mg.m_Buttom = -5;
            mg.m_Left = -5;
            mg.m_Right = -5;
            mg.m_Top = -5;

            if (System.Environment.OSVersion.Version.Major >= 6)
            //if (System.Environment.OSVersion.Version.Major >= 6 && System.Environment.OSVersion.Version.Minor >= 1)
            {
                if (System.Environment.OSVersion.Version.Minor == 0)
                {
                    DwmIsCompositionEnabled(ref en);
                    //check if the desktop composition is enabled

                    if (en > 0)
                    {
                        this.BackColor = System.Drawing.Color.Black;
                        //this.TransparencyKey = System.Drawing.Color.Black;
                        DwmExtendFrameIntoClientArea(this.Handle, ref mg);
                        
                        System.Drawing.Color wincolor = System.Drawing.Color.Red;
                        //Form.ActiveForm.ForeColor = wincolor;
                        this.display.ForeColor = wincolor;
                        this.button0.ForeColor = wincolor;
                        this.button1.ForeColor = wincolor;
                        this.button2.ForeColor = wincolor;
                        this.button3.ForeColor = wincolor;
                        this.button4.ForeColor = wincolor;
                        this.button5.ForeColor = wincolor;
                        this.button6.ForeColor = wincolor;
                        this.button7.ForeColor = wincolor;
                        this.button8.ForeColor = wincolor;
                        this.button9.ForeColor = wincolor;
                        this.plus.ForeColor = wincolor;
                        this.minus.ForeColor = wincolor;
                        this.divide.ForeColor = wincolor;
                        this.equal.ForeColor = wincolor;
                        this.comma.ForeColor = wincolor;
                        this.sign.ForeColor = wincolor;
                        this.clean.ForeColor = wincolor;
                        this.clear.ForeColor = wincolor;
                        this.acos.ForeColor = wincolor;
                        this.asin.ForeColor = wincolor;
                        this.asqr.ForeColor = wincolor;
                        this.atan.ForeColor = wincolor;
                        this.apercent.ForeColor = wincolor;
                        this.apow.ForeColor = wincolor;
                        this.memclean.ForeColor = wincolor;
                        this.memminus.ForeColor = wincolor;
                        this.memplus.ForeColor = wincolor;
                        this.memrite.ForeColor = wincolor;
                    }
                }
                else
                {
                    DwmIsCompositionEnabled(ref en);
                    //check if the desktop composition is enabled

                    if (en > 0)
                    {
                        this.BackColor = System.Drawing.Color.AliceBlue;
                        this.TransparencyKey = System.Drawing.Color.AliceBlue;
                        DwmExtendFrameIntoClientArea(this.Handle, ref mg);
                    }
                    else
                    {
                        //MessageBox.Show("Desktop Composition is Disabled!");
                    }
                }
            }
        }
        
        //settings
        const double maxch = 12; //количество символов

        //constant
        double m;
        string command;
        double ch1;
        double ch2;
        byte cl;
        byte com;
        string error;
        byte val;
        byte rept;
        //char validatetype;
        
        private void button1_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "1";
                else display.Text = display.Text + "1";
                cl = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "2";
                else display.Text = display.Text + "2";
                cl = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "3";
                else display.Text = display.Text + "3";
                cl = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "4";
                else display.Text = display.Text + "4";
                cl = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "5";
                else display.Text = display.Text + "5";
                cl = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "6";
                else display.Text = display.Text + "6";
                cl = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "7";
                else display.Text = display.Text + "7";
                cl = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "8";
                else display.Text = display.Text + "8";
                cl = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "9";
                else display.Text = display.Text + "9";
                cl = 1;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) display.Text = "0";
                else display.Text = display.Text + "0";
                if (display.Text == "0") cl = 0;
                else cl = 1;
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1 && com == 0)
            {
                if (cl == 1) display.Text = display.Text + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
                else display.Text = "0" + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
                cl = 1;
                com = 1;
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            if (error != "") clear_Click(null, new EventArgs());
            else
            {
                display.Text = "0";
                cl = 0;
                com = 0;
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (display.Text != "0")
                {
                    display.Text = Convert.ToString(Convert.ToDouble(display.Text) * (-1));
                }
                if (com == 1 && Math.Floor(Convert.ToDouble(display.Text)) == Convert.ToDouble(display.Text)) com = 0;
            }
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            m = 0;
            cl = 0;
            ch1 = 0;
            ch2 = 0;
            command = "";
            com = 0;
            error = "";
            val = 1;
            rept = 0;

            display.Text = "0";
            //buttonpanel.BackColor = Color.FromArgb(0);
            //advancpanel.BackColor = Color.FromArgb(0);
        }

        private void memplus_Click(object sender, EventArgs e)
        {
            valid_enter("memo");
            if (val == 1)
            {
                m = m + Convert.ToDouble(display.Text);
                if (m != 0) memlab.Visible = true;
                else memlab.Visible = false;
                cl = 0;
                com = 0;
            }
        }

        private void memminus_Click(object sender, EventArgs e)
        {
            valid_enter("memo");
            if (val == 1)
            {
                m = m - Convert.ToDouble(display.Text);
                if (m != 0) memlab.Visible = true;
                else memlab.Visible = false;
                cl = 0;
                com = 0;
            }
        }

        private void memrite_Click(object sender, EventArgs e)
        {
            valid_enter("memo");
            if (val == 1)
            {
                if (m != 0) display.Text = Convert.ToString(m);
                cl = 0;
                com = 0;
            }
        }

        private void memclean_Click(object sender, EventArgs e)
        {
            m = 0;
            memlab.Visible = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "+";
                    ch1 = Convert.ToDouble(display.Text);
                    resultdisp.Text = display.Text + command;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "+";
                            resultdisp.Text = display.Text + command;
                        }
                        else
                        {
                            command = "+";
                            resultdisp.Text = resultdisp.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "+";
                            ch1 = Convert.ToDouble(display.Text);
                            resultdisp.Text = display.Text + command;
                        }
                        else
                        {
                            Resh();
                            command = "+";
                            resultdisp.Text += display.Text + command;
                            display.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "-";
                    ch1 = Convert.ToDouble(display.Text);
                    resultdisp.Text = display.Text + command;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "-";
                            resultdisp.Text = display.Text + command;
                        }
                        else
                        {
                            command = "-";
                            resultdisp.Text = resultdisp.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "-";
                            ch1 = Convert.ToDouble(display.Text);
                            resultdisp.Text = display.Text + command;
                        }
                        else
                        {
                            Resh();
                            command = "-";
                            resultdisp.Text += display.Text + command;
                            display.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void multiplied_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "*";
                    ch1 = Convert.ToDouble(display.Text);
                    resultdisp.Text = display.Text + command;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "*";
                            resultdisp.Text = display.Text + command;
                        }
                        else
                        {
                            command = "*";
                            resultdisp.Text = resultdisp.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "*";
                            ch1 = Convert.ToDouble(display.Text);
                            resultdisp.Text = display.Text + command;
                        }
                        else
                        {
                            Resh();
                            command = "*";
                            resultdisp.Text += display.Text + command;
                            display.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "/";
                    ch1 = Convert.ToDouble(display.Text);
                    resultdisp.Text = display.Text + command;
                    //rept = 0;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "/";
                            resultdisp.Text = display.Text + command;
                        }
                        else
                        {
                            command = "/";
                            resultdisp.Text = resultdisp.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "/";
                            ch1 = Convert.ToDouble(display.Text);
                            resultdisp.Text = display.Text + command;
                            //rept = 0;
                        }
                        else
                        {
                            Resh();
                            command = "/";
                            resultdisp.Text += display.Text + command;
                            display.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (resultdisp.Text != "" || cl == 0)
                {
                    Resh();
                    if (error == "") display.Text = Convert.ToString(ch1);
                    else display.Text = error;
                    resultdisp.Text = "";
                    cl = 0;
                    com = 0;
                    rept = 1;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ch1 = 0;
            ch2 = 0;
            resultdisp.Text = "";
            display.Text = "0";
            command = "";
            cl = 0;
            com = 0;
            val = 1;
            error = "";
            rept = 0;
            display.Font = new Font("Microsoft Sans Serif", 24);
        }

        private void Resh()
        {
            switch (command)
            {
                  case "+":
                      if (cl == 1 || (cl == 0 && resultdisp.Text != "")) ch2 = Convert.ToDouble(display.Text);
                      ch1 = ch1 + ch2;
                      break;
                  case "-":
                      if (cl == 1 || (cl == 0 && resultdisp.Text != "")) ch2 = Convert.ToDouble(display.Text);
                      ch1 = ch1 - ch2;
                      break;
                  case "*":
                      if (cl == 1 || (cl == 0 && resultdisp.Text != "")) ch2 = Convert.ToDouble(display.Text);
                      ch1 = ch1 * ch2;
                      break;
                  case "/":
                      if (cl == 1 || (cl == 0 && resultdisp.Text != "")) ch2 = Convert.ToDouble(display.Text);
                      if (ch2 != 0) ch1 = ch1 / ch2;
                      else
                      {
                          ch1 = 0;
                          error = "Division by zero";
                          System.Media.SystemSounds.Asterisk.Play();
                      }
                      break;
            }
        }

        private void CalcForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            equal.Select();
            switch (e.KeyChar)
            {
                case '0':
                    button0_Click(null, new EventArgs());
                    break;
                case '1':
                    button1_Click(null, new EventArgs());
                    break;
                case '2':
                    button2_Click(null, new EventArgs());
                    break;
                case '3':
                    button3_Click(null, new EventArgs());
                    break;
                case '4':
                    button4_Click(null, new EventArgs());
                    break;
                case '5':
                    button5_Click(null, new EventArgs());
                    break;
                case '6':
                    button6_Click(null, new EventArgs());
                    break;
                case '7':
                    button7_Click(null, new EventArgs());
                    break;
                case '8':
                    button8_Click(null, new EventArgs());
                    break;
                case '9':
                    button9_Click(null, new EventArgs());
                    break;
                case '+':
                    plus_Click(null, new EventArgs());
                    break;
                case '-':
                    minus_Click(null, new EventArgs());
                    break;
                case '*':
                    multiplied_Click(null, new EventArgs());
                    break;
                case '/':
                    divide_Click(null, new EventArgs());
                    break;
                case '.':
                    comma_Click(null, new EventArgs());
                    break;
                case ',':
                    comma_Click(null, new EventArgs());
                    break;
                case '=':
                    equal_Click(null, new EventArgs());
                    break;
                case (char)Keys.Escape:
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case (char)Keys.Back:
                    clean_Click(null, new EventArgs());
                    break;
            }
        }

        private void norm2big_Click(object sender, EventArgs e)
        {
            Задание_3.ActiveForm.Width = 335;
            norm2big.Visible = false;
            big2norm.Visible = true;
            advancpanel.Visible = true;
        }

        private void norm2small_Click(object sender, EventArgs e)
        {
            Задание_3.ActiveForm.Height = 122;
            Задание_3.ActiveForm.Width = 285;
            if (System.Environment.OSVersion.Version.Major < 6)
            {
                Задание_3.ActiveForm.Opacity = 0.90;
            }
            //buttonpanel.Top = 110;
            //buttonpanel.Enabled = false;
            norm2big.Visible = false;
            norm2small.Visible = false;
            small2norm.Visible = true;
            advancpanel.Visible = false;
            big2norm.Visible = false;
            equal.Select();
        }

        private void small2norm_Click(object sender, EventArgs e)
        {
            Задание_3.ActiveForm.Height = 315;
            Задание_3.ActiveForm.Width = 285;
            if (System.Environment.OSVersion.Version.Major < 6)
            {
                Задание_3.ActiveForm.Opacity = 1;
            }
            norm2big.Visible = true;
            //buttonpanel.Top = 90;
            norm2small.Visible = true;
            small2norm.Visible = false;
        }

        private void asin_Click(object sender, EventArgs e)
        {
            valid_enter("a");
            if (val == 1)
            {
                display.Text = Convert.ToString(Math.Round(Math.Sin((Convert.ToDouble(display.Text) * Math.PI) / 180), 11));
                cl = 0;
                com = 0;
            }
        }

        private void acos_Click(object sender, EventArgs e)
        {
            valid_enter("a");
            if (val == 1)
            {
                display.Text = Convert.ToString(Math.Round(Math.Cos((Convert.ToDouble(display.Text) * Math.PI) / 180), 11));
                cl = 0;
                com = 0;
            }
        }

        private void atan_Click(object sender, EventArgs e)
        {
            valid_enter("a");
            if (val == 1)
            {
                if (((Convert.ToDouble(display.Text) / 90 % 2) == 1) || (Convert.ToDouble(display.Text) > 99999999))
                {
                    error = "Tangent of " + display.Text + "° is infinity";
                    display.Text = error;
                    System.Media.SystemSounds.Asterisk.Play();
                }
                else display.Text = Convert.ToString(Math.Round(Math.Tan((Convert.ToDouble(display.Text) * Math.PI) / 180), 11));
                cl = 0;
                com = 0;
            }
        }

        private void asqr_Click(object sender, EventArgs e)
        {
            valid_enter("a");
            if (val == 1)
            {
                if (Math.Sign(Convert.ToDouble(display.Text)) == -1)
                {
                    error = "Can't calculate square roots of negative numbers";
                    display.Text = error;
                    System.Media.SystemSounds.Asterisk.Play();
                }
                else
                {
                    display.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(display.Text)));
                }
                cl = 0;
                com = 0;
            }
        }

        private void apow_Click(object sender, EventArgs e)
        {
            valid_enter("a");
            if (val == 1)
            {
                display.Text = Convert.ToString(Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text));
                cl = 0;
                com = 0;
            }
        }

        private void apercent_Click(object sender, EventArgs e)
        {
            valid_enter("a");
            if (val == 1)
            {
                if (command != "")
                {
                    display.Text = Convert.ToString((Convert.ToDouble(display.Text) * ch1) / 100);

                }
            }
        }

        private void big2norm_Click(object sender, EventArgs e)
        {
            Задание_3.ActiveForm.Width = 285;
            advancpanel.Visible = false;
            big2norm.Visible = false;
            norm2big.Visible = true;
        }

        private void memlab_DoubleClick(object sender, EventArgs e)
        {
            error = "here is no bug, I think";
            display.Text = error;
        }

        private void display_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(display.Text);
        }

        private void CalcForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState) Hide();
        }

        private void trayicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void CalcForm_KeyDown(object sender, KeyEventArgs e)
        {
            equal.Select();
            if (e.KeyCode == Keys.Delete) clear_Click(this, new EventArgs());
            if (e.KeyCode == Keys.Enter) equal_Click(null, new EventArgs());
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            if (display.Text.Length < 12) display.Font = new Font("Microsoft Sans Serif",24);
            if (display.Text.Length > 12 && display.Text.Length <= 14) display.Font = new Font("Microsoft Sans Serif", 22);
            if (display.Text.Length > 14 && display.Text.Length <= 17) display.Font = new Font("Microsoft Sans Serif", 19);
            if (display.Text.Length > 17 && display.Text.Length <= 23) display.Font = new Font("Microsoft Sans Serif", 15);
            //if (display.Text.Length > 24) display.Font = new Font("Microsoft Sans Serif", 8);
            if (error != "") display.Font = new Font("Microsoft Sans Serif", 8);

            //validate display data
            if (display.Text == Convert.ToString(double.NaN))
            {
                error = "Неправильная операция";
                display.Text = error;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (display.Text == Convert.ToString(double.PositiveInfinity))
            {
                error = "Бесконечность";
                display.Text = error;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void valid_enter(object validatetype)
        {
            switch (Convert.ToString(validatetype))
            {
                case "number":
                    if (error == "")
                    {
                        if (display.Text.Length >= maxch && cl == 1)
                        {
                            val = 0;
                            System.Media.SystemSounds.Beep.Play();
                        }
                        else val = 1;
                    }
                    else
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    break;
                case "memo":
                    if (error != "")
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    else val = 1;
                    break;
                case "sign":
                    if (error != "")
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    else val = 1;
                    break;
                case "a":
                    if (error != "")
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    else val = 1;
                    break;
            }
        }

        private void resultdisp_TextChanged(object sender, EventArgs e)
        {
            resultdisp.SelectAll();
        }

        private void tmRestore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void tmHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tmManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://elio.at.ua/index/elculator_about/0-6");
        }

        private void tmBug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://elio.at.ua/publ/8-1-0-31");
        }

        private void tmAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Elculator version " + this.GetType().Assembly.GetName().Version);
        }

        private void tmExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
