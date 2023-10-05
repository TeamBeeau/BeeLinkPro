namespace Testing
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
            this.msgChoose1 = new Graphics.MsgChoose();
            this.path1 = new Graphics.Path();
            this.SuspendLayout();
            // 
            // msgChoose1
            // 
            this.msgChoose1.BackColor = System.Drawing.Color.Gainsboro;
            this.msgChoose1.Location = new System.Drawing.Point(304, 104);
            this.msgChoose1.Name = "msgChoose1";
            this.msgChoose1.Size = new System.Drawing.Size(348, 213);
            this.msgChoose1.TabIndex = 0;
            // 
            // path1
            // 
            this.path1.BackColor = System.Drawing.Color.Gainsboro;
            this.path1.Location = new System.Drawing.Point(101, 70);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(398, 263);
            this.path1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.msgChoose1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Graphics.MsgChoose msgChoose1;
        private Graphics.Path path1;
    }
}

