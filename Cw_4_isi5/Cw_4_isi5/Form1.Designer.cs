namespace Cw_4_isi5
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
            this.btnbuble = new System.Windows.Forms.Button();
            this.lbwynik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnbuble
            // 
            this.btnbuble.Location = new System.Drawing.Point(295, 246);
            this.btnbuble.Name = "btnbuble";
            this.btnbuble.Size = new System.Drawing.Size(75, 23);
            this.btnbuble.TabIndex = 0;
            this.btnbuble.Text = "Start";
            this.btnbuble.UseVisualStyleBackColor = true;
            this.btnbuble.Click += new System.EventHandler(this.btnbuble_Click);
            // 
            // lbwynik
            // 
            this.lbwynik.AutoSize = true;
            this.lbwynik.Location = new System.Drawing.Point(302, 171);
            this.lbwynik.Name = "lbwynik";
            this.lbwynik.Size = new System.Drawing.Size(0, 13);
            this.lbwynik.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "bublesort";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(279, 116);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(134, 20);
            this.tbInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbwynik);
            this.Controls.Add(this.btnbuble);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuble;
        private System.Windows.Forms.Label lbwynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
    }
}

