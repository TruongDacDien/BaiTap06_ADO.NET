namespace GUI
{
    partial class Frm_Main
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
            this.label_FarmName = new System.Windows.Forms.Label();
            this.dataGridView_GiaSuc = new System.Windows.Forms.DataGridView();
            this.groupBox_GiaoDien = new System.Windows.Forms.GroupBox();
            this.groupBox_ChucNang = new System.Windows.Forms.GroupBox();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.button_Doi = new System.Windows.Forms.Button();
            this.groupBox_SoGSBD = new System.Windows.Forms.GroupBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBox_De = new System.Windows.Forms.TextBox();
            this.textBox_Cuu = new System.Windows.Forms.TextBox();
            this.textBox_Bo = new System.Windows.Forms.TextBox();
            this.labelCuu = new System.Windows.Forms.Label();
            this.labelDe = new System.Windows.Forms.Label();
            this.labelBo = new System.Windows.Forms.Label();
            this.groupBox_DuLieu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaSuc)).BeginInit();
            this.groupBox_GiaoDien.SuspendLayout();
            this.groupBox_ChucNang.SuspendLayout();
            this.groupBox_SoGSBD.SuspendLayout();
            this.groupBox_DuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_FarmName
            // 
            this.label_FarmName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FarmName.AutoSize = true;
            this.label_FarmName.BackColor = System.Drawing.Color.Yellow;
            this.label_FarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FarmName.Location = new System.Drawing.Point(384, 22);
            this.label_FarmName.Name = "label_FarmName";
            this.label_FarmName.Size = new System.Drawing.Size(420, 59);
            this.label_FarmName.TabIndex = 0;
            this.label_FarmName.Text = "Nông Trại Vui Vẻ";
            // 
            // dataGridView_GiaSuc
            // 
            this.dataGridView_GiaSuc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_GiaSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GiaSuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_GiaSuc.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_GiaSuc.Name = "dataGridView_GiaSuc";
            this.dataGridView_GiaSuc.RowHeadersWidth = 62;
            this.dataGridView_GiaSuc.RowTemplate.Height = 28;
            this.dataGridView_GiaSuc.Size = new System.Drawing.Size(1172, 313);
            this.dataGridView_GiaSuc.TabIndex = 1;
            // 
            // groupBox_GiaoDien
            // 
            this.groupBox_GiaoDien.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox_GiaoDien.Controls.Add(this.groupBox_ChucNang);
            this.groupBox_GiaoDien.Controls.Add(this.groupBox_SoGSBD);
            this.groupBox_GiaoDien.Controls.Add(this.label_FarmName);
            this.groupBox_GiaoDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_GiaoDien.Location = new System.Drawing.Point(0, 0);
            this.groupBox_GiaoDien.Name = "groupBox_GiaoDien";
            this.groupBox_GiaoDien.Size = new System.Drawing.Size(1178, 406);
            this.groupBox_GiaoDien.TabIndex = 2;
            this.groupBox_GiaoDien.TabStop = false;
            // 
            // groupBox_ChucNang
            // 
            this.groupBox_ChucNang.Controls.Add(this.button_Xoa);
            this.groupBox_ChucNang.Controls.Add(this.button_ThongKe);
            this.groupBox_ChucNang.Controls.Add(this.button_Doi);
            this.groupBox_ChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ChucNang.Location = new System.Drawing.Point(589, 84);
            this.groupBox_ChucNang.Name = "groupBox_ChucNang";
            this.groupBox_ChucNang.Size = new System.Drawing.Size(583, 316);
            this.groupBox_ChucNang.TabIndex = 5;
            this.groupBox_ChucNang.TabStop = false;
            this.groupBox_ChucNang.Text = "Chức Năng";
            // 
            // button_Xoa
            // 
            this.button_Xoa.AutoSize = true;
            this.button_Xoa.BackColor = System.Drawing.SystemColors.Control;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(139, 204);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(344, 47);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "Xóa dữ liệu";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.AutoSize = true;
            this.button_ThongKe.BackColor = System.Drawing.SystemColors.Control;
            this.button_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongKe.Location = new System.Drawing.Point(139, 127);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(344, 47);
            this.button_ThongKe.TabIndex = 1;
            this.button_ThongKe.Text = "Thống Kê Sau Sinh";
            this.button_ThongKe.UseVisualStyleBackColor = false;
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // button_Doi
            // 
            this.button_Doi.AutoSize = true;
            this.button_Doi.BackColor = System.Drawing.SystemColors.Control;
            this.button_Doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Doi.Location = new System.Drawing.Point(139, 50);
            this.button_Doi.Name = "button_Doi";
            this.button_Doi.Size = new System.Drawing.Size(344, 47);
            this.button_Doi.TabIndex = 0;
            this.button_Doi.Text = "Tất cả gia súc đều đói";
            this.button_Doi.UseVisualStyleBackColor = false;
            this.button_Doi.Click += new System.EventHandler(this.button_Doi_Click);
            // 
            // groupBox_SoGSBD
            // 
            this.groupBox_SoGSBD.Controls.Add(this.buttonLuu);
            this.groupBox_SoGSBD.Controls.Add(this.textBox_De);
            this.groupBox_SoGSBD.Controls.Add(this.textBox_Cuu);
            this.groupBox_SoGSBD.Controls.Add(this.textBox_Bo);
            this.groupBox_SoGSBD.Controls.Add(this.labelCuu);
            this.groupBox_SoGSBD.Controls.Add(this.labelDe);
            this.groupBox_SoGSBD.Controls.Add(this.labelBo);
            this.groupBox_SoGSBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SoGSBD.Location = new System.Drawing.Point(12, 84);
            this.groupBox_SoGSBD.Name = "groupBox_SoGSBD";
            this.groupBox_SoGSBD.Size = new System.Drawing.Size(561, 316);
            this.groupBox_SoGSBD.TabIndex = 4;
            this.groupBox_SoGSBD.TabStop = false;
            this.groupBox_SoGSBD.Text = "Số lượng gia súc ban đầu";
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(151, 252);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(222, 47);
            this.buttonLuu.TabIndex = 3;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBox_De
            // 
            this.textBox_De.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_De.Location = new System.Drawing.Point(218, 195);
            this.textBox_De.Name = "textBox_De";
            this.textBox_De.Size = new System.Drawing.Size(337, 39);
            this.textBox_De.TabIndex = 6;
            // 
            // textBox_Cuu
            // 
            this.textBox_Cuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cuu.Location = new System.Drawing.Point(232, 118);
            this.textBox_Cuu.Name = "textBox_Cuu";
            this.textBox_Cuu.Size = new System.Drawing.Size(323, 39);
            this.textBox_Cuu.TabIndex = 5;
            // 
            // textBox_Bo
            // 
            this.textBox_Bo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Bo.Location = new System.Drawing.Point(218, 41);
            this.textBox_Bo.Name = "textBox_Bo";
            this.textBox_Bo.Size = new System.Drawing.Size(337, 39);
            this.textBox_Bo.TabIndex = 4;
            // 
            // labelCuu
            // 
            this.labelCuu.AutoSize = true;
            this.labelCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuu.Location = new System.Drawing.Point(6, 121);
            this.labelCuu.Name = "labelCuu";
            this.labelCuu.Size = new System.Drawing.Size(220, 32);
            this.labelCuu.TabIndex = 2;
            this.labelCuu.Text = "Số cừu ban đầu:";
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDe.Location = new System.Drawing.Point(6, 198);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(206, 32);
            this.labelDe.TabIndex = 3;
            this.labelDe.Text = "Số dê ban đầu:";
            // 
            // labelBo
            // 
            this.labelBo.AutoSize = true;
            this.labelBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBo.Location = new System.Drawing.Point(6, 44);
            this.labelBo.Name = "labelBo";
            this.labelBo.Size = new System.Drawing.Size(206, 32);
            this.labelBo.TabIndex = 1;
            this.labelBo.Text = "Số bò ban đầu:";
            // 
            // groupBox_DuLieu
            // 
            this.groupBox_DuLieu.Controls.Add(this.dataGridView_GiaSuc);
            this.groupBox_DuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_DuLieu.Location = new System.Drawing.Point(0, 406);
            this.groupBox_DuLieu.Name = "groupBox_DuLieu";
            this.groupBox_DuLieu.Size = new System.Drawing.Size(1178, 338);
            this.groupBox_DuLieu.TabIndex = 3;
            this.groupBox_DuLieu.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.groupBox_DuLieu);
            this.Controls.Add(this.groupBox_GiaoDien);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaSuc)).EndInit();
            this.groupBox_GiaoDien.ResumeLayout(false);
            this.groupBox_GiaoDien.PerformLayout();
            this.groupBox_ChucNang.ResumeLayout(false);
            this.groupBox_ChucNang.PerformLayout();
            this.groupBox_SoGSBD.ResumeLayout(false);
            this.groupBox_SoGSBD.PerformLayout();
            this.groupBox_DuLieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_FarmName;
        private System.Windows.Forms.DataGridView dataGridView_GiaSuc;
        private System.Windows.Forms.GroupBox groupBox_GiaoDien;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.Label labelCuu;
        private System.Windows.Forms.Label labelBo;
        private System.Windows.Forms.GroupBox groupBox_SoGSBD;
        private System.Windows.Forms.TextBox textBox_De;
        private System.Windows.Forms.TextBox textBox_Cuu;
        private System.Windows.Forms.TextBox textBox_Bo;
        private System.Windows.Forms.GroupBox groupBox_ChucNang;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.Button button_Doi;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.GroupBox groupBox_DuLieu;
    }
}