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
            resources.ApplyResources(this.button_yes, "button_yes");
            this.button_yes.Name = "button_yes";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // button_no
            // 
            this.button_no.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.button_no, "button_no");
            this.button_no.Name = "button_no";
            this.button_no.UseVisualStyleBackColor = true;
            this.button_no.Click += new System.EventHandler(this.button_no_MouseEnter);
            this.button_no.MouseEnter += new System.EventHandler(this.button_no_MouseEnter);
            this.button_no.MouseHover += new System.EventHandler(this.button_no_MouseEnter);
            // 
            // box_question
            // 
            resources.ApplyResources(this.box_question, "box_question");
            this.box_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_question.Name = "box_question";
            this.box_question.ReadOnly = true;
            this.box_question.ShortcutsEnabled = false;
            this.box_question.TabStop = false;
            // 
            // Surprise
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.box_question);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.button_no);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Surprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_no;
        private TextBox box_question;
        public Button button_yes;
    }
}