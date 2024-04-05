namespace Kalendář
{
    partial class Den
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
            this.button_new_event = new System.Windows.Forms.Button();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_day_name = new System.Windows.Forms.Label();
            this.lbl_svatek = new System.Windows.Forms.Label();
            this.lbl_events = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_new_event
            // 
            this.button_new_event.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_new_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_event.Location = new System.Drawing.Point(0, 514);
            this.button_new_event.Name = "button_new_event";
            this.button_new_event.Size = new System.Drawing.Size(342, 56);
            this.button_new_event.TabIndex = 0;
            this.button_new_event.Text = "Přidat událost";
            this.button_new_event.UseVisualStyleBackColor = true;
            this.button_new_event.Click += new System.EventHandler(this.button_new_event_Click);
            // 
            // lbl_day
            // 
            this.lbl_day.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day.Location = new System.Drawing.Point(0, 0);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(342, 70);
            this.lbl_day.TabIndex = 1;
            this.lbl_day.Text = "Den_X";
            this.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_day_name
            // 
            this.lbl_day_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_day_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day_name.Location = new System.Drawing.Point(0, 70);
            this.lbl_day_name.Name = "lbl_day_name";
            this.lbl_day_name.Size = new System.Drawing.Size(342, 34);
            this.lbl_day_name.TabIndex = 2;
            this.lbl_day_name.Text = "Name of the day";
            this.lbl_day_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_svatek
            // 
            this.lbl_svatek.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_svatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_svatek.Location = new System.Drawing.Point(0, 104);
            this.lbl_svatek.Name = "lbl_svatek";
            this.lbl_svatek.Size = new System.Drawing.Size(342, 56);
            this.lbl_svatek.TabIndex = 3;
            this.lbl_svatek.Text = "Svátek: XXXXXX";
            this.lbl_svatek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_events
            // 
            this.lbl_events.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_events.Location = new System.Drawing.Point(0, 160);
            this.lbl_events.Name = "lbl_events";
            this.lbl_events.Size = new System.Drawing.Size(342, 30);
            this.lbl_events.TabIndex = 4;
            this.lbl_events.Text = "Události:";
            this.lbl_events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 318);
            this.panel1.TabIndex = 5;
            // 
            // Den
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(342, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_events);
            this.Controls.Add(this.lbl_svatek);
            this.Controls.Add(this.lbl_day_name);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.button_new_event);
            this.Name = "Den";
            this.Text = "Den";
            this.Load += new System.EventHandler(this.Den_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_new_event;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Label lbl_day_name;
        private System.Windows.Forms.Label lbl_svatek;
        private System.Windows.Forms.Label lbl_events;
        private System.Windows.Forms.Panel panel1;
    }
}