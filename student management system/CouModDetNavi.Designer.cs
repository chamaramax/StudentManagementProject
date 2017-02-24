namespace student_management_system
{
    partial class CouModDetNavi
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
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_modno = new System.Windows.Forms.TextBox();
            this.txt_coursecode = new System.Windows.Forms.TextBox();
            this.lbl_modno = new System.Windows.Forms.Label();
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(491, 245);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(102, 33);
            this.btn_cancl.TabIndex = 15;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(373, 245);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(93, 33);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // txt_modno
            // 
            this.txt_modno.Location = new System.Drawing.Point(235, 185);
            this.txt_modno.Name = "txt_modno";
            this.txt_modno.Size = new System.Drawing.Size(214, 22);
            this.txt_modno.TabIndex = 13;
            this.txt_modno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_coursecode
            // 
            this.txt_coursecode.Location = new System.Drawing.Point(235, 137);
            this.txt_coursecode.Name = "txt_coursecode";
            this.txt_coursecode.Size = new System.Drawing.Size(214, 22);
            this.txt_coursecode.TabIndex = 12;
            this.txt_coursecode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_modno
            // 
            this.lbl_modno.AutoSize = true;
            this.lbl_modno.Location = new System.Drawing.Point(106, 185);
            this.lbl_modno.Name = "lbl_modno";
            this.lbl_modno.Size = new System.Drawing.Size(76, 17);
            this.lbl_modno.TabIndex = 11;
            this.lbl_modno.Text = "Module No";
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Location = new System.Drawing.Point(106, 137);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(90, 17);
            this.lbl_coursecode.TabIndex = 10;
            this.lbl_coursecode.Text = "Course Code";
            this.lbl_coursecode.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Course Module Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course Module Details";
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(260, 245);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(93, 33);
            this.btn_updt.TabIndex = 16;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.button3_Click);
            // 
            // CouModDetNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 311);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.txt_modno);
            this.Controls.Add(this.txt_coursecode);
            this.Controls.Add(this.lbl_modno);
            this.Controls.Add(this.lbl_coursecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CouModDetNavi";
            this.Text = "Course Module Details Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_modno;
        private System.Windows.Forms.TextBox txt_coursecode;
        private System.Windows.Forms.Label lbl_modno;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updt;
    }
}