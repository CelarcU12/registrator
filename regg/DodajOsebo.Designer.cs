namespace regg
{
    partial class DodajOsebo
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
            this.btnVstavi = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priimekBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVstavi
            // 
            this.btnVstavi.Location = new System.Drawing.Point(146, 191);
            this.btnVstavi.Name = "btnVstavi";
            this.btnVstavi.Size = new System.Drawing.Size(75, 23);
            this.btnVstavi.TabIndex = 17;
            this.btnVstavi.Text = "VSTAVI";
            this.btnVstavi.UseVisualStyleBackColor = true;
            this.btnVstavi.Click += new System.EventHandler(this.btnVstavi_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(106, 140);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(161, 20);
            this.IDBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID";
            // 
            // priimekBox
            // 
            this.priimekBox.Location = new System.Drawing.Point(106, 114);
            this.priimekBox.Name = "priimekBox";
            this.priimekBox.Size = new System.Drawing.Size(161, 20);
            this.priimekBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Priimek";
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(106, 88);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(161, 20);
            this.imeBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime";
            // 
            // DodajOsebo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 274);
            this.Controls.Add(this.btnVstavi);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priimekBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.label1);
            this.Name = "DodajOsebo";
            this.Text = "DodajOsebo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVstavi;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priimekBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Label label1;
    }
}