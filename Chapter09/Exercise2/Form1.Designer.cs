
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btOpen = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btChangeFile = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(50, 34);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(100, 41);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btChangeFile
            // 
            this.btChangeFile.Location = new System.Drawing.Point(50, 96);
            this.btChangeFile.Name = "btChangeFile";
            this.btChangeFile.Size = new System.Drawing.Size(100, 41);
            this.btChangeFile.TabIndex = 0;
            this.btChangeFile.Text = "変換ファイル";
            this.btChangeFile.UseVisualStyleBackColor = true;
            this.btChangeFile.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(50, 167);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(100, 41);
            this.btChange.TabIndex = 0;
            this.btChange.Text = "変換";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btChangeFile);
            this.Controls.Add(this.btOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btChangeFile;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.OpenFileDialog sfdSaveFile;
    }
}

