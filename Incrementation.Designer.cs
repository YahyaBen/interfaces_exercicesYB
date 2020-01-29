namespace Tp_2_Interfaces_Graphiques
{
    partial class Incrementation
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
            this.Text_Saisie = new System.Windows.Forms.TextBox();
            this.Button_Plus = new System.Windows.Forms.Button();
            this.Button_Moin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Saisie
            // 
            this.Text_Saisie.Location = new System.Drawing.Point(57, 41);
            this.Text_Saisie.Name = "Text_Saisie";
            this.Text_Saisie.Size = new System.Drawing.Size(417, 20);
            this.Text_Saisie.TabIndex = 0;
            this.Text_Saisie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_Plus
            // 
            this.Button_Plus.Location = new System.Drawing.Point(57, 75);
            this.Button_Plus.Name = "Button_Plus";
            this.Button_Plus.Size = new System.Drawing.Size(143, 43);
            this.Button_Plus.TabIndex = 1;
            this.Button_Plus.Text = "++";
            this.Button_Plus.UseVisualStyleBackColor = true;
            this.Button_Plus.Click += new System.EventHandler(this.Button_Plus_Click);
            // 
            // Button_Moin
            // 
            this.Button_Moin.Location = new System.Drawing.Point(306, 75);
            this.Button_Moin.Name = "Button_Moin";
            this.Button_Moin.Size = new System.Drawing.Size(168, 43);
            this.Button_Moin.TabIndex = 2;
            this.Button_Moin.Text = "--";
            this.Button_Moin.UseVisualStyleBackColor = true;
            this.Button_Moin.Click += new System.EventHandler(this.Button_Moin_Click);
            // 
            // Incrementation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 172);
            this.Controls.Add(this.Button_Moin);
            this.Controls.Add(this.Button_Plus);
            this.Controls.Add(this.Text_Saisie);
            this.Name = "Incrementation";
            this.Text = "Incrementaton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Saisie;
        private System.Windows.Forms.Button Button_Plus;
        private System.Windows.Forms.Button Button_Moin;
    }
}