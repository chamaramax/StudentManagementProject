﻿namespace student_management_system
{
    partial class CouDirAss
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
            this.lbl_courdirid = new System.Windows.Forms.Label();
            this.lbl_courcode = new System.Windows.Forms.Label();
            this.lbl_streamcode = new System.Windows.Forms.Label();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.cbox_courdirid = new System.Windows.Forms.ComboBox();
            this.cbox_courcode = new System.Windows.Forms.ComboBox();
            this.cbox_streamcode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Director Assigning Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Director Appointment";
            // 
            // lbl_courdirid
            // 
            this.lbl_courdirid.AutoSize = true;
            this.lbl_courdirid.Location = new System.Drawing.Point(154, 148);
            this.lbl_courdirid.Name = "lbl_courdirid";
            this.lbl_courdirid.Size = new System.Drawing.Size(124, 17);
            this.lbl_courdirid.TabIndex = 2;
            this.lbl_courdirid.Text = "Course Director ID";
            // 
            // lbl_courcode
            // 
            this.lbl_courcode.AutoSize = true;
            this.lbl_courcode.Location = new System.Drawing.Point(154, 187);
            this.lbl_courcode.Name = "lbl_courcode";
            this.lbl_courcode.Size = new System.Drawing.Size(90, 17);
            this.lbl_courcode.TabIndex = 3;
            this.lbl_courcode.Text = "Course Code";
            // 
            // lbl_streamcode
            // 
            this.lbl_streamcode.AutoSize = true;
            this.lbl_streamcode.Location = new System.Drawing.Point(154, 228);
            this.lbl_streamcode.Name = "lbl_streamcode";
            this.lbl_streamcode.Size = new System.Drawing.Size(90, 17);
            this.lbl_streamcode.TabIndex = 4;
            this.lbl_streamcode.Text = "Stream Code";
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(415, 288);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(102, 33);
            this.btn_sav.TabIndex = 5;
            this.btn_sav.Text = "Save ";
            this.btn_sav.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(533, 288);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(101, 33);
            this.btn_cancl.TabIndex = 6;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // cbox_courdirid
            // 
            this.cbox_courdirid.FormattingEnabled = true;
            this.cbox_courdirid.Location = new System.Drawing.Point(321, 148);
            this.cbox_courdirid.Name = "cbox_courdirid";
            this.cbox_courdirid.Size = new System.Drawing.Size(242, 24);
            this.cbox_courdirid.TabIndex = 7;
            // 
            // cbox_courcode
            // 
            this.cbox_courcode.FormattingEnabled = true;
            this.cbox_courcode.Location = new System.Drawing.Point(321, 187);
            this.cbox_courcode.Name = "cbox_courcode";
            this.cbox_courcode.Size = new System.Drawing.Size(242, 24);
            this.cbox_courcode.TabIndex = 8;
            // 
            // cbox_streamcode
            // 
            this.cbox_streamcode.FormattingEnabled = true;
            this.cbox_streamcode.Location = new System.Drawing.Point(321, 228);
            this.cbox_streamcode.Name = "cbox_streamcode";
            this.cbox_streamcode.Size = new System.Drawing.Size(242, 24);
            this.cbox_streamcode.TabIndex = 9;
            // 
            // CouDirAss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 348);
            this.Controls.Add(this.cbox_streamcode);
            this.Controls.Add(this.cbox_courcode);
            this.Controls.Add(this.cbox_courdirid);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.lbl_streamcode);
            this.Controls.Add(this.lbl_courcode);
            this.Controls.Add(this.lbl_courdirid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CouDirAss";
            this.Text = "Course Director Assigning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_courdirid;
        private System.Windows.Forms.Label lbl_courcode;
        private System.Windows.Forms.Label lbl_streamcode;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ComboBox cbox_courdirid;
        private System.Windows.Forms.ComboBox cbox_courcode;
        private System.Windows.Forms.ComboBox cbox_streamcode;
    }
}