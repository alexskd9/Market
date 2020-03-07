namespace Market
{
    partial class PurchaseWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocNumber = new System.Windows.Forms.TextBox();
            this.AddRow = new System.Windows.Forms.Button();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.SaveDoc = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.mname = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.munit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNewProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.CalendarFont = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(104, 13);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(98, 27);
            this.Date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "თარიღი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "დოკუმენტის N";
            // 
            // DocNumber
            // 
            this.DocNumber.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocNumber.Location = new System.Drawing.Point(447, 16);
            this.DocNumber.Name = "DocNumber";
            this.DocNumber.Size = new System.Drawing.Size(146, 27);
            this.DocNumber.TabIndex = 2;
            // 
            // AddRow
            // 
            this.AddRow.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRow.Location = new System.Drawing.Point(16, 94);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(88, 32);
            this.AddRow.TabIndex = 3;
            this.AddRow.Text = "დამატება";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRow.Location = new System.Drawing.Point(143, 94);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(88, 32);
            this.DeleteRow.TabIndex = 3;
            this.DeleteRow.Text = "წაშლა";
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // SaveDoc
            // 
            this.SaveDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDoc.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDoc.Location = new System.Drawing.Point(704, 440);
            this.SaveDoc.Name = "SaveDoc";
            this.SaveDoc.Size = new System.Drawing.Size(84, 31);
            this.SaveDoc.TabIndex = 3;
            this.SaveDoc.Text = "შენახვა";
            this.SaveDoc.UseVisualStyleBackColor = true;
            this.SaveDoc.Click += new System.EventHandler(this.SaveDoc_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mname,
            this.munit,
            this.mqty,
            this.mprice,
            this.msum,
            this.mcode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Location = new System.Drawing.Point(16, 153);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(772, 267);
            this.dgv1.TabIndex = 4;
            this.dgv1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv1_CurrentCellDirtyStateChanged);
            // 
            // mname
            // 
            this.mname.DataSource = this.productBindingSource;
            this.mname.DisplayMember = "mname";
            this.mname.HeaderText = "დასახელება";
            this.mname.Name = "mname";
            this.mname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Market.Product);
            // 
            // munit
            // 
            this.munit.HeaderText = "საზ. ერთ.";
            this.munit.Name = "munit";
            // 
            // mqty
            // 
            this.mqty.HeaderText = "რაოდენობა";
            this.mqty.Name = "mqty";
            // 
            // mprice
            // 
            this.mprice.HeaderText = "ფასი";
            this.mprice.Name = "mprice";
            // 
            // msum
            // 
            this.msum.HeaderText = "თანხა";
            this.msum.Name = "msum";
            // 
            // mcode
            // 
            this.mcode.HeaderText = "კოდი";
            this.mcode.Name = "mcode";
            this.mcode.Visible = false;
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProduct.Location = new System.Drawing.Point(627, 94);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(161, 32);
            this.AddNewProduct.TabIndex = 3;
            this.AddNewProduct.Text = "საქონლის დამატება";
            this.AddNewProduct.UseVisualStyleBackColor = true;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // PurchaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.SaveDoc);
            this.Controls.Add(this.AddNewProduct);
            this.Controls.Add(this.DeleteRow);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.DocNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "PurchaseWindow";
            this.Text = "შესყიდვა";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchaseWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocNumber;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.Button SaveDoc;
        public System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.DataGridViewComboBoxColumn mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn munit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn mprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn msum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcode;
    }
}