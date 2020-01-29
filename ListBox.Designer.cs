namespace Tp_2_Interfaces_Graphiques
{
    partial class ListBox
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
            this.Button_Add = new System.Windows.Forms.Button();
            this.Text_Add = new System.Windows.Forms.TextBox();
            this.Liste_Box = new System.Windows.Forms.ListBox();
            this.Button_Quitter = new System.Windows.Forms.Button();
            this.Button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Vider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(294, 23);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 0;
            this.Button_Add.Text = "Ajouter";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Text_Add
            // 
            this.Text_Add.Location = new System.Drawing.Point(25, 26);
            this.Text_Add.Name = "Text_Add";
            this.Text_Add.Size = new System.Drawing.Size(244, 20);
            this.Text_Add.TabIndex = 1;
            // 
            // Liste_Box
            // 
            this.Liste_Box.FormattingEnabled = true;
            this.Liste_Box.Location = new System.Drawing.Point(25, 67);
            this.Liste_Box.Name = "Liste_Box";
            this.Liste_Box.Size = new System.Drawing.Size(344, 95);
            this.Liste_Box.TabIndex = 2;
            // 
            // Button_Quitter
            // 
            this.Button_Quitter.Location = new System.Drawing.Point(25, 177);
            this.Button_Quitter.Name = "Button_Quitter";
            this.Button_Quitter.Size = new System.Drawing.Size(75, 23);
            this.Button_Quitter.TabIndex = 3;
            this.Button_Quitter.Text = "Quitter";
            this.Button_Quitter.UseVisualStyleBackColor = true;
            this.Button_Quitter.Click += new System.EventHandler(this.Button_Quitter_Click);
            // 
            // Button_Supprimer
            // 
            this.Button_Supprimer.Location = new System.Drawing.Point(153, 177);
            this.Button_Supprimer.Name = "Button_Supprimer";
            this.Button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Button_Supprimer.TabIndex = 4;
            this.Button_Supprimer.Text = "Supprimer";
            this.Button_Supprimer.UseVisualStyleBackColor = true;
            this.Button_Supprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button_Vider
            // 
            this.Button_Vider.Location = new System.Drawing.Point(294, 177);
            this.Button_Vider.Name = "Button_Vider";
            this.Button_Vider.Size = new System.Drawing.Size(75, 23);
            this.Button_Vider.TabIndex = 5;
            this.Button_Vider.Text = "Vider la Liste";
            this.Button_Vider.UseVisualStyleBackColor = true;
            this.Button_Vider.Click += new System.EventHandler(this.Button_Vider_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 212);
            this.Controls.Add(this.Button_Vider);
            this.Controls.Add(this.Button_Supprimer);
            this.Controls.Add(this.Button_Quitter);
            this.Controls.Add(this.Liste_Box);
            this.Controls.Add(this.Text_Add);
            this.Controls.Add(this.Button_Add);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.TextBox Text_Add;
        private System.Windows.Forms.ListBox Liste_Box;
        private System.Windows.Forms.Button Button_Quitter;
        private System.Windows.Forms.Button Button_Supprimer;
        private System.Windows.Forms.Button Button_Vider;
    }
}