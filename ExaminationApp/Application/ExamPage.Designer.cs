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
            this.Choice1 = new System.Windows.Forms.RadioButton();
            this.Choice2 = new System.Windows.Forms.RadioButton();
            this.Choice3 = new System.Windows.Forms.RadioButton();
            this.Choice4 = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQ
            // 
            this.lbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ.Location = new System.Drawing.Point(37, 26);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(705, 39);
            this.lbQ.TabIndex = 0;
            this.lbQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Choice1
            // 
            this.Choice1.Location = new System.Drawing.Point(40, 115);
            this.Choice1.Name = "Choice1";
            this.Choice1.Size = new System.Drawing.Size(188, 33);
            this.Choice1.TabIndex = 1;
            this.Choice1.Tag = "1";
            this.Choice1.Text = "text1";
            this.Choice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Choice1.UseVisualStyleBackColor = true;
            this.Choice1.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Choice2
            // 
            this.Choice2.Location = new System.Drawing.Point(448, 115);
            this.Choice2.Name = "Choice2";
            this.Choice2.Size = new System.Drawing.Size(188, 33);
            this.Choice2.TabIndex = 2;
            this.Choice2.Tag = "2";
            this.Choice2.Text = "text2";
            this.Choice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Choice2.UseVisualStyleBackColor = true;
            this.Choice2.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Choice3
            // 
            this.Choice3.Location = new System.Drawing.Point(40, 168);
            this.Choice3.Name = "Choice3";
            this.Choice3.Size = new System.Drawing.Size(188, 33);
            this.Choice3.TabIndex = 3;
            this.Choice3.Tag = "3";
            this.Choice3.Text = "text3";
            this.Choice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Choice3.UseVisualStyleBackColor = true;
            this.Choice3.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Choice4
            // 
            this.Choice4.Location = new System.Drawing.Point(448, 168);
            this.Choice4.Name = "Choice4";
            this.Choice4.Size = new System.Drawing.Size(188, 33);
            this.Choice4.TabIndex = 4;
            this.Choice4.Tag = "4";
            this.Choice4.Text = "text4";
            this.Choice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Choice4.UseVisualStyleBackColor = true;
            this.Choice4.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(619, 207);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(123, 38);
            this.next.TabIndex = 5;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.LawnGreen;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(303, 147);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(139, 54);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // ExamPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 274);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Choice4);
            this.Controls.Add(this.Choice3);
            this.Controls.Add(this.Choice2);
            this.Controls.Add(this.Choice1);
            this.Controls.Add(this.lbQ);
            this.Name = "ExamPage";
            this.Text = "ExamPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExamPage_FormClosed);
            this.Load += new System.EventHandler(this.ExamPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQ;
        private System.Windows.Forms.RadioButton Choice1;
        private System.Windows.Forms.RadioButton Choice2;
        private System.Windows.Forms.RadioButton Choice3;
        private System.Windows.Forms.RadioButton Choice4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button btnFinish;
    }
}