
namespace Xbox_Activity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ConnectionTxt = new System.Windows.Forms.Label();
            this.TitleIDTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxArt = new System.Windows.Forms.PictureBox();
            this.StatusTxt = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(13, 13);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ConnectionTxt
            // 
            this.ConnectionTxt.AutoSize = true;
            this.ConnectionTxt.Location = new System.Drawing.Point(3, 7);
            this.ConnectionTxt.Name = "ConnectionTxt";
            this.ConnectionTxt.Size = new System.Drawing.Size(99, 13);
            this.ConnectionTxt.TabIndex = 1;
            this.ConnectionTxt.Text = "Connect to console";
            // 
            // TitleIDTxt
            // 
            this.TitleIDTxt.AutoSize = true;
            this.TitleIDTxt.Location = new System.Drawing.Point(3, 52);
            this.TitleIDTxt.Name = "TitleIDTxt";
            this.TitleIDTxt.Size = new System.Drawing.Size(44, 13);
            this.TitleIDTxt.TabIndex = 2;
            this.TitleIDTxt.Text = "Title ID:";
            this.TitleIDTxt.Click += new System.EventHandler(this.TitleIDTxt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StatusTxt);
            this.panel1.Controls.Add(this.BoxArt);
            this.panel1.Controls.Add(this.TitleIDTxt);
            this.panel1.Controls.Add(this.ConnectionTxt);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 174);
            this.panel1.TabIndex = 3;
            // 
            // BoxArt
            // 
            this.BoxArt.Location = new System.Drawing.Point(221, 7);
            this.BoxArt.Name = "BoxArt";
            this.BoxArt.Size = new System.Drawing.Size(127, 155);
            this.BoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxArt.TabIndex = 3;
            this.BoxArt.TabStop = false;
            // 
            // StatusTxt
            // 
            this.StatusTxt.AutoSize = true;
            this.StatusTxt.Location = new System.Drawing.Point(6, 31);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(40, 13);
            this.StatusTxt.TabIndex = 4;
            this.StatusTxt.Text = "Status:";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(300, 9);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(79, 13);
            this.Credits.TabIndex = 4;
            this.Credits.Text = "By Professional";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 228);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Xbox Activity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label ConnectionTxt;
        private System.Windows.Forms.Label TitleIDTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BoxArt;
        private System.Windows.Forms.Label StatusTxt;
        private System.Windows.Forms.Label Credits;
    }
}

