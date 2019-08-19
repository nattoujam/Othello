namespace Othello_v1._0
{
    partial class PlayForm
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.currentTurn = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.B_Count = new System.Windows.Forms.Label();
            this.W_Count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TurnCount = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.RuleName = new System.Windows.Forms.Label();
            this.debug1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(616, 426);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "再戦";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // currentTurn
            // 
            this.currentTurn.AutoSize = true;
            this.currentTurn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.currentTurn.Location = new System.Drawing.Point(18, 59);
            this.currentTurn.Name = "currentTurn";
            this.currentTurn.Size = new System.Drawing.Size(35, 24);
            this.currentTurn.TabIndex = 2;
            this.currentTurn.Text = "黒";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(697, 426);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "終了";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // B_Count
            // 
            this.B_Count.AutoSize = true;
            this.B_Count.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.B_Count.Location = new System.Drawing.Point(119, 17);
            this.B_Count.Name = "B_Count";
            this.B_Count.Size = new System.Drawing.Size(69, 22);
            this.B_Count.TabIndex = 6;
            this.B_Count.Text = "label1";
            // 
            // W_Count
            // 
            this.W_Count.AutoSize = true;
            this.W_Count.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.W_Count.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.W_Count.Location = new System.Drawing.Point(119, 58);
            this.W_Count.Name = "W_Count";
            this.W_Count.Size = new System.Drawing.Size(69, 22);
            this.W_Count.TabIndex = 7;
            this.W_Count.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "黒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "白";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.W_Count);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.B_Count);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(572, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TurnCount);
            this.panel2.Controls.Add(this.currentTurn);
            this.panel2.Location = new System.Drawing.Point(572, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(64, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "のターンです。";
            // 
            // TurnCount
            // 
            this.TurnCount.AutoSize = true;
            this.TurnCount.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TurnCount.Location = new System.Drawing.Point(13, 10);
            this.TurnCount.Name = "TurnCount";
            this.TurnCount.Size = new System.Drawing.Size(69, 22);
            this.TurnCount.TabIndex = 3;
            this.TurnCount.Text = "label3";
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Result.Location = new System.Drawing.Point(583, 237);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(73, 24);
            this.Result.TabIndex = 8;
            this.Result.Text = "label4";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RuleName
            // 
            this.RuleName.AutoSize = true;
            this.RuleName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RuleName.Location = new System.Drawing.Point(569, 9);
            this.RuleName.Name = "RuleName";
            this.RuleName.Size = new System.Drawing.Size(46, 16);
            this.RuleName.TabIndex = 9;
            this.RuleName.Text = "label4";
            // 
            // debug1
            // 
            this.debug1.AutoSize = true;
            this.debug1.Location = new System.Drawing.Point(614, 411);
            this.debug1.Name = "debug1";
            this.debug1.Size = new System.Drawing.Size(35, 12);
            this.debug1.TabIndex = 10;
            this.debug1.Text = "label4";
            this.debug1.Visible = false;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.debug1);
            this.Controls.Add(this.RuleName);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ResetButton);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PlayForm";
            this.Text = "Othello";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label currentTurn;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label W_Count;
        private System.Windows.Forms.Label B_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TurnCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label RuleName;
        private System.Windows.Forms.Label debug1;
    }
}

