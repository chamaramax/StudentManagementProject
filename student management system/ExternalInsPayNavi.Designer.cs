namespace student_management_system
{
    partial class ExternalInsPayNavi
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
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_updt = new System.Windows.Forms.Button();
            this.dtp_paymntdate = new System.Windows.Forms.DateTimePicker();
            this.txt_cheqno = new System.Windows.Forms.TextBox();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.txt_externalins = new System.Windows.Forms.TextBox();
            this.txt_coursename = new System.Windows.Forms.TextBox();
            this.txt_traineeid = new System.Windows.Forms.TextBox();
            this.lbl_paymntdate = new System.Windows.Forms.Label();
            this.lbl_cheqno = new System.Windows.Forms.Label();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.lbl_externalins = new System.Windows.Forms.Label();
            this.lbl_coursename = new System.Windows.Forms.Label();
            this.lbl_traineeid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(599, 383);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(103, 31);
            this.btn_cancl.TabIndex = 31;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(361, 383);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(105, 31);
            this.btn_updt.TabIndex = 30;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            // 
            // dtp_paymntdate
            // 
            this.dtp_paymntdate.Location = new System.Drawing.Point(256, 326);
            this.dtp_paymntdate.Name = "dtp_paymntdate";
            this.dtp_paymntdate.Size = new System.Drawing.Size(284, 22);
            this.dtp_paymntdate.TabIndex = 29;
            // 
            // txt_cheqno
            // 
            this.txt_cheqno.Location = new System.Drawing.Point(256, 290);
            this.txt_cheqno.Name = "txt_cheqno";
            this.txt_cheqno.Size = new System.Drawing.Size(284, 22);
            this.txt_cheqno.TabIndex = 28;
            // 
            // txt_amt
            // 
            this.txt_amt.Location = new System.Drawing.Point(256, 253);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(284, 22);
            this.txt_amt.TabIndex = 27;
            // 
            // txt_externalins
            // 
            this.txt_externalins.Location = new System.Drawing.Point(256, 213);
            this.txt_externalins.Name = "txt_externalins";
            this.txt_externalins.Size = new System.Drawing.Size(284, 22);
            this.txt_externalins.TabIndex = 26;
            // 
            // txt_coursename
            // 
            this.txt_coursename.Location = new System.Drawing.Point(256, 174);
            this.txt_coursename.Name = "txt_coursename";
            this.txt_coursename.Size = new System.Drawing.Size(284, 22);
            this.txt_coursename.TabIndex = 25;
            this.txt_coursename.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_traineeid
            // 
            this.txt_traineeid.Location = new System.Drawing.Point(256, 132);
            this.txt_traineeid.Name = "txt_traineeid";
            this.txt_traineeid.Size = new System.Drawing.Size(284, 22);
            this.txt_traineeid.TabIndex = 24;
            // 
            // lbl_paymntdate
            // 
            this.lbl_paymntdate.AutoSize = true;
            this.lbl_paymntdate.Location = new System.Drawing.Point(132, 326);
            this.lbl_paymntdate.Name = "lbl_paymntdate";
            this.lbl_paymntdate.Size = new System.Drawing.Size(97, 17);
            this.lbl_paymntdate.TabIndex = 23;
            this.lbl_paymntdate.Text = "Payment Date";
            // 
            // lbl_cheqno
            // 
            this.lbl_cheqno.AutoSize = true;
            this.lbl_cheqno.Location = new System.Drawing.Point(132, 290);
            this.lbl_cheqno.Name = "lbl_cheqno";
            this.lbl_cheqno.Size = new System.Drawing.Size(79, 17);
            this.lbl_cheqno.TabIndex = 22;
            this.lbl_cheqno.Text = "Cheque No";
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Location = new System.Drawing.Point(132, 253);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(56, 17);
            this.lbl_amt.TabIndex = 21;
            this.lbl_amt.Text = "Amount";
            this.lbl_amt.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_externalins
            // 
            this.lbl_externalins.AutoSize = true;
            this.lbl_externalins.Location = new System.Drawing.Point(132, 213);
            this.lbl_externalins.Name = "lbl_externalins";
            this.lbl_externalins.Size = new System.Drawing.Size(81, 17);
            this.lbl_externalins.TabIndex = 20;
            this.lbl_externalins.Text = "External Ins";
            // 
            // lbl_coursename
            // 
            this.lbl_coursename.AutoSize = true;
            this.lbl_coursename.Location = new System.Drawing.Point(132, 174);
            this.lbl_coursename.Name = "lbl_coursename";
            this.lbl_coursename.Size = new System.Drawing.Size(94, 17);
            this.lbl_coursename.TabIndex = 19;
            this.lbl_coursename.Text = "Course Name";
            this.lbl_coursename.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_traineeid
            // 
            this.lbl_traineeid.AutoSize = true;
            this.lbl_traineeid.Location = new System.Drawing.Point(132, 132);
            this.lbl_traineeid.Name = "lbl_traineeid";
            this.lbl_traineeid.Size = new System.Drawing.Size(74, 17);
            this.lbl_traineeid.TabIndex = 18;
            this.lbl_traineeid.Text = "Trainee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "External Ins Payment Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "External Ins Payment";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(492, 383);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(85, 31);
            this.btn_del.TabIndex = 32;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // ExternalInsPayNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 451);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_updt);
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
            this.Name = "ExternalInsPayNavi";
            this.Text = "ExternalIns Payment Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.DateTimePicker dtp_paymntdate;
        private System.Windows.Forms.TextBox txt_cheqno;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.TextBox txt_externalins;
        private System.Windows.Forms.TextBox txt_coursename;
        private System.Windows.Forms.TextBox txt_traineeid;
        private System.Windows.Forms.Label lbl_paymntdate;
        private System.Windows.Forms.Label lbl_cheqno;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Label lbl_externalins;
        private System.Windows.Forms.Label lbl_coursename;
        private System.Windows.Forms.Label lbl_traineeid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
    }
}