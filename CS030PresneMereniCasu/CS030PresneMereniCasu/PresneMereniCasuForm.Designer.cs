
namespace CS030PresneMereniCasu
{
    partial class PresneMereniCasuForm
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
            this.testButton = new System.Windows.Forms.Button();
            this.vystupTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testButton.Location = new System.Drawing.Point(287, 67);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(241, 107);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Spustit Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // vystupTextBox
            // 
            this.vystupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vystupTextBox.Location = new System.Drawing.Point(12, 222);
            this.vystupTextBox.Multiline = true;
            this.vystupTextBox.Name = "vystupTextBox";
            this.vystupTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.vystupTextBox.Size = new System.Drawing.Size(776, 216);
            this.vystupTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vystupTextBox);
            this.Controls.Add(this.testButton);
            this.Name = "Form1";
            this.Text = "CS030 Přesné Měření Času - Daniel Černý 3.D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox vystupTextBox;
    }
}

