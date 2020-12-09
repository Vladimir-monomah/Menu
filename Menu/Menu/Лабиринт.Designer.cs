namespace Menu
{
    partial class Лабиринт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Лабиринт));
            this.button_start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.box_sound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(412, 292);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(101, 36);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Начать игру";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(105, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_sound
            // 
            this.box_sound.AutoSize = true;
            this.box_sound.BackColor = System.Drawing.Color.Transparent;
            this.box_sound.Checked = true;
            this.box_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_sound.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_sound.Location = new System.Drawing.Point(423, 251);
            this.box_sound.Name = "box_sound";
            this.box_sound.Size = new System.Drawing.Size(92, 20);
            this.box_sound.TabIndex = 2;
            this.box_sound.Text = "Звук есть";
            this.box_sound.UseVisualStyleBackColor = false;
            this.box_sound.CheckedChanged += new System.EventHandler(this.box_sound_CheckedChanged);
            // 
            // Лабиринт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.labirinty_dlya_detey_igr_skachat_52850_large;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.ControlBox = false;
            this.Controls.Add(this.box_sound);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_start);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Лабиринт";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабиринт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox box_sound;
    }
}