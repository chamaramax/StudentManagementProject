namespace student_management_system
{
    partial class CertiDet
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
            this.lbl_certino = new System.Windows.Forms.Label();
            this.lbl_traineeid = new System.Windows.Forms.Label();
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.lbl_batchid = new System.Windows.Forms.Label();
            this.txt_certino = new System.Windows.Forms.TextBox();
            this.txt_traineeid = new System.Windows.Forms.TextBox();
            this.txt_coursecode = new System.Windows.Forms.TextBox();
            this.txt_batchid = new System.Windows.Forms.TextBox();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificate Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Certificate Information";
            // 
            // lbl_certino
            // 
            this.lbl_certino.AutoSize = true;
            this.lbl_certino.Location = new System.Drawing.Point(137, 173);
            this.lbl_certino.Name = "lbl_certino";
            this.lbl_certino.Size = new System.Drawing.Size(93, 17);
            this.lbl_certino.TabIndex = 2;
            this.lbl_certino.Text = "Certificate No";
            this.lbl_certino.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_traineeid
            // 
            this.lbl_traineeid.AutoSize = true;
            this.lbl_traineeid.Location = new System.Drawing.Point(137, 209);
            this.lbl_traineeid.Name = "lbl_traineeid";
            this.lbl_traineeid.Size = new System.Drawing.Size(74, 17);
            this.lbl_traineeid.TabIndex = 3;
            this.lbl_traineeid.Text = "Trainee ID";
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Location = new System.Drawing.Point(140, 240);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(90, 17);
            this.lbl_coursecode.TabIndex = 4;
            this.lbl_coursecode.Text = "Course Code";
            // 
            // lbl_batchid
            // 
            this.lbl_batchid.AutoSize = true;
            this.lbl_batchid.Location = new System.Drawing.Point(140, 277);
            this.lbl_batchid.Name = "lbl_batchid";
            this.lbl_batchid.Size = new System.Drawing.Size(61, 17);
            this.lbl_batchid.TabIndex = 5;
            this.lbl_batchid.Text = "Batch ID";
            // 
            // txt_certino
            // 
            this.txt_certino.Location = new System.Drawing.Point(287, 173);
            this.txt_certino.Name = "txt_certino";
            this.txt_certino.Size = new System.Drawing.Size(252, 22);
            this.txt_certino.TabIndex = 6;
            // 
            // txt_traineeid
            // 
            this.txt_traineeid.Location = new System.Drawing.Point(287, 209);
            this.txt_traineeid.Name = "txt_traineeid";
            this.txt_traineeid.Size = new System.Drawing.Size(252, 22);
            this.txt_traineeid.TabIndex = 7;
            // 
            // txt_coursecode
            // 
            this.txt_coursecode.Location = new System.Drawing.Point(287, 240);
            this.txt_coursecode.Name = "txt_coursecode";
            this.txt_coursecode.Size = new System.Drawing.Size(252, 22);
            this.txt_coursecode.TabIndex = 8;
            // 
            // txt_batchid
            // 
            this.txt_batchid.Location = new System.Drawing.Point(287, 277);
            this.txt_batchid.Name = "txt_batchid";
            this.txt_batchid.Size = new System.Drawing.Size(252, 22);
            this.txt_batchid.TabIndex = 9;
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(487, 354);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(112, 33);
            this.btn_sav.TabIndex = 10;
            this.btn_sav.Text = "Save ";
            this.btn_sav.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(625, 354);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(110, 33);
            this.btn_cancl.TabIndex = 11;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // CertiDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 445);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.txt_batchid);
            this.Controls.Add(this.txt_coursecode);
            this.Controls.Add(this.txt_traineeid);
            this.Controls.Add(this.txt_certino);
            this.Controls.Add(this.lbl_batchid);
            this.Controls.Add(this.lbl_coursecode);
            this.Controls.Add(this.lbl_traineeid);
            this.Controls.Add(this.lbl_certino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CertiDet";
            this.Text = "Certificate Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_certino;
        private System.Windows.Forms.Label lbl_traineeid;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label lbl_batchid;
        private System.Windows.Forms.TextBox txt_certino;
        private System.Windows.Forms.TextBox txt_traineeid;
        private System.Windows.Forms.TextBox txt_coursecode;
        private System.Windows.Forms.TextBox txt_batchid;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_cancl;
    }
}