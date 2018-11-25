namespace Delegat3
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
            this.UseIngrediens = new System.Windows.Forms.Button();
            this.getSuz = new System.Windows.Forms.Button();
            this.getAmy = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // UseIngrediens
            // 
            this.UseIngrediens.Location = new System.Drawing.Point(12, 12);
            this.UseIngrediens.Name = "UseIngrediens";
            this.UseIngrediens.Size = new System.Drawing.Size(96, 23);
            this.UseIngrediens.TabIndex = 0;
            this.UseIngrediens.Text = "Pobierz składnik";
            this.UseIngrediens.UseVisualStyleBackColor = true;
            this.UseIngrediens.Click += new System.EventHandler(this.UseIngrediens_Click);
            // 
            // getSuz
            // 
            this.getSuz.Location = new System.Drawing.Point(12, 53);
            this.getSuz.Name = "getSuz";
            this.getSuz.Size = new System.Drawing.Size(112, 23);
            this.getSuz.TabIndex = 1;
            this.getSuz.Text = "Użyj delegatu Suz";
            this.getSuz.UseVisualStyleBackColor = true;
            this.getSuz.Click += new System.EventHandler(this.getSuz_Click);
            // 
            // getAmy
            // 
            this.getAmy.Location = new System.Drawing.Point(12, 92);
            this.getAmy.Name = "getAmy";
            this.getAmy.Size = new System.Drawing.Size(112, 23);
            this.getAmy.TabIndex = 2;
            this.getAmy.Text = "Uzyj delegatu Amy";
            this.getAmy.UseVisualStyleBackColor = true;
            this.getAmy.Click += new System.EventHandler(this.getAmy_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(114, 12);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(32, 20);
            this.amount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 127);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.getAmy);
            this.Controls.Add(this.getSuz);
            this.Controls.Add(this.UseIngrediens);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tajne skladniki";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UseIngrediens;
        private System.Windows.Forms.Button getSuz;
        private System.Windows.Forms.Button getAmy;
        private System.Windows.Forms.NumericUpDown amount;
    }
}

