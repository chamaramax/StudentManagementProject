namespace student_management_system
{
    partial class frm_batchdetails
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
            this.btn_sve = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_batchid = new System.Windows.Forms.Label();
            this.lbl_corseid = new System.Windows.Forms.Label();
            this.txt_batchid = new System.Windows.Forms.TextBox();
            this.txt_corseid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sve
            // 
            this.btn_sve.Location = new System.Drawing.Point(278, 324);
            this.btn_sve.Name = "btn_sve";
            this.btn_sve.Size = new System.Drawing.Size(75, 23);
            this.btn_sve.TabIndex = 0;
            this.btn_sve.Text = "Save";
            this.btn_sve.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(416, 324);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(75, 23);
            this.btn_cancl.TabIndex = 1;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Batch Details Entering Form";
            // 
            // lbl_batchid
            // 
            this.lbl_batchid.AutoSize = true;
            this.lbl_batchid.Location = new System.Drawing.Point(118, 121);
            this.lbl_batchid.Name = "lbl_batchid";
            this.lbl_batchid.Size = new System.Drawing.Size(61, 17);
            this.lbl_batchid.TabIndex = 3;
            this.lbl_batchid.Text = "Batch ID";
            // 
            // lbl_corseid
            // 
            this.lbl_corseid.AutoSize = true;
            this.lbl_corseid.Location = new System.Drawing.Point(118, 186);
            this.lbl_corseid.Name = "lbl_corseid";
            this.lbl_corseid.Size = new System.Drawing.Size(74, 17);
            this.lbl_corseid.TabIndex = 4;
            this.lbl_corseid.Text = "Course  ID";
            // 
            // txt_batchid
            // 
            this.txt_batchid.Location = new System.Drawing.Point(239, 121);
            this.txt_batchid.Name = "txt_batchid";
            this.txt_batchid.Size = new System.Drawing.Size(252, 22);
            this.txt_batchid.TabIndex = 5;
            // 
            // txt_corseid
            // 
            this.txt_corseid.Location = new System.Drawing.Point(239, 181);
            this.txt_corseid.Name = "txt_corseid";
            this.txt_corseid.Size = new System.Drawing.Size(252, 22);
            this.txt_corseid.TabIndex = 6;
            // 
            // frm_batchdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 449);
            this.Controls.Add(this.txt_corseid);
            this.Controls.Add(this.txt_batchid);
            this.Controls.Add(this.lbl_corseid);
            this.Controls.Add(this.lbl_batchid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sve);
            this.Name = "frm_batchdetails";
            this.Text = "Batch Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sve;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_batchid;
        private System.Windows.Forms.Label lbl_corseid;
        private System.Windows.Forms.TextBox txt_batchid;
        private System.Windows.Forms.TextBox txt_corseid;
    }
}