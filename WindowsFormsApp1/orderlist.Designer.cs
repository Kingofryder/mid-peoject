namespace WindowsFormsApp1
{
    partial class orderlist
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox飲料品項 = new System.Windows.Forms.ListBox();
            this.chk購物袋 = new System.Windows.Forms.CheckBox();
            this.chk外帶 = new System.Windows.Forms.CheckBox();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.comboBox甜度 = new System.Windows.Forms.ComboBox();
            this.comboBox冰塊 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chk內用 = new System.Windows.Forms.CheckBox();
            this.btn加入訂購單 = new System.Windows.Forms.Button();
            this.btn查看訂購單 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcoffee
            // 
            this.lblcoffee.AutoSize = true;
            this.lblcoffee.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoffee.ForeColor = System.Drawing.Color.White;
            this.lblcoffee.Location = new System.Drawing.Point(263, 26);
            this.lblcoffee.Name = "lblcoffee";
            this.lblcoffee.Size = new System.Drawing.Size(484, 60);
            this.lblcoffee.TabIndex = 1;
            this.lblcoffee.Text = "Cpt.j coffee管理系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(202, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "單價";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(31, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "冰塊";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(519, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "飲料品項";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(347, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "品項總價";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(34, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 35);
            this.label7.TabIndex = 8;
            this.label7.Text = "甜度";
            // 
            // listBox飲料品項
            // 
            this.listBox飲料品項.FormattingEnabled = true;
            this.listBox飲料品項.ItemHeight = 18;
            this.listBox飲料品項.Location = new System.Drawing.Point(525, 234);
            this.listBox飲料品項.Name = "listBox飲料品項";
            this.listBox飲料品項.Size = new System.Drawing.Size(443, 166);
            this.listBox飲料品項.TabIndex = 9;
            this.listBox飲料品項.SelectedIndexChanged += new System.EventHandler(this.listBox飲料品項_SelectedIndexChanged);
            // 
            // chk購物袋
            // 
            this.chk購物袋.AutoSize = true;
            this.chk購物袋.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk購物袋.ForeColor = System.Drawing.SystemColors.Control;
            this.chk購物袋.Location = new System.Drawing.Point(353, 170);
            this.chk購物袋.Name = "chk購物袋";
            this.chk購物袋.Size = new System.Drawing.Size(114, 34);
            this.chk購物袋.TabIndex = 10;
            this.chk購物袋.Text = "購物袋";
            this.chk購物袋.UseVisualStyleBackColor = true;
            this.chk購物袋.CheckedChanged += new System.EventHandler(this.chk購物袋_CheckedChanged);
            // 
            // chk外帶
            // 
            this.chk外帶.AutoSize = true;
            this.chk外帶.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk外帶.ForeColor = System.Drawing.SystemColors.Control;
            this.chk外帶.Location = new System.Drawing.Point(353, 296);
            this.chk外帶.Name = "chk外帶";
            this.chk外帶.Size = new System.Drawing.Size(89, 34);
            this.chk外帶.TabIndex = 11;
            this.chk外帶.Text = "外帶";
            this.chk外帶.UseVisualStyleBackColor = true;
            this.chk外帶.CheckedChanged += new System.EventHandler(this.chk外帶_CheckedChanged);
            // 
            // txt數量
            // 
            this.txt數量.Location = new System.Drawing.Point(40, 490);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(77, 29);
            this.txt數量.TabIndex = 13;
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl單價.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl單價.Location = new System.Drawing.Point(205, 493);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(98, 30);
            this.lbl單價.TabIndex = 14;
            this.lbl單價.Text = "0000元";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl品項總價.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl品項總價.Location = new System.Drawing.Point(353, 493);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(98, 30);
            this.lbl品項總價.TabIndex = 15;
            this.lbl品項總價.Text = "0000元";
            // 
            // comboBox甜度
            // 
            this.comboBox甜度.FormattingEnabled = true;
            this.comboBox甜度.Location = new System.Drawing.Point(140, 243);
            this.comboBox甜度.Name = "comboBox甜度";
            this.comboBox甜度.Size = new System.Drawing.Size(163, 26);
            this.comboBox甜度.TabIndex = 16;
            this.comboBox甜度.SelectedIndexChanged += new System.EventHandler(this.comboBox甜度_SelectedIndexChanged);
            // 
            // comboBox冰塊
            // 
            this.comboBox冰塊.FormattingEnabled = true;
            this.comboBox冰塊.Location = new System.Drawing.Point(140, 305);
            this.comboBox冰塊.Name = "comboBox冰塊";
            this.comboBox冰塊.Size = new System.Drawing.Size(163, 26);
            this.comboBox冰塊.TabIndex = 17;
            this.comboBox冰塊.SelectedIndexChanged += new System.EventHandler(this.comboBox冰塊_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(50, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 35);
            this.label10.TabIndex = 18;
            this.label10.Text = "訂購人(電話)";
            // 
            // txt訂購人
            // 
            this.txt訂購人.Location = new System.Drawing.Point(56, 175);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(247, 29);
            this.txt訂購人.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(123, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 35);
            this.label11.TabIndex = 19;
            this.label11.Text = "杯";
            // 
            // chk內用
            // 
            this.chk內用.AutoSize = true;
            this.chk內用.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk內用.ForeColor = System.Drawing.SystemColors.Control;
            this.chk內用.Location = new System.Drawing.Point(353, 234);
            this.chk內用.Name = "chk內用";
            this.chk內用.Size = new System.Drawing.Size(89, 34);
            this.chk內用.TabIndex = 20;
            this.chk內用.Text = "內用";
            this.chk內用.UseVisualStyleBackColor = true;
            this.chk內用.CheckedChanged += new System.EventHandler(this.chk內用_CheckedChanged);
            // 
            // btn加入訂購單
            // 
            this.btn加入訂購單.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn加入訂購單.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn加入訂購單.ForeColor = System.Drawing.SystemColors.Control;
            this.btn加入訂購單.Location = new System.Drawing.Point(37, 367);
            this.btn加入訂購單.Name = "btn加入訂購單";
            this.btn加入訂購單.Size = new System.Drawing.Size(150, 47);
            this.btn加入訂購單.TabIndex = 21;
            this.btn加入訂購單.Text = "加入訂購單";
            this.btn加入訂購單.UseVisualStyleBackColor = false;
            this.btn加入訂購單.Click += new System.EventHandler(this.btn加入訂購單_Click);
            // 
            // btn查看訂購單
            // 
            this.btn查看訂購單.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn查看訂購單.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn查看訂購單.ForeColor = System.Drawing.SystemColors.Control;
            this.btn查看訂購單.Location = new System.Drawing.Point(223, 367);
            this.btn查看訂購單.Name = "btn查看訂購單";
            this.btn查看訂購單.Size = new System.Drawing.Size(148, 47);
            this.btn查看訂購單.TabIndex = 22;
            this.btn查看訂購單.Text = "查看訂購單";
            this.btn查看訂購單.UseVisualStyleBackColor = false;
            this.btn查看訂購單.Click += new System.EventHandler(this.btn查看訂購單_Click);
            // 
            // orderlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1006, 554);
            this.Controls.Add(this.btn查看訂購單);
            this.Controls.Add(this.btn加入訂購單);
            this.Controls.Add(this.chk內用);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox冰塊);
            this.Controls.Add(this.comboBox甜度);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.chk外帶);
            this.Controls.Add(this.chk購物袋);
            this.Controls.Add(this.listBox飲料品項);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcoffee);
            this.Name = "orderlist";
            this.Text = "訂購項目";
            this.Load += new System.EventHandler(this.訂購項目_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox飲料品項;
        private System.Windows.Forms.CheckBox chk購物袋;
        private System.Windows.Forms.CheckBox chk外帶;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.ComboBox comboBox甜度;
        private System.Windows.Forms.ComboBox comboBox冰塊;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chk內用;
        private System.Windows.Forms.Button btn加入訂購單;
        private System.Windows.Forms.Button btn查看訂購單;
    }
}