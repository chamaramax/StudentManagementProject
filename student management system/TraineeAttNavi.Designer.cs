namespace student_management_system
{
    partial class TraineeAttNavi
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
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_updt = new System.Windows.Forms.Button();
            this.cbox_attendstatus = new System.Windows.Forms.ComboBox();
            this.dtp_attenddate = new System.Windows.Forms.DateTimePicker();
            this.txt_coursecode = new System.Windows.Forms.TextBox();
            this.txt_traineeid = new System.Windows.Forms.TextBox();
            this.lbl_attendstatus = new System.Windows.Forms.Label();
            this.lbl_attenddate = new System.Windows.Forms.Label();
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.lbl_traineeid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(563, 368);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 30);
            this.btn_del.TabIndex = 23;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(433, 368);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(109, 30);
            this.btn_updt.TabIndex = 22;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_attendstatus
            // 
            this.cbox_attendstatus.FormattingEnabled = true;
            this.cbox_attendstatus.Location = new System.Drawing.Point(304, 299);
            this.cbox_attendstatus.Name = "cbox_attendstatus";
            this.cbox_attendstatus.Size = new System.Drawing.Size(225, 24);
            this.cbox_attendstatus.TabIndex = 21;
            this.cbox_attendstatus.SelectedIndexChanged += new System.EventHandler(this.cbox_attendstatus_SelectedIndexChanged);
            // 
            // dtp_attenddate
            // 
            this.dtp_attenddate.Location = new System.Drawing.Point(304, 257);
            this.dtp_attenddate.Name = "dtp_attenddate";
            this.dtp_attenddate.Size = new System.Drawing.Size(225, 22);
            this.dtp_attenddate.TabIndex = 20;
            // 
            // txt_coursecode
            // 
            this.txt_coursecode.Location = new System.Drawing.Point(304, 214);
            this.txt_coursecode.Name = "txt_coursecode";
            this.txt_coursecode.Size = new System.Drawing.Size(225, 22);
            this.txt_coursecode.TabIndex = 19;
            // 
            // txt_traineeid
            // 
            this.txt_traineeid.Location = new System.Drawing.Point(304, 173);
            this.txt_traineeid.Name = "txt_traineeid";
            this.txt_traineeid.Size = new System.Drawing.Size(225, 22);
            this.txt_traineeid.TabIndex = 18;
            // 
            // lbl_attendstatus
            // 
            this.lbl_attendstatus.AutoSize = true;
            this.lbl_attendstatus.Location = new System.Drawing.Point(184, 299);
            this.lbl_attendstatus.Name = "lbl_attendstatus";
            this.lbl_attendstatus.Size = new System.Drawing.Size(93, 17);
            this.lbl_attendstatus.TabIndex = 17;
            this.lbl_attendstatus.Text = "Attend Status";
            this.lbl_attendstatus.Click += new System.EventHandler(this.lbl_attendstatus_Click);
            // 
            // lbl_attenddate
            // 
            this.lbl_attenddate.AutoSize = true;
            this.lbl_attenddate.Location = new System.Drawing.Point(184, 257);
            this.lbl_attenddate.Name = "lbl_attenddate";
            this.lbl_attenddate.Size = new System.Drawing.Size(83, 17);
            this.lbl_attenddate.TabIndex = 16;
            this.lbl_attenddate.Text = "Attend Date";
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Location = new System.Drawing.Point(184, 214);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(90, 17);
            this.lbl_coursecode.TabIndex = 15;
            this.lbl_coursecode.Text = "Course Code";
            // 
            // lbl_traineeid
            // 
            this.lbl_traineeid.AutoSize = true;
            this.lbl_traineeid.Location = new System.Drawing.Point(181, 173);
            this.lbl_traineeid.Name = "lbl_traineeid";
            this.lbl_traineeid.Size = new System.Drawing.Size(74, 17);
            this.lbl_traineeid.TabIndex = 14;
            this.lbl_traineeid.Text = "Trainee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trainee Attendance Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trainee Attendance";
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(686, 368);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(92, 30);
            this.btn_cancl.TabIndex = 24;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // TraineeAttNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 448);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.cbox_attendstatus);
            this.Controls.Add(this.dtp_attenddate);
            this.Controls.Add(this.txt_coursecode);
            this.Controls.Add(this.txt_traineeid);
            this.Controls.Add(this.lbl_attendstatus);
            this.Controls.Add(this.lbl_attenddate);
            this.Controls.Add(this.lbl_coursecode);
            this.Controls.Add(this.lbl_traineeid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TraineeAttNavi";
            this.Text = "Trainee Attendance ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.ComboBox cbox_attendstatus;
        private System.Windows.Forms.DateTimePicker dtp_attenddate;
        private System.Windows.Forms.TextBox txt_coursecode;
        private System.Windows.Forms.TextBox txt_traineeid;
        private System.Windows.Forms.Label lbl_attendstatus;
        private System.Windows.Forms.Label lbl_attenddate;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label lbl_traineeid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancl;
    }
}