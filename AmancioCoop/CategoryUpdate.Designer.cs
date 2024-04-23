
namespace AmancioCoop
{
    partial class CategoryUpdate
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updateBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // updateBtn2
            // 
            this.updateBtn2.Location = new System.Drawing.Point(49, 59);
            this.updateBtn2.Name = "updateBtn2";
            this.updateBtn2.Size = new System.Drawing.Size(189, 23);
            this.updateBtn2.TabIndex = 1;
            this.updateBtn2.Text = "UPDATE";
            this.updateBtn2.UseVisualStyleBackColor = true;
            this.updateBtn2.Click += new System.EventHandler(this.updateBtn2_Click);
            // 
            // CategoryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 91);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateBtn2);
            this.Name = "CategoryUpdate";
            this.Text = "CategoryUpdate";
            this.Load += new System.EventHandler(this.CategoryUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button updateBtn2;
    }
}