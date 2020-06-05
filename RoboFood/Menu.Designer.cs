namespace RoboFood
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Main_dishes = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Робота з клієнтом";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoToWaiter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 559);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 79);
            this.button2.TabIndex = 0;
            this.button2.Text = "Аналіз процесу роботи з клієнтом";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main_dishes
            // 
            this.Main_dishes.Location = new System.Drawing.Point(132, 247);
            this.Main_dishes.Name = "Main_dishes";
            this.Main_dishes.Size = new System.Drawing.Size(285, 79);
            this.Main_dishes.TabIndex = 0;
            this.Main_dishes.Text = "Меню";
            this.Main_dishes.UseVisualStyleBackColor = true;
            this.Main_dishes.Click += new System.EventHandler(this.GoToMenu);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(132, 350);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(285, 79);
            this.Title.TabIndex = 0;
            this.Title.Text = "Про програму";
            this.Title.UseVisualStyleBackColor = true;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(132, 452);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(285, 79);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Вихiд";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 556);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Main_dishes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoboFood";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Main_dishes;
        private System.Windows.Forms.Button Title;
        private System.Windows.Forms.Button Exit;
    }
}

