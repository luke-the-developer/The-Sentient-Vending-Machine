// Vending Machine 

using System.Collections.Specialized;
using System.Collections.Generic; 
using System.Net;
using System.Security.Policy;  
using System.Linq; 



namespace Vending_Machine
{
    public partial class Form1 : Form
    {

        Checkout checkout = new Checkout(); // this calls separate functions built in the checkout class to calculate the amount due, money paid and change

        Sentientvendy vendy = new Sentientvendy(); //vendy class extra feature

        Dictionary<string, Product> vendingProducts = new Dictionary<string, Product>(); //Dictionary for product names

        // coins for vending machine set as const so value can not be changed
        const double onePoundCoin = 1.00;
        const double twoPoundCoin = 2.00;
        const double tenPCoin = 0.10;
        const double fivePCoin = 0.05;
        const double twentyPCoin = 0.20;
        const double fiftyPCoin = 0.50;
        const double onePCoin = 0.01;
        const double twoPCoin = 0.02;

        double moneyPaid = 0.00;
        double changeDue = 0.00;
        string coinsInserted = "";
        double totalCoinsInserted = 0.00;


        public Form1()
        {
            InitializeComponent();

            paymentBox.AllowDrop = true; //to allow payment drag drop
            rubbishBin.AllowDrop = true; //to allow removal of items from list into bin
            paymentZone.Enabled = false;
            cancelComplete.Enabled = false;
            vendyBox.Enabled = false;

            addProducts(); //add products to dictionary for vending machine

        }

        //function for dictionary to hold product names, prices and quantity. This will be used to display the products in the vending machine
        void addProducts()
        {
            vendingProducts.Add("Butterfinger", new Product("Butterfinger", 1.50, 20));
            vendingProducts.Add("Mars", new Product("Mars", 1.40, 20));
            vendingProducts.Add("Tony's", new Product("Tony's", 1.60, 20));
            vendingProducts.Add("Coke", new Product("Coke", 1.20, 20));
        }

        double totalPrice = 0.00; // this holds the total price which will be caluclated for all items chosen. this is displayed at end of order

        private void calculateOrderSummary() //calculates all orders placed into order sumamry list box
        {
            orderSummary.Items.Clear();

            // getters from product class

            double butterfingerPrice = vendingProducts["Butterfinger"].getPrice();  //uses dictionary example 1 
            double marsPrice = vendingProducts["Mars"].getPrice();
            double tonysPrice = vendingProducts["Tony's"].getPrice();
            double cokePrice = vendingProducts["Coke"].getPrice();

            // calculate the total price of the items in the listbox1 using the dictionary and product class

            int butterfingerChosen = 0;
            int marsChosen = 0;
            int tonysChosen = 0;
            int cokeChosen = 0;

            foreach (string product in listBox1.Items) //foreach loop counts amount of each item in listbox1
            {
                if (product.Contains("Butterfinger "))
                {
                    butterfingerChosen++;
                }
                else if (product.Contains("Mars "))
                {
                    marsChosen++;
                }

                else if (product.Contains("Tony's "))
                {
                    tonysChosen++;
                }
                else if (product.Contains("Coke "))
                {
                    cokeChosen++;
                }
            }

            // this calculates the total price of the items selected

            double marsTotal = marsChosen * marsPrice;
            double butterfingerTotal = butterfingerChosen * butterfingerPrice;
            double tonysTotal = tonysChosen * tonysPrice;
            double cokeTotal = cokeChosen * cokePrice;

            totalPrice = marsTotal + butterfingerTotal + tonysTotal + cokeTotal;

            // this displays the full order in the order summary list box with amount and price

            if (butterfingerChosen > 0)
            {
                orderSummary.Items.Add("Butterfinger x " + butterfingerChosen + " - " + butterfingerTotal.ToString("£0.00")); //price at 0.00 waiting for calculation of total price for each item
            }

            if (marsChosen > 0)
            {
                orderSummary.Items.Add("Mars x " + marsChosen + " - " + marsTotal.ToString("£0.00"));
            }

            if (tonysChosen > 0)
            {
                orderSummary.Items.Add("Tony's x " + tonysChosen + " - " + tonysTotal.ToString("£0.00"));
            }
            if (cokeChosen > 0)
            {
                orderSummary.Items.Add("Coke x " + cokeChosen + " - " + cokeTotal.ToString("£0.00"));
            }

        }

