
namespace SzybkaWizyta
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelLekarz = new System.Windows.Forms.Label();
            this.dataWizyty = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGodzina = new System.Windows.Forms.Label();
            this.godzinaPicker = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wybrany lekarz:";
            // 
            // labelLekarz
            // 
            this.labelLekarz.AutoSize = true;
            this.labelLekarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLekarz.Location = new System.Drawing.Point(220, 120);
            this.labelLekarz.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelLekarz.Name = "labelLekarz";
            this.labelLekarz.Size = new System.Drawing.Size(136, 24);
            this.labelLekarz.TabIndex = 7;
            this.labelLekarz.Text = "imie i nazwisko";
            // 
            // dataWizyty
            // 
            this.dataWizyty.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataWizyty.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.dataWizyty.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.dataWizyty.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.dataWizyty.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.dataWizyty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataWizyty.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataWizyty.Location = new System.Drawing.Point(320, 180);
            this.dataWizyty.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dataWizyty.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dataWizyty.Name = "dataWizyty";
            this.dataWizyty.Size = new System.Drawing.Size(222, 29);
            this.dataWizyty.TabIndex = 8;
            this.dataWizyty.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 180);
            this.label1.MaximumSize = new System.Drawing.Size(700, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Proszę wybrać datę wizyty:";
            // 
            // labelGodzina
            // 
            this.labelGodzina.AutoSize = true;
            this.labelGodzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGodzina.Location = new System.Drawing.Point(40, 240);
            this.labelGodzina.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelGodzina.Name = "labelGodzina";
            this.labelGodzina.Size = new System.Drawing.Size(265, 24);
            this.labelGodzina.TabIndex = 10;
            this.labelGodzina.Text = "Proszę wybrać godzinę wizyty:";
            // 
            // godzinaPicker
            // 
            this.godzinaPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.godzinaPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.godzinaPicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.godzinaPicker.FormattingEnabled = true;
            this.godzinaPicker.Location = new System.Drawing.Point(350, 240);
            this.godzinaPicker.Name = "godzinaPicker";
            this.godzinaPicker.Size = new System.Drawing.Size(222, 32);
            this.godzinaPicker.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(40, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 280);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 80);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lekarze - Wybrany lekarz ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.godzinaPicker);
            this.Controls.Add(this.labelGodzina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataWizyty);
            this.Controls.Add(this.labelLekarz);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "SzybkaWizyta - wybór dnia i godziny";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLekarz;
        private System.Windows.Forms.DateTimePicker dataWizyty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGodzina;
        private System.Windows.Forms.ComboBox godzinaPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}