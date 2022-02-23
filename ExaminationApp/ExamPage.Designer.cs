namespace ExaminationApp
{
    partial class ExamPage
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
            this.lbQ = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQ
            // 
            this.lbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ.Location = new System.Drawing.Point(37, 31);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(599, 39);
            this.lbQ.TabIndex = 0;
            this.lbQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(436, 97);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 35);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button1";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(40, 97);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 35);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(40, 157);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 35);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "button1";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(436, 157);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(200, 35);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "button1";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // ExamPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 213);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lbQ);
            this.Name = "ExamPage";
            this.Text = "ExamPage";
            this.Load += new System.EventHandler(this.ExamPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQ;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}