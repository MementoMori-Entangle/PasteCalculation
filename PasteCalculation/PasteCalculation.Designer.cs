namespace PasteCalculation
{
    partial class PasteCalculation
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.CalculationTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CEqualButton = new System.Windows.Forms.Button();
            this.PlusOrMinusTextBox = new System.Windows.Forms.TextBox();
            this.PlusOrMinusLabel = new System.Windows.Forms.Label();
            this.MultiplicationTextBox = new System.Windows.Forms.TextBox();
            this.MultiplicationLable = new System.Windows.Forms.Label();
            this.DivisionTextBox = new System.Windows.Forms.TextBox();
            this.DivisionLabel = new System.Windows.Forms.Label();
            this.PMClearButton = new System.Windows.Forms.Button();
            this.MClearButton = new System.Windows.Forms.Button();
            this.DClearButton = new System.Windows.Forms.Button();
            this.PMCheckBox = new System.Windows.Forms.CheckBox();
            this.MCheckBox = new System.Windows.Forms.CheckBox();
            this.DCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberFormatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculationTextBox
            // 
            this.CalculationTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CalculationTextBox.Location = new System.Drawing.Point(12, 12);
            this.CalculationTextBox.Name = "CalculationTextBox";
            this.CalculationTextBox.Size = new System.Drawing.Size(378, 34);
            this.CalculationTextBox.TabIndex = 0;
            this.CalculationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClearButton.Location = new System.Drawing.Point(12, 56);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(49, 35);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CEqualButton
            // 
            this.CEqualButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CEqualButton.Location = new System.Drawing.Point(341, 56);
            this.CEqualButton.Name = "CEqualButton";
            this.CEqualButton.Size = new System.Drawing.Size(49, 35);
            this.CEqualButton.TabIndex = 4;
            this.CEqualButton.Text = "C=";
            this.CEqualButton.UseVisualStyleBackColor = true;
            this.CEqualButton.Click += new System.EventHandler(this.CEqualButton_Click);
            // 
            // PlusOrMinusTextBox
            // 
            this.PlusOrMinusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PlusOrMinusTextBox.Location = new System.Drawing.Point(12, 120);
            this.PlusOrMinusTextBox.Multiline = true;
            this.PlusOrMinusTextBox.Name = "PlusOrMinusTextBox";
            this.PlusOrMinusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PlusOrMinusTextBox.Size = new System.Drawing.Size(122, 129);
            this.PlusOrMinusTextBox.TabIndex = 5;
            this.PlusOrMinusTextBox.WordWrap = false;
            // 
            // PlusOrMinusLabel
            // 
            this.PlusOrMinusLabel.AutoSize = true;
            this.PlusOrMinusLabel.Location = new System.Drawing.Point(33, 105);
            this.PlusOrMinusLabel.Name = "PlusOrMinusLabel";
            this.PlusOrMinusLabel.Size = new System.Drawing.Size(75, 12);
            this.PlusOrMinusLabel.TabIndex = 6;
            this.PlusOrMinusLabel.Text = "Plus or Minus";
            // 
            // MultiplicationTextBox
            // 
            this.MultiplicationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MultiplicationTextBox.Location = new System.Drawing.Point(140, 120);
            this.MultiplicationTextBox.Multiline = true;
            this.MultiplicationTextBox.Name = "MultiplicationTextBox";
            this.MultiplicationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MultiplicationTextBox.Size = new System.Drawing.Size(122, 129);
            this.MultiplicationTextBox.TabIndex = 7;
            this.MultiplicationTextBox.WordWrap = false;
            // 
            // MultiplicationLable
            // 
            this.MultiplicationLable.AutoSize = true;
            this.MultiplicationLable.Location = new System.Drawing.Point(161, 105);
            this.MultiplicationLable.Name = "MultiplicationLable";
            this.MultiplicationLable.Size = new System.Drawing.Size(73, 12);
            this.MultiplicationLable.TabIndex = 8;
            this.MultiplicationLable.Text = "Multiplication";
            // 
            // DivisionTextBox
            // 
            this.DivisionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DivisionTextBox.Location = new System.Drawing.Point(268, 120);
            this.DivisionTextBox.Multiline = true;
            this.DivisionTextBox.Name = "DivisionTextBox";
            this.DivisionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DivisionTextBox.Size = new System.Drawing.Size(122, 129);
            this.DivisionTextBox.TabIndex = 9;
            this.DivisionTextBox.WordWrap = false;
            // 
            // DivisionLabel
            // 
            this.DivisionLabel.AutoSize = true;
            this.DivisionLabel.Location = new System.Drawing.Point(289, 105);
            this.DivisionLabel.Name = "DivisionLabel";
            this.DivisionLabel.Size = new System.Drawing.Size(46, 12);
            this.DivisionLabel.TabIndex = 10;
            this.DivisionLabel.Text = "Division";
            // 
            // PMClearButton
            // 
            this.PMClearButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PMClearButton.Location = new System.Drawing.Point(67, 56);
            this.PMClearButton.Name = "PMClearButton";
            this.PMClearButton.Size = new System.Drawing.Size(67, 35);
            this.PMClearButton.TabIndex = 11;
            this.PMClearButton.Text = "PMC";
            this.PMClearButton.UseVisualStyleBackColor = true;
            this.PMClearButton.Click += new System.EventHandler(this.PMClearButton_Click);
            // 
            // MClearButton
            // 
            this.MClearButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MClearButton.Location = new System.Drawing.Point(144, 56);
            this.MClearButton.Name = "MClearButton";
            this.MClearButton.Size = new System.Drawing.Size(53, 35);
            this.MClearButton.TabIndex = 12;
            this.MClearButton.Text = "MC";
            this.MClearButton.UseVisualStyleBackColor = true;
            this.MClearButton.Click += new System.EventHandler(this.MClearButton_Click);
            // 
            // DClearButton
            // 
            this.DClearButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DClearButton.Location = new System.Drawing.Point(268, 56);
            this.DClearButton.Name = "DClearButton";
            this.DClearButton.Size = new System.Drawing.Size(53, 35);
            this.DClearButton.TabIndex = 13;
            this.DClearButton.Text = "DC";
            this.DClearButton.UseVisualStyleBackColor = true;
            this.DClearButton.Click += new System.EventHandler(this.DClearButton_Click);
            // 
            // PMCheckBox
            // 
            this.PMCheckBox.AutoSize = true;
            this.PMCheckBox.Location = new System.Drawing.Point(12, 105);
            this.PMCheckBox.Name = "PMCheckBox";
            this.PMCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PMCheckBox.TabIndex = 14;
            this.PMCheckBox.UseVisualStyleBackColor = true;
            // 
            // MCheckBox
            // 
            this.MCheckBox.AutoSize = true;
            this.MCheckBox.Location = new System.Drawing.Point(140, 105);
            this.MCheckBox.Name = "MCheckBox";
            this.MCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MCheckBox.TabIndex = 15;
            this.MCheckBox.UseVisualStyleBackColor = true;
            // 
            // DCheckBox
            // 
            this.DCheckBox.AutoSize = true;
            this.DCheckBox.Location = new System.Drawing.Point(268, 105);
            this.DCheckBox.Name = "DCheckBox";
            this.DCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DCheckBox.TabIndex = 16;
            this.DCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumberFormatButton
            // 
            this.NumberFormatButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumberFormatButton.Location = new System.Drawing.Point(203, 56);
            this.NumberFormatButton.Name = "NumberFormatButton";
            this.NumberFormatButton.Size = new System.Drawing.Size(59, 35);
            this.NumberFormatButton.TabIndex = 17;
            this.NumberFormatButton.Text = "#,##0";
            this.NumberFormatButton.UseVisualStyleBackColor = true;
            this.NumberFormatButton.Click += new System.EventHandler(this.NumberFormatButton_Click);
            // 
            // PasteCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.NumberFormatButton);
            this.Controls.Add(this.DCheckBox);
            this.Controls.Add(this.MCheckBox);
            this.Controls.Add(this.PMCheckBox);
            this.Controls.Add(this.DClearButton);
            this.Controls.Add(this.MClearButton);
            this.Controls.Add(this.PMClearButton);
            this.Controls.Add(this.DivisionLabel);
            this.Controls.Add(this.DivisionTextBox);
            this.Controls.Add(this.MultiplicationLable);
            this.Controls.Add(this.MultiplicationTextBox);
            this.Controls.Add(this.PlusOrMinusLabel);
            this.Controls.Add(this.PlusOrMinusTextBox);
            this.Controls.Add(this.CEqualButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculationTextBox);
            this.Name = "PasteCalculation";
            this.Text = "PasteCalculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculationTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CEqualButton;
        private System.Windows.Forms.TextBox PlusOrMinusTextBox;
        private System.Windows.Forms.Label PlusOrMinusLabel;
        private System.Windows.Forms.TextBox MultiplicationTextBox;
        private System.Windows.Forms.Label MultiplicationLable;
        private System.Windows.Forms.TextBox DivisionTextBox;
        private System.Windows.Forms.Label DivisionLabel;
        private System.Windows.Forms.Button PMClearButton;
        private System.Windows.Forms.Button MClearButton;
        private System.Windows.Forms.Button DClearButton;
        private System.Windows.Forms.CheckBox PMCheckBox;
        private System.Windows.Forms.CheckBox MCheckBox;
        private System.Windows.Forms.CheckBox DCheckBox;
        private System.Windows.Forms.Button NumberFormatButton;
    }
}

