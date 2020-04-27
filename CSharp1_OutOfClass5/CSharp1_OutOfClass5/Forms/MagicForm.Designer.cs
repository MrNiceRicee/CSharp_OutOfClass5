namespace CSharp1_OutOfClass5.Forms
{
    partial class MagicForm
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
            this.label_number = new System.Windows.Forms.Label();
            this.MagicNumber_Box = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.ForeColor = System.Drawing.Color.White;
            this.label_number.Location = new System.Drawing.Point(151, 55);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(128, 13);
            this.label_number.TabIndex = 0;
            this.label_number.Text = "YOUR MAGIC NUMBER!";
            // 
            // MagicNumber_Box
            // 
            this.MagicNumber_Box.Location = new System.Drawing.Point(91, 103);
            this.MagicNumber_Box.Name = "MagicNumber_Box";
            this.MagicNumber_Box.Size = new System.Drawing.Size(219, 91);
            this.MagicNumber_Box.TabIndex = 1;
            this.MagicNumber_Box.Text = "NUMBER!";
            this.MagicNumber_Box.UseVisualStyleBackColor = true;
            // 
            // MagicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(416, 302);
            this.Controls.Add(this.MagicNumber_Box);
            this.Controls.Add(this.label_number);
            this.Name = "MagicForm";
            this.Text = "MagicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Button MagicNumber_Box;
    }
}