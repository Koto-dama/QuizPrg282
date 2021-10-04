
namespace QuizPrg282
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(293, 354);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(188, 58);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read from the text file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(42, 12);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(722, 316);
            this.lbMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lbMain;
    }
}

