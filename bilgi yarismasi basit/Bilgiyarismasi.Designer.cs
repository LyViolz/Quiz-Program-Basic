namespace Araç
{
    partial class Bilgiyarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgiyarismasi));
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnSonraki = new Button();
            LblSoruno = new Label();
            LblDogru = new Label();
            LblYanlis = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, -1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(662, 274);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnA.Location = new Point(0, 279);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(328, 87);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Font = new Font("Arial Rounded MT Bold", 26.25F);
            BtnB.Location = new Point(334, 279);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(328, 87);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Font = new Font("Arial Rounded MT Bold", 26.25F);
            BtnC.Location = new Point(0, 372);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(328, 87);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Font = new Font("Arial Rounded MT Bold", 26.25F);
            BtnD.Location = new Point(334, 372);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(328, 87);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AniMe Matrix - MB_EN", 15.7499981F, FontStyle.Bold);
            label1.Location = new Point(678, 42);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("AniMe Matrix - MB_EN", 15.7499981F, FontStyle.Bold);
            label2.Location = new Point(705, 85);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 6;
            label2.Text = "Dogru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("AniMe Matrix - MB_EN", 15.7499981F, FontStyle.Bold);
            label3.Location = new Point(701, 131);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 7;
            label3.Text = "Yanlis:";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(731, 222);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(185, 51);
            BtnSonraki.TabIndex = 8;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // LblSoruno
            // 
            LblSoruno.AutoSize = true;
            LblSoruno.Font = new Font("AniMe Matrix - MB_EN", 15.7499981F, FontStyle.Bold);
            LblSoruno.Location = new Point(834, 42);
            LblSoruno.Name = "LblSoruno";
            LblSoruno.Size = new Size(33, 25);
            LblSoruno.TabIndex = 9;
            LblSoruno.Text = "0";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Font = new Font("AniMe Matrix - MB_EN", 15.7499981F, FontStyle.Bold);
            LblDogru.Location = new Point(834, 85);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(33, 25);
            LblDogru.TabIndex = 10;
            LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Font = new Font("AniMe Matrix - MB_EN", 15.7499981F, FontStyle.Bold);
            LblYanlis.Location = new Point(834, 131);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(33, 25);
            LblYanlis.TabIndex = 11;
            LblYanlis.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 474);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 504);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(668, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(834, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Bilgiyarismasi
            // 
            AutoScaleDimensions = new SizeF(15F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(994, 627);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LblYanlis);
            Controls.Add(LblDogru);
            Controls.Add(LblSoruno);
            Controls.Add(BtnSonraki);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("AniMe Matrix - MB_EN", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Bilgiyarismasi";
            Text = "Bilgiyarismasi";
            Load += Bilgiyarismasi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnSonraki;
        private Label LblSoruno;
        private Label LblDogru;
        private Label LblYanlis;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}