        void DisplayTotalPrice()
        {
            label10.Text = "Total Price: " + totalPrice.ToString("£0.00"); // this displays total price in the total label
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // click events for each product
        private void butterfinger_Click(object sender, EventArgs e)
        {

            //add product name to list of products and uses a getter to get price from product class in dictionary          
            double butterfingerPrice = vendingProducts["Butterfinger"].getPrice(); // gets the butterfinger from vendingProducts dictionary and also uses getprice getter to get the price

            listBox1.Items.Add("Butterfinger " + butterfingerPrice.ToString("£0.00")); // Add the butterfinger to the list box and update the total price
            totalPrice += butterfingerPrice;  // Updates the total price with the price of the butterfinger using assignment operator
        }
        private void Mars_Click(object sender, EventArgs e)
        {

            double marsPrice = vendingProducts["Mars"].getPrice();

            listBox1.Items.Add("Mars " + marsPrice.ToString("£0.00"));
            totalPrice += marsPrice;
        }

        private void Tonys_Click(object sender, EventArgs e)
        {
            double tonysPrice = vendingProducts["Tony's"].getPrice();

            listBox1.Items.Add("Tony's " + tonysPrice.ToString("£0.00"));
            totalPrice += tonysPrice;
        }

        private void Coke_Click(object sender, EventArgs e)
        {
            double cokePrice = vendingProducts["Coke"].getPrice();

            listBox1.Items.Add("Coke " + cokePrice.ToString("£0.00"));
            totalPrice += cokePrice;

        }

        private void orderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkoutSave_Click(object sender, EventArgs e)
        {
            //function in here to disable the buttons for ordering products and open payment box for inserting the coins

            disableOrderZone();

            paymentZone.Visible = true; // payment zone made visible if visibility is ever set to false in properties
            paymentZone.Enabled = true;
            paymentBox.Visible = true;
            paymentBox.Enabled = true;

            finalAmount.Text = "Total Amount: " + totalPrice.ToString("£0.00");

        }


        private void cancelAll_Click(object sender, EventArgs e)
        {
            //asks user if they are sure they want to cancel and remove all 

            MessageBox.Show("WARNING! So you definitely want to cancel?\n\n This will remove all items\n\n Press Cancel All to remove all items");

            // this enables the Cancel All button so the user can click this button

            cancelComplete.Enabled = true;
        }

        //These are dragdrop events to remove an item from listbox1 and drag to rubbish bin to remove it from first list box

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.DoDragDrop(listBox1.SelectedItems.ToString(), DragDropEffects.Move);

                listBox1.Items.Remove(listBox1.SelectedItem); //removes the selected item from the listbox1
            }
        }

