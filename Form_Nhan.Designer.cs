namespace BaiTapnhom
{
    partial class Form_Nhan
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_soA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soB = new System.Windows.Forms.TextBox();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.btn_giai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(225, 359);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(84, 29);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_soA
            // 
            this.txt_soA.Location = new System.Drawing.Point(198, 91);
            this.txt_soA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soA.Name = "txt_soA";
            this.txt_soA.Size = new System.Drawing.Size(152, 26);
            this.txt_soA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết Quả";
            // 
            // txt_soB
            // 
            this.txt_soB.Location = new System.Drawing.Point(198, 168);
            this.txt_soB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soB.Name = "txt_soB";
            this.txt_soB.Size = new System.Drawing.Size(152, 26);
            this.txt_soB.TabIndex = 5;
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(198, 259);
            this.txt_ketqua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(152, 26);
            this.txt_ketqua.TabIndex = 6;
            // 
            // btn_giai
            // 
            this.btn_giai.Location = new System.Drawing.Point(75, 359);
            this.btn_giai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_giai.Name = "btn_giai";
            this.btn_giai.Size = new System.Drawing.Size(84, 29);
            this.btn_giai.TabIndex = 7;
            this.btn_giai.Text = "Giải";
            this.btn_giai.UseVisualStyleBackColor = true;
            this.btn_giai.Click += new System.EventHandler(this.btn_giai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(75, 452);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(84, 29);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phép Tính Nhân";
            // 
            // Form_chia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_giai);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.txt_soB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_soA);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_chia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_soA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soB;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Button btn_giai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
    }
}