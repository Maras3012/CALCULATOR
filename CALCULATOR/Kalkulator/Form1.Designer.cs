namespace Kalkulator        //namespace se koristi za organiziranje klasa a Calculator je ime programa
{
    partial class Form1     //dio klase Form1
    {
        private System.ComponentModel.IContainer components = null;     //omogucava funkcioniranje kontenjera

        protected override void Dispose(bool disposing)     //cisti koristene resurse
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tipka0 = new System.Windows.Forms.Button();
            this.tipka1 = new System.Windows.Forms.Button();
            this.tipka2 = new System.Windows.Forms.Button();
            this.tipka3 = new System.Windows.Forms.Button();
            this.tipka4 = new System.Windows.Forms.Button();
            this.tipka5 = new System.Windows.Forms.Button();
            this.tipka6 = new System.Windows.Forms.Button();
            this.tipka7 = new System.Windows.Forms.Button();
            this.tipka8 = new System.Windows.Forms.Button();
            this.tipka9 = new System.Windows.Forms.Button();
            this.tipka10 = new System.Windows.Forms.Button();
            this.tipka11 = new System.Windows.Forms.Button();
            this.tipka14 = new System.Windows.Forms.Button();
            this.tipka15 = new System.Windows.Forms.Button();
            this.tipka18 = new System.Windows.Forms.Button();
            this.tipka19 = new System.Windows.Forms.Button();
            this.tipka23 = new System.Windows.Forms.Button();
            this.tipka22 = new System.Windows.Forms.Button();
            this.tipka12 = new System.Windows.Forms.Button();
            this.tipka16 = new System.Windows.Forms.Button();
            this.tipka13 = new System.Windows.Forms.Button();
            this.tipka17 = new System.Windows.Forms.Button();
            this.tipka20 = new System.Windows.Forms.Button();
            this.tipka21 = new System.Windows.Forms.Button();
            this.tipka24 = new System.Windows.Forms.Button();
            this.tipka25 = new System.Windows.Forms.Button();
            this.Ekran_Rezultat = new System.Windows.Forms.TextBox();
            this.Ekran_Pred_Rezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tipka0
            // 
            this.tipka0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka0.Location = new System.Drawing.Point(22, 226);
            this.tipka0.Name = "tipka0";
            this.tipka0.Size = new System.Drawing.Size(96, 45);
            this.tipka0.TabIndex = 15;
            this.tipka0.Text = "0";
            this.tipka0.UseVisualStyleBackColor = false;
            this.tipka0.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka1
            // 
            this.tipka1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka1.Location = new System.Drawing.Point(22, 175);
            this.tipka1.Name = "tipka1";
            this.tipka1.Size = new System.Drawing.Size(45, 45);
            this.tipka1.TabIndex = 10;
            this.tipka1.Text = "1";
            this.tipka1.UseVisualStyleBackColor = false;
            this.tipka1.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka2
            // 
            this.tipka2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka2.Location = new System.Drawing.Point(73, 175);
            this.tipka2.Name = "tipka2";
            this.tipka2.Size = new System.Drawing.Size(45, 45);
            this.tipka2.TabIndex = 11;
            this.tipka2.Text = "2";
            this.tipka2.UseVisualStyleBackColor = false;
            this.tipka2.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka3
            // 
            this.tipka3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka3.Location = new System.Drawing.Point(124, 175);
            this.tipka3.Name = "tipka3";
            this.tipka3.Size = new System.Drawing.Size(45, 45);
            this.tipka3.TabIndex = 12;
            this.tipka3.Text = "3";
            this.tipka3.UseVisualStyleBackColor = false;
            this.tipka3.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka4
            // 
            this.tipka4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka4.Location = new System.Drawing.Point(22, 124);
            this.tipka4.Name = "tipka4";
            this.tipka4.Size = new System.Drawing.Size(45, 45);
            this.tipka4.TabIndex = 5;
            this.tipka4.Text = "4";
            this.tipka4.UseVisualStyleBackColor = false;
            this.tipka4.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka5
            // 
            this.tipka5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka5.Location = new System.Drawing.Point(73, 124);
            this.tipka5.Name = "tipka5";
            this.tipka5.Size = new System.Drawing.Size(45, 45);
            this.tipka5.TabIndex = 6;
            this.tipka5.Text = "5";
            this.tipka5.UseVisualStyleBackColor = false;
            this.tipka5.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka6
            // 
            this.tipka6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka6.Location = new System.Drawing.Point(124, 124);
            this.tipka6.Name = "tipka6";
            this.tipka6.Size = new System.Drawing.Size(45, 45);
            this.tipka6.TabIndex = 7;
            this.tipka6.Text = "6";
            this.tipka6.UseVisualStyleBackColor = false;
            this.tipka6.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka7
            // 
            this.tipka7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka7.Cursor = System.Windows.Forms.Cursors.Default;
            this.tipka7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka7.Location = new System.Drawing.Point(22, 73);
            this.tipka7.Name = "tipka7";
            this.tipka7.Size = new System.Drawing.Size(45, 45);
            this.tipka7.TabIndex = 0;
            this.tipka7.Text = "7";
            this.tipka7.UseVisualStyleBackColor = false;
            this.tipka7.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka8
            // 
            this.tipka8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka8.Location = new System.Drawing.Point(73, 73);
            this.tipka8.Name = "tipka8";
            this.tipka8.Size = new System.Drawing.Size(45, 45);
            this.tipka8.TabIndex = 1;
            this.tipka8.Text = "8";
            this.tipka8.UseVisualStyleBackColor = false;
            this.tipka8.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka9
            // 
            this.tipka9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka9.Location = new System.Drawing.Point(124, 73);
            this.tipka9.Name = "tipka9";
            this.tipka9.Size = new System.Drawing.Size(45, 45);
            this.tipka9.TabIndex = 2;
            this.tipka9.Text = "9";
            this.tipka9.UseVisualStyleBackColor = false;
            this.tipka9.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka10
            // 
            this.tipka10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka10.Location = new System.Drawing.Point(175, 73);
            this.tipka10.Name = "tipka10";
            this.tipka10.Size = new System.Drawing.Size(45, 45);
            this.tipka10.TabIndex = 3;
            this.tipka10.Text = "/";
            this.tipka10.UseVisualStyleBackColor = false;
            this.tipka10.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka11
            // 
            this.tipka11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka11.Location = new System.Drawing.Point(226, 73);
            this.tipka11.Name = "tipka11";
            this.tipka11.Size = new System.Drawing.Size(53, 45);
            this.tipka11.TabIndex = 4;
            this.tipka11.Text = "DEL";
            this.tipka11.UseVisualStyleBackColor = false;
            this.tipka11.Click += new System.EventHandler(this.operacija11_click);
            // 
            // tipka14
            // 
            this.tipka14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka14.Location = new System.Drawing.Point(175, 124);
            this.tipka14.Name = "tipka14";
            this.tipka14.Size = new System.Drawing.Size(45, 45);
            this.tipka14.TabIndex = 8;
            this.tipka14.Text = "*";
            this.tipka14.UseVisualStyleBackColor = false;
            this.tipka14.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka15
            // 
            this.tipka15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka15.Location = new System.Drawing.Point(226, 124);
            this.tipka15.Name = "tipka15";
            this.tipka15.Size = new System.Drawing.Size(53, 45);
            this.tipka15.TabIndex = 9;
            this.tipka15.Text = "AC";
            this.tipka15.UseVisualStyleBackColor = false;
            this.tipka15.Click += new System.EventHandler(this.operacija13_click);
            // 
            // tipka18
            // 
            this.tipka18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka18.Location = new System.Drawing.Point(175, 175);
            this.tipka18.Name = "tipka18";
            this.tipka18.Size = new System.Drawing.Size(45, 45);
            this.tipka18.TabIndex = 13;
            this.tipka18.Text = "-";
            this.tipka18.UseVisualStyleBackColor = false;
            this.tipka18.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka19
            // 
            this.tipka19.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka19.Location = new System.Drawing.Point(226, 175);
            this.tipka19.Name = "tipka19";
            this.tipka19.Size = new System.Drawing.Size(53, 96);
            this.tipka19.TabIndex = 19;
            this.tipka19.Text = "=";
            this.tipka19.UseVisualStyleBackColor = false;
            this.tipka19.Click += new System.EventHandler(this.operacija10_click);
            // 
            // tipka23
            // 
            this.tipka23.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka23.Location = new System.Drawing.Point(175, 226);
            this.tipka23.Name = "tipka23";
            this.tipka23.Size = new System.Drawing.Size(45, 45);
            this.tipka23.TabIndex = 18;
            this.tipka23.Text = "+";
            this.tipka23.UseVisualStyleBackColor = false;
            this.tipka23.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka22
            // 
            this.tipka22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipka22.Location = new System.Drawing.Point(124, 226);
            this.tipka22.Name = "tipka22";
            this.tipka22.Size = new System.Drawing.Size(45, 45);
            this.tipka22.TabIndex = 17;
            this.tipka22.Text = ".";
            this.tipka22.UseVisualStyleBackColor = false;
            this.tipka22.Click += new System.EventHandler(this.tipka_click);
            // 
            // tipka12
            // 
            this.tipka12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka12.Location = new System.Drawing.Point(285, 73);
            this.tipka12.Name = "tipka12";
            this.tipka12.Size = new System.Drawing.Size(45, 45);
            this.tipka12.TabIndex = 22;
            this.tipka12.Text = "SIN";
            this.tipka12.UseVisualStyleBackColor = false;
            this.tipka12.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka16
            // 
            this.tipka16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka16.Location = new System.Drawing.Point(285, 126);
            this.tipka16.Name = "tipka16";
            this.tipka16.Size = new System.Drawing.Size(45, 45);
            this.tipka16.TabIndex = 23;
            this.tipka16.Text = "TAN";
            this.tipka16.UseVisualStyleBackColor = false;
            this.tipka16.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka13
            // 
            this.tipka13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka13.Location = new System.Drawing.Point(336, 73);
            this.tipka13.Name = "tipka13";
            this.tipka13.Size = new System.Drawing.Size(45, 45);
            this.tipka13.TabIndex = 24;
            this.tipka13.Text = "COS";
            this.tipka13.UseVisualStyleBackColor = false;
            this.tipka13.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka17
            // 
            this.tipka17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka17.Location = new System.Drawing.Point(336, 126);
            this.tipka17.Name = "tipka17";
            this.tipka17.Size = new System.Drawing.Size(45, 45);
            this.tipka17.TabIndex = 25;
            this.tipka17.Text = "CTG";
            this.tipka17.UseVisualStyleBackColor = false;
            this.tipka17.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka20
            // 
            this.tipka20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka20.Location = new System.Drawing.Point(285, 177);
            this.tipka20.Name = "tipka20";
            this.tipka20.Size = new System.Drawing.Size(45, 45);
            this.tipka20.TabIndex = 26;
            this.tipka20.Text = "√";
            this.tipka20.UseVisualStyleBackColor = false;
            this.tipka20.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka21
            // 
            this.tipka21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka21.Location = new System.Drawing.Point(336, 177);
            this.tipka21.Name = "tipka21";
            this.tipka21.Size = new System.Drawing.Size(45, 45);
            this.tipka21.TabIndex = 27;
            this.tipka21.Text = "π";
            this.tipka21.UseVisualStyleBackColor = false;
            this.tipka21.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka24
            // 
            this.tipka24.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka24.Location = new System.Drawing.Point(285, 226);
            this.tipka24.Name = "tipka24";
            this.tipka24.Size = new System.Drawing.Size(45, 45);
            this.tipka24.TabIndex = 28;
            this.tipka24.Text = "HEX";
            this.tipka24.UseVisualStyleBackColor = false;
            this.tipka24.Click += new System.EventHandler(this.operacija_click);
            // 
            // tipka25
            // 
            this.tipka25.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipka25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipka25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipka25.Location = new System.Drawing.Point(336, 226);
            this.tipka25.Name = "tipka25";
            this.tipka25.Size = new System.Drawing.Size(45, 45);
            this.tipka25.TabIndex = 29;
            this.tipka25.Text = "BIN";
            this.tipka25.UseVisualStyleBackColor = false;
            this.tipka25.Click += new System.EventHandler(this.operacija_click);
            // 
            // Ekran_Rezultat
            // 
            this.Ekran_Rezultat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Ekran_Rezultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ekran_Rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekran_Rezultat.Location = new System.Drawing.Point(22, 40);
            this.Ekran_Rezultat.Name = "Ekran_Rezultat";
            this.Ekran_Rezultat.Size = new System.Drawing.Size(359, 29);
            this.Ekran_Rezultat.TabIndex = 20;
            this.Ekran_Rezultat.Text = "0";
            this.Ekran_Rezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ekran_Pred_Rezultat
            // 
            this.Ekran_Pred_Rezultat.AutoSize = true;
            this.Ekran_Pred_Rezultat.BackColor = System.Drawing.SystemColors.Window;
            this.Ekran_Pred_Rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekran_Pred_Rezultat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Ekran_Pred_Rezultat.Location = new System.Drawing.Point(18, 13);
            this.Ekran_Pred_Rezultat.Name = "Ekran_Pred_Rezultat";
            this.Ekran_Pred_Rezultat.Size = new System.Drawing.Size(0, 24);
            this.Ekran_Pred_Rezultat.TabIndex = 21;
            // 
            // Forma1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(403, 291);
            this.Controls.Add(this.Ekran_Pred_Rezultat);
            this.Controls.Add(this.Ekran_Rezultat);
            this.Controls.Add(this.tipka0);
            this.Controls.Add(this.tipka1);
            this.Controls.Add(this.tipka2);
            this.Controls.Add(this.tipka3);
            this.Controls.Add(this.tipka4);
            this.Controls.Add(this.tipka5);
            this.Controls.Add(this.tipka6);
            this.Controls.Add(this.tipka7);
            this.Controls.Add(this.tipka8);
            this.Controls.Add(this.tipka9);
            this.Controls.Add(this.tipka10);
            this.Controls.Add(this.tipka11);
            this.Controls.Add(this.tipka14);
            this.Controls.Add(this.tipka15);
            this.Controls.Add(this.tipka18);
            this.Controls.Add(this.tipka19);
            this.Controls.Add(this.tipka23);
            this.Controls.Add(this.tipka22);
            this.Controls.Add(this.tipka12);
            this.Controls.Add(this.tipka16);
            this.Controls.Add(this.tipka13);
            this.Controls.Add(this.tipka17);
            this.Controls.Add(this.tipka20);
            this.Controls.Add(this.tipka21);
            this.Controls.Add(this.tipka24);
            this.Controls.Add(this.tipka25);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Forma1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tipka0;
        private System.Windows.Forms.Button tipka1;
        private System.Windows.Forms.Button tipka2;
        private System.Windows.Forms.Button tipka3;
        private System.Windows.Forms.Button tipka4;
        private System.Windows.Forms.Button tipka5;
        private System.Windows.Forms.Button tipka6;
        private System.Windows.Forms.Button tipka7;
        private System.Windows.Forms.Button tipka8;
        private System.Windows.Forms.Button tipka9;
        private System.Windows.Forms.Button tipka10;
        private System.Windows.Forms.Button tipka11;
        private System.Windows.Forms.Button tipka14;
        private System.Windows.Forms.Button tipka15;
        private System.Windows.Forms.Button tipka18;
        private System.Windows.Forms.Button tipka19;
        private System.Windows.Forms.Button tipka23;
        private System.Windows.Forms.Button tipka22;
        private System.Windows.Forms.Button tipka12;
        private System.Windows.Forms.Button tipka16;
        private System.Windows.Forms.Button tipka13;
        private System.Windows.Forms.Button tipka17;
        private System.Windows.Forms.Button tipka20;
        private System.Windows.Forms.Button tipka21;
        private System.Windows.Forms.Button tipka24;
        private System.Windows.Forms.Button tipka25;
        private System.Windows.Forms.TextBox Ekran_Rezultat;
        private System.Windows.Forms.Label Ekran_Pred_Rezultat;
    }
}

