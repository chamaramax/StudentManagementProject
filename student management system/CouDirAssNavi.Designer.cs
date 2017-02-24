namespace student_management_system
{
    partial class CouDirAssNavi
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
            this.cbox_streamcode = new System.Windows.Forms.ComboBox();
            this.cbox_coursecode = new System.Windows.Forms.ComboBox();
            this.cbox_courdirid = new System.Windows.Forms.ComboBox();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_updt = new System.Windows.Forms.Button();
            this.lbl_streamcode = new System.Windows.Forms.Label();
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.lbl_courdirid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_streamcode
            // 
            this.cbox_streamcode.FormattingEnabled = true;
            this.cbox_streamcode.Location = new System.Drawing.Point(323, 242);
            this.cbox_streamcode.Name = "cbox_streamcode";
            this.cbox_streamcode.Size = new System.Drawing.Size(242, 24);
            this.cbox_streamcode.TabIndex = 19;
            // 
            // cbox_coursecode
            // 
            this.cbox_coursecode.FormattingEnabled = true;
            this.cbox_coursecode.Location = new System.Drawing.Point(323, 201);
            this.cbox_coursecode.Name = "cbox_coursecode";
            this.cbox_coursecode.Size = new System.Drawing.Size(242, 24);
            this.cbox_coursecode.TabIndex = 18;
            // 
            // cbox_courdirid
            // 
            this.cbox_courdirid.FormattingEnabled = true;
            this.cbox_courdirid.Location = new System.Drawing.Point(323, 162);
            this.cbox_courdirid.Name = "cbox_courdirid";
            this.cbox_courdirid.Size = new System.Drawing.Size(242, 24);
            this.cbox_courdirid.TabIndex = 17;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(595, 302);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(101, 33);
            this.btn_cancl.TabIndex = 16;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(352, 302);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(102, 33);
            this.btn_updt.TabIndex = 15;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            // 
            // lbl_streamcode
            // 
            this.lbl_streamcode.AutoSize = true;
            this.lbl_streamcode.Location = new System.Drawing.Point(156, 242);
            this.lbl_streamcode.Name = "lbl_streamcode";
            this.lbl_streamcode.Size = new System.Drawing.Size(90, 17);
            this.lbl_streamcode.TabIndex = 14;
            this.lbl_streamcode.Text = "Stream Code";
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Location = new System.Drawing.Point(156, 201);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(90, 17);
            this.lbl_coursecode.TabIndex = 13;
            this.lbl_coursecode.Text = "Course Code";
            // 
            // lbl_courdirid
            // 
            this.lbl_courdirid.AutoSize = true;
            this.lbl_courdirid.Location = new System.Drawing.Point(156, 162);
            this.lbl_courdirid.Name = "lbl_courdirid";
            this.lbl_courdirid.Size = new System.Drawing.Size(124, 17);
            this.lbl_courdirid.TabIndex = 12;
            this.lbl_courdirid.Text = "Course Director ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course Director Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course Director Assigning Form";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(483, 302);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(91, 32);
            this.btn_del.TabIndex = 20;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // CouDirAssNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 396);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.cbox_streamcode);
            this.Controls.Add(this.cbox_coursecode);
            this.Controls.Add(this.cbox_courdirid);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.lbl_streamcode);
            this.Controls.Add(this.lbl_coursecode);
            this.Controls.Add(this.lbl_courdirid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CouDirAssNavi";
            this.Text = "Course Director Assignning Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_streamcode;
        private System.Windows.Forms.ComboBox cbox_coursecode;
        private System.Windows.Forms.ComboBox cbox_courdirid;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Label lbl_streamcode;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label lbl_courdirid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
    }
}