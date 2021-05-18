
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
            this.StatusTxt = new System.Windows.Forms.Label();
            this.BoxArt = new System.Windows.Forms.PictureBox();
            this.Credits = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XSTS = new System.Windows.Forms.TextBox();
            this.XUID = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 174);
            this.panel1.TabIndex = 3;
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
            // BoxArt
            // 
            this.BoxArt.Location = new System.Drawing.Point(221, 7);
            this.BoxArt.Name = "BoxArt";
            this.BoxArt.Size = new System.Drawing.Size(127, 155);
            this.BoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxArt.TabIndex = 3;
            this.BoxArt.TabStop = false;
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(300, 259);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(79, 13);
            this.Credits.TabIndex = 4;
            this.Credits.Text = "By Professional";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(385, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(591, 323);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xb1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "XSTS Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "XUID:";
            // 
            // XSTS
            // 
            this.XSTS.Location = new System.Drawing.Point(255, 13);
            this.XSTS.Name = "XSTS";
            this.XSTS.Size = new System.Drawing.Size(100, 20);
            this.XSTS.TabIndex = 9;
            // 
            // XUID
            // 
            this.XUID.Location = new System.Drawing.Point(255, 39);
            this.XUID.Name = "XUID";
            this.XUID.Size = new System.Drawing.Size(100, 20);
            this.XUID.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 408);
            this.Controls.Add(this.XUID);
            this.Controls.Add(this.XSTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XSTS;
        private System.Windows.Forms.TextBox XUID;
    }
}

