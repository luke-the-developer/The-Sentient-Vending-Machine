namespace Vending_Machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            itemsAdded = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            butterfinger = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Mars = new Button();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            Tonys = new Button();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            Coke = new Button();
            orderSummary = new ListBox();
            speakVendy = new Button();
            removeItem = new Button();
            confirmItems = new Button();
            checkoutSave = new Button();
            label10 = new Label();
            cancelAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // itemsAdded
            // 
            itemsAdded.FormattingEnabled = true;
            itemsAdded.ItemHeight = 25;
            itemsAdded.Location = new Point(837, 346);
            itemsAdded.Name = "itemsAdded";
            itemsAdded.Size = new Size(340, 279);
            itemsAdded.TabIndex = 0;
            itemsAdded.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 205);
            label1.Name = "label1";
            label1.Size = new Size(185, 36);
            label1.TabIndex = 3;
            label1.Text = "Butterfinger";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butterfinger
            // 
            butterfinger.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butterfinger.Location = new Point(44, 265);
            butterfinger.Name = "butterfinger";
            butterfinger.Size = new Size(142, 34);
            butterfinger.TabIndex = 4;
            butterfinger.Text = "Choose Me!";
            butterfinger.UseVisualStyleBackColor = true;
            butterfinger.Click += butterfinger_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 237);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 5;
            label2.Text = "£1.50";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Mars_bar;
            pictureBox2.Location = new Point(228, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Goudy Stout", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(261, 9);
            label3.Name = "label3";
            label3.Size = new Size(687, 80);
            label3.TabIndex = 7;
            label3.Text = "£ VENDY £";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(237, 203);
            label4.Name = "label4";
            label4.Size = new Size(149, 38);
            label4.TabIndex = 8;
            label4.Text = "MARS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 241);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 9;
            label5.Text = "£1.40";
            // 
            // Mars
            // 
            Mars.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mars.Location = new Point(253, 265);
            Mars.Name = "Mars";
            Mars.Size = new Size(133, 34);
            Mars.TabIndex = 10;
            Mars.Text = "CHOOSE ME!";
            Mars.UseVisualStyleBackColor = true;
            Mars.Click += Mars_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.TonysChoclolate;
            pictureBox3.Location = new Point(432, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(475, 207);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 12;
            label6.Text = "Tony's";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 240);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 13;
            label7.Text = "£1.75";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(954, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(233, 227);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // Tonys
            // 
            Tonys.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tonys.Location = new Point(447, 265);
            Tonys.Name = "Tonys";
            Tonys.Size = new Size(126, 34);
            Tonys.TabIndex = 16;
            Tonys.Text = "CHOOSE ME!";
            Tonys.UseVisualStyleBackColor = true;
            Tonys.Click += Tonys_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Coke;
            pictureBox5.Location = new Point(57, 326);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(119, 163);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(87, 494);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 18;
            label8.Text = "COKE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 517);
            label9.Name = "label9";
            label9.Size = new Size(56, 25);
            label9.TabIndex = 19;
            label9.Text = "£1.20";
            // 
            // Coke
            // 
            Coke.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Coke.Location = new Point(44, 545);
            Coke.Name = "Coke";
            Coke.Size = new Size(142, 34);
            Coke.TabIndex = 20;
            Coke.Text = "CHOOSE ME!";
            Coke.UseVisualStyleBackColor = true;
            Coke.Click += Coke_Click;
            // 
            // orderSummary
            // 
            orderSummary.FormattingEnabled = true;
            orderSummary.ItemHeight = 25;
            orderSummary.Location = new Point(837, 741);
            orderSummary.Name = "orderSummary";
            orderSummary.Size = new Size(340, 254);
            orderSummary.TabIndex = 21;
            orderSummary.SelectedIndexChanged += orderSummary_SelectedIndexChanged;
            // 
            // speakVendy
            // 
            speakVendy.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            speakVendy.Location = new Point(954, 257);
            speakVendy.Name = "speakVendy";
            speakVendy.Size = new Size(233, 71);
            speakVendy.TabIndex = 22;
            speakVendy.Text = "Speak With Vendy...";
            speakVendy.UseVisualStyleBackColor = true;
            speakVendy.Click += speakVendy_Click;
            // 
            // removeItem
            // 
            removeItem.Location = new Point(837, 647);
            removeItem.Name = "removeItem";
            removeItem.Size = new Size(115, 60);
            removeItem.TabIndex = 23;
            removeItem.Text = "Remove Item";
            removeItem.UseVisualStyleBackColor = true;
            // 
            // confirmItems
            // 
            confirmItems.Location = new Point(1040, 650);
            confirmItems.Name = "confirmItems";
            confirmItems.Size = new Size(128, 57);
            confirmItems.TabIndex = 24;
            confirmItems.Text = "Finish!";
            confirmItems.UseVisualStyleBackColor = true;
            confirmItems.Click += confirmItems_Click;
            // 
            // checkoutSave
            // 
            checkoutSave.Location = new Point(844, 1042);
            checkoutSave.Name = "checkoutSave";
            checkoutSave.Size = new Size(330, 76);
            checkoutSave.TabIndex = 25;
            checkoutSave.Text = "Checkout";
            checkoutSave.UseVisualStyleBackColor = true;
            checkoutSave.Click += checkoutSave_Click;
            // 
            // label10
            // 
            label10.Location = new Point(686, 346);
            label10.Name = "label10";
            label10.Size = new Size(128, 143);
            label10.TabIndex = 26;
            label10.Text = "Total";
            // 
            // cancelAll
            // 
            cancelAll.Location = new Point(1040, 1189);
            cancelAll.Name = "cancelAll";
            cancelAll.Size = new Size(112, 34);
            cancelAll.TabIndex = 27;
            cancelAll.Text = "Cancel";
            cancelAll.UseVisualStyleBackColor = true;
            cancelAll.Click += cancelAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 1571);
            Controls.Add(cancelAll);
            Controls.Add(label10);
            Controls.Add(checkoutSave);
            Controls.Add(confirmItems);
            Controls.Add(removeItem);
            Controls.Add(speakVendy);
            Controls.Add(orderSummary);
            Controls.Add(Coke);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox5);
            Controls.Add(Tonys);
            Controls.Add(pictureBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(Mars);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(butterfinger);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(itemsAdded);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox itemsAdded;
        private PictureBox pictureBox1;
        private Label label1;
        private Button butterfinger;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Mars;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox4;
        private Button Tonys;
        private PictureBox pictureBox5;
        private Label label8;
        private Label label9;
        private Button Coke;
        private ListBox orderSummary;
        private Button speakVendy;
        private Button removeItem;
        private Button confirmItems;
        private Button checkoutSave;
        private Label label10;
        private Button cancelAll;
    }
}
