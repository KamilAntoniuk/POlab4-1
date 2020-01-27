namespace POlab4
{
    partial class Form1
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
            this.buttonMemorySave = new System.Windows.Forms.Button();
            this.buttonXMLopendes = new System.Windows.Forms.Button();
            this.buttonXMLsave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.LnameTB = new System.Windows.Forms.TextBox();
            this.FnameTB = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonMemorySave
            // 
            this.buttonMemorySave.Location = new System.Drawing.Point(281, 191);
            this.buttonMemorySave.Name = "buttonMemorySave";
            this.buttonMemorySave.Size = new System.Drawing.Size(108, 23);
            this.buttonMemorySave.TabIndex = 27;
            this.buttonMemorySave.Text = "Zapisz do pamięci";
            this.buttonMemorySave.UseVisualStyleBackColor = true;
            this.buttonMemorySave.Click += new System.EventHandler(this.buttonMemorySave_Click);
            // 
            // buttonXMLopendes
            // 
            this.buttonXMLopendes.Location = new System.Drawing.Point(787, 205);
            this.buttonXMLopendes.Name = "buttonXMLopendes";
            this.buttonXMLopendes.Size = new System.Drawing.Size(151, 23);
            this.buttonXMLopendes.TabIndex = 26;
            this.buttonXMLopendes.Text = "Wczytaj XML";
            this.buttonXMLopendes.UseVisualStyleBackColor = true;
            this.buttonXMLopendes.Click += new System.EventHandler(this.buttonXMLopendes_Click);
            // 
            // buttonXMLsave
            // 
            this.buttonXMLsave.Location = new System.Drawing.Point(144, 221);
            this.buttonXMLsave.Name = "buttonXMLsave";
            this.buttonXMLsave.Size = new System.Drawing.Size(130, 23);
            this.buttonXMLsave.TabIndex = 25;
            this.buttonXMLsave.Text = "Zapisz do XML";
            this.buttonXMLsave.UseVisualStyleBackColor = true;
            this.buttonXMLsave.Click += new System.EventHandler(this.buttonXMLsave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Wczytaj Json";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(377, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(561, 147);
            this.listBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adres zamieszkania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Imię";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Zapisz do Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(144, 155);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(200, 20);
            this.AddressTB.TabIndex = 17;
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(144, 115);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(200, 20);
            this.BirthDate.TabIndex = 16;
            // 
            // LnameTB
            // 
            this.LnameTB.Location = new System.Drawing.Point(144, 72);
            this.LnameTB.Name = "LnameTB";
            this.LnameTB.Size = new System.Drawing.Size(200, 20);
            this.LnameTB.TabIndex = 15;
            // 
            // FnameTB
            // 
            this.FnameTB.Location = new System.Drawing.Point(144, 29);
            this.FnameTB.Name = "FnameTB";
            this.FnameTB.Size = new System.Drawing.Size(200, 20);
            this.FnameTB.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(975, 271);
            this.Controls.Add(this.buttonMemorySave);
            this.Controls.Add(this.buttonXMLopendes);
            this.Controls.Add(this.buttonXMLsave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.LnameTB);
            this.Controls.Add(this.FnameTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMemorySave;
        private System.Windows.Forms.Button buttonXMLopendes;
        private System.Windows.Forms.Button buttonXMLsave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.TextBox LnameTB;
        private System.Windows.Forms.TextBox FnameTB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

