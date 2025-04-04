namespace Timer_initBuilder
{
    partial class Generator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxTimerSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPrescaler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.txtOCRA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCOMA = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOCRB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCOMB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxTimerSelect
            // 
            this.cbxTimerSelect.FormattingEnabled = true;
            this.cbxTimerSelect.Items.AddRange(new object[] {
            "Timer0",
            "Timer1",
            "Timer2"});
            this.cbxTimerSelect.Location = new System.Drawing.Point(12, 29);
            this.cbxTimerSelect.Name = "cbxTimerSelect";
            this.cbxTimerSelect.Size = new System.Drawing.Size(124, 21);
            this.cbxTimerSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer auswahl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prescaler auswahl:";
            // 
            // cbxPrescaler
            // 
            this.cbxPrescaler.FormattingEnabled = true;
            this.cbxPrescaler.Items.AddRange(new object[] {
            "1",
            "8",
            "32",
            "64",
            "128",
            "256",
            "1024"});
            this.cbxPrescaler.Location = new System.Drawing.Point(15, 83);
            this.cbxPrescaler.Name = "cbxPrescaler";
            this.cbxPrescaler.Size = new System.Drawing.Size(121, 21);
            this.cbxPrescaler.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modus auswahl:(nur die Nummer davon)";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(15, 140);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(121, 20);
            this.txtMode.TabIndex = 5;
            // 
            // txtOCRA
            // 
            this.txtOCRA.Location = new System.Drawing.Point(15, 195);
            this.txtOCRA.Name = "txtOCRA";
            this.txtOCRA.Size = new System.Drawing.Size(121, 20);
            this.txtOCRA.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "OCR Wert:";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(291, 30);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(411, 185);
            this.txt_output.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "COM Mode:";
            // 
            // cbxCOMA
            // 
            this.cbxCOMA.FormattingEnabled = true;
            this.cbxCOMA.Items.AddRange(new object[] {
            "NON-Inverting",
            "Inverting"});
            this.cbxCOMA.Location = new System.Drawing.Point(15, 249);
            this.cbxCOMA.Name = "cbxCOMA";
            this.cbxCOMA.Size = new System.Drawing.Size(121, 21);
            this.cbxCOMA.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(291, 249);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(411, 23);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Funktion Erstellen";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ACHTUNG: dieses program bau nur die init, keine interrupts oder prüf die richtigk" +
    "eit";
            // 
            // txtOCRB
            // 
            this.txtOCRB.Location = new System.Drawing.Point(142, 195);
            this.txtOCRB.Name = "txtOCRB";
            this.txtOCRB.Size = new System.Drawing.Size(121, 20);
            this.txtOCRB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "A Wert/ Normal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "B Wert:";
            // 
            // cbxCOMB
            // 
            this.cbxCOMB.FormattingEnabled = true;
            this.cbxCOMB.Items.AddRange(new object[] {
            "NON-Inverting",
            "Inverting"});
            this.cbxCOMB.Location = new System.Drawing.Point(142, 249);
            this.cbxCOMB.Name = "cbxCOMB";
            this.cbxCOMB.Size = new System.Drawing.Size(121, 21);
            this.cbxCOMB.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "A Wert/ Normal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "B Wert:";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 329);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxCOMB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOCRB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cbxCOMA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOCRA);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPrescaler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTimerSelect);
            this.Name = "Generator";
            this.Text = "C Timer Init function Generator for Atmega32";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTimerSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPrescaler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.TextBox txtOCRA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCOMA;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOCRB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxCOMB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

