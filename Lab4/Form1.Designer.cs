
namespace Lab4
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
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.FirstArgTextBox = new System.Windows.Forms.TextBox();
            this.SecondArgTextBox = new System.Windows.Forms.TextBox();
            this.SignLabel = new System.Windows.Forms.Label();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.InfoVisibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.SignComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(292, 72);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 7;
            // 
            // FirstArgTextBox
            // 
            this.FirstArgTextBox.Location = new System.Drawing.Point(112, 69);
            this.FirstArgTextBox.MaxLength = 3;
            this.FirstArgTextBox.Name = "FirstArgTextBox";
            this.FirstArgTextBox.Size = new System.Drawing.Size(35, 20);
            this.FirstArgTextBox.TabIndex = 8;
            this.FirstArgTextBox.TextChanged += new System.EventHandler(this.FirstArgTextBox_TextChanged);
            this.FirstArgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstArgTextBox_KeyPress);
            // 
            // SecondArgTextBox
            // 
            this.SecondArgTextBox.Location = new System.Drawing.Point(217, 69);
            this.SecondArgTextBox.MaxLength = 3;
            this.SecondArgTextBox.Name = "SecondArgTextBox";
            this.SecondArgTextBox.Size = new System.Drawing.Size(35, 20);
            this.SecondArgTextBox.TabIndex = 9;
            this.SecondArgTextBox.TextChanged += new System.EventHandler(this.SecondArgTextBox_TextChanged);
            this.SecondArgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondArgTextBox_KeyPress);
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Location = new System.Drawing.Point(186, 44);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(0, 13);
            this.SignLabel.TabIndex = 11;
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Location = new System.Drawing.Point(186, 22);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(0, 13);
            this.OperationLabel.TabIndex = 13;
            // 
            // InfoVisibilityCheckBox
            // 
            this.InfoVisibilityCheckBox.AutoSize = true;
            this.InfoVisibilityCheckBox.Checked = true;
            this.InfoVisibilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InfoVisibilityCheckBox.Location = new System.Drawing.Point(112, 115);
            this.InfoVisibilityCheckBox.Name = "InfoVisibilityCheckBox";
            this.InfoVisibilityCheckBox.Size = new System.Drawing.Size(196, 17);
            this.InfoVisibilityCheckBox.TabIndex = 14;
            this.InfoVisibilityCheckBox.Text = "Отобразить имя и знак операции";
            this.InfoVisibilityCheckBox.UseVisualStyleBackColor = true;
            this.InfoVisibilityCheckBox.CheckedChanged += new System.EventHandler(this.InfoVisibilityCheckBox_CheckedChanged);
            // 
            // SignComboBox
            // 
            this.SignComboBox.FormattingEnabled = true;
            this.SignComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.SignComboBox.Location = new System.Drawing.Point(162, 69);
            this.SignComboBox.Name = "SignComboBox";
            this.SignComboBox.Size = new System.Drawing.Size(39, 21);
            this.SignComboBox.TabIndex = 15;
            this.SignComboBox.Text = "+";
            this.SignComboBox.SelectedIndexChanged += new System.EventHandler(this.SignComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 144);
            this.Controls.Add(this.SignComboBox);
            this.Controls.Add(this.InfoVisibilityCheckBox);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.SecondArgTextBox);
            this.Controls.Add(this.FirstArgTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox FirstArgTextBox;
        private System.Windows.Forms.TextBox SecondArgTextBox;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.CheckBox InfoVisibilityCheckBox;
        private System.Windows.Forms.ComboBox SignComboBox;
    }
}

