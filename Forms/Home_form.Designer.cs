namespace MiniInventorySystem.Forms
{
    partial class Home_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_form));
            this.btn_display_all = new System.Windows.Forms.Button();
            this.btn_update_product = new System.Windows.Forms.Button();
            this.btn_remove_product = new System.Windows.Forms.Button();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.myGridView = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_display_all
            // 
            this.btn_display_all.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_display_all.Location = new System.Drawing.Point(1134, 460);
            this.btn_display_all.Name = "btn_display_all";
            this.btn_display_all.Size = new System.Drawing.Size(192, 39);
            this.btn_display_all.TabIndex = 19;
            this.btn_display_all.Text = "Display All ";
            this.btn_display_all.UseVisualStyleBackColor = true;
            this.btn_display_all.Click += new System.EventHandler(this.btn_display_all_Click);
            // 
            // btn_update_product
            // 
            this.btn_update_product.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_update_product.Location = new System.Drawing.Point(1134, 285);
            this.btn_update_product.Name = "btn_update_product";
            this.btn_update_product.Size = new System.Drawing.Size(192, 39);
            this.btn_update_product.TabIndex = 18;
            this.btn_update_product.Text = "Update Product";
            this.btn_update_product.UseVisualStyleBackColor = true;
            this.btn_update_product.Click += new System.EventHandler(this.btn_update_product_Click);
            // 
            // btn_remove_product
            // 
            this.btn_remove_product.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_remove_product.Location = new System.Drawing.Point(1134, 376);
            this.btn_remove_product.Name = "btn_remove_product";
            this.btn_remove_product.Size = new System.Drawing.Size(192, 39);
            this.btn_remove_product.TabIndex = 17;
            this.btn_remove_product.Text = "Remove Product";
            this.btn_remove_product.UseVisualStyleBackColor = true;
            this.btn_remove_product.Click += new System.EventHandler(this.btn_remove_product_Click);
            // 
            // btn_add_product
            // 
            this.btn_add_product.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_add_product.Location = new System.Drawing.Point(1134, 191);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(192, 39);
            this.btn_add_product.TabIndex = 16;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.txtbox_search);
            this.panel2.Location = new System.Drawing.Point(22, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 91);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(-4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mini Inventory System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(421, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Find product by id";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(767, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 38);
            this.search.TabIndex = 15;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(354, 41);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // txtbox_search
            // 
            this.txtbox_search.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.ForeColor = System.Drawing.Color.Black;
            this.txtbox_search.Location = new System.Drawing.Point(381, 42);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(301, 29);
            this.txtbox_search.TabIndex = 13;
            this.txtbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myGridView
            // 
            this.myGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGridView.Location = new System.Drawing.Point(22, 138);
            this.myGridView.Name = "myGridView";
            this.myGridView.RowHeadersWidth = 51;
            this.myGridView.RowTemplate.Height = 26;
            this.myGridView.Size = new System.Drawing.Size(1099, 417);
            this.myGridView.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1236, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(498, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Products List";
            // 
            // Home_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1345, 578);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remove_product);
            this.Controls.Add(this.btn_update_product);
            this.Controls.Add(this.btn_display_all);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.myGridView);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_display_all;
        private System.Windows.Forms.Button btn_update_product;
        private System.Windows.Forms.Button btn_remove_product;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtbox_search;
        public System.Windows.Forms.DataGridView myGridView;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}