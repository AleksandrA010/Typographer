namespace Typographer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserTextField = new System.Windows.Forms.RichTextBox();
            this.OutputTextField = new System.Windows.Forms.RichTextBox();
            this.Correctbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserTextField
            // 
            this.UserTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextField.Location = new System.Drawing.Point(10, 50);
            this.UserTextField.Name = "UserTextField";
            this.UserTextField.Size = new System.Drawing.Size(380, 389);
            this.UserTextField.TabIndex = 0;
            this.UserTextField.Text = "";
            // 
            // OutputTextField
            // 
            this.OutputTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextField.Location = new System.Drawing.Point(400, 49);
            this.OutputTextField.Name = "OutputTextField";
            this.OutputTextField.ReadOnly = true;
            this.OutputTextField.Size = new System.Drawing.Size(380, 389);
            this.OutputTextField.TabIndex = 1;
            this.OutputTextField.Text = "";
            // 
            // Correctbutton
            // 
            this.Correctbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Correctbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Correctbutton.FlatAppearance.BorderSize = 0;
            this.Correctbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Correctbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Correctbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Correctbutton.Location = new System.Drawing.Point(315, 455);
            this.Correctbutton.Name = "Correctbutton";
            this.Correctbutton.Size = new System.Drawing.Size(150, 40);
            this.Correctbutton.TabIndex = 2;
            this.Correctbutton.Text = "Оттипографить";
            this.Correctbutton.UseVisualStyleBackColor = false;
            this.Correctbutton.Click += new System.EventHandler(this.Correctbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 508);
            this.Controls.Add(this.Correctbutton);
            this.Controls.Add(this.OutputTextField);
            this.Controls.Add(this.UserTextField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 555);
            this.Name = "Form1";
            this.Text = "Typographer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox UserTextField;
        private System.Windows.Forms.RichTextBox OutputTextField;
        private System.Windows.Forms.Button Correctbutton;
    }
}

