namespace student_management_system
{
    partial class BatchDeNavi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_batchid = new System.Windows.Forms.Label();
            this.lbl_courseid = new System.Windows.Forms.Label();
            this.txt_batchid = new System.Windows.Forms.TextBox();
            this.txt_courseid = new System.Windows.Forms.TextBox();
            this.btn_updt = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Batch Details Entering Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Batch Details";
            // 
            // lbl_batchid
            // 
            this.lbl_batchid.AutoSize = true;
            this.lbl_batchid.Location = new System.Drawing.Point(146, 163);
            this.lbl_batchid.Name = "lbl_batchid";
            this.lbl_batchid.Size = new System.Drawing.Size(61, 17);
            this.lbl_batchid.TabIndex = 2;
            this.lbl_batchid.Text = "Batch ID";
            // 
            // lbl_courseid
            // 
            this.lbl_courseid.AutoSize = true;
            this.lbl_courseid.Location = new System.Drawing.Point(146, 223);
            this.lbl_courseid.Name = "lbl_courseid";
            this.lbl_courseid.Size = new System.Drawing.Size(70, 17);
            this.lbl_courseid.TabIndex = 3;
            this.lbl_courseid.Text = "Course ID";
            // 
            // txt_batchid
            // 
            this.txt_batchid.Location = new System.Drawing.Point(253, 163);
            this.txt_batchid.Name = "txt_batchid";
            this.txt_batchid.Size = new System.Drawing.Size(210, 22);
            this.txt_batchid.TabIndex = 4;
            // 
            // txt_courseid
            // 
            this.txt_courseid.Location = new System.Drawing.Point(253, 223);
            this.txt_courseid.Name = "txt_courseid";
            this.txt_courseid.Size = new System.Drawing.Size(210, 22);
            this.txt_courseid.TabIndex = 5;
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(405, 294);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(88, 32);
            this.btn_updt.TabIndex = 6;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(517, 294);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(86, 32);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(631, 294);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(80, 32);
            this.btn_cancl.TabIndex = 9;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // BatchDeNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 351);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.txt_courseid);
            this.Controls.Add(this.txt_batchid);
            this.Controls.Add(this.lbl_courseid);
            this.Controls.Add(this.lbl_batchid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BatchDeNavi";
            this.Text = "Batch Details Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_batchid;
        private System.Windows.Forms.Label lbl_courseid;
        private System.Windows.Forms.TextBox txt_batchid;
        private System.Windows.Forms.TextBox txt_courseid;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_cancl;
    }
}