namespace BuilderPatternSample {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.saltWaterBuildButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saltWaterBuildButton
            // 
            this.saltWaterBuildButton.Location = new System.Drawing.Point(12, 12);
            this.saltWaterBuildButton.Name = "saltWaterBuildButton";
            this.saltWaterBuildButton.Size = new System.Drawing.Size(145, 23);
            this.saltWaterBuildButton.TabIndex = 0;
            this.saltWaterBuildButton.Text = "saltWaterBuild";
            this.saltWaterBuildButton.UseVisualStyleBackColor = true;
            this.saltWaterBuildButton.Click += new System.EventHandler(this.saltWaterBuildButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 41);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(542, 106);
            this.resultTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 159);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.saltWaterBuildButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saltWaterBuildButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

