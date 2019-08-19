namespace Othello_v1._0
{
    partial class Cell
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DebugColorLabel = new System.Windows.Forms.Label();
            this.DebugIsReverseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DebugColorLabel
            // 
            this.DebugColorLabel.AutoSize = true;
            this.DebugColorLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DebugColorLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DebugColorLabel.Location = new System.Drawing.Point(3, 0);
            this.DebugColorLabel.Name = "DebugColorLabel";
            this.DebugColorLabel.Size = new System.Drawing.Size(35, 12);
            this.DebugColorLabel.TabIndex = 0;
            this.DebugColorLabel.Text = "label1";
            // 
            // DebugIsReverseLabel
            // 
            this.DebugIsReverseLabel.AutoSize = true;
            this.DebugIsReverseLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DebugIsReverseLabel.Location = new System.Drawing.Point(3, 12);
            this.DebugIsReverseLabel.Name = "DebugIsReverseLabel";
            this.DebugIsReverseLabel.Size = new System.Drawing.Size(35, 12);
            this.DebugIsReverseLabel.TabIndex = 1;
            this.DebugIsReverseLabel.Text = "label1";
            // 
            // Cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DebugIsReverseLabel);
            this.Controls.Add(this.DebugColorLabel);
            this.DoubleBuffered = true;
            this.Name = "Cell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DebugColorLabel;
        private System.Windows.Forms.Label DebugIsReverseLabel;
    }
}
