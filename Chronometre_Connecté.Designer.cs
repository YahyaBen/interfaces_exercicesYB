namespace Tp_2_Interfaces_Graphiques
{
    partial class Chronometre_Connecté
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
            this.components = new System.ComponentModel.Container();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.DGV_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Lap = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_Pause = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Text_Chrono = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Button_Fermer = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_ID,
            this.DGV_Temps,
            this.DGV_Date,
            this.DGV_Time});
            this.DGV.Location = new System.Drawing.Point(12, 194);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(402, 194);
            this.DGV.TabIndex = 11;
            // 
            // DGV_ID
            // 
            this.DGV_ID.HeaderText = "Lap Numero";
            this.DGV_ID.Name = "DGV_ID";
            // 
            // DGV_Temps
            // 
            this.DGV_Temps.HeaderText = "Temps";
            this.DGV_Temps.Name = "DGV_Temps";
            // 
            // DGV_Date
            // 
            this.DGV_Date.HeaderText = "Date";
            this.DGV_Date.Name = "DGV_Date";
            // 
            // DGV_Time
            // 
            this.DGV_Time.HeaderText = "Time";
            this.DGV_Time.Name = "DGV_Time";
            // 
            // Button_Lap
            // 
            this.Button_Lap.Location = new System.Drawing.Point(12, 155);
            this.Button_Lap.Name = "Button_Lap";
            this.Button_Lap.Size = new System.Drawing.Size(402, 27);
            this.Button_Lap.TabIndex = 10;
            this.Button_Lap.Text = "LAP";
            this.Button_Lap.UseVisualStyleBackColor = true;
            this.Button_Lap.Click += new System.EventHandler(this.Button_Lap_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(380, 88);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(137, 44);
            this.Button_Reset.TabIndex = 9;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Button_Pause
            // 
            this.Button_Pause.Location = new System.Drawing.Point(215, 88);
            this.Button_Pause.Name = "Button_Pause";
            this.Button_Pause.Size = new System.Drawing.Size(102, 44);
            this.Button_Pause.TabIndex = 8;
            this.Button_Pause.Text = "Pause";
            this.Button_Pause.UseVisualStyleBackColor = true;
            this.Button_Pause.Click += new System.EventHandler(this.Button_Pause_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(12, 88);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(144, 44);
            this.Button_Start.TabIndex = 7;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Text_Chrono
            // 
            this.Text_Chrono.AutoSize = true;
            this.Text_Chrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Chrono.Location = new System.Drawing.Point(176, 19);
            this.Text_Chrono.Name = "Text_Chrono";
            this.Text_Chrono.Size = new System.Drawing.Size(238, 51);
            this.Text_Chrono.TabIndex = 6;
            this.Text_Chrono.Text = "00:00:0000";
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Button_Fermer
            // 
            this.Button_Fermer.ForeColor = System.Drawing.Color.Red;
            this.Button_Fermer.Location = new System.Drawing.Point(440, 178);
            this.Button_Fermer.Name = "Button_Fermer";
            this.Button_Fermer.Size = new System.Drawing.Size(102, 145);
            this.Button_Fermer.TabIndex = 12;
            this.Button_Fermer.Text = "Fermer La Connexion";
            this.Button_Fermer.UseVisualStyleBackColor = true;
            this.Button_Fermer.Click += new System.EventHandler(this.Button_Fermer_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.ForeColor = System.Drawing.Color.Red;
            this.Button_Delete.Location = new System.Drawing.Point(440, 335);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(102, 53);
            this.Button_Delete.TabIndex = 13;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Chronometre_Connecté
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 403);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Fermer);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Button_Lap);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_Pause);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Text_Chrono);
            this.Name = "Chronometre_Connecté";
            this.Text = "Chronometre_Connecté";
            this.Load += new System.EventHandler(this.Chronometre_Connecté_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Date;
        private System.Windows.Forms.Button Button_Lap;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_Pause;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label Text_Chrono;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Button_Fermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Time;
        private System.Windows.Forms.Button Button_Delete;
    }
}