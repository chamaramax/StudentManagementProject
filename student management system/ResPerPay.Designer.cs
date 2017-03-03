namespace student_management_system
{
    partial class resorsperson
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
            this.lbl_voucherno = new System.Windows.Forms.Label();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.lbl_paymntdate = new System.Windows.Forms.Label();
            this.lbl_respersnid = new System.Windows.Forms.Label();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_voucherno = new System.Windows.Forms.TextBox();
            this.txt_respersnid = new System.Windows.Forms.TextBox();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.dtp_paymntdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Person Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resource Person Payment Information";
            // 
            // lbl_voucherno
            // 
            this.lbl_voucherno.AutoSize = true;
            this.lbl_voucherno.Location = new System.Drawing.Point(155, 124);
            this.lbl_voucherno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_voucherno.Name = "lbl_voucherno";
            this.lbl_voucherno.Size = new System.Drawing.Size(64, 13);
            this.lbl_voucherno.TabIndex = 2;
            this.lbl_voucherno.Text = "Voucher No";
            this.lbl_voucherno.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Location = new System.Drawing.Point(155, 186);
            this.lbl_amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(43, 13);
            this.lbl_amt.TabIndex = 3;
            this.lbl_amt.Text = "Amount";
            // 
            // lbl_paymntdate
            // 
            this.lbl_paymntdate.AutoSize = true;
            this.lbl_paymntdate.Location = new System.Drawing.Point(155, 216);
            this.lbl_paymntdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_paymntdate.Name = "lbl_paymntdate";
            this.lbl_paymntdate.Size = new System.Drawing.Size(74, 13);
            this.lbl_paymntdate.TabIndex = 4;
            this.lbl_paymntdate.Text = "Payment Date";
            // 
            // lbl_respersnid
            // 
            this.lbl_respersnid.AutoSize = true;
            this.lbl_respersnid.Location = new System.Drawing.Point(155, 158);
            this.lbl_respersnid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_respersnid.Name = "lbl_respersnid";
            this.lbl_respersnid.Size = new System.Drawing.Size(103, 13);
            this.lbl_respersnid.TabIndex = 6;
            this.lbl_respersnid.Text = "Resource Person ID";
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(398, 261);
            this.btn_sav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(80, 27);
            this.btn_sav.TabIndex = 7;
            this.btn_sav.Text = "Save ";
            this.btn_sav.UseVisualStyleBackColor = true;
            this.btn_sav.Click += new System.EventHandler(this.btn_sav_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(500, 261);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(78, 27);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_voucherno
            // 
            this.txt_voucherno.Location = new System.Drawing.Point(286, 124);
            this.txt_voucherno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_voucherno.Name = "txt_voucherno";
            this.txt_voucherno.Size = new System.Drawing.Size(192, 20);
            this.txt_voucherno.TabIndex = 9;
            // 
            // txt_respersnid
            // 
            this.txt_respersnid.Location = new System.Drawing.Point(286, 158);
            this.txt_respersnid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_respersnid.Name = "txt_respersnid";
            this.txt_respersnid.Size = new System.Drawing.Size(192, 20);
            this.txt_respersnid.TabIndex = 10;
            // 
            // txt_amt
            // 
            this.txt_amt.Location = new System.Drawing.Point(286, 186);
            this.txt_amt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(192, 20);
            this.txt_amt.TabIndex = 11;
            // 
            // dtp_paymntdate
            // 
            this.dtp_paymntdate.Location = new System.Drawing.Point(286, 216);
            this.dtp_paymntdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_paymntdate.Name = "dtp_paymntdate";
            this.dtp_paymntdate.Size = new System.Drawing.Size(192, 20);
            this.dtp_paymntdate.TabIndex = 12;
            // 
            // resorsperson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 316);
            this.Controls.Add(this.dtp_paymntdate);
            this.Controls.Add(this.txt_amt);
            this.Controls.Add(this.txt_respersnid);
            this.Controls.Add(this.txt_voucherno);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.lbl_respersnid);
            this.Controls.Add(this.lbl_paymntdate);
            this.Controls.Add(this.lbl_amt);
            this.Controls.Add(this.lbl_voucherno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "resorsperson";
            this.Text = "Resource Person Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_voucherno;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Label lbl_paymntdate;
        private System.Windows.Forms.Label lbl_respersnid;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_voucherno;
        private System.Windows.Forms.TextBox txt_respersnid;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.DateTimePicker dtp_paymntdate;
    }
}