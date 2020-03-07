namespace Market.Windows
{
    partial class OptionsWindow
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
            this.Percent = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.BackupDB = new System.Windows.Forms.Button();
            this.RestoreDB = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(133, 124);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(30, 19);
            this.Percent.TabIndex = 7;
            this.Percent.Text = "0%";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(87, 96);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(128, 25);
            this.ProgressBar.TabIndex = 6;
            // 
            // BackupDB
            // 
            this.BackupDB.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupDB.Location = new System.Drawing.Point(54, 158);
            this.BackupDB.Name = "BackupDB";
            this.BackupDB.Size = new System.Drawing.Size(203, 29);
            this.BackupDB.TabIndex = 5;
            this.BackupDB.Text = "სარეზერვო ასლის შექმნა";
            this.BackupDB.UseVisualStyleBackColor = true;
            this.BackupDB.Click += new System.EventHandler(this.Backup_Click);
            // 
            // RestoreDB
            // 
            this.RestoreDB.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreDB.Location = new System.Drawing.Point(54, 205);
            this.RestoreDB.Name = "RestoreDB";
            this.RestoreDB.Size = new System.Drawing.Size(203, 29);
            this.RestoreDB.TabIndex = 5;
            this.RestoreDB.Text = "სარეზერვო ასლის აღდგენა";
            this.RestoreDB.UseVisualStyleBackColor = true;
            this.RestoreDB.Click += new System.EventHandler(this.RestoreDB_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "სერვერი";
            // 
            // ServerName
            // 
            this.ServerName.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::Market.Properties.Settings.Default, "ServerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ServerName.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerName.FormattingEnabled = true;
            this.ServerName.Location = new System.Drawing.Point(110, 34);
            this.ServerName.Name = global::Market.Properties.Settings.Default.ServerName;
            this.ServerName.Size = new System.Drawing.Size(170, 27);
            this.ServerName.TabIndex = 9;
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 253);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.RestoreDB);
            this.Controls.Add(this.BackupDB);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "OptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "პარამეტრები";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button BackupDB;
        private System.Windows.Forms.Button RestoreDB;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServerName;
    }
}