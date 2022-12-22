
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DogsBreeds = new System.Windows.Forms.ListBox();
            this.Subspeciesofbreed = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get all dogs breeds";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(647, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get all subspecies of breed";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(242, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Random picture of Dog";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(475, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Random picture of selected breed";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DogsBreeds
            // 
            this.DogsBreeds.BackColor = System.Drawing.SystemColors.Info;
            this.DogsBreeds.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DogsBreeds.FormattingEnabled = true;
            this.DogsBreeds.ItemHeight = 20;
            this.DogsBreeds.Location = new System.Drawing.Point(12, 20);
            this.DogsBreeds.Name = "DogsBreeds";
            this.DogsBreeds.Size = new System.Drawing.Size(185, 364);
            this.DogsBreeds.TabIndex = 4;
            // 
            // Subspeciesofbreed
            // 
            this.Subspeciesofbreed.BackColor = System.Drawing.SystemColors.Info;
            this.Subspeciesofbreed.FormattingEnabled = true;
            this.Subspeciesofbreed.ItemHeight = 20;
            this.Subspeciesofbreed.Location = new System.Drawing.Point(647, 20);
            this.Subspeciesofbreed.Name = "Subspeciesofbreed";
            this.Subspeciesofbreed.Size = new System.Drawing.Size(141, 364);
            this.Subspeciesofbreed.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(242, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 327);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Subspeciesofbreed);
            this.Controls.Add(this.DogsBreeds);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox DogsBreeds;
        private System.Windows.Forms.ListBox Subspeciesofbreed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

