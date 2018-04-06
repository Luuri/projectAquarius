namespace ManagementCreate
{
    partial class FormProEdit
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
            this.tbEditProName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProEditSave = new System.Windows.Forms.Button();
            this.btnProEditCancel = new System.Windows.Forms.Button();
            this.lbEditProRoute = new System.Windows.Forms.ListBox();
            this.btnProEditRouteItemDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEditProDevices = new System.Windows.Forms.ComboBox();
            this.btnProEditRouteItemMove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEditProName
            // 
            this.tbEditProName.Location = new System.Drawing.Point(67, 24);
            this.tbEditProName.Name = "tbEditProName";
            this.tbEditProName.Size = new System.Drawing.Size(118, 20);
            this.tbEditProName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // btnProEditSave
            // 
            this.btnProEditSave.Location = new System.Drawing.Point(187, 260);
            this.btnProEditSave.Name = "btnProEditSave";
            this.btnProEditSave.Size = new System.Drawing.Size(104, 27);
            this.btnProEditSave.TabIndex = 2;
            this.btnProEditSave.Text = "Save Changes";
            this.btnProEditSave.UseVisualStyleBackColor = true;
            this.btnProEditSave.Click += new System.EventHandler(this.btnProEditSave_Click);
            // 
            // btnProEditCancel
            // 
            this.btnProEditCancel.Location = new System.Drawing.Point(307, 260);
            this.btnProEditCancel.Name = "btnProEditCancel";
            this.btnProEditCancel.Size = new System.Drawing.Size(104, 27);
            this.btnProEditCancel.TabIndex = 3;
            this.btnProEditCancel.Text = "Cancel";
            this.btnProEditCancel.UseVisualStyleBackColor = true;
            this.btnProEditCancel.Click += new System.EventHandler(this.btnProEditCancel_Click);
            // 
            // lbEditProRoute
            // 
            this.lbEditProRoute.FormattingEnabled = true;
            this.lbEditProRoute.Location = new System.Drawing.Point(67, 61);
            this.lbEditProRoute.Name = "lbEditProRoute";
            this.lbEditProRoute.Size = new System.Drawing.Size(120, 95);
            this.lbEditProRoute.TabIndex = 4;
            this.lbEditProRoute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbEditProRoute_KeyPress);
            // 
            // btnProEditRouteItemDelete
            // 
            this.btnProEditRouteItemDelete.Location = new System.Drawing.Point(67, 173);
            this.btnProEditRouteItemDelete.Name = "btnProEditRouteItemDelete";
            this.btnProEditRouteItemDelete.Size = new System.Drawing.Size(120, 23);
            this.btnProEditRouteItemDelete.TabIndex = 5;
            this.btnProEditRouteItemDelete.Text = "Delete Item";
            this.btnProEditRouteItemDelete.UseVisualStyleBackColor = true;
            this.btnProEditRouteItemDelete.Click += new System.EventHandler(this.btnProEditRouteItemDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Route:";
            // 
            // cbEditProDevices
            // 
            this.cbEditProDevices.FormattingEnabled = true;
            this.cbEditProDevices.Location = new System.Drawing.Point(261, 63);
            this.cbEditProDevices.Name = "cbEditProDevices";
            this.cbEditProDevices.Size = new System.Drawing.Size(118, 21);
            this.cbEditProDevices.TabIndex = 7;
            // 
            // btnProEditRouteItemMove
            // 
            this.btnProEditRouteItemMove.Location = new System.Drawing.Point(209, 61);
            this.btnProEditRouteItemMove.Name = "btnProEditRouteItemMove";
            this.btnProEditRouteItemMove.Size = new System.Drawing.Size(28, 23);
            this.btnProEditRouteItemMove.TabIndex = 8;
            this.btnProEditRouteItemMove.Text = "<";
            this.btnProEditRouteItemMove.UseVisualStyleBackColor = true;
            this.btnProEditRouteItemMove.Click += new System.EventHandler(this.btnProEditRouteItemMove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Devices:";
            // 
            // FormProEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProEditRouteItemMove);
            this.Controls.Add(this.cbEditProDevices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProEditRouteItemDelete);
            this.Controls.Add(this.lbEditProRoute);
            this.Controls.Add(this.btnProEditCancel);
            this.Controls.Add(this.btnProEditSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEditProName);
            this.Name = "FormProEdit";
            this.Text = "Edit Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEditProName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProEditSave;
        private System.Windows.Forms.Button btnProEditCancel;
        private System.Windows.Forms.ListBox lbEditProRoute;
        private System.Windows.Forms.Button btnProEditRouteItemDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEditProDevices;
        private System.Windows.Forms.Button btnProEditRouteItemMove;
        private System.Windows.Forms.Label label3;
    }
}