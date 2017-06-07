namespace AirplanPOS
{
    partial class Recall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recall));
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.seatNumText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(16, 680);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 40);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(888, 680);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seatNumText
            // 
            this.seatNumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seatNumText.Enabled = false;
            this.seatNumText.Font = new System.Drawing.Font("Segoe MDL2 Assets", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatNumText.Location = new System.Drawing.Point(330, 249);
            this.seatNumText.Name = "seatNumText";
            this.seatNumText.Size = new System.Drawing.Size(339, 43);
            this.seatNumText.TabIndex = 6;
            this.seatNumText.Text = "456";
            this.seatNumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(341, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 86);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Food was cold";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Recall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.seatNumText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Name = "Recall";
            this.ShowIcon = false;
            this.Text = "Recall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox seatNumText;
        private System.Windows.Forms.TextBox textBox1;
    }
}