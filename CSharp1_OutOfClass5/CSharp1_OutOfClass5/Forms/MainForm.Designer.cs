namespace CSharp1_OutOfClass5
{
    partial class Form1
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
            this.combo_fruit = new System.Windows.Forms.ComboBox();
            this.combo_number = new System.Windows.Forms.ComboBox();
            this.combo_month = new System.Windows.Forms.ComboBox();
            this.combo_name = new System.Windows.Forms.ComboBox();
            this.label_month = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_fruit = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_fruit
            // 
            this.combo_fruit.FormattingEnabled = true;
            this.combo_fruit.Location = new System.Drawing.Point(191, 149);
            this.combo_fruit.Name = "combo_fruit";
            this.combo_fruit.Size = new System.Drawing.Size(121, 21);
            this.combo_fruit.TabIndex = 15;
            // 
            // combo_number
            // 
            this.combo_number.FormattingEnabled = true;
            this.combo_number.Location = new System.Drawing.Point(191, 112);
            this.combo_number.Name = "combo_number";
            this.combo_number.Size = new System.Drawing.Size(121, 21);
            this.combo_number.TabIndex = 14;
            // 
            // combo_month
            // 
            this.combo_month.FormattingEnabled = true;
            this.combo_month.Location = new System.Drawing.Point(191, 73);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(121, 21);
            this.combo_month.TabIndex = 13;
            // 
            // combo_name
            // 
            this.combo_name.FormattingEnabled = true;
            this.combo_name.Location = new System.Drawing.Point(191, 36);
            this.combo_name.Name = "combo_name";
            this.combo_name.Size = new System.Drawing.Size(121, 21);
            this.combo_name.TabIndex = 12;
            // 
            // label_month
            // 
            this.label_month.AutoSize = true;
            this.label_month.ForeColor = System.Drawing.Color.White;
            this.label_month.Location = new System.Drawing.Point(44, 81);
            this.label_month.Name = "label_month";
            this.label_month.Size = new System.Drawing.Size(87, 13);
            this.label_month.TabIndex = 11;
            this.label_month.Text = "Enter birth month";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.ForeColor = System.Drawing.Color.White;
            this.label_number.Location = new System.Drawing.Point(44, 120);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(93, 13);
            this.label_number.TabIndex = 10;
            this.label_number.Text = "Enter best number";
            // 
            // label_fruit
            // 
            this.label_fruit.AutoSize = true;
            this.label_fruit.ForeColor = System.Drawing.Color.White;
            this.label_fruit.Location = new System.Drawing.Point(44, 157);
            this.label_fruit.Name = "label_fruit";
            this.label_fruit.Size = new System.Drawing.Size(93, 13);
            this.label_fruit.TabIndex = 9;
            this.label_fruit.Text = "Enter the best fruit";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(44, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(141, 13);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Enter first letter of your name";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(191, 197);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(121, 23);
            this.button_submit.TabIndex = 16;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(422, 232);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.combo_fruit);
            this.Controls.Add(this.combo_number);
            this.Controls.Add(this.combo_month);
            this.Controls.Add(this.combo_name);
            this.Controls.Add(this.label_month);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_fruit);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_fruit;
        private System.Windows.Forms.ComboBox combo_number;
        private System.Windows.Forms.ComboBox combo_month;
        private System.Windows.Forms.ComboBox combo_name;
        private System.Windows.Forms.Label label_month;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_fruit;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_submit;
    }
}

