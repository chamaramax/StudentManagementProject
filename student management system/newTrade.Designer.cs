namespace student_management_system
{
    partial class newTrade
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
            this.txt_ttn = new System.Windows.Forms.TextBox();
            this.txt_ttf = new System.Windows.Forms.TextBox();
            this.txt_ttid = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Trade Test Development Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trade Test Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trade Test Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trade Test ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Test Fee(LKR)";
            // 
            // txt_ttn
            // 
            this.txt_ttn.Location = new System.Drawing.Point(256, 170);
            this.txt_ttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ttn.Name = "txt_ttn";
            this.txt_ttn.Size = new System.Drawing.Size(387, 20);
            this.txt_ttn.TabIndex = 6;
            // 
            // txt_ttf
            // 
            this.txt_ttf.Location = new System.Drawing.Point(256, 211);
            this.txt_ttf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ttf.Name = "txt_ttf";
            this.txt_ttf.Size = new System.Drawing.Size(209, 20);
            this.txt_ttf.TabIndex = 7;
            // 
            // txt_ttid
            // 
            this.txt_ttid.Location = new System.Drawing.Point(256, 129);
            this.txt_ttid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ttid.Name = "txt_ttid";
            this.txt_ttid.Size = new System.Drawing.Size(209, 20);
            this.txt_ttid.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(426, 257);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 28);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(532, 257);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 28);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // newTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 306);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_ttid);
            this.Controls.Add(this.txt_ttf);
            this.Controls.Add(this.txt_ttn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "newTrade";
            this.Text = "New Trade Test Design";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ttn;
        private System.Windows.Forms.TextBox txt_ttf;
        private System.Windows.Forms.TextBox txt_ttid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}