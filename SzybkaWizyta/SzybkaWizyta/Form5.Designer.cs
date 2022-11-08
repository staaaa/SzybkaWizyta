
namespace SzybkaWizyta
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataWizyty = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 28);
            this.label2.MaximumSize = new System.Drawing.Size(800, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(726, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Witaj w aplikacji SzybkaWizyta - wersja dla lekarzy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 76);
            this.label1.MaximumSize = new System.Drawing.Size(800, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz dzień, dla którego ma zostać wyświetlony terminarz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataWizyty
            // 
            this.dataWizyty.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataWizyty.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataWizyty.Location = new System.Drawing.Point(320, 133);
            this.dataWizyty.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dataWizyty.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dataWizyty.Name = "dataWizyty";
            this.dataWizyty.Size = new System.Drawing.Size(222, 38);
            this.dataWizyty.TabIndex = 10;
            this.dataWizyty.ValueChanged += new System.EventHandler(this.dataWizyty_ValueChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dataWizyty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataWizyty;
    }
}