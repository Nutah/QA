namespace QA
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
            this.questionTb = new System.Windows.Forms.TextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.answerBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.answerTb = new System.Windows.Forms.RichTextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTb
            // 
            this.questionTb.Location = new System.Drawing.Point(12, 41);
            this.questionTb.Name = "questionTb";
            this.questionTb.Size = new System.Drawing.Size(862, 22);
            this.questionTb.TabIndex = 1;
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "Open...";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // answerBtn
            // 
            this.answerBtn.Enabled = false;
            this.answerBtn.Location = new System.Drawing.Point(880, 40);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(75, 23);
            this.answerBtn.TabIndex = 3;
            this.answerBtn.Text = "Answer";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(880, 522);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next Q";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // answerTb
            // 
            this.answerTb.Location = new System.Drawing.Point(13, 70);
            this.answerTb.Name = "answerTb";
            this.answerTb.Size = new System.Drawing.Size(861, 475);
            this.answerTb.TabIndex = 5;
            this.answerTb.Text = "";
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(94, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 566);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.answerTb);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.answerBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.questionTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionTb;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.RichTextBox answerTb;
        private System.Windows.Forms.Button startBtn;
    }
}

