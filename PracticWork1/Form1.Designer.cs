namespace PracticWork1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dGVSuppliers = new System.Windows.Forms.DataGridView();
            this.dGVStock = new System.Windows.Forms.DataGridView();
            this.dGVGoods_type = new System.Windows.Forms.DataGridView();
            this.dGVGoods = new System.Windows.Forms.DataGridView();
            this.showInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMinimalCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMaximumCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMaximumQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodWithMinimalQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allInformationAboutTheGoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGVShow = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.showInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectDBToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // SelectDBToolStripMenuItem
            // 
            this.SelectDBToolStripMenuItem.Name = "SelectDBToolStripMenuItem";
            this.SelectDBToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.SelectDBToolStripMenuItem.Text = "Select database";
            this.SelectDBToolStripMenuItem.Click += new System.EventHandler(this.SelectDBToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTablesToolStripMenuItem,
            this.SaveChangesToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // CreateTablesToolStripMenuItem
            // 
            this.CreateTablesToolStripMenuItem.Name = "CreateTablesToolStripMenuItem";
            this.CreateTablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateTablesToolStripMenuItem.Text = "Create tables";
            this.CreateTablesToolStripMenuItem.Click += new System.EventHandler(this.CreateTablesToolStripMenuItem_Click);
            // 
            // SaveChangesToolStripMenuItem
            // 
            this.SaveChangesToolStripMenuItem.Name = "SaveChangesToolStripMenuItem";
            this.SaveChangesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveChangesToolStripMenuItem.Text = "Save changes";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.CheckPathExists = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dGVSuppliers
            // 
            this.dGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSuppliers.Location = new System.Drawing.Point(12, 322);
            this.dGVSuppliers.Name = "dGVSuppliers";
            this.dGVSuppliers.Size = new System.Drawing.Size(240, 150);
            this.dGVSuppliers.TabIndex = 1;
            // 
            // dGVStock
            // 
            this.dGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStock.Location = new System.Drawing.Point(307, 322);
            this.dGVStock.Name = "dGVStock";
            this.dGVStock.Size = new System.Drawing.Size(240, 150);
            this.dGVStock.TabIndex = 1;
            // 
            // dGVGoods_type
            // 
            this.dGVGoods_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGoods_type.Location = new System.Drawing.Point(12, 64);
            this.dGVGoods_type.Name = "dGVGoods_type";
            this.dGVGoods_type.Size = new System.Drawing.Size(240, 150);
            this.dGVGoods_type.TabIndex = 1;
            // 
            // dGVGoods
            // 
            this.dGVGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGoods.Location = new System.Drawing.Point(307, 64);
            this.dGVGoods.Name = "dGVGoods";
            this.dGVGoods.Size = new System.Drawing.Size(240, 150);
            this.dGVGoods.TabIndex = 1;
            // 
            // showInformationToolStripMenuItem
            // 
            this.showInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allInformationAboutTheGoodToolStripMenuItem,
            this.goodWithMaximumQuantityToolStripMenuItem,
            this.goodWithMinimalQuantityToolStripMenuItem,
            this.goodWithMinimalCostToolStripMenuItem,
            this.goodWithMaximumCostToolStripMenuItem});
            this.showInformationToolStripMenuItem.Name = "showInformationToolStripMenuItem";
            this.showInformationToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.showInformationToolStripMenuItem.Text = "Show information";
            // 
            // goodWithMinimalCostToolStripMenuItem
            // 
            this.goodWithMinimalCostToolStripMenuItem.Name = "goodWithMinimalCostToolStripMenuItem";
            this.goodWithMinimalCostToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.goodWithMinimalCostToolStripMenuItem.Text = "Good with minimal cost";
            this.goodWithMinimalCostToolStripMenuItem.Click += new System.EventHandler(this.goodWithMinimalCostToolStripMenuItem_Click);
            // 
            // goodWithMaximumCostToolStripMenuItem
            // 
            this.goodWithMaximumCostToolStripMenuItem.Name = "goodWithMaximumCostToolStripMenuItem";
            this.goodWithMaximumCostToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.goodWithMaximumCostToolStripMenuItem.Text = "Good with maximum cost";
            this.goodWithMaximumCostToolStripMenuItem.Click += new System.EventHandler(this.goodWithMaximumCostToolStripMenuItem_Click);
            // 
            // goodWithMaximumQuantityToolStripMenuItem
            // 
            this.goodWithMaximumQuantityToolStripMenuItem.Name = "goodWithMaximumQuantityToolStripMenuItem";
            this.goodWithMaximumQuantityToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.goodWithMaximumQuantityToolStripMenuItem.Text = "Good with maximum quantity";
            this.goodWithMaximumQuantityToolStripMenuItem.Click += new System.EventHandler(this.goodWithMaximumQuantityToolStripMenuItem_Click);
            // 
            // goodWithMinimalQuantityToolStripMenuItem
            // 
            this.goodWithMinimalQuantityToolStripMenuItem.Name = "goodWithMinimalQuantityToolStripMenuItem";
            this.goodWithMinimalQuantityToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.goodWithMinimalQuantityToolStripMenuItem.Text = "Good with minimal quantity";
            this.goodWithMinimalQuantityToolStripMenuItem.Click += new System.EventHandler(this.goodWithMinimalQuantityToolStripMenuItem_Click);
            // 
            // allInformationAboutTheGoodToolStripMenuItem
            // 
            this.allInformationAboutTheGoodToolStripMenuItem.Name = "allInformationAboutTheGoodToolStripMenuItem";
            this.allInformationAboutTheGoodToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.allInformationAboutTheGoodToolStripMenuItem.Text = "All information about the good";
            this.allInformationAboutTheGoodToolStripMenuItem.Click += new System.EventHandler(this.allInformationAboutTheGoodToolStripMenuItem_Click);
            // 
            // dGVShow
            // 
            this.dGVShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVShow.Location = new System.Drawing.Point(611, 64);
            this.dGVShow.Name = "dGVShow";
            this.dGVShow.Size = new System.Drawing.Size(540, 506);
            this.dGVShow.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 582);
            this.Controls.Add(this.dGVShow);
            this.Controls.Add(this.dGVGoods);
            this.Controls.Add(this.dGVStock);
            this.Controls.Add(this.dGVGoods_type);
            this.Controls.Add(this.dGVSuppliers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveChangesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dGVSuppliers;
        private System.Windows.Forms.DataGridView dGVStock;
        private System.Windows.Forms.DataGridView dGVGoods_type;
        private System.Windows.Forms.DataGridView dGVGoods;
        private System.Windows.Forms.ToolStripMenuItem showInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMinimalCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMaximumCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMaximumQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodWithMinimalQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allInformationAboutTheGoodToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGVShow;
    }
}

