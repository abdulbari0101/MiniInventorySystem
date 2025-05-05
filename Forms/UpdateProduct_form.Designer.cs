namespace MiniInventorySystem.Forms
{
    partial class UpdateProduct_form
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_price = new System.Windows.Forms.TextBox();
            this.txtBox_model = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.txtBox_brand = new System.Windows.Forms.TextBox();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menu_category = new System.Windows.Forms.ComboBox();
            this.txtBox_Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(820, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "SAR";
            // 
            // txtBox_price
            // 
            this.txtBox_price.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBox_price.Location = new System.Drawing.Point(591, 273);
            this.txtBox_price.Name = "txtBox_price";
            this.txtBox_price.Size = new System.Drawing.Size(223, 28);
            this.txtBox_price.TabIndex = 54;
            // 
            // txtBox_model
            // 
            this.txtBox_model.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBox_model.Location = new System.Drawing.Point(591, 192);
            this.txtBox_model.Name = "txtBox_model";
            this.txtBox_model.Size = new System.Drawing.Size(266, 28);
            this.txtBox_model.TabIndex = 53;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(510, 11);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 34);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txtBox_name
            // 
            this.txtBox_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBox_name.Location = new System.Drawing.Point(591, 111);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(266, 28);
            this.txtBox_name.TabIndex = 52;
            // 
            // txtBox_brand
            // 
            this.txtBox_brand.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBox_brand.Location = new System.Drawing.Point(131, 192);
            this.txtBox_brand.Name = "txtBox_brand";
            this.txtBox_brand.Size = new System.Drawing.Size(266, 28);
            this.txtBox_brand.TabIndex = 50;
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBox_ID.Location = new System.Drawing.Point(131, 111);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(266, 28);
            this.txtBox_ID.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 23);
            this.label10.TabIndex = 45;
            this.label10.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Location = new System.Drawing.Point(131, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 54);
            this.panel1.TabIndex = 44;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(51, 11);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 34);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(510, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(303, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Update Product Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Brand";
            // 
            // menu_category
            // 
            this.menu_category.FormattingEnabled = true;
            this.menu_category.Location = new System.Drawing.Point(131, 277);
            this.menu_category.Name = "menu_category";
            this.menu_category.Size = new System.Drawing.Size(266, 24);
            this.menu_category.TabIndex = 57;
            // 
            // txtBox_Quantity
            // 
            this.txtBox_Quantity.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBox_Quantity.Location = new System.Drawing.Point(419, 386);
            this.txtBox_Quantity.Name = "txtBox_Quantity";
            this.txtBox_Quantity.Size = new System.Drawing.Size(146, 28);
            this.txtBox_Quantity.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Quantity";
            // 
            // UpdateProduct_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 576);
            this.Controls.Add(this.txtBox_Quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menu_category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_price);
            this.Controls.Add(this.txtBox_model);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.txtBox_brand);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "UpdateProduct_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProduct_form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_price;
        private System.Windows.Forms.TextBox txtBox_model;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.TextBox txtBox_brand;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox menu_category;
        private System.Windows.Forms.TextBox txtBox_Quantity;
        private System.Windows.Forms.Label label6;
    }
}