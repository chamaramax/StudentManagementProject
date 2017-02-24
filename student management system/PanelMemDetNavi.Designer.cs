namespace student_management_system
{
    partial class PanelMemDetNavi
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
            this.txt_membname = new System.Windows.Forms.TextBox();
            this.txt_panelno = new System.Windows.Forms.TextBox();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.lbl_membename = new System.Windows.Forms.Label();
            this.lbl_panelno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_membname
            // 
            this.txt_membname.Location = new System.Drawing.Point(210, 180);
            this.txt_membname.Name = "txt_membname";
            this.txt_membname.Size = new System.Drawing.Size(263, 22);
            this.txt_membname.TabIndex = 15;
            // 
            // txt_panelno
            // 
            this.txt_panelno.Location = new System.Drawing.Point(210, 138);
            this.txt_panelno.Name = "txt_panelno";
            this.txt_panelno.Size = new System.Drawing.Size(170, 22);
            this.txt_panelno.TabIndex = 14;
            this.txt_panelno.TextChanged += new System.EventHandler(this.txt_panelno_TextChanged);
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(443, 256);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(103, 35);
            this.btn_cancl.TabIndex = 13;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(191, 256);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(112, 35);
            this.btn_upd.TabIndex = 12;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            // 
            // lbl_membename
            // 
            this.lbl_membename.AutoSize = true;
            this.lbl_membename.Location = new System.Drawing.Point(91, 180);
            this.lbl_membename.Name = "lbl_membename";
            this.lbl_membename.Size = new System.Drawing.Size(100, 17);
            this.lbl_membename.TabIndex = 11;
            this.lbl_membename.Text = "Member Name";
            // 
            // lbl_panelno
            // 
            this.lbl_panelno.AutoSize = true;
            this.lbl_panelno.Location = new System.Drawing.Point(91, 138);
            this.lbl_panelno.Name = "lbl_panelno";
            this.lbl_panelno.Size = new System.Drawing.Size(66, 17);
            this.lbl_panelno.TabIndex = 10;
            this.lbl_panelno.Text = "Panel No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Panel Member Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Panel Member Details";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(322, 255);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(106, 36);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // PanelMemDetNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 332);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.txt_membname);
            this.Controls.Add(this.txt_panelno);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.lbl_membename);
            this.Controls.Add(this.lbl_panelno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelMemDetNavi";
            this.Text = "Panel Member Details Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_membname;
        private System.Windows.Forms.TextBox txt_panelno;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Label lbl_membename;
        private System.Windows.Forms.Label lbl_panelno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
    }
}