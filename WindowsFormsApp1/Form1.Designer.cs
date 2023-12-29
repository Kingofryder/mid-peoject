namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcoffee = new System.Windows.Forms.Label();
            this.btn咖啡訂購單 = new System.Windows.Forms.Button();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcoffee
            // 
            this.lblcoffee.AutoSize = true;
            this.lblcoffee.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoffee.ForeColor = System.Drawing.Color.White;
            this.lblcoffee.Location = new System.Drawing.Point(171, 32);
            this.lblcoffee.Name = "lblcoffee";
            this.lblcoffee.Size = new System.Drawing.Size(484, 60);
            this.lblcoffee.TabIndex = 0;
            this.lblcoffee.Text = "Cpt.j coffee管理系統";
            // 
            // btn咖啡訂購單
            // 
            this.btn咖啡訂購單.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn咖啡訂購單.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn咖啡訂購單.ForeColor = System.Drawing.SystemColors.Control;
            this.btn咖啡訂購單.Location = new System.Drawing.Point(306, 148);
            this.btn咖啡訂購單.Name = "btn咖啡訂購單";
            this.btn咖啡訂購單.Size = new System.Drawing.Size(202, 119);
            this.btn咖啡訂購單.TabIndex = 2;
            this.btn咖啡訂購單.Text = "咖啡訂購單";
            this.btn咖啡訂購單.UseVisualStyleBackColor = false;
            this.btn咖啡訂購單.Click += new System.EventHandler(this.btn咖啡訂購單_Click);
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn會員資料管理.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn會員資料管理.ForeColor = System.Drawing.SystemColors.Control;
            this.btn會員資料管理.Location = new System.Drawing.Point(306, 447);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(202, 119);
            this.btn會員資料管理.TabIndex = 3;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = false;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn商品管理
            // 
            this.btn商品管理.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn商品管理.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn商品管理.ForeColor = System.Drawing.SystemColors.Control;
            this.btn商品管理.Location = new System.Drawing.Point(306, 296);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(202, 119);
            this.btn商品管理.TabIndex = 5;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = false;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(782, 590);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.btn咖啡訂購單);
            this.Controls.Add(this.lblcoffee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcoffee;
        private System.Windows.Forms.Button btn咖啡訂購單;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn商品管理;
    }
}

