namespace regg
{
    partial class GlavnoOkno
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
            this.vnosBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_prihod = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.ura = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.izhod1 = new System.Windows.Forms.Label();
            this.SkupnoStUr = new System.Windows.Forms.Label();
            this.lbl_casIzhod = new System.Windows.Forms.Label();
            this.lbl_casSkupni = new System.Windows.Forms.Label();
            this.tipkovnica = new System.Windows.Forms.Panel();
            this.enter = new System.Windows.Forms.Button();
            this.st0 = new System.Windows.Forms.Button();
            this.st9 = new System.Windows.Forms.Button();
            this.st8 = new System.Windows.Forms.Button();
            this.st7 = new System.Windows.Forms.Button();
            this.st6 = new System.Windows.Forms.Button();
            this.st5 = new System.Windows.Forms.Button();
            this.st4 = new System.Windows.Forms.Button();
            this.st3 = new System.Windows.Forms.Button();
            this.st2 = new System.Windows.Forms.Button();
            this.st1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipkovnica.SuspendLayout();
            this.SuspendLayout();
            // 
            // vnosBox
            // 
            this.vnosBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.vnosBox.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vnosBox.Location = new System.Drawing.Point(372, 85);
            this.vnosBox.Name = "vnosBox";
            this.vnosBox.Size = new System.Drawing.Size(220, 38);
            this.vnosBox.TabIndex = 5;
            this.vnosBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vnosBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(271, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id kartice: ";
            // 
            // lbl_prihod
            // 
            this.lbl_prihod.AutoSize = true;
            this.lbl_prihod.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_prihod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_prihod.Location = new System.Drawing.Point(346, 171);
            this.lbl_prihod.Name = "lbl_prihod";
            this.lbl_prihod.Size = new System.Drawing.Size(0, 38);
            this.lbl_prihod.TabIndex = 11;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.date.Location = new System.Drawing.Point(12, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 25);
            this.date.TabIndex = 13;
            // 
            // ura
            // 
            this.ura.AutoSize = true;
            this.ura.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ura.Location = new System.Drawing.Point(12, 34);
            this.ura.Name = "ura";
            this.ura.Size = new System.Drawing.Size(0, 25);
            this.ura.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // izhod1
            // 
            this.izhod1.AutoSize = true;
            this.izhod1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izhod1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.izhod1.Location = new System.Drawing.Point(182, 264);
            this.izhod1.Name = "izhod1";
            this.izhod1.Size = new System.Drawing.Size(164, 18);
            this.izhod1.TabIndex = 15;
            this.izhod1.Text = "Od zadnjega izhoda: ";
            // 
            // SkupnoStUr
            // 
            this.SkupnoStUr.AutoSize = true;
            this.SkupnoStUr.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkupnoStUr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkupnoStUr.Location = new System.Drawing.Point(203, 305);
            this.SkupnoStUr.Name = "SkupnoStUr";
            this.SkupnoStUr.Size = new System.Drawing.Size(143, 18);
            this.SkupnoStUr.TabIndex = 16;
            this.SkupnoStUr.Text = "Skupno število ur:";
            // 
            // lbl_casIzhod
            // 
            this.lbl_casIzhod.AutoSize = true;
            this.lbl_casIzhod.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casIzhod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_casIzhod.Location = new System.Drawing.Point(367, 264);
            this.lbl_casIzhod.Name = "lbl_casIzhod";
            this.lbl_casIzhod.Size = new System.Drawing.Size(0, 29);
            this.lbl_casIzhod.TabIndex = 17;
            // 
            // lbl_casSkupni
            // 
            this.lbl_casSkupni.AutoSize = true;
            this.lbl_casSkupni.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casSkupni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_casSkupni.Location = new System.Drawing.Point(367, 305);
            this.lbl_casSkupni.Name = "lbl_casSkupni";
            this.lbl_casSkupni.Size = new System.Drawing.Size(0, 18);
            this.lbl_casSkupni.TabIndex = 18;
            // 
            // tipkovnica
            // 
            this.tipkovnica.Controls.Add(this.enter);
            this.tipkovnica.Controls.Add(this.st0);
            this.tipkovnica.Controls.Add(this.st9);
            this.tipkovnica.Controls.Add(this.st8);
            this.tipkovnica.Controls.Add(this.st7);
            this.tipkovnica.Controls.Add(this.st6);
            this.tipkovnica.Controls.Add(this.st5);
            this.tipkovnica.Controls.Add(this.st4);
            this.tipkovnica.Controls.Add(this.st3);
            this.tipkovnica.Controls.Add(this.st2);
            this.tipkovnica.Controls.Add(this.st1);
            this.tipkovnica.Location = new System.Drawing.Point(636, 206);
            this.tipkovnica.Name = "tipkovnica";
            this.tipkovnica.Size = new System.Drawing.Size(195, 226);
            this.tipkovnica.TabIndex = 19;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.enter.ForeColor = System.Drawing.Color.AliceBlue;
            this.enter.Image = global::regg.Properties.Resources.enterIcon;
            this.enter.Location = new System.Drawing.Point(129, 171);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(57, 50);
            this.enter.TabIndex = 10;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // st0
            // 
            this.st0.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st0.ForeColor = System.Drawing.Color.AliceBlue;
            this.st0.Location = new System.Drawing.Point(66, 171);
            this.st0.Name = "st0";
            this.st0.Size = new System.Drawing.Size(57, 50);
            this.st0.TabIndex = 9;
            this.st0.Text = "0";
            this.st0.UseVisualStyleBackColor = false;
            this.st0.Click += new System.EventHandler(this.st0_Click);
            // 
            // st9
            // 
            this.st9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st9.ForeColor = System.Drawing.Color.AliceBlue;
            this.st9.Location = new System.Drawing.Point(129, 114);
            this.st9.Name = "st9";
            this.st9.Size = new System.Drawing.Size(57, 50);
            this.st9.TabIndex = 8;
            this.st9.Text = "9";
            this.st9.UseVisualStyleBackColor = false;
            this.st9.Click += new System.EventHandler(this.st9_Click);
            // 
            // st8
            // 
            this.st8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st8.ForeColor = System.Drawing.Color.AliceBlue;
            this.st8.Location = new System.Drawing.Point(66, 115);
            this.st8.Name = "st8";
            this.st8.Size = new System.Drawing.Size(57, 50);
            this.st8.TabIndex = 7;
            this.st8.Text = "8";
            this.st8.UseVisualStyleBackColor = false;
            this.st8.Click += new System.EventHandler(this.st8_Click);
            // 
            // st7
            // 
            this.st7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st7.ForeColor = System.Drawing.Color.AliceBlue;
            this.st7.Location = new System.Drawing.Point(3, 115);
            this.st7.Name = "st7";
            this.st7.Size = new System.Drawing.Size(57, 50);
            this.st7.TabIndex = 6;
            this.st7.Text = "7";
            this.st7.UseVisualStyleBackColor = false;
            this.st7.Click += new System.EventHandler(this.st7_Click);
            // 
            // st6
            // 
            this.st6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st6.ForeColor = System.Drawing.Color.AliceBlue;
            this.st6.Location = new System.Drawing.Point(129, 58);
            this.st6.Name = "st6";
            this.st6.Size = new System.Drawing.Size(57, 50);
            this.st6.TabIndex = 5;
            this.st6.Text = "6";
            this.st6.UseVisualStyleBackColor = false;
            this.st6.Click += new System.EventHandler(this.st6_Click);
            // 
            // st5
            // 
            this.st5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st5.ForeColor = System.Drawing.Color.AliceBlue;
            this.st5.Location = new System.Drawing.Point(66, 59);
            this.st5.Name = "st5";
            this.st5.Size = new System.Drawing.Size(57, 50);
            this.st5.TabIndex = 4;
            this.st5.Text = "5";
            this.st5.UseVisualStyleBackColor = false;
            this.st5.Click += new System.EventHandler(this.st5_Click);
            // 
            // st4
            // 
            this.st4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st4.ForeColor = System.Drawing.Color.AliceBlue;
            this.st4.Location = new System.Drawing.Point(3, 59);
            this.st4.Name = "st4";
            this.st4.Size = new System.Drawing.Size(57, 50);
            this.st4.TabIndex = 3;
            this.st4.Text = "4";
            this.st4.UseVisualStyleBackColor = false;
            this.st4.Click += new System.EventHandler(this.st4_Click);
            // 
            // st3
            // 
            this.st3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st3.ForeColor = System.Drawing.Color.AliceBlue;
            this.st3.Location = new System.Drawing.Point(129, 3);
            this.st3.Name = "st3";
            this.st3.Size = new System.Drawing.Size(57, 50);
            this.st3.TabIndex = 2;
            this.st3.Text = "3";
            this.st3.UseVisualStyleBackColor = false;
            this.st3.Click += new System.EventHandler(this.st3_Click);
            // 
            // st2
            // 
            this.st2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st2.ForeColor = System.Drawing.Color.AliceBlue;
            this.st2.Location = new System.Drawing.Point(66, 3);
            this.st2.Name = "st2";
            this.st2.Size = new System.Drawing.Size(57, 50);
            this.st2.TabIndex = 1;
            this.st2.Text = "2";
            this.st2.UseVisualStyleBackColor = false;
            this.st2.Click += new System.EventHandler(this.st2_Click);
            // 
            // st1
            // 
            this.st1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.st1.ForeColor = System.Drawing.Color.AliceBlue;
            this.st1.Location = new System.Drawing.Point(3, 3);
            this.st1.Name = "st1";
            this.st1.Size = new System.Drawing.Size(57, 50);
            this.st1.TabIndex = 0;
            this.st1.Text = "1";
            this.st1.UseVisualStyleBackColor = false;
            this.st1.Click += new System.EventHandler(this.st1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // GlavnoOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1101, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipkovnica);
            this.Controls.Add(this.lbl_casSkupni);
            this.Controls.Add(this.lbl_casIzhod);
            this.Controls.Add(this.SkupnoStUr);
            this.Controls.Add(this.izhod1);
            this.Controls.Add(this.ura);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lbl_prihod);
            this.Controls.Add(this.vnosBox);
            this.Controls.Add(this.label2);
            this.Name = "GlavnoOkno";
            this.Text = "Registrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tipkovnica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox vnosBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_prihod;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label ura;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label izhod1;
        private System.Windows.Forms.Label SkupnoStUr;
        private System.Windows.Forms.Label lbl_casIzhod;
        private System.Windows.Forms.Label lbl_casSkupni;
        private System.Windows.Forms.Panel tipkovnica;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button st0;
        private System.Windows.Forms.Button st9;
        private System.Windows.Forms.Button st8;
        private System.Windows.Forms.Button st7;
        private System.Windows.Forms.Button st6;
        private System.Windows.Forms.Button st5;
        private System.Windows.Forms.Button st4;
        private System.Windows.Forms.Button st3;
        private System.Windows.Forms.Button st2;
        private System.Windows.Forms.Button st1;
        private System.Windows.Forms.Label label1;
    }
}

