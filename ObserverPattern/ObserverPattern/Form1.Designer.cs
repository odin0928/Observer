namespace ObserverPattern
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox兔兔 = new System.Windows.Forms.PictureBox();
            this.pictureBox莎莉 = new System.Windows.Forms.PictureBox();
            this.pictureBox熊大 = new System.Windows.Forms.PictureBox();
            this.pictureBox饅頭人 = new System.Windows.Forms.PictureBox();
            this.buttonAtteck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label兔兔生命 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label莎莉生命 = new System.Windows.Forms.Label();
            this.label熊大生命 = new System.Windows.Forms.Label();
            this.label饅頭人生命 = new System.Windows.Forms.Label();
            this.label兔兔狀態 = new System.Windows.Forms.Label();
            this.label莎莉狀態 = new System.Windows.Forms.Label();
            this.label熊大狀態 = new System.Windows.Forms.Label();
            this.label饅頭人狀態 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox兔兔)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox莎莉)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox熊大)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox饅頭人)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 270);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(613, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pictureBox兔兔
            // 
            this.pictureBox兔兔.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox兔兔.Image")));
            this.pictureBox兔兔.Location = new System.Drawing.Point(91, 13);
            this.pictureBox兔兔.Name = "pictureBox兔兔";
            this.pictureBox兔兔.Size = new System.Drawing.Size(141, 135);
            this.pictureBox兔兔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox兔兔.TabIndex = 1;
            this.pictureBox兔兔.TabStop = false;
            this.pictureBox兔兔.Click += new System.EventHandler(this.pictureBox兔兔_Click);
            // 
            // pictureBox莎莉
            // 
            this.pictureBox莎莉.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox莎莉.Image")));
            this.pictureBox莎莉.Location = new System.Drawing.Point(259, 13);
            this.pictureBox莎莉.Name = "pictureBox莎莉";
            this.pictureBox莎莉.Size = new System.Drawing.Size(141, 135);
            this.pictureBox莎莉.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox莎莉.TabIndex = 2;
            this.pictureBox莎莉.TabStop = false;
            this.pictureBox莎莉.Click += new System.EventHandler(this.pictureBox莎莉_Click);
            // 
            // pictureBox熊大
            // 
            this.pictureBox熊大.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox熊大.Image")));
            this.pictureBox熊大.Location = new System.Drawing.Point(427, 13);
            this.pictureBox熊大.Name = "pictureBox熊大";
            this.pictureBox熊大.Size = new System.Drawing.Size(141, 135);
            this.pictureBox熊大.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox熊大.TabIndex = 3;
            this.pictureBox熊大.TabStop = false;
            this.pictureBox熊大.Click += new System.EventHandler(this.pictureBox熊大_Click);
            // 
            // pictureBox饅頭人
            // 
            this.pictureBox饅頭人.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox饅頭人.Image")));
            this.pictureBox饅頭人.Location = new System.Drawing.Point(595, 13);
            this.pictureBox饅頭人.Name = "pictureBox饅頭人";
            this.pictureBox饅頭人.Size = new System.Drawing.Size(141, 135);
            this.pictureBox饅頭人.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox饅頭人.TabIndex = 4;
            this.pictureBox饅頭人.TabStop = false;
            this.pictureBox饅頭人.Click += new System.EventHandler(this.pictureBox饅頭人_Click);
            // 
            // buttonAtteck
            // 
            this.buttonAtteck.Location = new System.Drawing.Point(638, 270);
            this.buttonAtteck.Name = "buttonAtteck";
            this.buttonAtteck.Size = new System.Drawing.Size(111, 153);
            this.buttonAtteck.TabIndex = 5;
            this.buttonAtteck.Text = "發動攻擊";
            this.buttonAtteck.UseVisualStyleBackColor = true;
            this.buttonAtteck.Click += new System.EventHandler(this.buttonAtteck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "生命值";
            // 
            // label兔兔生命
            // 
            this.label兔兔生命.BackColor = System.Drawing.Color.Black;
            this.label兔兔生命.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label兔兔生命.ForeColor = System.Drawing.Color.Yellow;
            this.label兔兔生命.Location = new System.Drawing.Point(106, 176);
            this.label兔兔生命.Name = "label兔兔生命";
            this.label兔兔生命.Size = new System.Drawing.Size(109, 30);
            this.label兔兔生命.TabIndex = 8;
            this.label兔兔生命.Text = "0";
            this.label兔兔生命.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(14, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "\'狀態";
            // 
            // label莎莉生命
            // 
            this.label莎莉生命.BackColor = System.Drawing.Color.Black;
            this.label莎莉生命.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label莎莉生命.ForeColor = System.Drawing.Color.Yellow;
            this.label莎莉生命.Location = new System.Drawing.Point(274, 176);
            this.label莎莉生命.Name = "label莎莉生命";
            this.label莎莉生命.Size = new System.Drawing.Size(109, 30);
            this.label莎莉生命.TabIndex = 10;
            this.label莎莉生命.Text = "0";
            this.label莎莉生命.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label熊大生命
            // 
            this.label熊大生命.BackColor = System.Drawing.Color.Black;
            this.label熊大生命.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label熊大生命.ForeColor = System.Drawing.Color.Yellow;
            this.label熊大生命.Location = new System.Drawing.Point(442, 176);
            this.label熊大生命.Name = "label熊大生命";
            this.label熊大生命.Size = new System.Drawing.Size(109, 30);
            this.label熊大生命.TabIndex = 11;
            this.label熊大生命.Text = "0";
            this.label熊大生命.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label饅頭人生命
            // 
            this.label饅頭人生命.BackColor = System.Drawing.Color.Black;
            this.label饅頭人生命.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label饅頭人生命.ForeColor = System.Drawing.Color.Yellow;
            this.label饅頭人生命.Location = new System.Drawing.Point(610, 176);
            this.label饅頭人生命.Name = "label饅頭人生命";
            this.label饅頭人生命.Size = new System.Drawing.Size(109, 30);
            this.label饅頭人生命.TabIndex = 12;
            this.label饅頭人生命.Text = "0";
            this.label饅頭人生命.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label兔兔狀態
            // 
            this.label兔兔狀態.BackColor = System.Drawing.Color.Blue;
            this.label兔兔狀態.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label兔兔狀態.ForeColor = System.Drawing.Color.Yellow;
            this.label兔兔狀態.Location = new System.Drawing.Point(127, 224);
            this.label兔兔狀態.Name = "label兔兔狀態";
            this.label兔兔狀態.Size = new System.Drawing.Size(66, 19);
            this.label兔兔狀態.TabIndex = 13;
            this.label兔兔狀態.Text = "線上";
            this.label兔兔狀態.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label莎莉狀態
            // 
            this.label莎莉狀態.BackColor = System.Drawing.Color.Blue;
            this.label莎莉狀態.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label莎莉狀態.ForeColor = System.Drawing.Color.Yellow;
            this.label莎莉狀態.Location = new System.Drawing.Point(296, 224);
            this.label莎莉狀態.Name = "label莎莉狀態";
            this.label莎莉狀態.Size = new System.Drawing.Size(66, 19);
            this.label莎莉狀態.TabIndex = 14;
            this.label莎莉狀態.Text = "線上";
            this.label莎莉狀態.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label熊大狀態
            // 
            this.label熊大狀態.BackColor = System.Drawing.Color.Blue;
            this.label熊大狀態.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label熊大狀態.ForeColor = System.Drawing.Color.Yellow;
            this.label熊大狀態.Location = new System.Drawing.Point(465, 224);
            this.label熊大狀態.Name = "label熊大狀態";
            this.label熊大狀態.Size = new System.Drawing.Size(66, 19);
            this.label熊大狀態.TabIndex = 15;
            this.label熊大狀態.Text = "線上";
            this.label熊大狀態.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label饅頭人狀態
            // 
            this.label饅頭人狀態.BackColor = System.Drawing.Color.Blue;
            this.label饅頭人狀態.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label饅頭人狀態.ForeColor = System.Drawing.Color.Yellow;
            this.label饅頭人狀態.Location = new System.Drawing.Point(634, 224);
            this.label饅頭人狀態.Name = "label饅頭人狀態";
            this.label饅頭人狀態.Size = new System.Drawing.Size(66, 19);
            this.label饅頭人狀態.TabIndex = 16;
            this.label饅頭人狀態.Text = "線上";
            this.label饅頭人狀態.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.label饅頭人狀態);
            this.Controls.Add(this.label熊大狀態);
            this.Controls.Add(this.label莎莉狀態);
            this.Controls.Add(this.label兔兔狀態);
            this.Controls.Add(this.label饅頭人生命);
            this.Controls.Add(this.label熊大生命);
            this.Controls.Add(this.label莎莉生命);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label兔兔生命);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAtteck);
            this.Controls.Add(this.pictureBox饅頭人);
            this.Controls.Add(this.pictureBox熊大);
            this.Controls.Add(this.pictureBox莎莉);
            this.Controls.Add(this.pictureBox兔兔);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox兔兔)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox莎莉)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox熊大)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox饅頭人)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox兔兔;
        private System.Windows.Forms.PictureBox pictureBox莎莉;
        private System.Windows.Forms.PictureBox pictureBox熊大;
        private System.Windows.Forms.PictureBox pictureBox饅頭人;
        private System.Windows.Forms.Button buttonAtteck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label兔兔生命;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label莎莉生命;
        private System.Windows.Forms.Label label熊大生命;
        private System.Windows.Forms.Label label饅頭人生命;
        private System.Windows.Forms.Label label兔兔狀態;
        private System.Windows.Forms.Label label莎莉狀態;
        private System.Windows.Forms.Label label熊大狀態;
        private System.Windows.Forms.Label label饅頭人狀態;
    }
}

