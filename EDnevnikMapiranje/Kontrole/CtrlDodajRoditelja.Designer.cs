﻿namespace EDnevnikMapiranje
{
    partial class CtrlDodajRoditelja
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJmgb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbUSavetu = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatumOdUSavetu = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatumDoUSavetu = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbZensko.ForeColor = System.Drawing.Color.White;
            this.rbZensko.Location = new System.Drawing.Point(110, 240);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(76, 23);
            this.rbZensko.TabIndex = 37;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Zensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbMusko.ForeColor = System.Drawing.Color.White;
            this.rbMusko.Location = new System.Drawing.Point(110, 211);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(75, 23);
            this.rbMusko.TabIndex = 36;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Musko";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Datum Rodjenja";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(141, 159);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRodjenja.TabIndex = 34;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(141, 185);
            this.txtBrojTelefona.MaxLength = 12;
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTelefona.TabIndex = 33;
            this.txtBrojTelefona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJmgb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Broj Telefona";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(141, 133);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Lozinka";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(141, 83);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnickoIme.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Korisnicko Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(141, 55);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(141, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ime";
            // 
            // txtJmgb
            // 
            this.txtJmgb.Location = new System.Drawing.Point(141, 3);
            this.txtJmgb.MaxLength = 13;
            this.txtJmgb.Name = "txtJmgb";
            this.txtJmgb.Size = new System.Drawing.Size(100, 20);
            this.txtJmgb.TabIndex = 21;
            this.txtJmgb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJmgb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "JMBG";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(141, 336);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(78, 40);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // cbUSavetu
            // 
            this.cbUSavetu.AutoSize = true;
            this.cbUSavetu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbUSavetu.ForeColor = System.Drawing.Color.White;
            this.cbUSavetu.Location = new System.Drawing.Point(110, 263);
            this.cbUSavetu.Name = "cbUSavetu";
            this.cbUSavetu.Size = new System.Drawing.Size(89, 23);
            this.cbUSavetu.TabIndex = 38;
            this.cbUSavetu.Text = "U Savetu";
            this.cbUSavetu.UseVisualStyleBackColor = true;
            this.cbUSavetu.CheckedChanged += new System.EventHandler(this.CbUSavetu_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Datum Od U Savetu";
            // 
            // dtpDatumOdUSavetu
            // 
            this.dtpDatumOdUSavetu.Location = new System.Drawing.Point(155, 284);
            this.dtpDatumOdUSavetu.Name = "dtpDatumOdUSavetu";
            this.dtpDatumOdUSavetu.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOdUSavetu.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 19);
            this.label10.TabIndex = 42;
            this.label10.Text = "Datum Do U Savetu";
            // 
            // dtpDatumDoUSavetu
            // 
            this.dtpDatumDoUSavetu.Location = new System.Drawing.Point(155, 310);
            this.dtpDatumDoUSavetu.Name = "dtpDatumDoUSavetu";
            this.dtpDatumDoUSavetu.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDoUSavetu.TabIndex = 41;
            // 
            // CtrlDodajRoditelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDatumDoUSavetu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDatumOdUSavetu);
            this.Controls.Add(this.cbUSavetu);
            this.Controls.Add(this.rbZensko);
            this.Controls.Add(this.rbMusko);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJmgb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Name = "CtrlDodajRoditelja";
            this.Size = new System.Drawing.Size(383, 379);
            this.Load += new System.EventHandler(this.CtrlDodajRoditelja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbZensko;
        private System.Windows.Forms.RadioButton rbMusko;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJmgb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox cbUSavetu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatumOdUSavetu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDatumDoUSavetu;
    }
}
