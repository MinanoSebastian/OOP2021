
namespace SendMail
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBcc
            // 
            this.tbBcc.Location = new System.Drawing.Point(101, 109);
            this.tbBcc.Margin = new System.Windows.Forms.Padding(2);
            this.tbBcc.Multiline = true;
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(524, 21);
            this.tbBcc.TabIndex = 0;
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(101, 154);
            this.TbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TbTitle.Multiline = true;
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(524, 23);
            this.TbTitle.TabIndex = 1;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(101, 195);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(524, 162);
            this.tbMessage.TabIndex = 2;
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(555, 373);
            this.tbSend.Margin = new System.Windows.Forms.Padding(2);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(70, 57);
            this.tbSend.TabIndex = 3;
            this.tbSend.Text = "送信";
            this.tbSend.UseVisualStyleBackColor = true;
            this.tbSend.Click += new System.EventHandler(this.tbSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(35, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bcc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "件名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "本文：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(46, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(48, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "To:";
            // 
            // tbCc
            // 
            this.tbCc.Location = new System.Drawing.Point(101, 73);
            this.tbCc.Margin = new System.Windows.Forms.Padding(2);
            this.tbCc.Multiline = true;
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(524, 21);
            this.tbCc.TabIndex = 0;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(101, 36);
            this.tbTo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTo.Multiline = true;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(524, 21);
            this.tbTo.TabIndex = 0;
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(101, 373);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(75, 57);
            this.btConfig.TabIndex = 7;
            this.btConfig.Text = "設定";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 484);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.tbBcc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBcc;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button tbSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Button btConfig;
    }
}

