
namespace SzybkaWizyta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputPesel = new System.Windows.Forms.TextBox();
            this.inputHaslo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRejestracja = new System.Windows.Forms.Label();
            this.labelNotExist = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPesel
            // 
            this.inputPesel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.inputPesel.Font = new System.Drawing.Font("Nexa-Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPesel.Location = new System.Drawing.Point(140, 240);
            this.inputPesel.Multiline = true;
            this.inputPesel.Name = "inputPesel";
            this.inputPesel.Size = new System.Drawing.Size(600, 40);
            this.inputPesel.TabIndex = 0;
            // 
            // inputHaslo
            // 
            this.inputHaslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.inputHaslo.Font = new System.Drawing.Font("Nexa-Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputHaslo.Location = new System.Drawing.Point(140, 340);
            this.inputHaslo.Multiline = true;
            this.inputHaslo.Name = "inputHaslo";
            this.inputHaslo.Size = new System.Drawing.Size(600, 40);
            this.inputHaslo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Nexa-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(140, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "ZALOGUJ SIĘ!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Witamy w aplikacji SzybkaWizyta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa-Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zaloguj się, aby kontynuować...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(140, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasło:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nexa-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(250, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nie masz konta?";
            // 
            // labelRejestracja
            // 
            this.labelRejestracja.AutoSize = true;
            this.labelRejestracja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.labelRejestracja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRejestracja.Font = new System.Drawing.Font("Nexa-Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelRejestracja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.labelRejestracja.Location = new System.Drawing.Point(430, 596);
            this.labelRejestracja.Name = "labelRejestracja";
            this.labelRejestracja.Padding = new System.Windows.Forms.Padding(3);
            this.labelRejestracja.Size = new System.Drawing.Size(166, 33);
            this.labelRejestracja.TabIndex = 8;
            this.labelRejestracja.Text = "Zarejestruj się!";
            this.labelRejestracja.Click += new System.EventHandler(this.labelRejestracja_Click);
            // 
            // labelNotExist
            // 
            this.labelNotExist.AutoSize = true;
            this.labelNotExist.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNotExist.ForeColor = System.Drawing.Color.Red;
            this.labelNotExist.Location = new System.Drawing.Point(241, 421);
            this.labelNotExist.Name = "labelNotExist";
            this.labelNotExist.Size = new System.Drawing.Size(0, 21);
            this.labelNotExist.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 80);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelNotExist);
            this.Controls.Add(this.labelRejestracja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputHaslo);
            this.Controls.Add(this.inputPesel);
            this.Name = "Form1";
            this.Text = "SzybkaWizyta - logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPesel;
        private System.Windows.Forms.TextBox inputHaslo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRejestracja;
        private System.Windows.Forms.Label labelNotExist;
        private System.Windows.Forms.Panel panel2;
    }
}

