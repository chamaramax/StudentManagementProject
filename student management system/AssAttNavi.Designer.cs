namespace student_management_system
{
    partial class AssAttNavi
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
            this.txt_evaludate = new System.Windows.Forms.TextBox();
            this.txt_tradetestid = new System.Windows.Forms.TextBox();
            this.txt_assessorid = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_updt = new System.Windows.Forms.Button();
            this.lbl_evaludate = new System.Windows.Forms.Label();
            this.lbl_tradetestid = new System.Windows.Forms.Label();
            this.lbl_assessorid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_evaludate
            // 
            this.txt_evaludate.Location = new System.Drawing.Point(237, 217);
            this.txt_evaludate.Name = "txt_evaludate";
            this.txt_evaludate.Size = new System.Drawing.Size(298, 22);
            this.txt_evaludate.TabIndex = 19;
            // 
            // txt_tradetestid
            // 
            this.txt_tradetestid.Location = new System.Drawing.Point(237, 178);
            this.txt_tradetestid.Name = "txt_tradetestid";
            this.txt_tradetestid.Size = new System.Drawing.Size(298, 22);
            this.txt_tradetestid.TabIndex = 18;
            // 
            // txt_assessorid
            // 
            this.txt_assessorid.Location = new System.Drawing.Point(237, 136);
            this.txt_assessorid.Name = "txt_assessorid";
            this.txt_assessorid.Size = new System.Drawing.Size(298, 22);
            this.txt_assessorid.TabIndex = 17;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(421, 278);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(105, 35);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(298, 278);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(117, 35);
            this.btn_updt.TabIndex = 15;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            // 
            // lbl_evaludate
            // 
            this.lbl_evaludate.AutoSize = true;
            this.lbl_evaludate.Location = new System.Drawing.Point(74, 217);
            this.lbl_evaludate.Name = "lbl_evaludate";
            this.lbl_evaludate.Size = new System.Drawing.Size(108, 17);
            this.lbl_evaludate.TabIndex = 14;
            this.lbl_evaludate.Text = "Evaluation Date";
            // 
            // lbl_tradetestid
            // 
            this.lbl_tradetestid.AutoSize = true;
            this.lbl_tradetestid.Location = new System.Drawing.Point(74, 178);
            this.lbl_tradetestid.Name = "lbl_tradetestid";
            this.lbl_tradetestid.Size = new System.Drawing.Size(95, 17);
            this.lbl_tradetestid.TabIndex = 13;
            this.lbl_tradetestid.Text = "Trade Test ID";
            // 
            // lbl_assessorid
            // 
            this.lbl_assessorid.AutoSize = true;
            this.lbl_assessorid.Location = new System.Drawing.Point(74, 136);
            this.lbl_assessorid.Name = "lbl_assessorid";
            this.lbl_assessorid.Size = new System.Drawing.Size(83, 17);
            this.lbl_assessorid.TabIndex = 12;
            this.lbl_assessorid.Text = "Assessor ID";
            this.lbl_assessorid.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Assessor Attendance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Assessor Attendance";
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(532, 278);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(95, 35);
            this.btn_cancl.TabIndex = 20;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // AssAttNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 350);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.txt_evaludate);
            this.Controls.Add(this.txt_tradetestid);
            this.Controls.Add(this.txt_assessorid);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.lbl_evaludate);
            this.Controls.Add(this.lbl_tradetestid);
            this.Controls.Add(this.lbl_assessorid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssAttNavi";
            this.Text = "Assessor Attendance Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_evaludate;
        private System.Windows.Forms.TextBox txt_tradetestid;
        private System.Windows.Forms.TextBox txt_assessorid;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Label lbl_evaludate;
        private System.Windows.Forms.Label lbl_tradetestid;
        private System.Windows.Forms.Label lbl_assessorid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancl;
    }
}