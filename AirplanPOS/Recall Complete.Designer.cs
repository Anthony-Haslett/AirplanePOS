namespace AirplanPOS
{
    partial class Recall_Complete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recall_Complete));
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(456, 240);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 112);
            this.back.TabIndex = 5;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(448, 416);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(128, 120);
            this.exit.TabIndex = 6;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recall_Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 741);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Name = "Recall_Complete";
            this.Text = "Recall_Complete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
    }
}