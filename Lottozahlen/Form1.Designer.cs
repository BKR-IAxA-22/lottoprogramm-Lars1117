namespace Lottozahlen
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
            this.button_zahlen = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_zahlen
            // 
            this.button_zahlen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_zahlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zahlen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_zahlen.Location = new System.Drawing.Point(201, 96);
            this.button_zahlen.Name = "button_zahlen";
            this.button_zahlen.Size = new System.Drawing.Size(327, 80);
            this.button_zahlen.TabIndex = 1;
            this.button_zahlen.Text = "Lottozahlen auslosen";
            this.button_zahlen.UseVisualStyleBackColor = false;
            this.button_zahlen.Click += new System.EventHandler(this.button_zahlen_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(233, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 27);
            this.textBox2.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(303, 211);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(53, 27);
            this.textBox6.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(448, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 27);
            this.textBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(380, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 27);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(162, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(53, 27);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(517, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 27);
            this.textBox5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(740, 417);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_zahlen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_zahlen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

