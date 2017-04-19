namespace RefLinkGenerator
{
    partial class Form1
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
            this.eingabeFeld = new System.Windows.Forms.TextBox();
            this.amaButton = new System.Windows.Forms.RadioButton();
            this.mmButton = new System.Windows.Forms.RadioButton();
            this.ausgabeFeld = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eingabeFeld
            // 
            this.eingabeFeld.Location = new System.Drawing.Point(8, 12);
            this.eingabeFeld.Name = "eingabeFeld";
            this.eingabeFeld.Size = new System.Drawing.Size(650, 20);
            this.eingabeFeld.TabIndex = 0;
            this.eingabeFeld.Text = "hier Link eingeben";
            // 
            // amaButton
            // 
            this.amaButton.AutoSize = true;
            this.amaButton.Location = new System.Drawing.Point(16, 19);
            this.amaButton.Name = "amaButton";
            this.amaButton.Size = new System.Drawing.Size(63, 17);
            this.amaButton.TabIndex = 1;
            this.amaButton.TabStop = true;
            this.amaButton.Text = "Amazon";
            this.amaButton.UseVisualStyleBackColor = true;
            this.amaButton.CheckedChanged += new System.EventHandler(this.AmaButton_CheckedChanged);
            // 
            // mmButton
            // 
            this.mmButton.AutoSize = true;
            this.mmButton.Location = new System.Drawing.Point(16, 54);
            this.mmButton.Name = "mmButton";
            this.mmButton.Size = new System.Drawing.Size(80, 17);
            this.mmButton.TabIndex = 2;
            this.mmButton.TabStop = true;
            this.mmButton.Text = "Mediamarkt";
            this.mmButton.UseVisualStyleBackColor = true;
            this.mmButton.CheckedChanged += new System.EventHandler(this.MMButton_CheckedChanged);
            // 
            // ausgabeFeld
            // 
            this.ausgabeFeld.Location = new System.Drawing.Point(8, 128);
            this.ausgabeFeld.Name = "ausgabeFeld";
            this.ausgabeFeld.Size = new System.Drawing.Size(650, 20);
            this.ausgabeFeld.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(293, 183);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Konvertieren";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amaButton);
            this.groupBox1.Controls.Add(this.mmButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welchen Ref-Link wollen Sie erzeugen?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.ausgabeFeld);
            this.Controls.Add(this.eingabeFeld);
            this.Name = "Form1";
            this.Text = "Ref-Link Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eingabeFeld;
        private System.Windows.Forms.RadioButton amaButton;
        private System.Windows.Forms.RadioButton mmButton;
        private System.Windows.Forms.TextBox ausgabeFeld;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

