namespace WindowsFormsApp1
{
    partial class orderlist2
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
            this.lblcoffee = new System.Windows.Forms.Label();
            this.lbl訂購資料 = new System.Windows.Forms.Label();
            this.listbox品項列表 = new System.Windows.Forms.ListBox();
            this.lbl外帶 = new System.Windows.Forms.Label();
            this.lbl購物袋 = new System.Windows.Forms.Label();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.btn移除所有選項 = new System.Windows.Forms.Button();
            this.btn清除所有選項 = new System.Windows.Forms.Button();
            this.btn輸出訂購單 = new System.Windows.Forms.Button();
            this.btn繼續訂購 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcoffee
            // 
            this.lblcoffee.AutoSize = true;
            this.lblcoffee.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoffee.ForeColor = System.Drawing.Color.White;
            this.lblcoffee.Location = new System.Drawing.Point(299, 35);
            this.lblcoffee.Name = "lblcoffee";
            this.lblcoffee.Size = new System.Drawing.Size(459, 60);
            this.lblcoffee.TabIndex = 2;
            this.lblcoffee.Text = "訂購品項列表(結帳)";
            // 
            // lbl訂購資料
            // 
            this.lbl訂購資料.AutoSize = true;
            this.lbl訂購資料.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl訂購資料.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl訂購資料.Location = new System.Drawing.Point(48, 108);
            this.lbl訂購資料.Name = "lbl訂購資料";
            this.lbl訂購資料.Size = new System.Drawing.Size(167, 44);
            this.lbl訂購資料.TabIndex = 3;
            this.lbl訂購資料.Text = "訂購資料";
            // 
            // listbox品項列表
            // 
            this.listbox品項列表.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox品項列表.FormattingEnabled = true;
            this.listbox品項列表.ItemHeight = 28;
            this.listbox品項列表.Location = new System.Drawing.Point(56, 167);
            this.listbox品項列表.Name = "listbox品項列表";
            this.listbox品項列表.Size = new System.Drawing.Size(974, 256);
            this.listbox品項列表.TabIndex = 4;
            this.listbox品項列表.SelectedIndexChanged += new System.EventHandler(this.listbox品項列表_SelectedIndexChanged);
            // 
            // lbl外帶
            // 
            this.lbl外帶.AutoSize = true;
            this.lbl外帶.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl外帶.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl外帶.Location = new System.Drawing.Point(658, 467);
            this.lbl外帶.Name = "lbl外帶";
            this.lbl外帶.Size = new System.Drawing.Size(63, 30);
            this.lbl外帶.TabIndex = 5;
            this.lbl外帶.Text = "外帶";
            // 
            // lbl購物袋
            // 
            this.lbl購物袋.AutoSize = true;
            this.lbl購物袋.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl購物袋.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl購物袋.Location = new System.Drawing.Point(727, 467);
            this.lbl購物袋.Name = "lbl購物袋";
            this.lbl購物袋.Size = new System.Drawing.Size(88, 30);
            this.lbl購物袋.TabIndex = 6;
            this.lbl購物袋.Text = "購物袋";
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl總價.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl總價.Location = new System.Drawing.Point(656, 527);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(236, 40);
            this.lbl總價.TabIndex = 7;
            this.lbl總價.Text = "總價000000元";
            // 
            // btn移除所有選項
            // 
            this.btn移除所有選項.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn移除所有選項.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn移除所有選項.ForeColor = System.Drawing.SystemColors.Control;
            this.btn移除所有選項.Location = new System.Drawing.Point(137, 462);
            this.btn移除所有選項.Name = "btn移除所有選項";
            this.btn移除所有選項.Size = new System.Drawing.Size(199, 50);
            this.btn移除所有選項.TabIndex = 8;
            this.btn移除所有選項.Text = "移除所有選項";
            this.btn移除所有選項.UseVisualStyleBackColor = false;
            this.btn移除所有選項.Click += new System.EventHandler(this.btn移除所有選項_Click);
            // 
            // btn清除所有選項
            // 
            this.btn清除所有選項.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn清除所有選項.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn清除所有選項.ForeColor = System.Drawing.SystemColors.Control;
            this.btn清除所有選項.Location = new System.Drawing.Point(137, 530);
            this.btn清除所有選項.Name = "btn清除所有選項";
            this.btn清除所有選項.Size = new System.Drawing.Size(199, 50);
            this.btn清除所有選項.TabIndex = 9;
            this.btn清除所有選項.Text = "清除所有選項";
            this.btn清除所有選項.UseVisualStyleBackColor = false;
            this.btn清除所有選項.Click += new System.EventHandler(this.btn清除所有選項_Click);
            // 
            // btn輸出訂購單
            // 
            this.btn輸出訂購單.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn輸出訂購單.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn輸出訂購單.ForeColor = System.Drawing.SystemColors.Control;
            this.btn輸出訂購單.Location = new System.Drawing.Point(371, 459);
            this.btn輸出訂購單.Name = "btn輸出訂購單";
            this.btn輸出訂購單.Size = new System.Drawing.Size(235, 50);
            this.btn輸出訂購單.TabIndex = 10;
            this.btn輸出訂購單.Text = "輸出訂購單檔案";
            this.btn輸出訂購單.UseVisualStyleBackColor = false;
            this.btn輸出訂購單.Click += new System.EventHandler(this.btn輸出訂購單_Click);
            // 
            // btn繼續訂購
            // 
            this.btn繼續訂購.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn繼續訂購.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn繼續訂購.ForeColor = System.Drawing.SystemColors.Control;
            this.btn繼續訂購.Location = new System.Drawing.Point(371, 530);
            this.btn繼續訂購.Name = "btn繼續訂購";
            this.btn繼續訂購.Size = new System.Drawing.Size(235, 50);
            this.btn繼續訂購.TabIndex = 11;
            this.btn繼續訂購.Text = "繼續訂購(關閉表單)";
            this.btn繼續訂購.UseVisualStyleBackColor = false;
            this.btn繼續訂購.Click += new System.EventHandler(this.btn繼續訂購_Click);
            // 
            // 咖啡項目２
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1096, 616);
            this.Controls.Add(this.btn繼續訂購);
            this.Controls.Add(this.btn輸出訂購單);
            this.Controls.Add(this.btn清除所有選項);
            this.Controls.Add(this.btn移除所有選項);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.lbl購物袋);
            this.Controls.Add(this.lbl外帶);
            this.Controls.Add(this.listbox品項列表);
            this.Controls.Add(this.lbl訂購資料);
            this.Controls.Add(this.lblcoffee);
            this.Name = "咖啡項目２";
            this.Text = "咖啡項目２";
            this.Load += new System.EventHandler(this.咖啡項目２_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcoffee;
        private System.Windows.Forms.Label lbl訂購資料;
        private System.Windows.Forms.ListBox listbox品項列表;
        private System.Windows.Forms.Label lbl外帶;
        private System.Windows.Forms.Label lbl購物袋;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Button btn移除所有選項;
        private System.Windows.Forms.Button btn清除所有選項;
        private System.Windows.Forms.Button btn輸出訂購單;
        private System.Windows.Forms.Button btn繼續訂購;
    }
}