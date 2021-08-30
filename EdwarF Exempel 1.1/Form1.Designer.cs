
namespace EdwarF_Exempel_1._1
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
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(434, 203);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(95, 38);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(529, 109);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 26);
            this.tbxTal2.TabIndex = 1;
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(414, 296);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(128, 26);
            this.tbxSumma.TabIndex = 2;
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(333, 109);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 26);
            this.tbxTal1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 408);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "EdwarF Exempel 1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.TextBox tbxTal1;
    }
}

