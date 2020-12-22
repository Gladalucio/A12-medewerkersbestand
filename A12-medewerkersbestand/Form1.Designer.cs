namespace Salaris
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
            this.components = new System.ComponentModel.Container();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVolgNr = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSalaris = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.btnSalaris = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnLaden = new System.Windows.Forms.Button();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.txtPostcode2 = new System.Windows.Forms.TextBox();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(59, 213);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(2);
            this.btnToevoegen.MinimumSize = new System.Drawing.Size(113, 34);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(127, 34);
            this.btnToevoegen.TabIndex = 7;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volgnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salaris";
            // 
            // txtVolgNr
            // 
            this.txtVolgNr.Enabled = false;
            this.txtVolgNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolgNr.Location = new System.Drawing.Point(150, 19);
            this.txtVolgNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtVolgNr.Multiline = true;
            this.txtVolgNr.Name = "txtVolgNr";
            this.txtVolgNr.Size = new System.Drawing.Size(61, 24);
            this.txtVolgNr.TabIndex = 6;
            this.txtVolgNr.Text = "1";
            this.txtVolgNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(150, 47);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaam.Multiline = true;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(186, 26);
            this.txtNaam.TabIndex = 1;
            this.txtNaam.Leave += new System.EventHandler(this.txtNaam_Leave);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(150, 77);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(186, 25);
            this.txtAdres.TabIndex = 2;
            // 
            // txtSalaris
            // 
            this.txtSalaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaris.Location = new System.Drawing.Point(150, 168);
            this.txtSalaris.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalaris.Multiline = true;
            this.txtSalaris.Name = "txtSalaris";
            this.txtSalaris.Size = new System.Drawing.Size(93, 27);
            this.txtSalaris.TabIndex = 6;
            this.txtSalaris.Leave += new System.EventHandler(this.txtSalaris_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "€";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(150, 107);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.MaxLength = 4;
            this.txtPostcode.MinimumSize = new System.Drawing.Size(44, 25);
            this.txtPostcode.Multiline = true;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(61, 25);
            this.txtPostcode.TabIndex = 3;
            this.txtPostcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPostcode.Leave += new System.EventHandler(this.txtPostcode_Leave);
            // 
            // btnSalaris
            // 
            this.btnSalaris.Enabled = false;
            this.btnSalaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaris.Location = new System.Drawing.Point(197, 213);
            this.btnSalaris.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalaris.MinimumSize = new System.Drawing.Size(113, 34);
            this.btnSalaris.Name = "btnSalaris";
            this.btnSalaris.Size = new System.Drawing.Size(127, 34);
            this.btnSalaris.TabIndex = 8;
            this.btnSalaris.Text = "Salaris";
            this.btnSalaris.UseVisualStyleBackColor = true;
            this.btnSalaris.Click += new System.EventHandler(this.btnSalaris_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Enabled = false;
            this.btnVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.Location = new System.Drawing.Point(59, 260);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerwijderen.MinimumSize = new System.Drawing.Size(113, 34);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(127, 34);
            this.btnVerwijderen.TabIndex = 9;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnLaden
            // 
            this.btnLaden.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaden.Location = new System.Drawing.Point(197, 260);
            this.btnLaden.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaden.MinimumSize = new System.Drawing.Size(113, 34);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(127, 34);
            this.btnLaden.TabIndex = 10;
            this.btnLaden.Text = "Laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            this.btnLaden.Click += new System.EventHandler(this.btnLaden_Click);
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.Enabled = false;
            this.btnWijzigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigen.Location = new System.Drawing.Point(59, 307);
            this.btnWijzigen.Margin = new System.Windows.Forms.Padding(2);
            this.btnWijzigen.MinimumSize = new System.Drawing.Size(113, 34);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(127, 34);
            this.btnWijzigen.TabIndex = 11;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Enabled = false;
            this.btnOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpslaan.Location = new System.Drawing.Point(197, 307);
            this.btnOpslaan.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpslaan.MinimumSize = new System.Drawing.Size(113, 34);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(127, 34);
            this.btnOpslaan.TabIndex = 12;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(17, 358);
            this.lstData.Margin = new System.Windows.Forms.Padding(2);
            this.lstData.MinimumSize = new System.Drawing.Size(339, 212);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(339, 251);
            this.lstData.TabIndex = 13;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // txtPostcode2
            // 
            this.txtPostcode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode2.Location = new System.Drawing.Point(231, 107);
            this.txtPostcode2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode2.MaxLength = 2;
            this.txtPostcode2.Multiline = true;
            this.txtPostcode2.Name = "txtPostcode2";
            this.txtPostcode2.Size = new System.Drawing.Size(44, 25);
            this.txtPostcode2.TabIndex = 4;
            this.txtPostcode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPostcode2.Leave += new System.EventHandler(this.txtPostcode2_Leave);
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWoonplaats.Location = new System.Drawing.Point(150, 137);
            this.txtWoonplaats.Margin = new System.Windows.Forms.Padding(2);
            this.txtWoonplaats.Multiline = true;
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.Size = new System.Drawing.Size(186, 27);
            this.txtWoonplaats.TabIndex = 5;
            this.txtWoonplaats.Leave += new System.EventHandler(this.txtWoonplaats_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Woonplaats";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV | *.csv";
            // 
            // err
            // 
            this.err.BlinkRate = 0;
            this.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(375, 624);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWoonplaats);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.btnLaden);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnSalaris);
            this.Controls.Add(this.txtPostcode2);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalaris);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtVolgNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToevoegen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(375, 624);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medewerkerbestand";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVolgNr;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSalaris;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Button btnSalaris;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.TextBox txtPostcode2;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

