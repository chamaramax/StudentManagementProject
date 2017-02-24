namespace student_management_system
{
    partial class PanelMemDet
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
            this.lbl_panelno = new System.Windows.Forms.Label();
            this.lbl_membname = new System.Windows.Forms.Label();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.txt_panelno = new System.Windows.Forms.TextBox();
            this.txt_membname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel Member Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Panel Member Information";
            // 
            // lbl_panelno
            // 
            this.lbl_panelno.AutoSize = true;
            this.lbl_panelno.Location = new System.Drawing.Point(108, 134);
            this.lbl_panelno.Name = "lbl_panelno";
            this.lbl_panelno.Size = new System.Drawing.Size(66, 17);
            this.lbl_panelno.TabIndex = 2;
            this.lbl_panelno.Text = "Panel No";
            this.lbl_panelno.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_membname
            // 
            this.lbl_membname.AutoSize = true;
            this.lbl_membname.Location = new System.Drawing.Point(108, 176);
            this.lbl_membname.Name = "lbl_membname";
            this.lbl_membname.Size = new System.Drawing.Size(100, 17);
            this.lbl_membname.TabIndex = 3;
            this.lbl_membname.Text = "Member Name";
            // 
            // btn_sav
            // 
            this.btn_sav.Location = new System.Drawing.Point(285, 252);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(112, 35);
            this.btn_sav.TabIndex = 4;
            this.btn_sav.Text = "Save";
            this.btn_sav.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Location = new System.Drawing.Point(403, 252);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(103, 35);
            this.btn_cancl.TabIndex = 5;
            this.btn_cancl.Text = "Cancel";
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // txt_panelno
            // 
            this.txt_panelno.Location = new System.Drawing.Point(227, 134);
            this.txt_panelno.Name = "txt_panelno";
            this.txt_panelno.Size = new System.Drawing.Size(170, 22);
            this.txt_panelno.TabIndex = 6;
            // 
            // txt_membname
            // 
            this.txt_membname.Location = new System.Drawing.Point(227, 176);
            this.txt_membname.Name = "txt_membname";
            this.txt_membname.Size = new System.Drawing.Size(263, 22);
            this.txt_membname.TabIndex = 7;
            // 
            // PanelMemDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 317);
            this.Controls.Add(this.txt_membname);
            this.Controls.Add(this.txt_panelno);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.lbl_membname);
            this.Controls.Add(this.lbl_panelno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelMemDet";
            this.Text = "Panel Member Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_panelno;
        private System.Windows.Forms.Label lbl_membname;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.TextBox txt_panelno;
        private System.Windows.Forms.TextBox txt_membname;
    }
}