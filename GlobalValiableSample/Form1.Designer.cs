namespace GlobalValiableSample
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
            this.sampleLabel = new System.Windows.Forms.Label();
            this.openChileButton = new System.Windows.Forms.Button();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.btnUpdateFactory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sampleLabel
            // 
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sampleLabel.Location = new System.Drawing.Point(287, 35);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(237, 37);
            this.sampleLabel.TabIndex = 0;
            this.sampleLabel.Text = "グローバル変数";
            // 
            // openChileButton
            // 
            this.openChileButton.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.openChileButton.Location = new System.Drawing.Point(266, 87);
            this.openChileButton.Name = "openChileButton";
            this.openChileButton.Size = new System.Drawing.Size(282, 76);
            this.openChileButton.TabIndex = 1;
            this.openChileButton.Text = "子画面を開く";
            this.openChileButton.UseVisualStyleBackColor = true;
            this.openChileButton.Click += new System.EventHandler(this.openChileButton_Click);
            // 
            // txtFactory
            // 
            this.txtFactory.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFactory.Location = new System.Drawing.Point(294, 336);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(246, 44);
            this.txtFactory.TabIndex = 4;
            this.txtFactory.Text = "更新する値";
            // 
            // btnUpdateFactory
            // 
            this.btnUpdateFactory.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdateFactory.Location = new System.Drawing.Point(233, 209);
            this.btnUpdateFactory.Name = "btnUpdateFactory";
            this.btnUpdateFactory.Size = new System.Drawing.Size(363, 75);
            this.btnUpdateFactory.TabIndex = 3;
            this.btnUpdateFactory.Text = "グローバル変数更新";
            this.btnUpdateFactory.UseVisualStyleBackColor = true;
            this.btnUpdateFactory.Click += new System.EventHandler(this.btnUpdateFactory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "親";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFactory);
            this.Controls.Add(this.btnUpdateFactory);
            this.Controls.Add(this.openChileButton);
            this.Controls.Add(this.sampleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sampleLabel;
        private System.Windows.Forms.Button openChileButton;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Button btnUpdateFactory;
        private System.Windows.Forms.Label label1;
    }
}

