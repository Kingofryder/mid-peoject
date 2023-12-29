namespace WindowsFormsApp1
{
    partial class FormDetails
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
            this.groupBox商品修改 = new System.Windows.Forms.GroupBox();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn選取商品照片 = new System.Windows.Forms.Button();
            this.groupBox商品新增 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn儲存修改2 = new System.Windows.Forms.Button();
            this.btn選取照片2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.groupBox商品修改.SuspendLayout();
            this.groupBox商品新增.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品資訊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品價格";
            // 
            // groupBox商品修改
            // 
            this.groupBox商品修改.Controls.Add(this.btn儲存修改);
            this.groupBox商品修改.Controls.Add(this.btn選取商品照片);
            this.groupBox商品修改.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox商品修改.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox商品修改.Location = new System.Drawing.Point(15, 444);
            this.groupBox商品修改.Name = "groupBox商品修改";
            this.groupBox商品修改.Size = new System.Drawing.Size(338, 100);
            this.groupBox商品修改.TabIndex = 6;
            this.groupBox商品修改.TabStop = false;
            this.groupBox商品修改.Text = "商品修改";
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.Location = new System.Drawing.Point(180, 37);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(142, 43);
            this.btn儲存修改.TabIndex = 1;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = false;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取商品照片
            // 
            this.btn選取商品照片.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn選取商品照片.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn選取商品照片.Location = new System.Drawing.Point(6, 37);
            this.btn選取商品照片.Name = "btn選取商品照片";
            this.btn選取商品照片.Size = new System.Drawing.Size(168, 43);
            this.btn選取商品照片.TabIndex = 0;
            this.btn選取商品照片.Text = "選取商品照片";
            this.btn選取商品照片.UseVisualStyleBackColor = false;
            this.btn選取商品照片.Click += new System.EventHandler(this.btn選取商品照片_Click);
            // 
            // groupBox商品新增
            // 
            this.groupBox商品新增.Controls.Add(this.btn清空欄位);
            this.groupBox商品新增.Controls.Add(this.btn儲存修改2);
            this.groupBox商品新增.Controls.Add(this.btn選取照片2);
            this.groupBox商品新增.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox商品新增.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox商品新增.Location = new System.Drawing.Point(362, 444);
            this.groupBox商品新增.Name = "groupBox商品新增";
            this.groupBox商品新增.Size = new System.Drawing.Size(411, 100);
            this.groupBox商品新增.TabIndex = 7;
            this.groupBox商品新增.TabStop = false;
            this.groupBox商品新增.Text = "商品新增";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.ForeColor = System.Drawing.Color.DarkRed;
            this.btn清空欄位.Location = new System.Drawing.Point(295, 37);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(110, 41);
            this.btn清空欄位.TabIndex = 4;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn儲存修改2
            // 
            this.btn儲存修改2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn儲存修改2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改2.Location = new System.Drawing.Point(168, 37);
            this.btn儲存修改2.Name = "btn儲存修改2";
            this.btn儲存修改2.Size = new System.Drawing.Size(121, 43);
            this.btn儲存修改2.TabIndex = 3;
            this.btn儲存修改2.Text = "儲存修改";
            this.btn儲存修改2.UseVisualStyleBackColor = false;
            this.btn儲存修改2.Click += new System.EventHandler(this.btn儲存修改2_Click);
            // 
            // btn選取照片2
            // 
            this.btn選取照片2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn選取照片2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn選取照片2.Location = new System.Drawing.Point(10, 37);
            this.btn選取照片2.Name = "btn選取照片2";
            this.btn選取照片2.Size = new System.Drawing.Size(152, 43);
            this.btn選取照片2.TabIndex = 2;
            this.btn選取照片2.Text = "選取商品照片";
            this.btn選取照片2.UseVisualStyleBackColor = false;
            this.btn選取照片2.Click += new System.EventHandler(this.btn選取照片2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(366, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "商品圖檔";
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(362, 99);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(411, 339);
            this.pictureBox商品圖檔.TabIndex = 9;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(128, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(228, 39);
            this.txtID.TabIndex = 10;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(128, 186);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(228, 39);
            this.txt商品名稱.TabIndex = 11;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(128, 276);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(228, 39);
            this.txt商品價格.TabIndex = 12;
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(794, 553);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox商品新增);
            this.Controls.Add(this.groupBox商品修改);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDetails";
            this.Text = "商品詳細資訊";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            this.groupBox商品修改.ResumeLayout(false);
            this.groupBox商品新增.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox商品修改;
        private System.Windows.Forms.GroupBox groupBox商品新增;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn選取商品照片;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn儲存修改2;
        private System.Windows.Forms.Button btn選取照片2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.TextBox txt商品價格;
    }
}