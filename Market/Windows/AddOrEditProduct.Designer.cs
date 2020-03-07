namespace Market.Windows
{
    partial class AddOrEditProduct
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
            this.mgroup = new System.Windows.Forms.ComboBox();
            this.munit = new System.Windows.Forms.ComboBox();
            this.mprice = new System.Windows.Forms.NumericUpDown();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mprice)).BeginInit();
            this.SuspendLayout();
            // 
            // mgroup
            // 
            this.mgroup.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgroup.FormattingEnabled = true;
            this.mgroup.Location = new System.Drawing.Point(173, 123);
            this.mgroup.Name = "mgroup";
            this.mgroup.Size = new System.Drawing.Size(329, 30);
            this.mgroup.TabIndex = 15;
            // 
            // munit
            // 
            this.munit.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munit.FormattingEnabled = true;
            this.munit.Location = new System.Drawing.Point(173, 179);
            this.munit.Name = "munit";
            this.munit.Size = new System.Drawing.Size(121, 30);
            this.munit.TabIndex = 16;
            // 
            // mprice
            // 
            this.mprice.DecimalPlaces = 2;
            this.mprice.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mprice.Location = new System.Drawing.Point(173, 227);
            this.mprice.Name = "mprice";
            this.mprice.Size = new System.Drawing.Size(120, 29);
            this.mprice.TabIndex = 17;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(402, 390);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(100, 30);
            this.ExecuteButton.TabIndex = 19;
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "გასაყიდი ფასი";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "ჯგუფი";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "საზომი ერთეული";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mname
            // 
            this.mname.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.Location = new System.Drawing.Point(173, 69);
            this.mname.MaxLength = 150;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(329, 29);
            this.mname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "დასახელება";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // barcode
            // 
            this.barcode.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Location = new System.Drawing.Point(173, 279);
            this.barcode.MaxLength = 13;
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(153, 29);
            this.barcode.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "შტრიხკოდი";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mcode
            // 
            this.mcode.Enabled = false;
            this.mcode.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcode.Location = new System.Drawing.Point(173, 21);
            this.mcode.MaxLength = 13;
            this.mcode.Name = "mcode";
            this.mcode.Size = new System.Drawing.Size(153, 29);
            this.mcode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "კოდი";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddOrEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 432);
            this.Controls.Add(this.mgroup);
            this.Controls.Add(this.munit);
            this.Controls.Add(this.mprice);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mcode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddOrEditProduct";
            this.Text = "AddOrEditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.mprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox mgroup;
        public System.Windows.Forms.ComboBox munit;
        public System.Windows.Forms.NumericUpDown mprice;
        public System.Windows.Forms.Button ExecuteButton;
        public System.Windows.Forms.TextBox mname;
        public System.Windows.Forms.TextBox barcode;
        public System.Windows.Forms.TextBox mcode;
    }
}