namespace AdmiProducts
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbAddpro = new System.Windows.Forms.GroupBox();
            this.combCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpbQuery = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbPricemin = new System.Windows.Forms.CheckBox();
            this.chbPricemax = new System.Windows.Forms.CheckBox();
            this.chbNameP = new System.Windows.Forms.CheckBox();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.txtbQueryPriceMin = new System.Windows.Forms.TextBox();
            this.txtbQueryPriceMax = new System.Windows.Forms.TextBox();
            this.txtbQueryName = new System.Windows.Forms.TextBox();
            this.combQueryCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.grpbAddpro.SuspendLayout();
            this.grpbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbAddpro
            // 
            this.grpbAddpro.Controls.Add(this.combCategory);
            this.grpbAddpro.Controls.Add(this.btnAdd);
            this.grpbAddpro.Controls.Add(this.txtbPrice);
            this.grpbAddpro.Controls.Add(this.lblPrice);
            this.grpbAddpro.Controls.Add(this.txtbStock);
            this.grpbAddpro.Controls.Add(this.lblStock);
            this.grpbAddpro.Controls.Add(this.lblCategory);
            this.grpbAddpro.Controls.Add(this.txtbName);
            this.grpbAddpro.Controls.Add(this.lblName);
            this.grpbAddpro.Controls.Add(this.txtbCode);
            this.grpbAddpro.Controls.Add(this.lblCode);
            this.grpbAddpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbAddpro.Location = new System.Drawing.Point(27, 15);
            this.grpbAddpro.Name = "grpbAddpro";
            this.grpbAddpro.Size = new System.Drawing.Size(396, 396);
            this.grpbAddpro.TabIndex = 0;
            this.grpbAddpro.TabStop = false;
            this.grpbAddpro.Text = "AGREGAR PRODUCOS";
            this.grpbAddpro.Enter += new System.EventHandler(this.grpbAddpro_Enter);
            // 
            // combCategory
            // 
            this.combCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCategory.FormattingEnabled = true;
            this.combCategory.Items.AddRange(new object[] {
            "HOGAR",
            "MECANICA",
            "OFICINA"});
            this.combCategory.Location = new System.Drawing.Point(144, 164);
            this.combCategory.Name = "combCategory";
            this.combCategory.Size = new System.Drawing.Size(219, 28);
            this.combCategory.TabIndex = 11;
            this.combCategory.SelectedIndexChanged += new System.EventHandler(this.combCategory_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(253, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbPrice
            // 
            this.txtbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrice.Location = new System.Drawing.Point(136, 227);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(227, 28);
            this.txtbPrice.TabIndex = 9;
            this.txtbPrice.TextChanged += new System.EventHandler(this.txtbPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(20, 227);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(78, 22);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "PRECIO";
            // 
            // txtbStock
            // 
            this.txtbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbStock.Location = new System.Drawing.Point(136, 278);
            this.txtbStock.Name = "txtbStock";
            this.txtbStock.Size = new System.Drawing.Size(227, 28);
            this.txtbStock.TabIndex = 7;
            this.txtbStock.TextChanged += new System.EventHandler(this.txtbStock_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(20, 284);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 22);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "STOCK";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(20, 165);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(116, 22);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "CATEGORIA";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(136, 105);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(227, 28);
            this.txtbName.TabIndex = 3;
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NOMBRE P.";
            // 
            // txtbCode
            // 
            this.txtbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCode.Location = new System.Drawing.Point(136, 46);
            this.txtbCode.Name = "txtbCode";
            this.txtbCode.Size = new System.Drawing.Size(227, 28);
            this.txtbCode.TabIndex = 1;
            this.txtbCode.TextChanged += new System.EventHandler(this.txtbCode_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(20, 46);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(82, 22);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "CODIGO";
            // 
            // grpbQuery
            // 
            this.grpbQuery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpbQuery.Controls.Add(this.label1);
            this.grpbQuery.Controls.Add(this.chbPricemin);
            this.grpbQuery.Controls.Add(this.chbPricemax);
            this.grpbQuery.Controls.Add(this.chbNameP);
            this.grpbQuery.Controls.Add(this.btnOriginal);
            this.grpbQuery.Controls.Add(this.txtbQueryPriceMin);
            this.grpbQuery.Controls.Add(this.txtbQueryPriceMax);
            this.grpbQuery.Controls.Add(this.txtbQueryName);
            this.grpbQuery.Controls.Add(this.combQueryCategory);
            this.grpbQuery.Controls.Add(this.btnSearch);
            this.grpbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbQuery.Location = new System.Drawing.Point(473, 16);
            this.grpbQuery.Name = "grpbQuery";
            this.grpbQuery.Size = new System.Drawing.Size(651, 201);
            this.grpbQuery.TabIndex = 6;
            this.grpbQuery.TabStop = false;
            this.grpbQuery.Text = "CONSULTAS";
            this.grpbQuery.Enter += new System.EventHandler(this.grpbQuery_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "CATEGORIA";
            // 
            // chbPricemin
            // 
            this.chbPricemin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chbPricemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPricemin.Location = new System.Drawing.Point(54, 104);
            this.chbPricemin.Name = "chbPricemin";
            this.chbPricemin.Size = new System.Drawing.Size(147, 28);
            this.chbPricemin.TabIndex = 19;
            this.chbPricemin.Text = "Precio Min";
            this.chbPricemin.UseVisualStyleBackColor = false;
            this.chbPricemin.CheckedChanged += new System.EventHandler(this.chbPricemin_CheckedChanged);
            // 
            // chbPricemax
            // 
            this.chbPricemax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chbPricemax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPricemax.Location = new System.Drawing.Point(348, 104);
            this.chbPricemax.Name = "chbPricemax";
            this.chbPricemax.Size = new System.Drawing.Size(147, 24);
            this.chbPricemax.TabIndex = 18;
            this.chbPricemax.Text = "Precio Max";
            this.chbPricemax.UseVisualStyleBackColor = false;
            this.chbPricemax.CheckedChanged += new System.EventHandler(this.chbPricemax_CheckedChanged);
            // 
            // chbNameP
            // 
            this.chbNameP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chbNameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNameP.Location = new System.Drawing.Point(93, 49);
            this.chbNameP.Name = "chbNameP";
            this.chbNameP.Size = new System.Drawing.Size(147, 24);
            this.chbNameP.TabIndex = 0;
            this.chbNameP.Text = "NOMBRE P.";
            this.chbNameP.UseVisualStyleBackColor = false;
            this.chbNameP.CheckedChanged += new System.EventHandler(this.chbNameP_CheckedChanged);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOriginal.Location = new System.Drawing.Point(522, 38);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(110, 37);
            this.btnOriginal.TabIndex = 17;
            this.btnOriginal.Text = "ORIGINAL";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // txtbQueryPriceMin
            // 
            this.txtbQueryPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQueryPriceMin.Location = new System.Drawing.Point(224, 98);
            this.txtbQueryPriceMin.Name = "txtbQueryPriceMin";
            this.txtbQueryPriceMin.Size = new System.Drawing.Size(107, 28);
            this.txtbQueryPriceMin.TabIndex = 16;
            this.txtbQueryPriceMin.TextChanged += new System.EventHandler(this.txtbQueryPriceMin_TextChanged_1);
            // 
            // txtbQueryPriceMax
            // 
            this.txtbQueryPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQueryPriceMax.Location = new System.Drawing.Point(501, 101);
            this.txtbQueryPriceMax.Name = "txtbQueryPriceMax";
            this.txtbQueryPriceMax.Size = new System.Drawing.Size(107, 28);
            this.txtbQueryPriceMax.TabIndex = 14;
            this.txtbQueryPriceMax.TextChanged += new System.EventHandler(this.txtbQueryPriceMax_TextChanged);
            // 
            // txtbQueryName
            // 
            this.txtbQueryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQueryName.Location = new System.Drawing.Point(246, 48);
            this.txtbQueryName.Name = "txtbQueryName";
            this.txtbQueryName.Size = new System.Drawing.Size(227, 28);
            this.txtbQueryName.TabIndex = 13;
            this.txtbQueryName.TextChanged += new System.EventHandler(this.txtbQueryName_TextChanged);
            this.txtbQueryName.Leave += new System.EventHandler(this.txtbQueryName_Leave);
            // 
            // combQueryCategory
            // 
            this.combQueryCategory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.combQueryCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQueryCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combQueryCategory.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.combQueryCategory.FormattingEnabled = true;
            this.combQueryCategory.Items.AddRange(new object[] {
            "HOGAR",
            "MECANICA",
            "OFICINA"});
            this.combQueryCategory.Location = new System.Drawing.Point(292, 149);
            this.combQueryCategory.Name = "combQueryCategory";
            this.combQueryCategory.Size = new System.Drawing.Size(173, 28);
            this.combQueryCategory.TabIndex = 12;
            this.combQueryCategory.SelectedIndexChanged += new System.EventHandler(this.combQueryCategory_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(522, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 37);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(438, 315);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(742, 252);
            this.dgvProduct.TabIndex = 7;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 612);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.grpbQuery);
            this.Controls.Add(this.grpbAddpro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbAddpro.ResumeLayout(false);
            this.grpbAddpro.PerformLayout();
            this.grpbQuery.ResumeLayout(false);
            this.grpbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbAddpro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox combCategory;
        private System.Windows.Forms.GroupBox grpbQuery;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbQueryName;
        private System.Windows.Forms.ComboBox combQueryCategory;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtbQueryPriceMax;
        private System.Windows.Forms.TextBox txtbQueryPriceMin;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.CheckBox chbNameP;
        private System.Windows.Forms.CheckBox chbPricemin;
        private System.Windows.Forms.CheckBox chbPricemax;
        private System.Windows.Forms.Label label1;
    }
}

