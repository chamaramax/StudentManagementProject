namespace student_management_system
{
    partial class TraineeAtt
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
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.lbl_attenddate = new System.Windows.Forms.Label();
            this.lbl_attendstatus = new System.Windows.Forms.Label();
            this.txt_traineeid = new System.Windows.Forms.TextBox();
            this.txt_coursecode = new System.Windows.Forms.TextBox();
            this.dtp_attenddate = new System.Windows.Forms.DateTimePicker();
            this.cbox_attendstatus = new System.Windows.Forms.ComboBox();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainee Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trainee Attendance Information";
            // 
            // lbl_traineeid
            // 
            this.lbl_traineeid.AutoSize = true;
            this.lbl_traineeid.Location = new System.Drawing.Point(211, 178);
            this.lbl_traineeid.Name = "lbl_traineeid";
            this.lbl_traineeid.Size = new System.Drawing.Size(74, 17);
            this.lbl_traineeid.TabIndex = 2;
            this.lbl_traineeid.Text = "Trainee ID";
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Location = new System.Drawing.Point(214, 219);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(90, 17);
            this.lbl_coursecode.TabIndex = 3;
            this.lbl_coursecode.Text = "Course Code";
            // 
            // lbl_attenddate
            // 
            this.lbl_attenddate.AutoSize = true;
            this.lbl_attenddate.Location = new System.Drawing.Point(214, 262);
            this.lbl_attenddate.Name = "lbl_attenddate";
            this.lbl_attenddate.Size = new System.Drawing.Size(83, 17);
            this.lbl_attenddate.TabIndex = 4;
            this.lbl_attenddate.Text = "Attend Date";
            // 
            // lbl_attendstatus
            // 
            this.lbl_attendstatus.AutoSize = true;
            this.lbl_attendstatus.Location = new System.Drawing.Point(214, 304);
            this.lbl_attendstatus.Name = "lbl_attendstatus";
            this.lbl_attendstatus.Size = new System.Drawing.Size(93, 17);
            this.lbl_attendstatus.TabIndex = 5;
            this.lbl_attendstatus.Text = "Attend Status";
            // 
            // txt_traineeid
            // 
            this.txt_traineeid.Location = new System.Drawing.Point(334, 178);
            this.txt_traineeid.Name = "txt_traineeid";
            this.txt_traineeid.Size = new System.Drawing.Size(225, 22);
            this.txt_traineeid.TabIndex = 6;
            // 
            // txt_coursecode
            // 
            this.txt_coursecode.Location = new System.Drawing.Point(334, 219);
            this.txt_coursecode.Name = "txt_coursecode";
            this.txt_coursecode.Size = new System.Drawing.Size(225, 22);
            this.txt_coursecode.TabIndex = 7;
            // 
            // dtp_attenddate
            // 
            this.dtp_attenddate.Location = new System.Drawing.Point(334, 262);
            this.dtp_attenddate.Name = "dtp_attenddate";
            this.dtp_attenddate.Size = new System.Drawing.Size(225, 22);
            this.dtp_attenddate.TabIndex = 8;
            // 
            // cbox_attendstatus
            // 
            this.cbox_attendstatus.FormattingEnabled = true;
            this.cbox_attendstatus.Location = new System.Drawing.Point(334, 304);
            this.cbox_attendstatus.Name = "cbox_attendstatus";
            this.cbox_attendstatus.Size = new System.Drawing.Size(225, 24);
            this.cbox_attendstatus.TabIndex = 9;
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(527, 373);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(109, 30);
            this.btn_sav.TabIndex = 10;
            this.btn_sav.Text = "Save";
            this.btn_sav.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(669, 373);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(96, 30);
            this.btn_cancl.TabIndex = 12;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // TraineeAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 425);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sav);
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
            this.Name = "TraineeAtt";
            this.Text = "Trainee Attendance Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_traineeid;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label lbl_attenddate;
        private System.Windows.Forms.Label lbl_attendstatus;
        private System.Windows.Forms.TextBox txt_traineeid;
        private System.Windows.Forms.TextBox txt_coursecode;
        private System.Windows.Forms.DateTimePicker dtp_attenddate;
        private System.Windows.Forms.ComboBox cbox_attendstatus;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_cancl;
    }
}