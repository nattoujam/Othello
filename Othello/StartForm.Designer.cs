namespace Othello
{
    partial class StartForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Selecter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isDebug = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(250, 363);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(300, 40);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Game Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseButton.Location = new System.Drawing.Point(250, 409);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(300, 40);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Selecter
            // 
            this.Selecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selecter.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Selecter.FormattingEnabled = true;
            this.Selecter.Items.AddRange(new object[] {
            "Normal",
            "Revolution",
            "AllRevolution",
            "WindPressure"});
            this.Selecter.Location = new System.Drawing.Point(74, 371);
            this.Selecter.Name = "Selecter";
            this.Selecter.Size = new System.Drawing.Size(170, 29);
            this.Selecter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(70, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ゲームルール";
            // 
            // isDebug
            // 
            this.isDebug.AutoSize = true;
            this.isDebug.Location = new System.Drawing.Point(364, 323);
            this.isDebug.Name = "isDebug";
            this.isDebug.Size = new System.Drawing.Size(56, 16);
            this.isDebug.TabIndex = 5;
            this.isDebug.Text = "Debug";
            this.isDebug.UseVisualStyleBackColor = true;
            this.isDebug.CheckedChanged += new System.EventHandler(this.IsDebug_CheckedChanged);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Othello.Properties.Resources.startPage;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.isDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selecter);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StartButton);
            this.MaximumSize = new System.Drawing.Size(812, 535);
            this.MinimumSize = new System.Drawing.Size(812, 535);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Othello - Mainpage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox Selecter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isDebug;
    }
}