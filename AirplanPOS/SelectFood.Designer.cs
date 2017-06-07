namespace AirplanPOS
{
    partial class SelectFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFood));
            this.enter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.burgerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.ForeColor = System.Drawing.Color.Transparent;
            this.enter.Location = new System.Drawing.Point(880, 680);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(120, 48);
            this.enter.TabIndex = 3;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(16, 688);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 40);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // burgerBox
            // 
            this.burgerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.burgerBox.Enabled = false;
            this.burgerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerBox.Location = new System.Drawing.Point(67, 181);
            this.burgerBox.Multiline = true;
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(247, 100);
            this.burgerBox.TabIndex = 6;
            this.burgerBox.Text = "A deluxe gourmet burger, with all the trimmings";
            // 
            // burgerBtn
            // 
            this.burgerBtn.BackColor = System.Drawing.Color.Transparent;
            this.burgerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("burgerBtn.BackgroundImage")));
            this.burgerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burgerBtn.Location = new System.Drawing.Point(67, 319);
            this.burgerBtn.Name = "burgerBtn";
            this.burgerBtn.Size = new System.Drawing.Size(247, 254);
            this.burgerBtn.TabIndex = 7;
            this.burgerBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(948, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 84);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // SelectFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.burgerBtn);
            this.Name = "SelectFood";
            this.Text = "SelectFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.Button burgerBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}