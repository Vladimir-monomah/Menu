namespace Elculator
{
    partial class Задание_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Задание_3));
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonpanel = new System.Windows.Forms.Panel();
            this.memclean = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.memrite = new System.Windows.Forms.Button();
            this.memplus = new System.Windows.Forms.Button();
            this.memminus = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiplied = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.memlab = new System.Windows.Forms.Label();
            this.resultdisp = new System.Windows.Forms.TextBox();
            this.norm2big = new System.Windows.Forms.Button();
            this.norm2small = new System.Windows.Forms.Button();
            this.small2norm = new System.Windows.Forms.Button();
            this.advancpanel = new System.Windows.Forms.Panel();
            this.apercent = new System.Windows.Forms.Button();
            this.apow = new System.Windows.Forms.Button();
            this.asqr = new System.Windows.Forms.Button();
            this.atan = new System.Windows.Forms.Button();
            this.acos = new System.Windows.Forms.Button();
            this.asin = new System.Windows.Forms.Button();
            this.big2norm = new System.Windows.Forms.Button();
            this.trayicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.traymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.tmHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmManual = new System.Windows.Forms.ToolStripMenuItem();
            this.tmBug = new System.Windows.Forms.ToolStripMenuItem();
            this.tmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonpanel.SuspendLayout();
            this.advancpanel.SuspendLayout();
            this.traymenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.ForeColor = System.Drawing.Color.Black;
            this.display.Location = new System.Drawing.Point(11, 42);
            this.display.Margin = new System.Windows.Forms.Padding(4);
            this.display.MaxLength = 8;
            this.display.MinimumSize = new System.Drawing.Size(257, 44);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.ShortcutsEnabled = false;
            this.display.Size = new System.Drawing.Size(257, 44);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            this.display.Text = "hello";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            this.display.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.display_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonpanel
            // 
            this.buttonpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonpanel.Controls.Add(this.memclean);
            this.buttonpanel.Controls.Add(this.clear);
            this.buttonpanel.Controls.Add(this.memrite);
            this.buttonpanel.Controls.Add(this.memplus);
            this.buttonpanel.Controls.Add(this.memminus);
            this.buttonpanel.Controls.Add(this.sign);
            this.buttonpanel.Controls.Add(this.clean);
            this.buttonpanel.Controls.Add(this.divide);
            this.buttonpanel.Controls.Add(this.multiplied);
            this.buttonpanel.Controls.Add(this.minus);
            this.buttonpanel.Controls.Add(this.plus);
            this.buttonpanel.Controls.Add(this.equal);
            this.buttonpanel.Controls.Add(this.comma);
            this.buttonpanel.Controls.Add(this.button0);
            this.buttonpanel.Controls.Add(this.button9);
            this.buttonpanel.Controls.Add(this.button8);
            this.buttonpanel.Controls.Add(this.button7);
            this.buttonpanel.Controls.Add(this.button6);
            this.buttonpanel.Controls.Add(this.button5);
            this.buttonpanel.Controls.Add(this.button4);
            this.buttonpanel.Controls.Add(this.button3);
            this.buttonpanel.Controls.Add(this.button2);
            this.buttonpanel.Controls.Add(this.button1);
            this.buttonpanel.Location = new System.Drawing.Point(11, 90);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(256, 190);
            this.buttonpanel.TabIndex = 2;
            this.buttonpanel.TabStop = true;
            // 
            // memclean
            // 
            this.memclean.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memclean.Location = new System.Drawing.Point(17, 8);
            this.memclean.Name = "memclean";
            this.memclean.Size = new System.Drawing.Size(40, 30);
            this.memclean.TabIndex = 22;
            this.memclean.TabStop = false;
            this.memclean.Text = "MC";
            this.memclean.UseVisualStyleBackColor = true;
            this.memclean.Click += new System.EventHandler(this.memclean_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(200, 8);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(40, 30);
            this.clear.TabIndex = 24;
            this.clear.TabStop = false;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // memrite
            // 
            this.memrite.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memrite.Location = new System.Drawing.Point(63, 8);
            this.memrite.Name = "memrite";
            this.memrite.Size = new System.Drawing.Size(40, 30);
            this.memrite.TabIndex = 21;
            this.memrite.TabStop = false;
            this.memrite.Text = "MR";
            this.memrite.UseVisualStyleBackColor = true;
            this.memrite.Click += new System.EventHandler(this.memrite_Click);
            // 
            // memplus
            // 
            this.memplus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memplus.Location = new System.Drawing.Point(109, 8);
            this.memplus.Name = "memplus";
            this.memplus.Size = new System.Drawing.Size(40, 30);
            this.memplus.TabIndex = 20;
            this.memplus.TabStop = false;
            this.memplus.Text = "M+";
            this.memplus.UseVisualStyleBackColor = true;
            this.memplus.Click += new System.EventHandler(this.memplus_Click);
            // 
            // memminus
            // 
            this.memminus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memminus.Location = new System.Drawing.Point(155, 8);
            this.memminus.Name = "memminus";
            this.memminus.Size = new System.Drawing.Size(40, 30);
            this.memminus.TabIndex = 19;
            this.memminus.TabStop = false;
            this.memminus.Text = "M-";
            this.memminus.UseVisualStyleBackColor = true;
            this.memminus.Click += new System.EventHandler(this.memminus_Click);
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign.Location = new System.Drawing.Point(200, 80);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(40, 30);
            this.sign.TabIndex = 18;
            this.sign.TabStop = false;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // clean
            // 
            this.clean.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean.Location = new System.Drawing.Point(200, 44);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(40, 30);
            this.clean.TabIndex = 17;
            this.clean.TabStop = false;
            this.clean.Text = "CE";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(155, 44);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(40, 30);
            this.divide.TabIndex = 16;
            this.divide.TabStop = false;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiplied
            // 
            this.multiplied.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplied.Location = new System.Drawing.Point(155, 80);
            this.multiplied.Name = "multiplied";
            this.multiplied.Size = new System.Drawing.Size(40, 30);
            this.multiplied.TabIndex = 15;
            this.multiplied.TabStop = false;
            this.multiplied.Text = "*";
            this.multiplied.UseVisualStyleBackColor = true;
            this.multiplied.Click += new System.EventHandler(this.multiplied_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(155, 116);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 30);
            this.minus.TabIndex = 14;
            this.minus.TabStop = false;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(155, 152);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 30);
            this.plus.TabIndex = 13;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(200, 116);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(40, 66);
            this.equal.TabIndex = 12;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // comma
            // 
            this.comma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comma.Location = new System.Drawing.Point(109, 152);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(40, 30);
            this.comma.TabIndex = 11;
            this.comma.TabStop = false;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(17, 152);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(86, 30);
            this.button0.TabIndex = 10;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(109, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 30);
            this.button9.TabIndex = 9;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(63, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 30);
            this.button8.TabIndex = 8;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(17, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 30);
            this.button7.TabIndex = 7;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(109, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.TabIndex = 6;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(63, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 30);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(17, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 30);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(109, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(63, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // memlab
            // 
            this.memlab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.memlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memlab.Location = new System.Drawing.Point(12, 67);
            this.memlab.Name = "memlab";
            this.memlab.Size = new System.Drawing.Size(18, 18);
            this.memlab.TabIndex = 23;
            this.memlab.Text = "M";
            this.memlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.memlab.Visible = false;
            this.memlab.DoubleClick += new System.EventHandler(this.memlab_DoubleClick);
            // 
            // resultdisp
            // 
            this.resultdisp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultdisp.Enabled = false;
            this.resultdisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultdisp.Location = new System.Drawing.Point(12, 12);
            this.resultdisp.Name = "resultdisp";
            this.resultdisp.ReadOnly = true;
            this.resultdisp.ShortcutsEnabled = false;
            this.resultdisp.Size = new System.Drawing.Size(256, 23);
            this.resultdisp.TabIndex = 3;
            this.resultdisp.TabStop = false;
            this.resultdisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultdisp.TextChanged += new System.EventHandler(this.resultdisp_TextChanged);
            // 
            // norm2big
            // 
            this.norm2big.Location = new System.Drawing.Point(267, 90);
            this.norm2big.Name = "norm2big";
            this.norm2big.Size = new System.Drawing.Size(10, 190);
            this.norm2big.TabIndex = 24;
            this.norm2big.TabStop = false;
            this.norm2big.UseVisualStyleBackColor = true;
            this.norm2big.Click += new System.EventHandler(this.norm2big_Click);
            // 
            // norm2small
            // 
            this.norm2small.Font = new System.Drawing.Font("Webdings", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.norm2small.Location = new System.Drawing.Point(11, 280);
            this.norm2small.Name = "norm2small";
            this.norm2small.Size = new System.Drawing.Size(256, 10);
            this.norm2small.TabIndex = 25;
            this.norm2small.TabStop = false;
            this.norm2small.UseVisualStyleBackColor = true;
            this.norm2small.Click += new System.EventHandler(this.norm2small_Click);
            // 
            // small2norm
            // 
            this.small2norm.Location = new System.Drawing.Point(11, 87);
            this.small2norm.Name = "small2norm";
            this.small2norm.Size = new System.Drawing.Size(256, 10);
            this.small2norm.TabIndex = 25;
            this.small2norm.TabStop = false;
            this.small2norm.UseVisualStyleBackColor = true;
            this.small2norm.Visible = false;
            this.small2norm.Click += new System.EventHandler(this.small2norm_Click);
            // 
            // advancpanel
            // 
            this.advancpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancpanel.Controls.Add(this.apercent);
            this.advancpanel.Controls.Add(this.apow);
            this.advancpanel.Controls.Add(this.asqr);
            this.advancpanel.Controls.Add(this.atan);
            this.advancpanel.Controls.Add(this.acos);
            this.advancpanel.Controls.Add(this.asin);
            this.advancpanel.Location = new System.Drawing.Point(275, 12);
            this.advancpanel.Name = "advancpanel";
            this.advancpanel.Size = new System.Drawing.Size(42, 268);
            this.advancpanel.TabIndex = 26;
            this.advancpanel.Visible = false;
            // 
            // apercent
            // 
            this.apercent.Location = new System.Drawing.Point(3, 225);
            this.apercent.Name = "apercent";
            this.apercent.Size = new System.Drawing.Size(34, 38);
            this.apercent.TabIndex = 30;
            this.apercent.TabStop = false;
            this.apercent.Text = "%";
            this.apercent.UseVisualStyleBackColor = true;
            this.apercent.Click += new System.EventHandler(this.apercent_Click);
            // 
            // apow
            // 
            this.apow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apow.Location = new System.Drawing.Point(3, 181);
            this.apow.Name = "apow";
            this.apow.Size = new System.Drawing.Size(34, 38);
            this.apow.TabIndex = 29;
            this.apow.TabStop = false;
            this.apow.Text = "x²";
            this.apow.UseVisualStyleBackColor = true;
            this.apow.Click += new System.EventHandler(this.apow_Click);
            // 
            // asqr
            // 
            this.asqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asqr.Location = new System.Drawing.Point(3, 137);
            this.asqr.Name = "asqr";
            this.asqr.Size = new System.Drawing.Size(34, 38);
            this.asqr.TabIndex = 28;
            this.asqr.TabStop = false;
            this.asqr.Text = "√";
            this.asqr.UseVisualStyleBackColor = true;
            this.asqr.Click += new System.EventHandler(this.asqr_Click);
            // 
            // atan
            // 
            this.atan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atan.Location = new System.Drawing.Point(3, 93);
            this.atan.Name = "atan";
            this.atan.Size = new System.Drawing.Size(34, 38);
            this.atan.TabIndex = 27;
            this.atan.TabStop = false;
            this.atan.Text = "tan";
            this.atan.UseVisualStyleBackColor = true;
            this.atan.Click += new System.EventHandler(this.atan_Click);
            // 
            // acos
            // 
            this.acos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acos.Location = new System.Drawing.Point(3, 49);
            this.acos.Name = "acos";
            this.acos.Size = new System.Drawing.Size(34, 38);
            this.acos.TabIndex = 26;
            this.acos.TabStop = false;
            this.acos.Text = "cos";
            this.acos.UseVisualStyleBackColor = true;
            this.acos.Click += new System.EventHandler(this.acos_Click);
            // 
            // asin
            // 
            this.asin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asin.Location = new System.Drawing.Point(3, 5);
            this.asin.Name = "asin";
            this.asin.Size = new System.Drawing.Size(34, 38);
            this.asin.TabIndex = 25;
            this.asin.TabStop = false;
            this.asin.Text = "sin";
            this.asin.UseVisualStyleBackColor = true;
            this.asin.Click += new System.EventHandler(this.asin_Click);
            // 
            // big2norm
            // 
            this.big2norm.Location = new System.Drawing.Point(317, 12);
            this.big2norm.Name = "big2norm";
            this.big2norm.Size = new System.Drawing.Size(10, 268);
            this.big2norm.TabIndex = 31;
            this.big2norm.TabStop = false;
            this.big2norm.Text = "*";
            this.big2norm.UseVisualStyleBackColor = true;
            this.big2norm.Visible = false;
            this.big2norm.Click += new System.EventHandler(this.big2norm_Click);
            // 
            // trayicon
            // 
            this.trayicon.ContextMenuStrip = this.traymenu;
            this.trayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayicon.Icon")));
            this.trayicon.Text = "Elculator";
            this.trayicon.Visible = true;
            this.trayicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayicon_MouseDoubleClick);
            // 
            // traymenu
            // 
            this.traymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmRestore,
            this.tmHide,
            this.toolStripSeparator1,
            this.tmManual,
            this.tmBug,
            this.tmAbout,
            this.toolStripSeparator2,
            this.tmExit});
            this.traymenu.Name = "traymenu";
            this.traymenu.ShowImageMargin = false;
            this.traymenu.Size = new System.Drawing.Size(125, 148);
            // 
            // tmRestore
            // 
            this.tmRestore.Name = "tmRestore";
            this.tmRestore.Size = new System.Drawing.Size(124, 22);
            this.tmRestore.Text = "Restore";
            this.tmRestore.Click += new System.EventHandler(this.tmRestore_Click);
            // 
            // tmHide
            // 
            this.tmHide.Name = "tmHide";
            this.tmHide.Size = new System.Drawing.Size(124, 22);
            this.tmHide.Text = "Hide";
            this.tmHide.Click += new System.EventHandler(this.tmHide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // tmManual
            // 
            this.tmManual.Name = "tmManual";
            this.tmManual.Size = new System.Drawing.Size(124, 22);
            this.tmManual.Text = "Manual (web)";
            this.tmManual.Click += new System.EventHandler(this.tmManual_Click);
            // 
            // tmBug
            // 
            this.tmBug.Name = "tmBug";
            this.tmBug.Size = new System.Drawing.Size(124, 22);
            this.tmBug.Text = "Say bug (web)";
            this.tmBug.Click += new System.EventHandler(this.tmBug_Click);
            // 
            // tmAbout
            // 
            this.tmAbout.Name = "tmAbout";
            this.tmAbout.Size = new System.Drawing.Size(124, 22);
            this.tmAbout.Text = "About";
            this.tmAbout.Click += new System.EventHandler(this.tmAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // tmExit
            // 
            this.tmExit.Name = "tmExit";
            this.tmExit.Size = new System.Drawing.Size(124, 22);
            this.tmExit.Text = "Exit";
            this.tmExit.Click += new System.EventHandler(this.tmExit_Click);
            // 
            // Задание_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 291);
            this.Controls.Add(this.big2norm);
            this.Controls.Add(this.advancpanel);
            this.Controls.Add(this.small2norm);
            this.Controls.Add(this.norm2small);
            this.Controls.Add(this.norm2big);
            this.Controls.Add(this.memlab);
            this.Controls.Add(this.resultdisp);
            this.Controls.Add(this.buttonpanel);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Задание_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcForm_KeyPress);
            this.Resize += new System.EventHandler(this.CalcForm_Resize);
            this.buttonpanel.ResumeLayout(false);
            this.advancpanel.ResumeLayout(false);
            this.traymenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiplied;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button memclean;
        private System.Windows.Forms.Button memrite;
        private System.Windows.Forms.Button memplus;
        private System.Windows.Forms.Button memminus;
        private System.Windows.Forms.Label memlab;
        private System.Windows.Forms.TextBox resultdisp;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button norm2big;
        private System.Windows.Forms.Button norm2small;
        private System.Windows.Forms.Button small2norm;
        private System.Windows.Forms.Panel advancpanel;
        private System.Windows.Forms.Button asin;
        private System.Windows.Forms.Button big2norm;
        private System.Windows.Forms.Button apercent;
        private System.Windows.Forms.Button apow;
        private System.Windows.Forms.Button asqr;
        private System.Windows.Forms.Button atan;
        private System.Windows.Forms.Button acos;
        private System.Windows.Forms.NotifyIcon trayicon;
        private System.Windows.Forms.ContextMenuStrip traymenu;
        private System.Windows.Forms.ToolStripMenuItem tmRestore;
        private System.Windows.Forms.ToolStripMenuItem tmHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmManual;
        private System.Windows.Forms.ToolStripMenuItem tmBug;
        private System.Windows.Forms.ToolStripMenuItem tmAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tmExit;
    }
}

