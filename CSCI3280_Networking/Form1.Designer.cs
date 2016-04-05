namespace CSCI3280_Networking
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
            this.peerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // peerListBox
            // 
            this.peerListBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.peerListBox.FormattingEnabled = true;
            this.peerListBox.ItemHeight = 12;
            this.peerListBox.Location = new System.Drawing.Point(407, 24);
            this.peerListBox.Name = "peerListBox";
            this.peerListBox.Size = new System.Drawing.Size(217, 76);
            this.peerListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connected Peer";
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(13, 365);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(611, 131);
            this.console.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(405, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Playlist";
            // 
            // playListBox
            // 
            this.playListBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.playListBox.FormattingEnabled = true;
            this.playListBox.ItemHeight = 12;
            this.playListBox.Location = new System.Drawing.Point(407, 121);
            this.playListBox.Name = "playListBox";
            this.playListBox.Size = new System.Drawing.Size(217, 220);
            this.playListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 508);
            this.Controls.Add(this.playListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.console);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peerListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox peerListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playListBox;
    }
}

