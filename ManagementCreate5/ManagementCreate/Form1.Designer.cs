namespace ManagementCreate
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateDev = new System.Windows.Forms.Button();
            this.tbDevPostCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDevIp = new System.Windows.Forms.TextBox();
            this.tbDevAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDevName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRoute = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lbDevs = new System.Windows.Forms.ListBox();
            this.lbPros = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditDev = new System.Windows.Forms.Button();
            this.btnDeleteDev = new System.Windows.Forms.Button();
            this.btnEditPro = new System.Windows.Forms.Button();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateDev);
            this.groupBox1.Controls.Add(this.tbDevPostCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDevIp);
            this.groupBox1.Controls.Add(this.tbDevAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDevName);
            this.groupBox1.Location = new System.Drawing.Point(20, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Device";
            // 
            // btnCreateDev
            // 
            this.btnCreateDev.Location = new System.Drawing.Point(87, 154);
            this.btnCreateDev.Name = "btnCreateDev";
            this.btnCreateDev.Size = new System.Drawing.Size(100, 33);
            this.btnCreateDev.TabIndex = 4;
            this.btnCreateDev.Text = "Add Device";
            this.btnCreateDev.UseVisualStyleBackColor = true;
            this.btnCreateDev.Click += new System.EventHandler(this.btnCreateDev_Click);
            // 
            // tbDevPostCode
            // 
            this.tbDevPostCode.Location = new System.Drawing.Point(87, 117);
            this.tbDevPostCode.Name = "tbDevPostCode";
            this.tbDevPostCode.Size = new System.Drawing.Size(100, 20);
            this.tbDevPostCode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Postal Code:";
            // 
            // tbDevIp
            // 
            this.tbDevIp.Location = new System.Drawing.Point(87, 65);
            this.tbDevIp.Name = "tbDevIp";
            this.tbDevIp.Size = new System.Drawing.Size(100, 20);
            this.tbDevIp.TabIndex = 1;
            // 
            // tbDevAddress
            // 
            this.tbDevAddress.Location = new System.Drawing.Point(87, 91);
            this.tbDevAddress.Name = "tbDevAddress";
            this.tbDevAddress.Size = new System.Drawing.Size(100, 20);
            this.tbDevAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Post Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tbDevName
            // 
            this.tbDevName.Location = new System.Drawing.Point(87, 39);
            this.tbDevName.Name = "tbDevName";
            this.tbDevName.Size = new System.Drawing.Size(100, 20);
            this.tbDevName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCreateProduct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.cbRoute);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbRoute);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbProductName);
            this.groupBox2.Location = new System.Drawing.Point(274, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(61, 97);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(122, 36);
            this.btnCreateProduct.TabIndex = 8;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Full route:";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(201, 65);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = ">";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // cbRoute
            // 
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(62, 65);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(121, 21);
            this.cbRoute.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Route:";
            // 
            // lbRoute
            // 
            this.lbRoute.FormattingEnabled = true;
            this.lbRoute.Location = new System.Drawing.Point(294, 65);
            this.lbRoute.Name = "lbRoute";
            this.lbRoute.Size = new System.Drawing.Size(120, 95);
            this.lbRoute.TabIndex = 0;
            this.lbRoute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbRoute_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(61, 35);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(122, 20);
            this.tbProductName.TabIndex = 5;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(19, 276);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 20;
            // 
            // lbDevs
            // 
            this.lbDevs.FormattingEnabled = true;
            this.lbDevs.Location = new System.Drawing.Point(20, 335);
            this.lbDevs.Name = "lbDevs";
            this.lbDevs.Size = new System.Drawing.Size(231, 212);
            this.lbDevs.TabIndex = 22;
            this.lbDevs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbDevs_KeyPress);
            // 
            // lbPros
            // 
            this.lbPros.FormattingEnabled = true;
            this.lbPros.Location = new System.Drawing.Point(387, 335);
            this.lbPros.Name = "lbPros";
            this.lbPros.Size = new System.Drawing.Size(231, 212);
            this.lbPros.TabIndex = 23;
            this.lbPros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbPros_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Devices:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Products:";
            // 
            // btnEditDev
            // 
            this.btnEditDev.Location = new System.Drawing.Point(20, 553);
            this.btnEditDev.Name = "btnEditDev";
            this.btnEditDev.Size = new System.Drawing.Size(109, 39);
            this.btnEditDev.TabIndex = 26;
            this.btnEditDev.Text = "Edit Device";
            this.btnEditDev.UseVisualStyleBackColor = true;
            this.btnEditDev.Click += new System.EventHandler(this.btnEditDev_Click);
            // 
            // btnDeleteDev
            // 
            this.btnDeleteDev.Location = new System.Drawing.Point(142, 553);
            this.btnDeleteDev.Name = "btnDeleteDev";
            this.btnDeleteDev.Size = new System.Drawing.Size(109, 39);
            this.btnDeleteDev.TabIndex = 27;
            this.btnDeleteDev.Text = "Delete Device";
            this.btnDeleteDev.UseVisualStyleBackColor = true;
            this.btnDeleteDev.Click += new System.EventHandler(this.btnDeleteDev_Click);
            // 
            // btnEditPro
            // 
            this.btnEditPro.Location = new System.Drawing.Point(387, 553);
            this.btnEditPro.Name = "btnEditPro";
            this.btnEditPro.Size = new System.Drawing.Size(109, 39);
            this.btnEditPro.TabIndex = 28;
            this.btnEditPro.Text = "Edit Product";
            this.btnEditPro.UseVisualStyleBackColor = true;
            this.btnEditPro.Click += new System.EventHandler(this.btnEditPro_Click);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.Location = new System.Drawing.Point(509, 553);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(109, 39);
            this.btnDeletePro.TabIndex = 29;
            this.btnDeletePro.Text = "Delete Product";
            this.btnDeletePro.UseVisualStyleBackColor = true;
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 673);
            this.Controls.Add(this.btnDeletePro);
            this.Controls.Add(this.btnEditPro);
            this.Controls.Add(this.btnDeleteDev);
            this.Controls.Add(this.btnEditDev);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPros);
            this.Controls.Add(this.lbDevs);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Management tools";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateDev;
        private System.Windows.Forms.TextBox tbDevPostCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDevIp;
        private System.Windows.Forms.TextBox tbDevAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDevName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbRoute;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbDevs;
        private System.Windows.Forms.ListBox lbPros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditDev;
        private System.Windows.Forms.Button btnDeleteDev;
        private System.Windows.Forms.Button btnEditPro;
        private System.Windows.Forms.Button btnDeletePro;
    }
}