        private void rubbishBin_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void rubbishBin_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.SelectedItems.Remove(listBox1.SelectedItems);
        }


        private void confirmItems_Click(object sender, EventArgs e) // this is the finish button on vending machine to confirm order
        {

            calculateOrderSummary(); //calling this to calculate order summary and display in that list box
            DisplayTotalPrice(); // after clicking the finish box this displays the total user owes for their items
        }

        //these are the drag drop functions to allow the insert of money into the machine
        private void twoPound_mouseDown(object sender, MouseEventArgs e)
        {

            twoPound.DoDragDrop(twoPoundCoin.ToString(), DragDropEffects.Copy);

        }

        private void onePound_mouseDown(object sender, MouseEventArgs e)
        {

            onePound.DoDragDrop(onePoundCoin.ToString(), DragDropEffects.Copy);

        }
        private void fiftyP_mouseDown(object sender, MouseEventArgs e)
        {

            fiftyP.DoDragDrop(fiftyPCoin.ToString(), DragDropEffects.Copy);

        }

        private void twentyP_mouseDown(object sender, MouseEventArgs e)
        {
            twentyP.DoDragDrop(twentyPCoin.ToString(), DragDropEffects.Copy);

        }

        private void tenP_mouseDown(object sender, MouseEventArgs e)
        {

            tenP.DoDragDrop(tenPCoin.ToString(), DragDropEffects.Copy);

        }

        private void fiveP_mouseDown(object sender, MouseEventArgs e)
        {
            fiveP.DoDragDrop(fivePCoin.ToString(), DragDropEffects.Copy);

        }

        private void twoP_mouseDown(object sender, MouseEventArgs e)
        {
            twoP.DoDragDrop(twoPCoin.ToString(), DragDropEffects.Copy);

        }

        private void oneP_mouseDown(object sender, MouseEventArgs e)
        {
            oneP.DoDragDrop(onePCoin.ToString(), DragDropEffects.Copy);

        }

        private void paymentBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void paymentBox_DragDrop(object sender, DragEventArgs e)
        {
            // get the value of the coin that was dropped into the payment box using coinsinserted variable

            string coinsInserted = (string)e.Data.GetData(DataFormats.StringFormat); //use stringformat from example2.
                                                                                     //could also use this to pass a file path to text file to save order summary

            //the total amount of coins inserted is calculated 
            totalCoinsInserted = double.Parse(coinsInserted); //parse the string to a double so i can do calculations for change owed

            if (double.TryParse(coinsInserted, out double coinValue))
            {
                checkout.moneyPaid(coinValue); //uses a checkout class function to calculate total coins inserted 

                PaymentDisplay(); // displays total paid, amount due and change due using the checkout class getters
            }
        }

        private void PaymentDisplay() // this displays coins entered in payment to vending machinecalculates amount due and change using checkout class functions
        {

            //calculate amount due and change

            checkout.amountDue(totalPrice);
            checkout.calculateChange(totalPrice);


            // calling in checkout class functions getters
            double totalPaid = checkout.getMoneyPaid();
            double amountDue = checkout.getAmountDue();
            double changeDue = checkout.getChangeDue();

            //displays each amount in payment box so user can see running totals
            finalAmount.Text = "Total Amount: " + totalPrice.ToString("£0.00") + "\nMoney paid: " + moneyPaid.ToString("£0.00") + "\nAmount Remaining: " + amountDue.ToString("£0.00") + "\nChange Due: " + changeDue.ToString("£0.00");

        }

        // drag drop to remove items from list box 1 into a bin. This feature will allow removal of each individual item

        private void Form1_Load(object sender, EventArgs e)
        {
            paymentBox.AllowDrop = true;
        }

        private void disableOrderZone()
        {
            //this function disables the buttons for ordering products and then opens the payment box for inserting coins. called when checkout button clicked
            // place this function in the checkout button click event that activates the payment  box

            if (checkoutSave.Enabled == true)
            {
                butterfinger.Enabled = false;
                Mars.Enabled = false;
                Tonys.Enabled = false;
                Coke.Enabled = false;
                speakVendy.Enabled = false;
                confirmItems.Enabled = false;
            }
        }

        private void restart() // this restarts the vending machine for a new user
        {
            totalPrice = 0.00;

            checkout.resetCheckout();

            checkoutSave.Enabled = true;
            butterfinger.Enabled = true;
            Mars.Enabled = true;
            Tonys.Enabled = true;
            Coke.Enabled = true;
            speakVendy.Enabled = true;
            confirmItems.Enabled = true;
            paymentZone.Enabled = false;

            //clear all of order zone and payment zone to reset vending machine for a new user

            listBox1.Items.Clear();
            orderSummary.Items.Clear();

            finalAmount.Text = "Total Amount: " + totalPrice.ToString("£0.00") + "\nMoney paid: " + moneyPaid.ToString("£0.00") + "\nAmount Remaining: " + totalPrice.ToString("£0.00") + "\nChange Due: " + changeDue.ToString("£0.00");
            label10.Text = "Total Price: " + totalPrice.ToString("£0.00");

            label10.Text = "Total Price: £0.00";
            change.Text = "Change: £0.00";

        }

        private void orderZone_Enter(object sender, EventArgs e)
        {
        }

        private void paymentZone_Enter(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e) //click event indexer case totalPrice doesnt auto show then user can click for it
        {

            //this uses the total price variable from the price of the items  selected 
            label10.Text = "Total Price: " + totalPrice.ToString("£0.00");
        }

        private void finalAmount_Click(object sender, EventArgs e) //click event in case amount doesnt show 
        {
            //this displays the various running totals so a user can click to display them if it doesnt show automatically
            PaymentDisplay();

        }

        private void cancelComplete_Click(object sender, EventArgs e)
        {

            if (cancelComplete.Enabled == true)
            {
                listBox1.Items.Clear();
                orderSummary.Items.Clear();
                MessageBox.Show("All items removed from order summary. Come back soon!");
                restart(); // this resets the vending machine for a new user
            }

        }

        private void change_Click(object sender, EventArgs e)
        {
            changeDue = checkout.getChangeDue();

            change.Text = "Change: " + changeDue.ToString("£0.00");
        }

        private void noStealing()
        {
            // this is a function to stop users from stealing items from the vending machine. It will check if the user has paid enough and if not it will display a message and reset the machine
            if (checkout.getAmountDue() > 0)
            {
                MessageBox.Show("You have not paid enough for your items. \n\n Thief!!! \n\n" +
                    "Vendy has caught you lifting items\n\n Vendy knows your face, your gait and can give a good description" +
                    "\n Vendy's robot fleet is on its way");

                listBox1.Items.Clear();
                Application.Restart(); // this restarts the vending machine. Can also make this exit if needed by using Exit() instead

            }
            else if (checkout.getMoneyPaid() == totalPrice)
            {
                MessageBox.Show("Thank you for your purchase.\n\nVendy is happy you have paid the correct amount");
            }

            else if (checkout.getMoneyPaid() > totalPrice)
            {
                MessageBox.Show("Thank you for your purchase. \n\nVendy is happy you have paid the correct amount");
            }

        }

        private void collectPurchase_Click(object sender, EventArgs e)
        {

            displayPurchases();

            exitGame.Enabled = true; // this allows user to exit after submitting details to claim their prize


            noStealing(); //checks the user has paid for their items and if not closes the vending machine

            MessageBox.Show("Please collect your items and change. \n\n" +
                "Before you go you need to speak to Vendy \n\n Just press 'speak to vendy' : ) \n\n you won't regret it!");

            vendyBox.Enabled = true; // this enables the speak to vendy button so user can click it again
            speakVendy.Enabled = true; // this enables the speak to vendy button so user can click it again


            disableVendyPrizeZone(); // this disables the prize zone so user can only click it once
        }

        //extra feature of sentient vending machine called Vendy. uses extra functionality researched
        private void speakVendy_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hi, I am Vendy, a sentient vending machine.\n\nI store anything from sweet treats to the deepest knowledge of the universe");

            string message = " \nDo you want to play a game with me?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, "Vendy", buttons);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Great stuff! Let's play a game of true and false.");


                // call vendyGame questions method
                vendy.VendyGameQuestions();
                restart();
                // work out score

                //display the player score and give instructions on claiming prizes
                MessageBox.Show("If you scored 7 or more you can claim a special prize from Vendy by pressing the blue button \n\n If between 5 and 7 a consolation prize by pressing the red button \n\n 1 to 5 you will need to play again");
                MessageBox.Show("Scores on the doors! \n\n You scored: " + vendy.getQuestionScore());

                if (vendy.getQuestionScore() >= 7)
                {
                    collectPrize.Enabled = true; // enables prize collect button
                }
                else if (vendy.getQuestionScore() >= 5 && vendy.getQuestionScore() < 7)
                {
                    //red collect prizes button is enabled

                    collectBoobyPrize.Enabled = true; // enables booby prize collect button
                    collectPrize.Enabled = false; // disables prize collect button
                    playAgain.Enabled = true;
                    speakVendy.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vendy strongly suggests you play again to win a prize. \n Press play again to have another go");

                    playAgain.Enabled = true; // this allows loser to play again to win a prize
                    speakVendy.Enabled = false;
                }
            }

            else
            {
                MessageBox.Show("hmmm, are you sure? Vendy thinks you should play");

                MessageBoxButtons dontLeave = MessageBoxButtons.YesNo;

                DialogResult leave = MessageBox.Show("Are you sure you want to leave? \n\n Vendy thinks you should play", "Vendy", dontLeave);

                if (leave == DialogResult.Yes)
                {
                    MessageBox.Show("Vendy is disappointed you do not want to play a game. \n Be aware vendy has a memory and feelings" +
                        "\n\n Vendy also has eyes and knows who you are.");
                    restart();
                }
                else
                {
                    MessageBox.Show("Vendy is happy you want to play a game. \n\n Press Speak to Vendy to start the game");
                }
            }
        }

        private void disableVendyPrizeZone()
        {
            //this controls the enable and disabling of Vendy prize zone 

            if (collectPurchase.Enabled == true)
            {
                collectPrize.Enabled = false;
                collectBoobyPrize.Enabled = false;
                playAgain.Enabled = false;
                exitGame.Enabled = false;
                submitPersonalDetails.Enabled = false;
                mysteryPrize1.Enabled = false;
                mysteryPrize2.Enabled = false;
                mysteryPrize3.Enabled = false;
                boobyPrize1.Enabled = false;
                boobyPrize2.Enabled = false;
                boobyPrize3.Enabled = false;
            }
        }

        private void mysteryPrize1_CheckedChanged(object sender, EventArgs e)
        {


            if (mysteryPrize1.Checked)
            {
                MessageBox.Show("You have selected mystery prize 1. \n\n This is a night at the Ritz Hotel for 2! Well done! \n\n Vendy will send the booking to your email");

                mysteryPrize2.Enabled = false;
                mysteryPrize3.Enabled = false;
            }
        }

        private void mysteryPrize2_CheckedChanged(object sender, EventArgs e)
        {
            if (mysteryPrize2.Checked)
            {
                MessageBox.Show("You have selected mystery prize 2.\n\n Tickets for Defcon in Las Vegas!! Well done \n\n Vendy will send these to your email \n\n Viva Las vegas!\n\n Vendy is singing and is so happy for you");

                mysteryPrize1.Enabled = false;
                mysteryPrize3.Enabled = false;
            }
        }
        private void mysteryPrize3_CheckedChanged(object sender, EventArgs e)
        {
            if (mysteryPrize3.Checked)
            {
                MessageBox.Show("You have selected mystery prize 3.\n\n Wow! An autonomous mini cooper!\n\n Vendy will send this to your address");
                mysteryPrize1.Enabled = false;
                mysteryPrize2.Enabled = false;
            }
        }

        private void boobyPrize1_CheckedChanged(object sender, EventArgs e)
        {
            if (boobyPrize1.Checked)
            {
                MessageBox.Show("You have selected this prize.\n\n This is a long weight \n\n Vendy will send it to your address");
                boobyPrize2.Enabled = false;
                boobyPrize3.Enabled = false;
            }
        }

        private void boobyPrize2_CheckedChanged(object sender, EventArgs e)
        {

            if (boobyPrize2.Checked)
            {
                MessageBox.Show("You have selected this prize.\n\n Tartan paint \n\n Vendy will send it to your address");
                boobyPrize1.Enabled = false;
                boobyPrize3.Enabled = false;
            }
        }

        private void boobyPrize3_CheckedChanged(object sender, EventArgs e)
        {
            if (boobyPrize3.Checked)
            {
                MessageBox.Show("You have selected this prize. \n\n A left handed screwdriver \n\n Vendy will send it to you");
            }
        }

        private void collectPrize_Click(object sender, EventArgs e)
        {
            // this enables the user to select a prize 

            MessageBox.Show("Choose one prize from the list and Vendy will make sure it arrives");
            mysteryPrize1.Enabled = true; //enabling all prize options
            mysteryPrize2.Enabled = true;
            mysteryPrize3.Enabled = true;
            submitPersonalDetails.Enabled = true; // this activates the submit button so user can then submit their details
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            //this offers one play again option to those who have lost and not submitted details for a prize

            //reset score

            vendy.resetScore();

            if (playAgain.Enabled == true)
            {
                MessageBox.Show("Vendy is happy to play again. \n\n Press Speak to Vendy to have another go");

            }
            speakVendy.Enabled = true;
            submitPersonalDetails.Enabled = true;
            textName.Clear();
            textEmail.Clear();
            textMobile.Clear();
            textAddress.Clear();
            textPassword.Clear();

            collectPrize.Enabled = false;
            collectBoobyPrize.Enabled = false;
            mysteryPrize1.Enabled = false; //enabling all prize options
            mysteryPrize2.Enabled = false;
            mysteryPrize3.Enabled = false;
            boobyPrize1.Enabled = false;
            boobyPrize2.Enabled = false;
            boobyPrize3.Enabled = false;
        }

        private void exitGame_Click(object sender, EventArgs e)
        {

            //this is exit game button, only available to those who have won a prize and submitted details
            //clear all fields and reset game for new user

            textName.Clear();
            textEmail.Clear();
            textMobile.Clear();
            textAddress.Clear();
            textPassword.Clear();

            MessageBox.Show("Thankyou for playing Vendy. \n\n Vendy knows where you live. \n\n Make sure you come back soon!");
            Application.Exit(); // this closes the application
        }

        private void collectBoobyPrize_Click(object sender, EventArgs e)
        {

            // this allows user to select a booby prize

            MessageBox.Show("Choose one prize from the list quickly and play again");
            boobyPrize1.Enabled = true;
            boobyPrize2.Enabled = true;
            boobyPrize3.Enabled = true;
        }

        private void submitPersonalDetails_Click(object sender, EventArgs e) //this gets the user details then saves it to a text file in project folder textFiles
        {
            //read the input from user details submitted

            string outputMessage = "";

            string name = textName.Text;
            string emailAddress = textEmail.Text;
            string mobileNumber = textMobile.Text;
            string homeAddress = textAddress.Text;
            string password = textPassword.Text;

            //Process

            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(emailAddress) &&
                !string.IsNullOrEmpty(mobileNumber) &&
                !string.IsNullOrEmpty(homeAddress) &&
                !string.IsNullOrEmpty(password))
            {
                outputMessage = $"Information submitted\n\nName: {name}\nEmail: {emailAddress}\nMobile: {mobileNumber}\nAddress: {homeAddress}\nPassword: ********\n"; //string interpolation

                submitDetailsDisplay.Text = outputMessage;
                submitDetailsDisplay.Visible = true;
            }
            else
            {
                MessageBox.Show("Provide your full details to claim your prize!");
            }

            //write the details to a text file and save it to project folder

            bool fileAppend = true; // this is to append the file to not overwrite previous entries

            StreamWriter writer = new StreamWriter("C:\\Users\\Luke\\source\\repos\\Vending_Machine\\Vending_Machine\\Resources\\TextFiles\\userDetails.txt", true); //this is the path to textfiles folder to save the new text file

            string[] userEntry = { "\nName: " + name, "Email: " + emailAddress, "Mobile: " + mobileNumber, "Address: " + homeAddress, "Password: " + password, "\n" }; // array of labels for writing to text file

            foreach (string entry in userEntry)
            {
                writer.WriteLine(entry);
            }

            writer.Close();

            MessageBox.Show("Details submitted successfully. Vendy will make sure your prize is sent to you ; ) \n\n Thankyou for playing vendy");

            exitGame.Enabled = true; // this allows user to exit after submitting details to claim their prize
        }

        private void displayPurchases()
        {
            // this displays the purchases from the oprder sumamry list box in the label for user to view

            DateTime timeNow = DateTime.Now; //gives the current time to be able to identify each separate purchase
                purchaseDisplay.Text = "\nOrder date: " + timeNow + "\n";

                foreach (var item in orderSummary.Items)
                {
                    purchaseDisplay.Text += item.ToString() + "\n"; 
                }

            //save this to a text file

            bool fileAppend = true; // this is to append the file to not overwrite previous entries

            StreamWriter writer = new StreamWriter("C:\\Users\\Luke\\source\\repos\\Vending_Machine\\Vending_Machine\\Resources\\TextFiles\\userPurchases.txt", true); //this is the path to textfiles folder to save the new text file

            string[] itemsPurchased = { "\nItems ordered: " + purchaseDisplay.Text, "\n" };

            foreach (string purchase in itemsPurchased)
            {
                writer.WriteLine(purchase);
            }
            writer.Close();
        }

        private void purchaseDisplay_Click(object sender, EventArgs e) //click event in case purchases do not appear
        {
            displayPurchases();
        }
    }

    public class Product //using this class so I can use it in my dictionary for product names, price and quantity
    {
       private string name;
       private double price;
       private int quantity;

        public Product(string productName, double productPrice, int productQuantity) // this is a constructor for product class
        {
            name = productName;
            price = productPrice;
            quantity = productQuantity;
        }

        //getters for product class
        public string getName()
        {
            return name; // this is a pointer to name of product in the dictionary
        }

        public double getPrice()
        {
            return price;
        }

        public int getQuantity()
        {
            return quantity;
        }
    }

    public class Checkout // keeping payment functions separate for secure development practices
    {
        //uses private variables which can be accessed from the public getters in the main form class

        private double totalCoinsInserted = 0.00;
        private double amountRemaining = 0.00;
        private double totalPrice = 0.00;
        private double changeDue = 0.00;
        
        public void moneyPaid(double coinValue) //need to pass double coinvalue to this function then add to totalcoinsinserted to maintain a running total
        {
            totalCoinsInserted += coinValue;
        }

        public double getMoneyPaid() //gets the money paid
        {
            return totalCoinsInserted;
        }


        public void amountDue(double totalPrice) 
        {
            amountRemaining = totalPrice - totalCoinsInserted;       

        }

        public double getAmountDue()  //gets the amount due 
        {
            return amountRemaining;
        }

        public void calculateChange(double totalPrice) 
        {

            changeDue = totalCoinsInserted - totalPrice;

            if (changeDue < 0)
            {
                changeDue = 0.00; // if the user has not paid enough, change due is set to 0
            }

        }
        public double getChangeDue()  //gets the change due
        {
            return changeDue;
        }

        public void resetCheckout()
        {
            totalCoinsInserted = 0.00;
            amountRemaining = 0.00;
            totalPrice = 0.00;
            changeDue = 0.00;
        }
    }

    public class Sentientvendy //class for the extra vendy feature
    {
        private int questionScore = 0;
        private double totalScore = 0.0;

        public int getQuestionScore() //this is a getter so i can access question score from main form
        {
            return questionScore;
        }

        public void resetScore()
        {
            questionScore = 0;
        }

        public double getTotalScore()
        {
            return totalScore;
        }

        public void VendyGameQuestions()
        {

            Dictionary<string, bool> questions = new Dictionary<string, bool>();

            questions.Add("Is quantum mechanics a spooky action at a distance?\n\n", true);
            questions.Add("Can Einstein float?\n\n", false);
            questions.Add("Is the speed of light faster than the speed of sound?\n\n", true);
            questions.Add("Does Isaac Asimov have laws?", true);
            questions.Add("Is Everett's many worlds interpretation a theory of parallel universes?\n\n", true);
            questions.Add("Is Werner Heisenberg certain about the position and momentum of a particle?\n\n", false);
            questions.Add("Is the Schrodinger equation a fundamental equation of quantum mechanics?\n\n", true);
            questions.Add("Is the Copenhagen interpretation a theory of quantum mechanics?\n\n", true);
            questions.Add("If a cat is in a box, is it both alive and dead at the same time?\n\n", true);
            questions.Add("Can neural networks offer sentience to a vending machine?\n\n", true);

            // score 1 point for a correct answer, 0 points for it being incorrect

            foreach (var question in questions)
            {

                //ask a question
                DialogResult answer = MessageBox.Show(question.Key, "Vendy asks, true or false?", MessageBoxButtons.YesNo);

                // check answer

                if ((answer == DialogResult.Yes && question.Value == true) || (answer == DialogResult.No && question.Value == false))
                {
                    MessageBox.Show("Correct! Vendy is impressed. Well done!");
                    questionScore++;
                }

                else
                {
                    MessageBox.Show("Incorrect! Vendy is disappointed. Better luck next time.");
                }
            }
        }

        //These are placeholders for extra chat functions for Vendy feature
        public static void VendyHappy() 
        {
            // this function is the best prize and allows user select a list of prizes

            MessageBox.Show("Bravo! Clap clap, you have won a prize from Vendy! \n\n Select a prize from the list below and Vendy will send it to your address");

        }

    }

}
