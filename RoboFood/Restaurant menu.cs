using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoboFood
{
    public partial class Restauraunt_menu : Form
    {
        public Button right;
        private Button left;
        private PictureBox pictureBox1;
        private Label indexPage;

        public Restauraunt_menu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restauraunt_menu));
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.indexPage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // right
            // 
            this.right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right.BackgroundImage")));
            this.right.Location = new System.Drawing.Point(868, 412);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(73, 63);
            this.right.TabIndex = 1;
            this.right.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left.BackgroundImage")));
            this.left.Location = new System.Drawing.Point(12, 412);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(70, 64);
            this.left.TabIndex = 1;
            this.left.UseVisualStyleBackColor = true;
            this.left.Visible = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // indexPage
            // 
            this.indexPage.AutoSize = true;
            this.indexPage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indexPage.Location = new System.Drawing.Point(403, 901);
            this.indexPage.Name = "indexPage";
            this.indexPage.Size = new System.Drawing.Size(105, 54);
            this.indexPage.TabIndex = 2;
            this.indexPage.Text = "1 / 3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 904);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Restauraunt_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(949, 953);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.indexPage);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Restauraunt_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Restauraunt_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Restauraunt_menu_Load(object sender, EventArgs e)
        {

        }

        private void right_Click(object sender, EventArgs e)
        {
            if (indexPage.Text == "2 / 3")
            {
                pictureBox1.Image = null;
                pictureBox1.Image = pictureBox1.Image = Properties.Resources.menu3;
                right.Visible = false;
                indexPage.Text = "3 / 3";
            }
            if (indexPage.Text == "1 / 3")
            {
                pictureBox1.Image = null;
                pictureBox1.Image = pictureBox1.Image = Properties.Resources.menu2;
                left.Visible = true;
                indexPage.Text = "2 / 3";
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (indexPage.Text == "2 / 3")
            {
                left.Visible = false;
                pictureBox1.Image = null;
                pictureBox1.Image = pictureBox1.Image = Properties.Resources.menu1;
                indexPage.Text = "1 / 3";

            }
            if (indexPage.Text == "3 / 3")
            {
                right.Visible = true;
                pictureBox1.Image = null;
                pictureBox1.Image = pictureBox1.Image = Properties.Resources.menu2;
                indexPage.Text = "2 / 3";
            }
        }
    }
}
