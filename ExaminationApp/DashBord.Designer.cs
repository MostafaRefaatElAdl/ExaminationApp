namespace ExaminationApp
{
    partial class DashBord
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
            this.studentView = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.find_Student_by_NID = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentView
            // 
            this.studentView.FormattingEnabled = true;
            this.studentView.ItemHeight = 20;
            this.studentView.Location = new System.Drawing.Point(69, 133);
            this.studentView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentView.Name = "studentView";
            this.studentView.Size = new System.Drawing.Size(473, 164);
            this.studentView.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 26);
            this.textBox1.TabIndex = 1;
            // 
            // find_Student_by_NID
            // 
            this.find_Student_by_NID.AutoSize = true;
            this.find_Student_by_NID.Location = new System.Drawing.Point(65, 33);
            this.find_Student_by_NID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.find_Student_by_NID.Name = "find_Student_by_NID";
            this.find_Student_by_NID.Size = new System.Drawing.Size(128, 20);
            this.find_Student_by_NID.TabIndex = 2;
            this.find_Student_by_NID.Text = "Find STD by NID";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(188, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(194, 34);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 348);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.find_Student_by_NID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.studentView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBord";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label find_Student_by_NID;
        private System.Windows.Forms.Button searchButton;
    }
}

