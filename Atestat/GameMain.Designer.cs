namespace Atestat
{
    partial class GameMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMain));
            this.ScrollMessage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollMessage
            // 
            this.ScrollMessage.BackColor = System.Drawing.Color.Transparent;
            this.ScrollMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScrollMessage.BackgroundImage")));
            this.ScrollMessage.Image = ((System.Drawing.Image)(resources.GetObject("ScrollMessage.Image")));
            this.ScrollMessage.Location = new System.Drawing.Point(294, 504);
            this.ScrollMessage.Name = "ScrollMessage";
            this.ScrollMessage.Size = new System.Drawing.Size(680, 269);
            this.ScrollMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScrollMessage.TabIndex = 0;
            this.ScrollMessage.TabStop = false;
            this.ScrollMessage.Visible = false;
            this.ScrollMessage.Click += new System.EventHandler(this.ScrollMessage_Click_1);
            // 
            // timer1
            //   
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.ScrollMessage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "GameMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameMain_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.GameMain_GiveFeedback);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ScrollMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ScrollMessage;
    }
}