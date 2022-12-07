namespace HelloWorldWF
{
    partial class MainForm
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
            this.bUpdateText = new System.Windows.Forms.Button();
            this.tbDemoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bUpdateText
            // 
            this.bUpdateText.Location = new System.Drawing.Point(84, 121);
            this.bUpdateText.Name = "bUpdateText";
            this.bUpdateText.Size = new System.Drawing.Size(75, 23);
            this.bUpdateText.TabIndex = 0;
            this.bUpdateText.Text = "Beállít";
            this.bUpdateText.UseVisualStyleBackColor = true;
            this.bUpdateText.Click += new System.EventHandler(this.bUpdateText_Click);
            // 
            // tbDemoText
            // 
            this.tbDemoText.Location = new System.Drawing.Point(84, 92);
            this.tbDemoText.Name = "tbDemoText";
            this.tbDemoText.Size = new System.Drawing.Size(100, 23);
            this.tbDemoText.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDemoText);
            this.Controls.Add(this.bUpdateText);
            this.Name = "MainForm";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bUpdateText;
        private TextBox tbDemoText;
    }
}