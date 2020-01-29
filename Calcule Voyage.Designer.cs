namespace Tp_2_Interfaces_Graphiques
{
    partial class GalculeVoyage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Resulat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_Consomation = new System.Windows.Forms.TextBox();
            this.Text_Kilometres = new System.Windows.Forms.TextBox();
            this.Text_PrixEss = new System.Windows.Forms.TextBox();
            this.Button_Calculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consommation de la voiture (L/ 100 Km) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres de Kilometres (Km):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix de l\'essance (Euro/Litre) :";
            // 
            // Label_Resulat
            // 
            this.Label_Resulat.AutoSize = true;
            this.Label_Resulat.Location = new System.Drawing.Point(293, 338);
            this.Label_Resulat.Name = "Label_Resulat";
            this.Label_Resulat.Size = new System.Drawing.Size(0, 13);
            this.Label_Resulat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Le Cout du voyage sera : ";
            // 
            // Text_Consomation
            // 
            this.Text_Consomation.Location = new System.Drawing.Point(296, 62);
            this.Text_Consomation.Name = "Text_Consomation";
            this.Text_Consomation.Size = new System.Drawing.Size(143, 20);
            this.Text_Consomation.TabIndex = 4;
            // 
            // Text_Kilometres
            // 
            this.Text_Kilometres.Location = new System.Drawing.Point(296, 120);
            this.Text_Kilometres.Name = "Text_Kilometres";
            this.Text_Kilometres.Size = new System.Drawing.Size(143, 20);
            this.Text_Kilometres.TabIndex = 5;
            // 
            // Text_PrixEss
            // 
            this.Text_PrixEss.Location = new System.Drawing.Point(296, 180);
            this.Text_PrixEss.Name = "Text_PrixEss";
            this.Text_PrixEss.Size = new System.Drawing.Size(143, 20);
            this.Text_PrixEss.TabIndex = 6;
            // 
            // Button_Calculer
            // 
            this.Button_Calculer.Location = new System.Drawing.Point(198, 254);
            this.Button_Calculer.Name = "Button_Calculer";
            this.Button_Calculer.Size = new System.Drawing.Size(120, 50);
            this.Button_Calculer.TabIndex = 7;
            this.Button_Calculer.Text = "Calculer";
            this.Button_Calculer.UseVisualStyleBackColor = true;
            this.Button_Calculer.Click += new System.EventHandler(this.Button_Calculer_Click);
            // 
            // GalculeVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 409);
            this.Controls.Add(this.Button_Calculer);
            this.Controls.Add(this.Text_PrixEss);
            this.Controls.Add(this.Text_Kilometres);
            this.Controls.Add(this.Text_Consomation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label_Resulat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GalculeVoyage";
            this.Text = "Calcule Voyage";
            this.Load += new System.EventHandler(this.GalculeVoyage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Resulat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_Consomation;
        private System.Windows.Forms.TextBox Text_Kilometres;
        private System.Windows.Forms.TextBox Text_PrixEss;
        private System.Windows.Forms.Button Button_Calculer;
    }
}

