namespace Kalendář
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_month_year = new System.Windows.Forms.Label();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_bin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_month_year
            // 
            this.label_month_year.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_month_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_month_year.Location = new System.Drawing.Point(0, 0);
            this.label_month_year.Name = "label_month_year";
            this.label_month_year.Size = new System.Drawing.Size(1176, 59);
            this.label_month_year.TabIndex = 0;
            this.label_month_year.Text = "label1";
            this.label_month_year.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_right.Location = new System.Drawing.Point(878, 14);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(182, 53);
            this.button_right.TabIndex = 1;
            this.button_right.Text = ">>>";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_left.Location = new System.Drawing.Point(126, 14);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(182, 53);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "<<<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_bin
            // 
            this.button_bin.Location = new System.Drawing.Point(-1, 0);
            this.button_bin.Name = "button_bin";
            this.button_bin.Size = new System.Drawing.Size(112, 66);
            this.button_bin.TabIndex = 3;
            this.button_bin.Text = "KOŠ";
            this.button_bin.UseVisualStyleBackColor = true;
            this.button_bin.Click += new System.EventHandler(this.button_bin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 923);
            this.Controls.Add(this.button_bin);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.label_month_year);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_month_year;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_bin;
    }
}

