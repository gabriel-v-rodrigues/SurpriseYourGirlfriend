namespace SurpriseForGirlfriend
{
    partial class Surprise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Surprise));
            this.button_yes = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.box_question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_yes
            // 
            this.button_yes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_yes.Location = new System.Drawing.Point(51, 178);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(80, 43);
            this.button_yes.TabIndex = 0;
            this.button_yes.Text = "Yes";
            this.button_yes.UseVisualStyleBackColor = true;
            // 
            // button_no
            // 
            this.button_no.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_no.Location = new System.Drawing.Point(310, 186);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(55, 27);
            this.button_no.TabIndex = 0;
            this.button_no.Text = "No";
            this.button_no.UseVisualStyleBackColor = true;
            // 
            // box_question
            // 
            this.box_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box_question.Location = new System.Drawing.Point(12, 34);
            this.box_question.Multiline = true;
            this.box_question.Name = "box_question";
            this.box_question.ReadOnly = true;
            this.box_question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.box_question.ShortcutsEnabled = false;
            this.box_question.Size = new System.Drawing.Size(410, 54);
            this.box_question.TabIndex = 2;
            this.box_question.TabStop = false;
            this.box_question.Text = "Do you want to be my girlfriend?";
            this.box_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Surprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.box_question);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Surprise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_yes;
        private Button button_no;
        private TextBox box_question;
    }
}