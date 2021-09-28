namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.XOTextBox = new System.Windows.Forms.TextBox();
            this.XKTextBox = new System.Windows.Forms.TextBox();
            this.DXTextBox = new System.Windows.Forms.TextBox();
            this.ConstTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.X0Label = new System.Windows.Forms.Label();
            this.XKLabel = new System.Windows.Forms.Label();
            this.DXLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XOTextBox
            // 
            this.XOTextBox.Location = new System.Drawing.Point(91, 79);
            this.XOTextBox.Name = "XOTextBox";
            this.XOTextBox.Size = new System.Drawing.Size(100, 20);
            this.XOTextBox.TabIndex = 0;
            // 
            // XKTextBox
            // 
            this.XKTextBox.Location = new System.Drawing.Point(91, 116);
            this.XKTextBox.Name = "XKTextBox";
            this.XKTextBox.Size = new System.Drawing.Size(100, 20);
            this.XKTextBox.TabIndex = 1;
            // 
            // DXTextBox
            // 
            this.DXTextBox.Location = new System.Drawing.Point(91, 154);
            this.DXTextBox.Name = "DXTextBox";
            this.DXTextBox.Size = new System.Drawing.Size(100, 20);
            this.DXTextBox.TabIndex = 2;
            // 
            // ConstTextBox
            // 
            this.ConstTextBox.Location = new System.Drawing.Point(91, 187);
            this.ConstTextBox.Multiline = true;
            this.ConstTextBox.Name = "ConstTextBox";
            this.ConstTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConstTextBox.TabIndex = 3;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 213);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(218, 186);
            this.ResultTextBox.TabIndex = 4;
            // 
            // X0Label
            // 
            this.X0Label.AutoSize = true;
            this.X0Label.Location = new System.Drawing.Point(50, 82);
            this.X0Label.Name = "X0Label";
            this.X0Label.Size = new System.Drawing.Size(29, 13);
            this.X0Label.TabIndex = 5;
            this.X0Label.Text = "X0 =";
            // 
            // XKLabel
            // 
            this.XKLabel.AutoSize = true;
            this.XKLabel.Location = new System.Drawing.Point(50, 119);
            this.XKLabel.Name = "XKLabel";
            this.XKLabel.Size = new System.Drawing.Size(30, 13);
            this.XKLabel.TabIndex = 6;
            this.XKLabel.Text = "XK =";
            // 
            // DXLabel
            // 
            this.DXLabel.AutoSize = true;
            this.DXLabel.Location = new System.Drawing.Point(48, 154);
            this.DXLabel.Name = "DXLabel";
            this.DXLabel.Size = new System.Drawing.Size(31, 13);
            this.DXLabel.TabIndex = 7;
            this.DXLabel.Text = "DX =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Const =";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(79, 412);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 9;
            this.CalcButton.Text = "расчитать";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 447);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DXLabel);
            this.Controls.Add(this.XKLabel);
            this.Controls.Add(this.X0Label);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ConstTextBox);
            this.Controls.Add(this.DXTextBox);
            this.Controls.Add(this.XKTextBox);
            this.Controls.Add(this.XOTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XOTextBox;
        private System.Windows.Forms.TextBox XKTextBox;
        private System.Windows.Forms.TextBox DXTextBox;
        private System.Windows.Forms.TextBox ConstTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label X0Label;
        private System.Windows.Forms.Label XKLabel;
        private System.Windows.Forms.Label DXLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcButton;
    }
}

