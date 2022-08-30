namespace PrintBarcodesFromGridview
{
    partial class frmMain
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lvPrint = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkShowPrices = new System.Windows.Forms.CheckBox();
            this.txtNoOfStickers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfStickers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1352, 59);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 27);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvPrint
            // 
            this.lvPrint.CheckBoxes = true;
            this.lvPrint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.ColumnHeader2,
            this.columnHeader4});
            this.lvPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPrint.GridLines = true;
            this.lvPrint.HideSelection = false;
            this.lvPrint.Location = new System.Drawing.Point(713, 92);
            this.lvPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvPrint.Name = "lvPrint";
            this.lvPrint.Size = new System.Drawing.Size(737, 412);
            this.lvPrint.TabIndex = 68;
            this.lvPrint.UseCompatibleStateImageBehavior = false;
            this.lvPrint.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Code";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            this.columnHeader3.Width = 200;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Barcode";
            this.ColumnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Search by Product Name or Code";
            // 
            // dgvSelect
            // 
            this.dgvSelect.AllowUserToAddRows = false;
            this.dgvSelect.AllowUserToDeleteRows = false;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvSelect.Location = new System.Drawing.Point(16, 92);
            this.dgvSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowHeadersWidth = 51;
            this.dgvSelect.Size = new System.Drawing.Size(669, 413);
            this.dgvSelect.TabIndex = 74;
            this.dgvSelect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelect_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Barcode";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(20, 43);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(216, 22);
            this.txtSearchProduct.TabIndex = 0;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(713, 59);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 27);
            this.btnReset.TabIndex = 77;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkShowPrices
            // 
            this.chkShowPrices.AutoSize = true;
            this.chkShowPrices.Location = new System.Drawing.Point(917, 63);
            this.chkShowPrices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkShowPrices.Name = "chkShowPrices";
            this.chkShowPrices.Size = new System.Drawing.Size(102, 19);
            this.chkShowPrices.TabIndex = 78;
            this.chkShowPrices.Text = "Show Price";
            this.chkShowPrices.UseVisualStyleBackColor = true;
            // 
            // txtNoOfStickers
            // 
            this.txtNoOfStickers.Location = new System.Drawing.Point(1173, 62);
            this.txtNoOfStickers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNoOfStickers.Name = "txtNoOfStickers";
            this.txtNoOfStickers.Size = new System.Drawing.Size(85, 22);
            this.txtNoOfStickers.TabIndex = 79;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 519);
            this.Controls.Add(this.txtNoOfStickers);
            this.Controls.Add(this.chkShowPrices);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.lvPrint);
            this.Controls.Add(this.btnPrint);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfStickers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.ListView lvPrint;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox chkShowPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown txtNoOfStickers;
    }
}

