
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
            this.tbTo = new System.Windows.Forms.TextBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(119, 25);
            this.tbTo.Multiline = true;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(251, 29);
            this.tbTo.TabIndex = 0;
            this.tbTo.TextChanged += new System.EventHandler(this.tbTo_TextChanged);
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(119, 86);
            this.TbTitle.Multiline = true;
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(251, 28);
            this.TbTitle.TabIndex = 1;
            this.TbTitle.TextChanged += new System.EventHandler(this.TbTitle_TextChanged);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(119, 144);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(251, 172);
            this.tbMessage.TabIndex = 2;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(376, 280);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(75, 36);
            this.tbSend.TabIndex = 3;
            this.tbSend.Text = "送信";
            this.tbSend.UseVisualStyleBackColor = true;
            this.tbSend.Click += new System.EventHandler(this.tbSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "送信先：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "件名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "本文：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.tbTo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button tbSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

