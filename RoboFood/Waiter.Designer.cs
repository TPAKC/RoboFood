using System.Windows.Forms;

namespace RoboFood
{
    partial class Waiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.A = new System.Windows.Forms.TabPage();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A5 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.TabPage();
            this.C = new System.Windows.Forms.TabPage();
            this.A9 = new System.Windows.Forms.Button();
            this.A6 = new System.Windows.Forms.Button();
            this.A7 = new System.Windows.Forms.Button();
            this.A8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWaiter = new System.Windows.Forms.Label();
            this.comboBoxWaiter = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.comboBoxTableNumber = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.A.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(802, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 483);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Замовлення";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 20);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(380, 460);
            this.dataGridView.TabIndex = 0;
            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].HeaderText = "Cтiл";
            dataGridView.Columns[0].Width = 45;
            dataGridView.Columns[1].HeaderText = "Офiцiант";
            dataGridView.Columns[1].Width = 190;
            dataGridView.Columns[2].HeaderText = "Час заказу";
            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[3].HeaderText = "Номер заказу";
            dataGridView.Columns[3].Width = 70;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.A);
            this.tabControl1.Controls.Add(this.B);
            this.tabControl1.Controls.Add(this.C);
            this.tabControl1.ItemSize = new System.Drawing.Size(110, 27);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(800, 980);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // A
            // 
            this.A.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A.BackgroundImage")));
            this.A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A.Controls.Add(this.A1);
            this.A.Controls.Add(this.A2);
            this.A.Controls.Add(this.A3);
            this.A.Controls.Add(this.A4);
            this.A.Controls.Add(this.A5);
            this.A.Controls.Add(this.A6);
            this.A.Controls.Add(this.A7);
            this.A.Controls.Add(this.A8);
            this.A.Controls.Add(this.A9);
            this.A.Location = new System.Drawing.Point(4, 31);
            this.A.Name = "A";
            this.A.Padding = new System.Windows.Forms.Padding(3);
            this.A.Size = new System.Drawing.Size(792, 945);
            this.A.TabIndex = 0;
            this.A.Text = "(A)Основний зал";
            this.A.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(96, 87);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(98, 107);
            this.A1.TabIndex = 0;
            this.A1.Text = "Стiл №1\n Вiльний";
            this.A1.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(96, 221);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(98, 106);
            this.A2.TabIndex = 0;
            this.A2.Text = "Стiл №2\n Вiльний";
            this.A2.UseVisualStyleBackColor = true;
            // 
            // A5
            // 
            this.A5.Location = new System.Drawing.Point(594, 583);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(100, 90);
            this.A5.TabIndex = 0;
            this.A5.Text = "Стiл №5\n Вiльний";
            this.A5.UseVisualStyleBackColor = true;
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(594, 462);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(100, 91);
            this.A4.TabIndex = 0;
            this.A4.Text = "Стiл №4\n Вiльний";
            this.A4.UseVisualStyleBackColor = true;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(594, 347);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 91);
            this.A3.TabIndex = 0;
            this.A3.Text = "Стiл №3\n Вiльний";
            this.A3.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B.BackgroundImage")));
            this.B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B.Location = new System.Drawing.Point(4, 31);
            this.B.Name = "B";
            this.B.Padding = new System.Windows.Forms.Padding(3);
            this.B.Size = new System.Drawing.Size(792, 945);
            this.B.TabIndex = 1;
            this.B.Text = "(B)Кальянний зал";
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C.BackgroundImage")));
            this.C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C.Location = new System.Drawing.Point(4, 31);
            this.C.Name = "C";
            this.C.Padding = new System.Windows.Forms.Padding(3);
            this.C.Size = new System.Drawing.Size(792, 945);
            this.C.TabIndex = 2;
            this.C.Text = "(C)Лiтня тераса";
            this.C.UseVisualStyleBackColor = true;
            // 
            // A9
            // 
            this.A9.Location = new System.Drawing.Point(96, 707);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(98, 124);
            this.A9.TabIndex = 0;
            this.A9.Text = "Стiл №9\n Вiльний";
            this.A9.UseVisualStyleBackColor = true;
            // 
            // A6
            // 
            this.A6.Location = new System.Drawing.Point(510, 749);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(108, 85);
            this.A6.TabIndex = 0;
            this.A6.Text = "Стiл №6\n Вiльний";
            this.A6.UseVisualStyleBackColor = true;
            // 
            // A7
            // 
            this.A7.Location = new System.Drawing.Point(511, 868);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(106, 87);
            this.A7.TabIndex = 0;
            this.A7.Text = "Стiл №7\n Вiльний";
            this.A7.UseVisualStyleBackColor = true;
            // 
            // A8
            // 
            this.A8.Location = new System.Drawing.Point(55, 907);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(262, 69);
            this.A8.TabIndex = 0;
            this.A8.Text = "Стiл №8\n Вiльний";
            this.A8.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxOrderNumber);
            this.groupBox2.Controls.Add(this.labelOrderNumber);
            this.groupBox2.Controls.Add(this.textBoxTime);
            this.groupBox2.Controls.Add(this.labelTime);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelWaiter);
            this.groupBox2.Controls.Add(this.comboBoxWaiter);
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Controls.Add(this.comboBoxStatus);
            this.groupBox2.Controls.Add(this.labelTableNumber);
            this.groupBox2.Controls.Add(this.comboBoxTableNumber);
            this.groupBox2.Location = new System.Drawing.Point(802, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагування";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Час";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(181, 166);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(193, 27);
            this.textBoxOrderNumber.TabIndex = 4;
            this.textBoxOrderNumber.Visible = false;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelOrderNumber.Location = new System.Drawing.Point(6, 164);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(159, 25);
            this.labelOrderNumber.TabIndex = 2;
            this.labelOrderNumber.Text = "№ Замолвлення";
            this.labelOrderNumber.Visible = false;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(181, 199);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(193, 27);
            this.textBoxTime.TabIndex = 4;
            this.textBoxTime.Text = "12:00";
            this.textBoxTime.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(6, 197);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(162, 25);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Час бронювання";
            this.labelTime.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(181, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Змiнити";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelWaiter
            // 
            this.labelWaiter.AutoSize = true;
            this.labelWaiter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelWaiter.Location = new System.Drawing.Point(5, 130);
            this.labelWaiter.Name = "labelWaiter";
            this.labelWaiter.Size = new System.Drawing.Size(108, 28);
            this.labelWaiter.TabIndex = 2;
            this.labelWaiter.Text = "Офiцiант";
            this.labelWaiter.Visible = false;
            // 
            // comboBoxWaiter
            // 
            this.comboBoxWaiter.FormattingEnabled = true;
            this.comboBoxWaiter.Location = new System.Drawing.Point(181, 133);
            this.comboBoxWaiter.Name = "comboBoxWaiter";
            this.comboBoxWaiter.Size = new System.Drawing.Size(193, 28);
            this.comboBoxWaiter.TabIndex = 1;
            this.comboBoxWaiter.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(5, 62);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(153, 28);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Новий статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Вiльний",
            "Очiкують замолвлення",
            "Зайнятий",
            "Потрiбно прибирання",
            "Заброньований"});
            this.comboBoxStatus.Location = new System.Drawing.Point(181, 66);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(193, 28);
            this.comboBoxStatus.TabIndex = 1;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTableNumber.Location = new System.Drawing.Point(5, 26);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(89, 28);
            this.labelTableNumber.TabIndex = 2;
            this.labelTableNumber.Text = "Стiл №";
            // 
            // comboBoxTableNumber
            // 
            this.comboBoxTableNumber.FormattingEnabled = true;
            this.comboBoxTableNumber.Location = new System.Drawing.Point(181, 30);
            this.comboBoxTableNumber.Name = "comboBoxTableNumber";
            this.comboBoxTableNumber.Size = new System.Drawing.Size(193, 28);
            this.comboBoxTableNumber.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(802, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Офiцiанти";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(181, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Найняти";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Iм`я офiцiанта:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(180, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Звільнити";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Iм`я офiцiанта:";
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 977);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Waiter_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.A.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage A;
        private System.Windows.Forms.TabPage B;
        private System.Windows.Forms.TabPage C;
        private System.Windows.Forms.Button A5;
        private System.Windows.Forms.Button A4;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A9;
        private System.Windows.Forms.Button A6;
        private System.Windows.Forms.Button A7;
        private System.Windows.Forms.Button A8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWaiter;
        private System.Windows.Forms.ComboBox comboBoxWaiter;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.ComboBox comboBoxTableNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}