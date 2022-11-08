
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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(218, 33);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wybrany lekarz:";
            // 
            // labelLekarz
            // 
            this.labelLekarz.AutoSize = true;
            this.labelLekarz.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLekarz.Location = new System.Drawing.Point(446, 33);
            this.labelLekarz.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelLekarz.Name = "labelLekarz";
            this.labelLekarz.Size = new System.Drawing.Size(222, 27);
            this.labelLekarz.TabIndex = 7;
            this.labelLekarz.Text = "imie i nazwisko";
            // 
            // dataWizyty
            // 
            this.dataWizyty.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataWizyty.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataWizyty.Location = new System.Drawing.Point(446, 88);
            this.dataWizyty.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dataWizyty.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dataWizyty.Name = "dataWizyty";
            this.dataWizyty.Size = new System.Drawing.Size(222, 38);
            this.dataWizyty.TabIndex = 8;
            this.dataWizyty.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 97);
            this.label1.MaximumSize = new System.Drawing.Size(700, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Proszę wybrać datę wizyty:";
            // 
            // labelGodzina
            // 
            this.labelGodzina.AutoSize = true;
            this.labelGodzina.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGodzina.Location = new System.Drawing.Point(22, 167);
            this.labelGodzina.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelGodzina.Name = "labelGodzina";
            this.labelGodzina.Size = new System.Drawing.Size(418, 27);
            this.labelGodzina.TabIndex = 10;
            this.labelGodzina.Text = "Proszę wybrać godzinę wizyty:";
            // 
            // godzinaPicker
            // 
            this.godzinaPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.godzinaPicker.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.godzinaPicker.FormattingEnabled = true;
            this.godzinaPicker.Location = new System.Drawing.Point(446, 161);
            this.godzinaPicker.Name = "godzinaPicker";
            this.godzinaPicker.Size = new System.Drawing.Size(222, 38);
            this.godzinaPicker.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 262);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
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
    }
}