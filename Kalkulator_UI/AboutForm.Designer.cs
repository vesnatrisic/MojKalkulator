namespace Kalkulator_UI
{
    partial class AboutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.VratiSeNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĆAO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VratiSeNazad
            // 
            this.VratiSeNazad.Location = new System.Drawing.Point(569, 368);
            this.VratiSeNazad.Name = "VratiSeNazad";
            this.VratiSeNazad.Size = new System.Drawing.Size(132, 23);
            this.VratiSeNazad.TabIndex = 1;
            this.VratiSeNazad.Text = "Vrati se nazad";
            this.VratiSeNazad.UseVisualStyleBackColor = true;
            this.VratiSeNazad.Click += new System.EventHandler(this.VratiSeNazad_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 662);
            this.Controls.Add(this.VratiSeNazad);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VratiSeNazad;
    }
}