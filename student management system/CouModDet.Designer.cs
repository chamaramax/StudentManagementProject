namespace student_management_system
{
    partial class CouModDet
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
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.lbl_moduleno = new System.Windows.Forms.Label();
            this.txt_coursecode = new System.Windows.Forms.TextBox();
            this.txt_moduleno = new System.Windows.Forms.TextBox();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Module Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Module Information";
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Location = new System.Drawing.Point(143, 146);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(90, 17);
            this.lbl_coursecode.TabIndex = 2;
            this.lbl_coursecode.Text = "Course Code";
            // 
            // lbl_moduleno
            // 
            this.lbl_moduleno.AutoSize = true;
            this.lbl_moduleno.Location = new System.Drawing.Point(143, 194);
            this.lbl_moduleno.Name = "lbl_moduleno";
            this.lbl_moduleno.Size = new System.Drawing.Size(76, 17);
            this.lbl_moduleno.TabIndex = 3;
            this.lbl_moduleno.Text = "Module No";
            // 
            // txt_coursecode
            // 
            this.txt_coursecode.Location = new System.Drawing.Point(272, 146);
            this.txt_coursecode.Name = "txt_coursecode";
            this.txt_coursecode.Size = new System.Drawing.Size(214, 22);
            this.txt_coursecode.TabIndex = 4;
            // 
            // txt_moduleno
            // 
            this.txt_moduleno.Location = new System.Drawing.Point(272, 194);
            this.txt_moduleno.Name = "txt_moduleno";
            this.txt_moduleno.Size = new System.Drawing.Size(214, 22);
            this.txt_moduleno.TabIndex = 5;
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(410, 254);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(93, 33);
            this.btn_sav.TabIndex = 6;
            this.btn_sav.Text = "Save";
            this.btn_sav.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(528, 254);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(102, 33);
            this.btn_cancl.TabIndex = 7;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // CouModDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 310);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.txt_moduleno);
            this.Controls.Add(this.txt_coursecode);
            this.Controls.Add(this.lbl_moduleno);
            this.Controls.Add(this.lbl_coursecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CouModDet";
            this.Text = "Course Module Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label lbl_moduleno;
        private System.Windows.Forms.TextBox txt_coursecode;
        private System.Windows.Forms.TextBox txt_moduleno;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_cancl;
    }
}