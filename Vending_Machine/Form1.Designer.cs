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
            listBox1 = new ListBox();
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
            confirmItems = new Button();
            checkoutSave = new Button();
            label10 = new Label();
            cancelAll = new Button();
            twoPound = new PictureBox();
            onePound = new PictureBox();
            fiftyP = new PictureBox();
            twentyP = new PictureBox();
            tenP = new PictureBox();
            fiveP = new PictureBox();
            twoP = new PictureBox();
            oneP = new PictureBox();
            paymentBox = new PictureBox();
            change = new Label();
            finalAmount = new Label();
            paymentZone = new GroupBox();
            collectPurchase = new Button();
            orderZone = new GroupBox();
            cancelComplete = new Button();
            textBox1 = new TextBox();
            vendyBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twoPound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)onePound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiftyP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twentyP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tenP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiveP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twoP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oneP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentBox).BeginInit();
            paymentZone.SuspendLayout();
            orderZone.SuspendLayout();
            vendyBox.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(545, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(340, 279);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 264);
            label1.Name = "label1";
            label1.Size = new Size(185, 36);
            label1.TabIndex = 3;
            label1.Text = "Butterfinger";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butterfinger
            // 
            butterfinger.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butterfinger.Location = new Point(181, 328);
            butterfinger.Name = "butterfinger";
            butterfinger.Size = new Size(159, 34);
            butterfinger.TabIndex = 4;
            butterfinger.Text = "Choose Me!";
            butterfinger.UseVisualStyleBackColor = true;
            butterfinger.Click += butterfinger_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 300);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 5;
            label2.Text = "£1.50";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Mars_bar;
            pictureBox2.Location = new Point(192, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 46);
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
            label4.Location = new Point(176, 92);
            label4.Name = "label4";
            label4.Size = new Size(149, 38);
            label4.TabIndex = 8;
            label4.Text = "MARS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 125);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 9;
            label5.Text = "£1.40";
            // 
            // Mars
            // 
            Mars.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mars.Location = new Point(192, 156);
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
            pictureBox3.Location = new Point(21, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 99);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 12;
            label6.Text = "Tony's";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 123);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 13;
            label7.Text = "£1.75";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(68, 45);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(233, 227);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // Tonys
            // 
            Tonys.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tonys.Location = new Point(9, 156);
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
            pictureBox5.Location = new Point(222, 402);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(86, 116);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(237, 527);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 18;
            label8.Text = "COKE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(238, 562);
            label9.Name = "label9";
            label9.Size = new Size(56, 25);
            label9.TabIndex = 19;
            label9.Text = "£1.20";
            // 
            // Coke
            // 
            Coke.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Coke.Location = new Point(195, 590);
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
            orderSummary.Location = new Point(542, 391);
            orderSummary.Name = "orderSummary";
            orderSummary.Size = new Size(340, 254);
            orderSummary.TabIndex = 21;
            orderSummary.SelectedIndexChanged += orderSummary_SelectedIndexChanged;
            // 
            // speakVendy
            // 
            speakVendy.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            speakVendy.Location = new Point(68, 278);
            speakVendy.Name = "speakVendy";
            speakVendy.Size = new Size(233, 71);
            speakVendy.TabIndex = 22;
            speakVendy.Text = "Speak With Vendy...";
            speakVendy.UseVisualStyleBackColor = true;
            // 
            // confirmItems
            // 
            confirmItems.Location = new Point(748, 328);
            confirmItems.Name = "confirmItems";
            confirmItems.Size = new Size(128, 57);
            confirmItems.TabIndex = 24;
            confirmItems.Text = "Finish!";
            confirmItems.UseVisualStyleBackColor = true;
            confirmItems.Click += confirmItems_Click;
            // 
            // checkoutSave
            // 
            checkoutSave.Location = new Point(545, 651);
            checkoutSave.Name = "checkoutSave";
            checkoutSave.Size = new Size(340, 76);
            checkoutSave.TabIndex = 25;
            checkoutSave.Text = "Checkout";
            checkoutSave.UseVisualStyleBackColor = true;
            checkoutSave.Click += checkoutSave_Click;
            // 
            // label10
            // 
            label10.Location = new Point(411, 43);
            label10.Name = "label10";
            label10.Size = new Size(128, 143);
            label10.TabIndex = 26;
            label10.Text = "Total Price";
            label10.Click += label10_Click;
            // 
            // cancelAll
            // 
            cancelAll.Location = new Point(770, 733);
            cancelAll.Name = "cancelAll";
            cancelAll.Size = new Size(115, 52);
            cancelAll.TabIndex = 27;
            cancelAll.Text = "Cancel";
            cancelAll.UseVisualStyleBackColor = true;
            cancelAll.Click += cancelAll_Click;
            // 
            // twoPound
            // 
            twoPound.Image = Properties.Resources._2Pound;
            twoPound.Location = new Point(43, 49);
            twoPound.Name = "twoPound";
            twoPound.Size = new Size(113, 111);
            twoPound.SizeMode = PictureBoxSizeMode.Zoom;
            twoPound.TabIndex = 28;
            twoPound.TabStop = false;
            twoPound.MouseDown += twoPound_mouseDown;
            // 
            // onePound
            // 
            onePound.Image = Properties.Resources._1Pound;
            onePound.Location = new Point(162, 49);
            onePound.Name = "onePound";
            onePound.Size = new Size(109, 111);
            onePound.SizeMode = PictureBoxSizeMode.Zoom;
            onePound.TabIndex = 29;
            onePound.TabStop = false;
            onePound.MouseDown += onePound_mouseDown;
            // 
            // fiftyP
            // 
            fiftyP.Image = Properties.Resources._50P;
            fiftyP.Location = new Point(277, 49);
            fiftyP.Name = "fiftyP";
            fiftyP.Size = new Size(109, 111);
            fiftyP.TabIndex = 30;
            fiftyP.TabStop = false;
            fiftyP.MouseDown += fiftyP_mouseDown;
            // 
            // twentyP
            // 
            twentyP.Image = Properties.Resources._20P;
            twentyP.Location = new Point(390, 49);
            twentyP.Name = "twentyP";
            twentyP.Size = new Size(109, 111);
            twentyP.SizeMode = PictureBoxSizeMode.Zoom;
            twentyP.TabIndex = 31;
            twentyP.TabStop = false;
            twentyP.MouseDown += twentyP_mouseDown;
            // 
            // tenP
            // 
            tenP.Image = Properties.Resources._10P;
            tenP.Location = new Point(43, 166);
            tenP.Name = "tenP";
            tenP.Size = new Size(113, 111);
            tenP.SizeMode = PictureBoxSizeMode.Zoom;
            tenP.TabIndex = 32;
            tenP.TabStop = false;
            tenP.MouseDown += tenP_mouseDown;
            // 
            // fiveP
            // 
            fiveP.Image = Properties.Resources._5P;
            fiveP.Location = new Point(164, 166);
            fiveP.Name = "fiveP";
            fiveP.Size = new Size(107, 111);
            fiveP.SizeMode = PictureBoxSizeMode.Zoom;
            fiveP.TabIndex = 33;
            fiveP.TabStop = false;
            fiveP.MouseDown += fiveP_mouseDown;
            // 
            // twoP
            // 
            twoP.Image = Properties.Resources._2P;
            twoP.Location = new Point(277, 166);
            twoP.Name = "twoP";
            twoP.Size = new Size(109, 111);
            twoP.SizeMode = PictureBoxSizeMode.Zoom;
            twoP.TabIndex = 34;
            twoP.TabStop = false;
            twoP.MouseDown += twoP_mouseDown;
            // 
            // oneP
            // 
            oneP.Image = Properties.Resources._1P;
            oneP.Location = new Point(392, 166);
            oneP.Name = "oneP";
            oneP.Size = new Size(107, 111);
            oneP.SizeMode = PictureBoxSizeMode.Zoom;
            oneP.TabIndex = 35;
            oneP.TabStop = false;
            oneP.MouseDown += oneP_mouseDown;
            // 
            // paymentBox
            // 
            paymentBox.Image = Properties.Resources.coinSlot;
            paymentBox.Location = new Point(949, 50);
            paymentBox.Name = "paymentBox";
            paymentBox.Size = new Size(243, 227);
            paymentBox.SizeMode = PictureBoxSizeMode.Zoom;
            paymentBox.TabIndex = 36;
            paymentBox.TabStop = false;
            paymentBox.DragDrop += paymentBox_DragDrop;
            paymentBox.DragEnter += paymentBox_DragEnter;
            // 
            // change
            // 
            change.Location = new Point(29, 332);
            change.Name = "change";
            change.Size = new Size(265, 93);
            change.TabIndex = 37;
            change.Text = "Press for Change";
            change.Click += change_Click;
            // 
            // finalAmount
            // 
            finalAmount.Location = new Point(612, 49);
            finalAmount.Name = "finalAmount";
            finalAmount.Size = new Size(273, 228);
            finalAmount.TabIndex = 38;
            finalAmount.Text = "Amount Due";
            finalAmount.Click += finalAmount_Click;
            // 
            // paymentZone
            // 
            paymentZone.Controls.Add(collectPurchase);
            paymentZone.Controls.Add(fiftyP);
            paymentZone.Controls.Add(change);
            paymentZone.Controls.Add(finalAmount);
            paymentZone.Controls.Add(paymentBox);
            paymentZone.Controls.Add(twoPound);
            paymentZone.Controls.Add(onePound);
            paymentZone.Controls.Add(twentyP);
            paymentZone.Controls.Add(oneP);
            paymentZone.Controls.Add(tenP);
            paymentZone.Controls.Add(twoP);
            paymentZone.Controls.Add(fiveP);
            paymentZone.Location = new Point(12, 1086);
            paymentZone.Name = "paymentZone";
            paymentZone.Size = new Size(1311, 463);
            paymentZone.TabIndex = 39;
            paymentZone.TabStop = false;
            paymentZone.Text = "Payment Zone";
            paymentZone.Enter += paymentZone_Enter;
            // 
            // collectPurchase
            // 
            collectPurchase.Location = new Point(319, 332);
            collectPurchase.Name = "collectPurchase";
            collectPurchase.Size = new Size(180, 73);
            collectPurchase.TabIndex = 39;
            collectPurchase.Text = "Collect All";
            collectPurchase.UseVisualStyleBackColor = true;
            collectPurchase.Click += collectPurchase_Click;
            // 
            // orderZone
            // 
            orderZone.Controls.Add(cancelComplete);
            orderZone.Controls.Add(cancelAll);
            orderZone.Controls.Add(label10);
            orderZone.Controls.Add(checkoutSave);
            orderZone.Controls.Add(confirmItems);
            orderZone.Controls.Add(orderSummary);
            orderZone.Controls.Add(Coke);
            orderZone.Controls.Add(label9);
            orderZone.Controls.Add(label8);
            orderZone.Controls.Add(pictureBox5);
            orderZone.Controls.Add(Tonys);
            orderZone.Controls.Add(label7);
            orderZone.Controls.Add(label6);
            orderZone.Controls.Add(pictureBox3);
            orderZone.Controls.Add(Mars);
            orderZone.Controls.Add(label5);
            orderZone.Controls.Add(label4);
            orderZone.Controls.Add(pictureBox2);
            orderZone.Controls.Add(label2);
            orderZone.Controls.Add(butterfinger);
            orderZone.Controls.Add(label1);
            orderZone.Controls.Add(pictureBox1);
            orderZone.Controls.Add(listBox1);
            orderZone.Location = new Point(12, 116);
            orderZone.Name = "orderZone";
            orderZone.Size = new Size(917, 900);
            orderZone.TabIndex = 40;
            orderZone.TabStop = false;
            orderZone.Text = "Order Zone";
            orderZone.Enter += orderZone_Enter;
            // 
            // cancelComplete
            // 
            cancelComplete.Location = new Point(545, 733);
            cancelComplete.Name = "cancelComplete";
            cancelComplete.Size = new Size(208, 52);
            cancelComplete.TabIndex = 28;
            cancelComplete.Text = "Cancel All";
            cancelComplete.UseVisualStyleBackColor = true;
            cancelComplete.Click += cancelComplete_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 369);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 31);
            textBox1.TabIndex = 41;
            // 
            // vendyBox
            // 
            vendyBox.Controls.Add(textBox1);
            vendyBox.Controls.Add(pictureBox4);
            vendyBox.Controls.Add(speakVendy);
            vendyBox.Location = new Point(961, 128);
            vendyBox.Name = "vendyBox";
            vendyBox.Size = new Size(362, 888);
            vendyBox.TabIndex = 42;
            vendyBox.TabStop = false;
            vendyBox.Text = "Vendy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 1570);
            Controls.Add(vendyBox);
            Controls.Add(orderZone);
            Controls.Add(paymentZone);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)twoPound).EndInit();
            ((System.ComponentModel.ISupportInitialize)onePound).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiftyP).EndInit();
            ((System.ComponentModel.ISupportInitialize)twentyP).EndInit();
            ((System.ComponentModel.ISupportInitialize)tenP).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiveP).EndInit();
            ((System.ComponentModel.ISupportInitialize)twoP).EndInit();
            ((System.ComponentModel.ISupportInitialize)oneP).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentBox).EndInit();
            paymentZone.ResumeLayout(false);
            orderZone.ResumeLayout(false);
            orderZone.PerformLayout();
            vendyBox.ResumeLayout(false);
            vendyBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
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
        private Button confirmItems;
        private Button checkoutSave;
        private Label label10;
        private Button cancelAll;
        private PictureBox twoPound;
        private PictureBox onePound;
        private PictureBox fiftyP;
        private PictureBox twentyP;
        private PictureBox tenP;
        private PictureBox fiveP;
        private PictureBox twoP;
        private PictureBox oneP;
        private PictureBox paymentBox;
        private Label change;
        private Label finalAmount;
        private GroupBox paymentZone;
        private GroupBox orderZone;
        private Button cancelComplete;
        private TextBox textBox1;
        private GroupBox vendyBox;
        private Button collectPurchase;
    }
}
