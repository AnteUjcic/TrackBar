namespace TrackBarKontrola
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
            this.tbTrakBar = new System.Windows.Forms.TrackBar();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrakBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTrakBar
            // 
            this.tbTrakBar.Location = new System.Drawing.Point(189, 50);
            this.tbTrakBar.Maximum = 100;
            this.tbTrakBar.Name = "tbTrakBar";
            this.tbTrakBar.Size = new System.Drawing.Size(196, 45);
            this.tbTrakBar.TabIndex = 0;
            this.tbTrakBar.TickFrequency = 5;
            this.tbTrakBar.Scroll += new System.EventHandler(this.tbTrakBar_Scroll);
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(189, 101);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(100, 20);
            this.txtTextBox.TabIndex = 1;
            this.txtTextBox.TextChanged += new System.EventHandler(this.txtTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.tbTrakBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTrakBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbTrakBar;
        private System.Windows.Forms.TextBox txtTextBox;
    }
}

