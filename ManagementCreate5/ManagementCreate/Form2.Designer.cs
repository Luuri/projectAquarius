namespace ManagementCreate
{
    partial class FormDevEdit
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
            this.btnDevEditCancel = new System.Windows.Forms.Button();
            this.btnDevEditSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbEditDevName = new System.Windows.Forms.TextBox();
            this.tbEditDevIP = new System.Windows.Forms.TextBox();
            this.tbEditDevAddress = new System.Windows.Forms.TextBox();
            this.tbEditDevPostCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDevEditCancel
            // 
            this.btnDevEditCancel.Location = new System.Drawing.Point(191, 159);
            this.btnDevEditCancel.Name = "btnDevEditCancel";
            this.btnDevEditCancel.Size = new System.Drawing.Size(88, 27);
            this.btnDevEditCancel.TabIndex = 41;
            this.btnDevEditCancel.Text = "Cancel";
            this.btnDevEditCancel.UseVisualStyleBackColor = true;
            this.btnDevEditCancel.Click += new System.EventHandler(this.btnDevEditCancel_Click);
            // 
            // btnDevEditSave
            // 
            this.btnDevEditSave.Location = new System.Drawing.Point(51, 159);
            this.btnDevEditSave.Name = "btnDevEditSave";
            this.btnDevEditSave.Size = new System.Drawing.Size(104, 27);
            this.btnDevEditSave.TabIndex = 40;
            this.btnDevEditSave.Text = "Save Changes";
            this.btnDevEditSave.UseVisualStyleBackColor = true;
            this.btnDevEditSave.Click += new System.EventHandler(this.btnDevEditSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "IP Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Name:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(65, 17);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 29;
            // 
            // tbEditDevName
            // 
            this.tbEditDevName.Location = new System.Drawing.Point(121, 28);
            this.tbEditDevName.Name = "tbEditDevName";
            this.tbEditDevName.Size = new System.Drawing.Size(118, 20);
            this.tbEditDevName.TabIndex = 36;
            // 
            // tbEditDevIP
            // 
            this.tbEditDevIP.Location = new System.Drawing.Point(121, 54);
            this.tbEditDevIP.Name = "tbEditDevIP";
            this.tbEditDevIP.Size = new System.Drawing.Size(118, 20);
            this.tbEditDevIP.TabIndex = 37;
            // 
            // tbEditDevAddress
            // 
            this.tbEditDevAddress.Location = new System.Drawing.Point(121, 80);
            this.tbEditDevAddress.Name = "tbEditDevAddress";
            this.tbEditDevAddress.Size = new System.Drawing.Size(118, 20);
            this.tbEditDevAddress.TabIndex = 38;
            // 
            // tbEditDevPostCode
            // 
            this.tbEditDevPostCode.Location = new System.Drawing.Point(121, 106);
            this.tbEditDevPostCode.Name = "tbEditDevPostCode";
            this.tbEditDevPostCode.Size = new System.Drawing.Size(118, 20);
            this.tbEditDevPostCode.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Post Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Postal Code:";
            // 
            // FormDevEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEditDevPostCode);
            this.Controls.Add(this.tbEditDevAddress);
            this.Controls.Add(this.tbEditDevIP);
            this.Controls.Add(this.tbEditDevName);
            this.Controls.Add(this.btnDevEditCancel);
            this.Controls.Add(this.btnDevEditSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMsg);
            this.Name = "FormDevEdit";
            this.Text = "Edit Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevEditCancel;
        private System.Windows.Forms.Button btnDevEditSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox tbEditDevName;
        private System.Windows.Forms.TextBox tbEditDevIP;
        private System.Windows.Forms.TextBox tbEditDevAddress;
        private System.Windows.Forms.TextBox tbEditDevPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}