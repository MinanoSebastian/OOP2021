
namespace RssReader
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.
            
            ComponentModel.IContainer components = null;

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
            this.RssReader = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.setRssReader = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // RssReader
            // 
            this.RssReader.AutoSize = true;
            this.RssReader.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RssReader.Location = new System.Drawing.Point(6, 9);
            this.RssReader.Name = "RssReader";
            this.RssReader.Size = new System.Drawing.Size(186, 36);
            this.RssReader.TabIndex = 0;
            this.RssReader.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(209, 20);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(227, 25);
            this.tbUrl.TabIndex = 1;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(466, 15);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(88, 34);
            this.btRead.TabIndex = 2;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // setRssReader
            // 
            this.setRssReader.FormattingEnabled = true;
            this.setRssReader.ItemHeight = 18;
            this.setRssReader.Location = new System.Drawing.Point(12, 66);
            this.setRssReader.Name = "setRssReader";
            this.setRssReader.Size = new System.Drawing.Size(134, 346);
            this.setRssReader.TabIndex = 3;
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(188, 66);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(350, 346);
            this.wbBrowser.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.setRssReader);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.RssReader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RssReader;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.ListBox setRssReader;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}

