namespace OperS_lab5
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
            this.increasePriorityButton = new System.Windows.Forms.Button();
            this.decreasePriorityButton = new System.Windows.Forms.Button();
            this.stopThreadButton = new System.Windows.Forms.Button();
            this.createThreadButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // increasePriorityButton
            // 
            this.increasePriorityButton.Location = new System.Drawing.Point(61, 81);
            this.increasePriorityButton.Name = "increasePriorityButton";
            this.increasePriorityButton.Size = new System.Drawing.Size(233, 23);
            this.increasePriorityButton.TabIndex = 0;
            this.increasePriorityButton.Text = "Повысить приоритет";
            this.increasePriorityButton.UseVisualStyleBackColor = true;
            this.increasePriorityButton.Click += new System.EventHandler(this.increasePriorityButton_Click_1);
            // 
            // decreasePriorityButton
            // 
            this.decreasePriorityButton.Location = new System.Drawing.Point(61, 143);
            this.decreasePriorityButton.Name = "decreasePriorityButton";
            this.decreasePriorityButton.Size = new System.Drawing.Size(233, 23);
            this.decreasePriorityButton.TabIndex = 1;
            this.decreasePriorityButton.Text = "Понизить приоритет";
            this.decreasePriorityButton.UseVisualStyleBackColor = true;
            this.decreasePriorityButton.Click += new System.EventHandler(this.decreasePriorityButton_Click_1);
            // 
            // stopThreadButton
            // 
            this.stopThreadButton.Location = new System.Drawing.Point(61, 200);
            this.stopThreadButton.Name = "stopThreadButton";
            this.stopThreadButton.Size = new System.Drawing.Size(75, 23);
            this.stopThreadButton.TabIndex = 2;
            this.stopThreadButton.Text = "стоп";
            this.stopThreadButton.UseVisualStyleBackColor = true;
            this.stopThreadButton.Click += new System.EventHandler(this.stopThreadButton_Click_1);
            // 
            // createThreadButton
            // 
            this.createThreadButton.Location = new System.Drawing.Point(291, 323);
            this.createThreadButton.Name = "createThreadButton";
            this.createThreadButton.Size = new System.Drawing.Size(75, 23);
            this.createThreadButton.TabIndex = 3;
            this.createThreadButton.Text = "создать";
            this.createThreadButton.UseVisualStyleBackColor = true;
            this.createThreadButton.Click += new System.EventHandler(this.createThreadButton_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(399, -13);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 589);
            this.richTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.createThreadButton);
            this.Controls.Add(this.stopThreadButton);
            this.Controls.Add(this.decreasePriorityButton);
            this.Controls.Add(this.increasePriorityButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button increasePriorityButton;
        private System.Windows.Forms.Button decreasePriorityButton;
        private System.Windows.Forms.Button stopThreadButton;
        private System.Windows.Forms.Button createThreadButton;
        private System.Windows.Forms.TextBox richTextBox1;
    }
}

