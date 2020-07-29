namespace FunkcjaKwadratowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelZnak = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbZnak = new System.Windows.Forms.TextBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.labelW = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelNier = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelWpr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Równania i nierówności kwadratowe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA.ForeColor = System.Drawing.Color.Purple;
            this.labelA.Location = new System.Drawing.Point(6, 51);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(100, 32);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Podaj a:";
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelB.ForeColor = System.Drawing.Color.Purple;
            this.labelB.Location = new System.Drawing.Point(226, 51);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(100, 32);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Podaj b:";
            // 
            // labelC
            // 
            this.labelC.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelC.ForeColor = System.Drawing.Color.Purple;
            this.labelC.Location = new System.Drawing.Point(467, 52);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(100, 31);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "Podaj c:";
            // 
            // labelZnak
            // 
            this.labelZnak.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZnak.ForeColor = System.Drawing.Color.Purple;
            this.labelZnak.Location = new System.Drawing.Point(711, 53);
            this.labelZnak.Name = "labelZnak";
            this.labelZnak.Size = new System.Drawing.Size(116, 30);
            this.labelZnak.TabIndex = 4;
            this.labelZnak.Text = "Podaj znak:";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbA.Location = new System.Drawing.Point(93, 49);
            this.tbA.Multiline = true;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(65, 37);
            this.tbA.TabIndex = 5;
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbB.Location = new System.Drawing.Point(318, 46);
            this.tbB.Multiline = true;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(65, 37);
            this.tbB.TabIndex = 6;
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbC
            // 
            this.tbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbC.Location = new System.Drawing.Point(573, 50);
            this.tbC.Multiline = true;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(65, 37);
            this.tbC.TabIndex = 7;
            this.tbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbZnak
            // 
            this.tbZnak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbZnak.Location = new System.Drawing.Point(853, 53);
            this.tbZnak.Multiline = true;
            this.tbZnak.Name = "tbZnak";
            this.tbZnak.Size = new System.Drawing.Size(65, 37);
            this.tbZnak.TabIndex = 8;
            this.tbZnak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOblicz.Location = new System.Drawing.Point(357, 114);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(102, 37);
            this.btnOblicz.TabIndex = 9;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // labelW
            // 
            this.labelW.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelW.ForeColor = System.Drawing.Color.Red;
            this.labelW.Location = new System.Drawing.Point(7, 196);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(249, 310);
            this.labelW.TabIndex = 10;
            this.labelW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelX
            // 
            this.labelX.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX.ForeColor = System.Drawing.Color.Red;
            this.labelX.Location = new System.Drawing.Point(328, 230);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(326, 267);
            this.labelX.TabIndex = 11;
            this.labelX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNier
            // 
            this.labelNier.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNier.ForeColor = System.Drawing.Color.Red;
            this.labelNier.Location = new System.Drawing.Point(734, 196);
            this.labelNier.Name = "labelNier";
            this.labelNier.Size = new System.Drawing.Size(242, 310);
            this.labelNier.TabIndex = 12;
            this.labelNier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(538, 114);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 37);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelWpr
            // 
            this.labelWpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWpr.Location = new System.Drawing.Point(301, 170);
            this.labelWpr.Name = "labelWpr";
            this.labelWpr.Size = new System.Drawing.Size(376, 42);
            this.labelWpr.TabIndex = 14;
            this.labelWpr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(164, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "x2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(389, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1011, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWpr);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelNier);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.tbZnak);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.labelZnak);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Program dla Laury XDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelZnak;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbZnak;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelNier;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelWpr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

