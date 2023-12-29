namespace WindowsFormsApp1
{
    partial class Formshow
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
            this.components = new System.ComponentModel.Container();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btn資料刪除 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView商品展示
            // 
            this.listView商品展示.BackColor = System.Drawing.Color.Gainsboro;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(12, 120);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(760, 432);
            this.listView商品展示.TabIndex = 0;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView商品展示_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品展示表單";
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn圖片模式.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.ForeColor = System.Drawing.SystemColors.Control;
            this.btn圖片模式.Location = new System.Drawing.Point(799, 120);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(132, 54);
            this.btn圖片模式.TabIndex = 2;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = false;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn列表模式.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.ForeColor = System.Drawing.SystemColors.Control;
            this.btn列表模式.Location = new System.Drawing.Point(799, 202);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(132, 54);
            this.btn列表模式.TabIndex = 3;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.UseVisualStyleBackColor = false;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn新增商品.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.ForeColor = System.Drawing.SystemColors.Control;
            this.btn新增商品.Location = new System.Drawing.Point(799, 287);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(132, 54);
            this.btn新增商品.TabIndex = 4;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = false;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn重新整理
            // 
            this.btn重新整理.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn重新整理.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新整理.ForeColor = System.Drawing.SystemColors.Control;
            this.btn重新整理.Location = new System.Drawing.Point(799, 365);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(132, 54);
            this.btn重新整理.TabIndex = 5;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = false;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn資料刪除
            // 
            this.btn資料刪除.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn資料刪除.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料刪除.ForeColor = System.Drawing.Color.DarkRed;
            this.btn資料刪除.Location = new System.Drawing.Point(799, 498);
            this.btn資料刪除.Name = "btn資料刪除";
            this.btn資料刪除.Size = new System.Drawing.Size(132, 54);
            this.btn資料刪除.TabIndex = 6;
            this.btn資料刪除.Text = "資料刪除";
            this.btn資料刪除.UseVisualStyleBackColor = false;
            this.btn資料刪除.Click += new System.EventHandler(this.btn資料刪除_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(966, 564);
            this.Controls.Add(this.btn資料刪除);
            this.Controls.Add(this.btn重新整理);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView商品展示);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.ImageList imageList商品圖檔;
        private System.Windows.Forms.Button btn資料刪除;
    }
}