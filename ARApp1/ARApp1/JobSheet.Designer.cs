namespace ARApp1
{
    partial class JobSheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jobChkList = new System.Windows.Forms.CheckedListBox();
            this.lblSubmitted = new System.Windows.Forms.Label();
            this.lblSubmitting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Sheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Robert Williams";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "12 Sep 2013 - 15:28 PDT";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(6, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(266, 66);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "# AxPort23-M02 - Auxilary Engine\r\n\r\nAuxilary Engine Valve Refitting\r\n\r\nJob: NR234" +
                "/23P/Sa-M02 - Preemptive - SysAlert\r\n\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(-5, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 2);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // jobChkList
            // 
            this.jobChkList.BackColor = System.Drawing.SystemColors.Window;
            this.jobChkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobChkList.FormattingEnabled = true;
            this.jobChkList.Items.AddRange(new object[] {
            "Engine Greezing",
            "Valve Corrosion Check",
            "Belt Check",
            "Anti Rust Treatment",
            "Assembly Tightening"});
            this.jobChkList.Location = new System.Drawing.Point(4, 123);
            this.jobChkList.Name = "jobChkList";
            this.jobChkList.Size = new System.Drawing.Size(144, 75);
            this.jobChkList.TabIndex = 5;
            // 
            // lblSubmitted
            // 
            this.lblSubmitted.AutoSize = true;
            this.lblSubmitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitted.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSubmitted.Location = new System.Drawing.Point(60, 156);
            this.lblSubmitted.Name = "lblSubmitted";
            this.lblSubmitted.Size = new System.Drawing.Size(168, 16);
            this.lblSubmitted.TabIndex = 7;
            this.lblSubmitted.Text = "Submitted Successfully";
            this.lblSubmitted.Visible = false;
            // 
            // lblSubmitting
            // 
            this.lblSubmitting.AutoSize = true;
            this.lblSubmitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitting.ForeColor = System.Drawing.Color.Maroon;
            this.lblSubmitting.Location = new System.Drawing.Point(60, 140);
            this.lblSubmitting.Name = "lblSubmitting";
            this.lblSubmitting.Size = new System.Drawing.Size(166, 16);
            this.lblSubmitting.TabIndex = 6;
            this.lblSubmitting.Text = "Submitting Job Sheet...";
            this.lblSubmitting.Visible = false;
            // 
            // JobSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 208);
            this.ControlBox = false;
            this.Controls.Add(this.lblSubmitted);
            this.Controls.Add(this.lblSubmitting);
            this.Controls.Add(this.jobChkList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.JobSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckedListBox jobChkList;
        public System.Windows.Forms.Label lblSubmitted;
        public System.Windows.Forms.Label lblSubmitting;
    }
}