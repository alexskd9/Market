namespace Market
{
    partial class SaleWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Execute = new System.Windows.Forms.Button();
            this.mcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidSum = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocSum = new System.Windows.Forms.TextBox();
            this.munit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueField = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.TextBox();
            this.SearchByCode = new System.Windows.Forms.Button();
            this.SearchByName = new System.Windows.Forms.Button();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.changetext = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
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
            this.code,
            this.name,
            this.unit,
            this.qty,
            this.price,
            this.ssum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Location = new System.Drawing.Point(13, 160);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(775, 242);
            this.dgv1.TabIndex = 0;
            this.dgv1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv1_CurrentCellDirtyStateChanged);
            // 
            // code
            // 
            this.code.HeaderText = "კოდი";
            this.code.Name = "code";
            this.code.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "დასახელება";
            this.name.Name = "name";
            // 
            // unit
            // 
            this.unit.HeaderText = "საზ. ერთ.";
            this.unit.Name = "unit";
            // 
            // qty
            // 
            this.qty.HeaderText = "რაოდენობა";
            this.qty.Name = "qty";
            // 
            // price
            // 
            this.price.HeaderText = "ფასი";
            this.price.Name = "price";
            // 
            // ssum
            // 
            this.ssum.HeaderText = "თანხა";
            this.ssum.Name = "ssum";
            // 
            // Execute
            // 
            this.Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Execute.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.Location = new System.Drawing.Point(675, 488);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(113, 40);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "შესრულება";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // mcode
            // 
            this.mcode.HeaderText = "კოდი";
            this.mcode.Name = "mcode";
            this.mcode.Visible = false;
            // 
            // PaidSum
            // 
            this.PaidSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaidSum.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidSum.Location = new System.Drawing.Point(176, 464);
            this.PaidSum.Name = "PaidSum";
            this.PaidSum.Size = new System.Drawing.Size(129, 27);
            this.PaidSum.TabIndex = 1;
            this.PaidSum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidSum_KeyDown);
            // 
            // mname
            // 
            this.mname.HeaderText = "დასახელება";
            this.mname.Name = "mname";
            // 
            // DocSum
            // 
            this.DocSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DocSum.Enabled = false;
            this.DocSum.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSum.Location = new System.Drawing.Point(176, 429);
            this.DocSum.Name = "DocSum";
            this.DocSum.Size = new System.Drawing.Size(129, 27);
            this.DocSum.TabIndex = 1;
            this.DocSum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueField_KeyDown);
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
            // ValueField
            // 
            this.ValueField.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueField.Location = new System.Drawing.Point(217, 71);
            this.ValueField.Name = "ValueField";
            this.ValueField.Size = new System.Drawing.Size(235, 27);
            this.ValueField.TabIndex = 1;
            this.ValueField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueField_KeyDown);
            // 
            // change
            // 
            this.change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.change.Enabled = false;
            this.change.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(176, 499);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(129, 27);
            this.change.TabIndex = 1;
            this.change.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueField_KeyDown);
            // 
            // SearchByCode
            // 
            this.SearchByCode.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByCode.Location = new System.Drawing.Point(217, 111);
            this.SearchByCode.Name = "SearchByCode";
            this.SearchByCode.Size = new System.Drawing.Size(93, 31);
            this.SearchByCode.TabIndex = 3;
            this.SearchByCode.Text = "კოდი (F8)";
            this.SearchByCode.UseVisualStyleBackColor = true;
            this.SearchByCode.Click += new System.EventHandler(this.SearchByCode_Click);
            // 
            // SearchByName
            // 
            this.SearchByName.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByName.Location = new System.Drawing.Point(331, 111);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(121, 31);
            this.SearchByName.TabIndex = 3;
            this.SearchByName.Text = "დასახელება (F9)";
            this.SearchByName.UseVisualStyleBackColor = true;
            this.SearchByName.Click += new System.EventHandler(this.SearchByName_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRow.Location = new System.Drawing.Point(675, 111);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(113, 31);
            this.DeleteRow.TabIndex = 3;
            this.DeleteRow.Text = "წაშლა (Ctrl+D)";
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "მნიშვნელობის შეყვანა (F2):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "გადასახდელი თანხა";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "გადახდილი თანხა (F6)";
            // 
            // changetext
            // 
            this.changetext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changetext.AutoSize = true;
            this.changetext.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetext.Location = new System.Drawing.Point(113, 502);
            this.changetext.Name = "changetext";
            this.changetext.Size = new System.Drawing.Size(58, 19);
            this.changetext.TabIndex = 4;
            this.changetext.Text = "ხურდა";
            // 
            // Date
            // 
            this.Date.CalendarFont = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(104, 10);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(98, 27);
            this.Date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "თარიღი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "დოკუმენტის N";
            // 
            // DocNumber
            // 
            this.DocNumber.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocNumber.Location = new System.Drawing.Point(642, 13);
            this.DocNumber.Name = "DocNumber";
            this.DocNumber.Size = new System.Drawing.Size(146, 27);
            this.DocNumber.TabIndex = 8;
            // 
            // SaleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.DocNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.changetext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteRow);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.SearchByCode);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.change);
            this.Controls.Add(this.PaidSum);
            this.Controls.Add(this.DocSum);
            this.Controls.Add(this.ValueField);
            this.Controls.Add(this.dgv1);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Name = "SaleWindow";
            this.Text = "გაყიდვა";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcode;
        private System.Windows.Forms.TextBox PaidSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname;
        private System.Windows.Forms.TextBox DocSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn munit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn mprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn msum;
        private System.Windows.Forms.TextBox ValueField;
        private System.Windows.Forms.TextBox change;
        private System.Windows.Forms.Button SearchByCode;
        private System.Windows.Forms.Button SearchByName;
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label changetext;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssum;
    }
}