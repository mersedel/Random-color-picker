namespace Random_color_picker
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
            this.nextColorButton = new System.Windows.Forms.Button();
            this.copyCurColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextColorButton
            // 
            this.nextColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextColorButton.Location = new System.Drawing.Point(652, 373);
            this.nextColorButton.Name = "nextColorButton";
            this.nextColorButton.Size = new System.Drawing.Size(120, 35);
            this.nextColorButton.TabIndex = 0;
            this.nextColorButton.Text = "Next color";
            this.nextColorButton.UseVisualStyleBackColor = true;
            this.nextColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nextColorButton_MouseClick);
            // 
            // copyCurColorButton
            // 
            this.copyCurColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyCurColorButton.Location = new System.Drawing.Point(652, 414);
            this.copyCurColorButton.Name = "copyCurColorButton";
            this.copyCurColorButton.Size = new System.Drawing.Size(120, 35);
            this.copyCurColorButton.TabIndex = 1;
            this.copyCurColorButton.Text = "Copy current color";
            this.copyCurColorButton.UseVisualStyleBackColor = true;
            this.copyCurColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.copyCurColorButton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.copyCurColorButton);
            this.Controls.Add(this.nextColorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Color picker by mersedel";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button nextColorButton;
        public System.Windows.Forms.Button copyCurColorButton;
    }
}

