namespace ExaminationApp
{
    partial class StudentWelcomPage
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
            this.panelSliderMenue = new System.Windows.Forms.Panel();
            this.cours_grade_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.grade_btn = new System.Windows.Forms.Button();
            this.course_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.course_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header_stname_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.crsNameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.panelSliderMenue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSliderMenue
            // 
            this.panelSliderMenue.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelSliderMenue.Controls.Add(this.cours_grade_Panel);
            this.panelSliderMenue.Controls.Add(this.grade_btn);
            this.panelSliderMenue.Controls.Add(this.course_Panel);
            this.panelSliderMenue.Controls.Add(this.course_btn);
            this.panelSliderMenue.Controls.Add(this.panel1);
            this.panelSliderMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSliderMenue.Location = new System.Drawing.Point(0, 0);
            this.panelSliderMenue.Name = "panelSliderMenue";
            this.panelSliderMenue.Padding = new System.Windows.Forms.Padding(1);
            this.panelSliderMenue.Size = new System.Drawing.Size(225, 516);
            this.panelSliderMenue.TabIndex = 0;
            // 
            // cours_grade_Panel
            // 
            this.cours_grade_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cours_grade_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cours_grade_Panel.Location = new System.Drawing.Point(1, 334);
            this.cours_grade_Panel.Name = "cours_grade_Panel";
            this.cours_grade_Panel.Size = new System.Drawing.Size(223, 156);
            this.cours_grade_Panel.TabIndex = 4;
            this.cours_grade_Panel.Visible = false;
            // 
            // grade_btn
            // 
            this.grade_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_btn.Location = new System.Drawing.Point(1, 295);
            this.grade_btn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.grade_btn.Name = "grade_btn";
            this.grade_btn.Padding = new System.Windows.Forms.Padding(2);
            this.grade_btn.Size = new System.Drawing.Size(223, 39);
            this.grade_btn.TabIndex = 3;
            this.grade_btn.Text = "Grades";
            this.grade_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grade_btn.UseVisualStyleBackColor = true;
            this.grade_btn.Click += new System.EventHandler(this.grade_btn_Click);
            // 
            // course_Panel
            // 
            this.course_Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.course_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.course_Panel.Location = new System.Drawing.Point(1, 141);
            this.course_Panel.Name = "course_Panel";
            this.course_Panel.Size = new System.Drawing.Size(223, 154);
            this.course_Panel.TabIndex = 2;
            this.course_Panel.Visible = false;
            this.course_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.course_Panel_Paint);
            // 
            // course_btn
            // 
            this.course_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.course_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_btn.Location = new System.Drawing.Point(1, 102);
            this.course_btn.Name = "course_btn";
            this.course_btn.Padding = new System.Windows.Forms.Padding(2);
            this.course_btn.Size = new System.Drawing.Size(223, 39);
            this.course_btn.TabIndex = 1;
            this.course_btn.Text = "Courses";
            this.course_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.course_btn.UseVisualStyleBackColor = true;
            this.course_btn.Click += new System.EventHandler(this.course_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::ExaminationApp.Properties.Resources.iti_logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 101);
            this.panel1.TabIndex = 0;
            // 
            // header_stname_btn
            // 
            this.header_stname_btn.AccessibleName = "header_stname_btn";
            this.header_stname_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header_stname_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_stname_btn.Enabled = false;
            this.header_stname_btn.FlatAppearance.BorderSize = 0;
            this.header_stname_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_stname_btn.Location = new System.Drawing.Point(225, 0);
            this.header_stname_btn.Margin = new System.Windows.Forms.Padding(0);
            this.header_stname_btn.Name = "header_stname_btn";
            this.header_stname_btn.Size = new System.Drawing.Size(714, 47);
            this.header_stname_btn.TabIndex = 1;
            this.header_stname_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.header_stname_btn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(225, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 469);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.5F));
            this.tableLayoutPanel1.Controls.Add(this.crsNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gradeLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Visible = false;
            // 
            // crsNameLabel
            // 
            this.crsNameLabel.AutoSize = true;
            this.crsNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.crsNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.crsNameLabel.Location = new System.Drawing.Point(3, 0);
            this.crsNameLabel.Name = "crsNameLabel";
            this.crsNameLabel.Padding = new System.Windows.Forms.Padding(10);
            this.crsNameLabel.Size = new System.Drawing.Size(95, 59);
            this.crsNameLabel.TabIndex = 0;
            this.crsNameLabel.Text = "lab1                      ";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradeLabel.Location = new System.Drawing.Point(106, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Padding = new System.Windows.Forms.Padding(10);
            this.gradeLabel.Size = new System.Drawing.Size(80, 59);
            this.gradeLabel.TabIndex = 1;
            this.gradeLabel.Text = "lab2           ";
            // 
            // StudentWelcomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(939, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header_stname_btn);
            this.Controls.Add(this.panelSliderMenue);
            this.Name = "StudentWelcomPage";
            this.Text = "StudentWelcomPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentWelcomPage_FormClosed);
            this.Load += new System.EventHandler(this.StudentWelcomPage_Load);
            this.panelSliderMenue.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSliderMenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel course_Panel;
        private System.Windows.Forms.Button course_btn;
        private System.Windows.Forms.FlowLayoutPanel cours_grade_Panel;
        private System.Windows.Forms.Button grade_btn;
        private System.Windows.Forms.Button header_stname_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label crsNameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}