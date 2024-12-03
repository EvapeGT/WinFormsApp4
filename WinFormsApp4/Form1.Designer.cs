namespace WinFormsApp4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picOne = new PictureBox();
            picTwo = new PictureBox();
            picThree = new PictureBox();
            btnStart = new Button();
            btnW = new Button();
            lblSavings = new Label();
            lblCOH = new Label();
            label1 = new Label();
            label2 = new Label();
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThree).BeginInit();
            SuspendLayout();
            // 
            // picOne
            // 
            picOne.Location = new Point(46, 41);
            picOne.Name = "picOne";
            picOne.Size = new Size(139, 143);
            picOne.TabIndex = 0;
            picOne.TabStop = false;
            // 
            // picTwo
            // 
            picTwo.Location = new Point(202, 41);
            picTwo.Name = "picTwo";
            picTwo.Size = new Size(137, 143);
            picTwo.TabIndex = 1;
            picTwo.TabStop = false;
            // 
            // picThree
            // 
            picThree.Location = new Point(354, 41);
            picThree.Name = "picThree";
            picThree.Size = new Size(141, 143);
            picThree.TabIndex = 2;
            picThree.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(132, 214);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(118, 45);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // btnW
            // 
            btnW.Location = new Point(286, 214);
            btnW.Name = "btnW";
            btnW.Size = new Size(123, 45);
            btnW.TabIndex = 4;
            btnW.Text = "Withdraw";
            btnW.UseVisualStyleBackColor = true;
            btnW.Click += btnW_Click_1;
            // 
            // lblSavings
            // 
            lblSavings.AutoSize = true;
            lblSavings.BorderStyle = BorderStyle.FixedSingle;
            lblSavings.Font = new Font("Segoe UI", 30F);
            lblSavings.Location = new Point(564, 77);
            lblSavings.Name = "lblSavings";
            lblSavings.Size = new Size(58, 69);
            lblSavings.TabIndex = 5;
            lblSavings.Text = "0";
            // 
            // lblCOH
            // 
            lblCOH.AutoSize = true;
            lblCOH.BorderStyle = BorderStyle.FixedSingle;
            lblCOH.Font = new Font("Segoe UI", 30F);
            lblCOH.Location = new Point(732, 77);
            lblCOH.Name = "lblCOH";
            lblCOH.Size = new Size(85, 69);
            lblCOH.TabIndex = 6;
            lblCOH.Text = "45";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(564, 41);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 7;
            label1.Text = "Savings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(732, 41);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 8;
            label2.Text = "Cash on hand";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "467471229_558758433720036_6296356101419153777_n.png");
            imageList1.Images.SetKeyName(1, "Add a heading (2).png");
            imageList1.Images.SetKeyName(2, "SingaporeA_2.jpg");
            imageList1.Images.SetKeyName(3, "02824fcaf0ddc8e92698b5f808b2e241.jpg");
            imageList1.Images.SetKeyName(4, "school-art-design-media-nanyang-technological-university-campus-school-art-design-media-nanyang-technological-191034644.png");
            imageList1.Images.SetKeyName(5, "jgi-university-policies2.jpg");
            imageList1.Images.SetKeyName(6, "landprocess-urban-rooftop-farm-thammasat-university-thailand-designboom-1200-1.jpg");
            imageList1.Images.SetKeyName(7, "IOA-LOGO-300x300.png");
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 329);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCOH);
            Controls.Add(lblSavings);
            Controls.Add(btnW);
            Controls.Add(btnStart);
            Controls.Add(picThree);
            Controls.Add(picTwo);
            Controls.Add(picOne);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThree).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picOne;
        private PictureBox picTwo;
        private PictureBox picThree;
        private Button btnStart;
        private Button btnW;
        private Label lblSavings;
        private Label lblCOH;
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}
