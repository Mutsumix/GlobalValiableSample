namespace GlobalValiableSample
{
    partial class ChildForm
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
            this.btnUpdateFactory = new System.Windows.Forms.Button();
            this.sampleLabel = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateFactory
            // 
            this.btnUpdateFactory.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdateFactory.Location = new System.Drawing.Point(215, 203);
            this.btnUpdateFactory.Name = "btnUpdateFactory";
            this.btnUpdateFactory.Size = new System.Drawing.Size(363, 75);
            this.btnUpdateFactory.TabIndex = 0;
            this.btnUpdateFactory.Text = "グローバル変数更新";
            this.btnUpdateFactory.UseVisualStyleBackColor = true;
            this.btnUpdateFactory.Click += new System.EventHandler(this.btnUpdateFactory_Click);
            // 
            // sampleLabel
            // 
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sampleLabel.Location = new System.Drawing.Point(270, 86);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(237, 37);
            this.sampleLabel.TabIndex = 1;
            this.sampleLabel.Text = "グローバル変数";
            // 
            // txtFactory
            // 
            this.txtFactory.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFactory.Location = new System.Drawing.Point(277, 329);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(246, 44);
            this.txtFactory.TabIndex = 2;
            this.txtFactory.Text = "更新する値";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "子";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFactory);
            this.Controls.Add(this.sampleLabel);
            this.Controls.Add(this.btnUpdateFactory);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateFactory;
        private System.Windows.Forms.Label sampleLabel;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label label1;
    }
}