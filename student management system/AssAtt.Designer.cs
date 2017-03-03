namespace student_management_system
{
    partial class AssAtt
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
            this.lbl_assessorid = new System.Windows.Forms.Label();
            this.lbl_tradetestid = new System.Windows.Forms.Label();
            this.lbl_evaludate = new System.Windows.Forms.Label();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.txt_assessorid = new System.Windows.Forms.TextBox();
            this.txt_tradetestid = new System.Windows.Forms.TextBox();
            this.txt_evaludate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessor Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessor Attendance";
            // 
            // lbl_assessorid
            // 
            this.lbl_assessorid.AutoSize = true;
            this.lbl_assessorid.Location = new System.Drawing.Point(88, 110);
            this.lbl_assessorid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_assessorid.Name = "lbl_assessorid";
            this.lbl_assessorid.Size = new System.Drawing.Size(63, 13);
            this.lbl_assessorid.TabIndex = 2;
            this.lbl_assessorid.Text = "Assessor ID";
            // 
            // lbl_tradetestid
            // 
            this.lbl_tradetestid.AutoSize = true;
            this.lbl_tradetestid.Location = new System.Drawing.Point(88, 145);
            this.lbl_tradetestid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tradetestid.Name = "lbl_tradetestid";
            this.lbl_tradetestid.Size = new System.Drawing.Size(73, 13);
            this.lbl_tradetestid.TabIndex = 3;
            this.lbl_tradetestid.Text = "Trade Test ID";
            // 
            // lbl_evaludate
            // 
            this.lbl_evaludate.AutoSize = true;
            this.lbl_evaludate.Location = new System.Drawing.Point(88, 176);
            this.lbl_evaludate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_evaludate.Name = "lbl_evaludate";
            this.lbl_evaludate.Size = new System.Drawing.Size(83, 13);
            this.lbl_evaludate.TabIndex = 4;
            this.lbl_evaludate.Text = "Evaluation Date";
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(300, 226);
            this.btn_sav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(88, 28);
            this.btn_sav.TabIndex = 5;
            this.btn_sav.Text = "Save";
            this.btn_sav.UseVisualStyleBackColor = true;
            this.btn_sav.Click += new System.EventHandler(this.btn_sav_Click);
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(410, 226);
            this.btn_cancl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(79, 28);
            this.btn_cancl.TabIndex = 6;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // txt_assessorid
            // 
            this.txt_assessorid.Location = new System.Drawing.Point(211, 110);
            this.txt_assessorid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_assessorid.Name = "txt_assessorid";
            this.txt_assessorid.Size = new System.Drawing.Size(224, 20);
            this.txt_assessorid.TabIndex = 7;
            // 
            // txt_tradetestid
            // 
            this.txt_tradetestid.Location = new System.Drawing.Point(211, 145);
            this.txt_tradetestid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tradetestid.Name = "txt_tradetestid";
            this.txt_tradetestid.Size = new System.Drawing.Size(224, 20);
            this.txt_tradetestid.TabIndex = 8;
            // 
            // txt_evaludate
            // 
            this.txt_evaludate.Location = new System.Drawing.Point(211, 176);
            this.txt_evaludate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_evaludate.Name = "txt_evaludate";
            this.txt_evaludate.Size = new System.Drawing.Size(224, 20);
            this.txt_evaludate.TabIndex = 9;
            // 
            // AssAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 264);
            this.Controls.Add(this.txt_evaludate);
            this.Controls.Add(this.txt_tradetestid);
            this.Controls.Add(this.txt_assessorid);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.lbl_evaludate);
            this.Controls.Add(this.lbl_tradetestid);
            this.Controls.Add(this.lbl_assessorid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssAtt";
            this.Text = "Assessor Attendance Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_assessorid;
        private System.Windows.Forms.Label lbl_tradetestid;
        private System.Windows.Forms.Label lbl_evaludate;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.TextBox txt_assessorid;
        private System.Windows.Forms.TextBox txt_tradetestid;
        private System.Windows.Forms.TextBox txt_evaludate;
    }
}