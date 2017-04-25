namespace AirplanPOS
{
    partial class Confirm_Recall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_Recall));
            this.goBack = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Transparent;
            this.goBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goBack.ForeColor = System.Drawing.Color.Transparent;
            this.goBack.Location = new System.Drawing.Point(351, 97);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(57, 90);
            this.goBack.TabIndex = 8;
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm.ForeColor = System.Drawing.Color.Transparent;
            this.confirm.Location = new System.Drawing.Point(52, 97);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(66, 90);
            this.confirm.TabIndex = 9;
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Confirm_Recall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 287);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.goBack);
            this.DoubleBuffered = true;
            this.Name = "Confirm_Recall";
            this.Text = "Confirm_Recall";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button confirm;
    }
}