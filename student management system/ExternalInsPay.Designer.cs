namespace student_management_system
{
    partial class ExternalInsPay
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
            this.lbl_traineeid = new System.Windows.Forms.Label();
            this.lbl_coursename = new System.Windows.Forms.Label();
            this.lbl_externalins = new System.Windows.Forms.Label();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.lbl_cheqno = new System.Windows.Forms.Label();
            this.lbl_paymntdate = new System.Windows.Forms.Label();
            this.txt_traineeid = new System.Windows.Forms.TextBox();
            this.txt_coursename = new System.Windows.Forms.TextBox();
            this.txt_externalins = new System.Windows.Forms.TextBox();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.txt_cheqno = new System.Windows.Forms.TextBox();
            this.dtp_paymntdate = new System.Windows.Forms.DateTimePicker();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "External Ins Payment";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "External Ins Payment Information";
            this.label2.UseWaitCursor = true;
            // 
            // lbl_traineeid
            // 
            this.lbl_traineeid.AutoSize = true;
            this.lbl_traineeid.Location = new System.Drawing.Point(138, 137);
            this.lbl_traineeid.Name = "lbl_traineeid";
            this.lbl_traineeid.Size = new System.Drawing.Size(74, 17);
            this.lbl_traineeid.TabIndex = 2;
            this.lbl_traineeid.Text = "Trainee ID";
            this.lbl_traineeid.UseWaitCursor = true;
            this.lbl_traineeid.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_coursename
            // 
            this.lbl_coursename.AutoSize = true;
            this.lbl_coursename.Location = new System.Drawing.Point(138, 179);
            this.lbl_coursename.Name = "lbl_coursename";
            this.lbl_coursename.Size = new System.Drawing.Size(94, 17);
            this.lbl_coursename.TabIndex = 3;
            this.lbl_coursename.Text = "Course Name";
            this.lbl_coursename.UseWaitCursor = true;
            this.lbl_coursename.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_externalins
            // 
            this.lbl_externalins.AutoSize = true;
            this.lbl_externalins.Location = new System.Drawing.Point(138, 218);
            this.lbl_externalins.Name = "lbl_externalins";
            this.lbl_externalins.Size = new System.Drawing.Size(81, 17);
            this.lbl_externalins.TabIndex = 4;
            this.lbl_externalins.Text = "External Ins";
            this.lbl_externalins.UseWaitCursor = true;
            this.lbl_externalins.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Location = new System.Drawing.Point(138, 258);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(56, 17);
            this.lbl_amt.TabIndex = 5;
            this.lbl_amt.Text = "Amount";
            this.lbl_amt.UseWaitCursor = true;
            this.lbl_amt.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_cheqno
            // 
            this.lbl_cheqno.AutoSize = true;
            this.lbl_cheqno.Location = new System.Drawing.Point(138, 295);
            this.lbl_cheqno.Name = "lbl_cheqno";
            this.lbl_cheqno.Size = new System.Drawing.Size(79, 17);
            this.lbl_cheqno.TabIndex = 6;
            this.lbl_cheqno.Text = "Cheque No";
            this.lbl_cheqno.UseWaitCursor = true;
            // 
            // lbl_paymntdate
            // 
            this.lbl_paymntdate.AutoSize = true;
            this.lbl_paymntdate.Location = new System.Drawing.Point(138, 331);
            this.lbl_paymntdate.Name = "lbl_paymntdate";
            this.lbl_paymntdate.Size = new System.Drawing.Size(97, 17);
            this.lbl_paymntdate.TabIndex = 7;
            this.lbl_paymntdate.Text = "Payment Date";
            this.lbl_paymntdate.UseWaitCursor = true;
            // 
            // txt_traineeid
            // 
            this.txt_traineeid.Location = new System.Drawing.Point(262, 137);
            this.txt_traineeid.Name = "txt_traineeid";
            this.txt_traineeid.Size = new System.Drawing.Size(284, 22);
            this.txt_traineeid.TabIndex = 8;
            this.txt_traineeid.UseWaitCursor = true;
            this.txt_traineeid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_coursename
            // 
            this.txt_coursename.Location = new System.Drawing.Point(262, 179);
            this.txt_coursename.Name = "txt_coursename";
            this.txt_coursename.Size = new System.Drawing.Size(284, 22);
            this.txt_coursename.TabIndex = 9;
            this.txt_coursename.UseWaitCursor = true;
            // 
            // txt_externalins
            // 
            this.txt_externalins.Location = new System.Drawing.Point(262, 218);
            this.txt_externalins.Name = "txt_externalins";
            this.txt_externalins.Size = new System.Drawing.Size(284, 22);
            this.txt_externalins.TabIndex = 10;
            this.txt_externalins.UseWaitCursor = true;
            this.txt_externalins.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_amt
            // 
            this.txt_amt.Location = new System.Drawing.Point(262, 258);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(284, 22);
            this.txt_amt.TabIndex = 11;
            this.txt_amt.UseWaitCursor = true;
            // 
            // txt_cheqno
            // 
            this.txt_cheqno.Location = new System.Drawing.Point(262, 295);
            this.txt_cheqno.Name = "txt_cheqno";
            this.txt_cheqno.Size = new System.Drawing.Size(284, 22);
            this.txt_cheqno.TabIndex = 12;
            this.txt_cheqno.UseWaitCursor = true;
            // 
            // dtp_paymntdate
            // 
            this.dtp_paymntdate.Location = new System.Drawing.Point(262, 331);
            this.dtp_paymntdate.Name = "dtp_paymntdate";
            this.dtp_paymntdate.Size = new System.Drawing.Size(284, 22);
            this.dtp_paymntdate.TabIndex = 13;
            this.dtp_paymntdate.UseWaitCursor = true;
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(461, 388);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(105, 31);
            this.btn_sav.TabIndex = 14;
            this.btn_sav.Text = "Save";
            this.btn_sav.UseVisualStyleBackColor = true;
            this.btn_sav.UseWaitCursor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(584, 388);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(103, 31);
            this.btn_cancl.TabIndex = 15;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.UseWaitCursor = true;
            // 
            // ExternalInsPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 439);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.dtp_paymntdate);
            this.Controls.Add(this.txt_cheqno);
            this.Controls.Add(this.txt_amt);
            this.Controls.Add(this.txt_externalins);
            this.Controls.Add(this.txt_coursename);
            this.Controls.Add(this.txt_traineeid);
            this.Controls.Add(this.lbl_paymntdate);
            this.Controls.Add(this.lbl_cheqno);
            this.Controls.Add(this.lbl_amt);
            this.Controls.Add(this.lbl_externalins);
            this.Controls.Add(this.lbl_coursename);
            this.Controls.Add(this.lbl_traineeid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExternalInsPay";
            this.Text = "External Ins Payment";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_traineeid;
        private System.Windows.Forms.Label lbl_coursename;
        private System.Windows.Forms.Label lbl_externalins;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Label lbl_cheqno;
        private System.Windows.Forms.Label lbl_paymntdate;
        private System.Windows.Forms.TextBox txt_traineeid;
        private System.Windows.Forms.TextBox txt_coursename;
        private System.Windows.Forms.TextBox txt_externalins;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.TextBox txt_cheqno;
        private System.Windows.Forms.DateTimePicker dtp_paymntdate;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_cancl;
    }
}