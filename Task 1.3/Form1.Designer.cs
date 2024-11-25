namespace Task_1._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbOutput = new TextBox();
            button1 = new Button();
            tbInput = new TextBox();
            SuspendLayout();
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(199, 206);
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(259, 23);
            tbOutput.TabIndex = 0;
            tbOutput.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(241, 129);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 1;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbInput
            // 
            tbInput.Location = new Point(199, 70);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(259, 23);
            tbInput.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbInput);
            Controls.Add(button1);
            Controls.Add(tbOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbOutput;
        private Button button1;
        private TextBox tbInput;
    }
}
