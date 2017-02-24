namespace student_management_system
{
    partial class respersonatten
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_respid = new System.Windows.Forms.TextBox();
            this.txt_cosid = new System.Windows.Forms.TextBox();
            this.txt_sttime = new System.Windows.Forms.TextBox();
            this.txt_etime = new System.Windows.Forms.TextBox();
            this.dtp_lecdate = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Person Attend Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resource Person ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lecture Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resource Person Attend Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "End Time";
            // 
            // txt_respid
            // 
            this.txt_respid.Location = new System.Drawing.Point(347, 175);
            this.txt_respid.Name = "txt_respid";
            this.txt_respid.Size = new System.Drawing.Size(261, 22);
            this.txt_respid.TabIndex = 7;
            // 
            // txt_cosid
            // 
            this.txt_cosid.Location = new System.Drawing.Point(347, 221);
            this.txt_cosid.Name = "txt_cosid";
            this.txt_cosid.Size = new System.Drawing.Size(261, 22);
            this.txt_cosid.TabIndex = 8;
            // 
            // txt_sttime
            // 
            this.txt_sttime.Location = new System.Drawing.Point(347, 297);
            this.txt_sttime.Name = "txt_sttime";
            this.txt_sttime.Size = new System.Drawing.Size(261, 22);
            this.txt_sttime.TabIndex = 10;
            // 
            // txt_etime
            // 
            this.txt_etime.Location = new System.Drawing.Point(347, 336);
            this.txt_etime.Name = "txt_etime";
            this.txt_etime.Size = new System.Drawing.Size(261, 22);
            this.txt_etime.TabIndex = 11;
            // 
            // dtp_lecdate
            // 
            this.dtp_lecdate.Location = new System.Drawing.Point(347, 260);
            this.dtp_lecdate.Name = "dtp_lecdate";
            this.dtp_lecdate.Size = new System.Drawing.Size(261, 22);
            this.dtp_lecdate.TabIndex = 12;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(533, 392);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 37);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(674, 392);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 37);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // respersonatten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 456);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_lecdate);
            this.Controls.Add(this.txt_etime);
            this.Controls.Add(this.txt_sttime);
            this.Controls.Add(this.txt_cosid);
            this.Controls.Add(this.txt_respid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "respersonatten";
            this.Text = "Resource Person Attendence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_respid;
        private System.Windows.Forms.TextBox txt_cosid;
        private System.Windows.Forms.TextBox txt_sttime;
        private System.Windows.Forms.TextBox txt_etime;
        private System.Windows.Forms.DateTimePicker dtp_lecdate;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_cancel;
    }
}