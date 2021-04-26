
namespace WinFormsLesson6
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
            this.infoLbl = new System.Windows.Forms.Label();
            this.clarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(23, 9);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(38, 15);
            this.infoLbl.TabIndex = 0;
            this.infoLbl.Text = "label1";
            // 
            // clarBtn
            // 
            this.clarBtn.Location = new System.Drawing.Point(395, 27);
            this.clarBtn.Name = "clarBtn";
            this.clarBtn.Size = new System.Drawing.Size(75, 23);
            this.clarBtn.TabIndex = 1;
            this.clarBtn.Text = "Clear";
            this.clarBtn.UseVisualStyleBackColor = true;
            this.clarBtn.Click += new System.EventHandler(this.clarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clarBtn);
            this.Controls.Add(this.infoLbl);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Button clarBtn;
    }
}

