namespace MiniInventorySystem.Forms
{
    partial class AddSameProduct_form
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
            this.txtBox_Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_aviQuantity = new System.Windows.Forms.Label();
            this.lbl_over_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Quantity
            // 
            this.txtBox_Quantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBox_Quantity.Location = new System.Drawing.Point(523, 307);
            this.txtBox_Quantity.Name = "txtBox_Quantity";
            this.txtBox_Quantity.Size = new System.Drawing.Size(146, 32);
            this.txtBox_Quantity.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Enter Quantity";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(64, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 54);
            this.panel1.TabIndex = 46;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(146, 10);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 34);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(722, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 34);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "OK";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(486, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 45;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(56, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 33);
            this.label2.TabIndex = 47;
            this.label2.Text = "ProductID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(449, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 48;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(819, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 33);
            this.label4.TabIndex = 49;
            this.label4.Text = "Model:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_name.Location = new System.Drawing.Point(549, 143);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(198, 33);
            this.lbl_name.TabIndex = 50;
            this.lbl_name.Text = "Samsung S23";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_id.Location = new System.Drawing.Point(226, 143);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(45, 33);
            this.lbl_id.TabIndex = 51;
            this.lbl_id.Text = "Id";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_model.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_model.Location = new System.Drawing.Point(923, 143);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(119, 33);
            this.lbl_model.TabIndex = 52;
            this.lbl_model.Text = "SM-234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(769, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 28);
            this.label5.TabIndex = 53;
            this.label5.Text = "Available quantity:";
            // 
            // lbl_aviQuantity
            // 
            this.lbl_aviQuantity.AutoSize = true;
            this.lbl_aviQuantity.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviQuantity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_aviQuantity.Location = new System.Drawing.Point(993, 68);
            this.lbl_aviQuantity.Name = "lbl_aviQuantity";
            this.lbl_aviQuantity.Size = new System.Drawing.Size(36, 26);
            this.lbl_aviQuantity.TabIndex = 54;
            this.lbl_aviQuantity.Text = "50";
            // 
            // lbl_over_error
            // 
            this.lbl_over_error.AutoSize = true;
            this.lbl_over_error.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_over_error.Location = new System.Drawing.Point(450, 357);
            this.lbl_over_error.Name = "lbl_over_error";
            this.lbl_over_error.Size = new System.Drawing.Size(277, 20);
            this.lbl_over_error.TabIndex = 55;
            this.lbl_over_error.Text = "can\'t remove over available quantity!";
            this.lbl_over_error.Visible = false;
            // 
            // AddSameProduct_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 485);
            this.Controls.Add(this.lbl_over_error);
            this.Controls.Add(this.lbl_aviQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Quantity);
            this.Controls.Add(this.label6);
            this.Name = "AddSameProduct_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSameProduct_form";
            this.Load += new System.EventHandler(this.AddSameProduct_form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_aviQuantity;
        private System.Windows.Forms.Label lbl_over_error;
    }
}