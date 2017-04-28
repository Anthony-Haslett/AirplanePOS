namespace AirplanPOS
{
    partial class SeatNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatNum));
            this.enter = new System.Windows.Forms.Button();
            this.seatNumText = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.ForeColor = System.Drawing.Color.Transparent;
            this.enter.Location = new System.Drawing.Point(888, 672);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(128, 48);
            this.enter.TabIndex = 1;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // seatNumText
            // 
            this.seatNumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seatNumText.Font = new System.Drawing.Font("Segoe MDL2 Assets", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatNumText.Location = new System.Drawing.Point(328, 320);
            this.seatNumText.Name = "seatNumText";
            this.seatNumText.Size = new System.Drawing.Size(368, 43);
            this.seatNumText.TabIndex = 2;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(24, 676);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 40);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(964, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 84);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeatNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 741);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.seatNumText);
            this.Controls.Add(this.enter);
            this.DoubleBuffered = true;
            this.Name = "SeatNum";
            this.Text = "Enter Seat Number";
            this.Load += new System.EventHandler(this.SeatNum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox seatNumText;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exitBtn;
    }
}

