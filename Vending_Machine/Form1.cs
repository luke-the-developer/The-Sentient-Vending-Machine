//planning notes

//1.[COMPLETE] Create lots of click buttons for each product and include price  [COMPLETE]
//2. Add a remove button to get rid of items from list box and then update total price in order summary 
//3. [COMPLETE] build ability to cancel all items and order. place this in a cancel button in order zone area [COMPLETE]
// Add cancellation to the first listbox - either drag drop or individual remove for each item
//4. [COMPLETE] add functionality to add each item to list box once selected and display it in list box [COMPLETE]
//5. A paid receipt or summary shows the list of products and saves to a text file after items are paid for
//6. [COMPLETE] Set the checkout button to freeze everything but payment zone. Use groups/read only to stop adding more items [COMPLETE]
//7. [COMPLETE]Add a function to group same items together display quantity and then show in order summary also totaling the price with each item added [COMPLETE]
//8. Work out calculations for total price amount of items then display in total checkout area under amount due. Coins entered lowers amount. (functions moneyPaid) 
//9.[COMPLETE] Add a drag drop function to allow money to be inserted into the vending machine [COMPLETE]
//10.Work out how to disable coins and drag drop in checkout area but then activate coins and slot once checkout button is clicked.
//11. [COMPLETE] Add a total label and running total of all products so far [COMPLETE]
//12. Add a label or messagebox which displays change from payment made and then resets the machine to start again.
//13. Add drag drop function from list box to drag items from first list box into rubbish bin
//14. Add a class, dictionary and list for the extra Vendy feature. Make a game or feature where user can win a prize or get a random product. Incorporate radio buttons and other controls I have not used so far
//15. Add a useful label displaying most recent action of the user
// this could be for answering questions or making choices. Could add a hacking feature of the vending machine, such as a number code guess for assembly and opcode manipulation

//EXTRA. extra create a chat option - sentience feature (if user just wants a chat). also can build in logic to choose products
//this could be a rand operator - nested inf statements on a loop. a random product selector implying the machine is sentient
//could have a built in game function - sentient vending machine asks if you wanna play a game - can win prizes

// Vendy To Do List
// 1. clean up dictionary and list
// 2. imporve the game with more questions and a score
// 3. add the prizes and show this on the design 
// 4. finish  extra functions on a win or lose and play again. 
//5. add radio buttons or checkboxes to the different parts of the vendy prizes so user can choose a mystery prize from good or bad pile pending on their score


using System.Collections.Specialized;
using System.Numerics;
using System.Security.Policy;


namespace Vending_Machine
{
    public partial class Form1 : Form
    {

        Checkout checkout = new Checkout(); // I will use this to call separate functions built in the checkout class to calculate the amount due, money paid and change
        
        Sentientvendy sentient = new Sentientvendy(); //vendy extra feature

        Dictionary<string, Product> vendingProducts = new Dictionary<string, Product>();

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

            paymentBox.AllowDrop = true;
            paymentZone.Enabled = false;
            cancelComplete.Enabled = false;

            addProducts(); //function to add products to dictionary for vending machine

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

        // amount of stock available in vending machine
        const int butterfingerQuantity = 20;
        const int marsQuantity = 20;
        const int tonysQuantity = 20;
        const int cokeQuantity = 20;


        // function to add quantity of items, group them and calculate price for order summary. I Call this function in the confirm items (finish button) click event
        //experiment here with a list of items from tutorial and can use a dictionary to store. 
        private void calculateOrderSummary()
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

            foreach (string product in listBox1.Items)
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
            MessageBox.Show("Butterfinger added to your order");  // Confirms user selected the butterfinger 
            totalPrice += butterfingerPrice;  // Updates the total price with the price of the butterfinger using assignment operator
        }
        private void Mars_Click(object sender, EventArgs e)
        {

            double marsPrice = vendingProducts["Mars"].getPrice();

            //variable for amount inside vending machine
            listBox1.Items.Add("Mars " + marsPrice.ToString("£0.00"));
            MessageBox.Show("Mars added to your order");
            totalPrice += marsPrice;

            // group more than one of the same item together and then display this in the list box
        }

        private void Tonys_Click(object sender, EventArgs e)
        {
            double tonysPrice = vendingProducts["Tony's"].getPrice();

            listBox1.Items.Add("Tony's " + tonysPrice.ToString("£0.00"));
            MessageBox.Show("Tony's added to your order");//confirms  user selected Tony's chocolonely
            totalPrice += tonysPrice;
        }

        private void Coke_Click(object sender, EventArgs e)
        {
            double cokePrice = vendingProducts["Coke"].getPrice();

            listBox1.Items.Add("Coke " + cokePrice.ToString("£0.00"));
            MessageBox.Show("Coke Selected"); // confirms user selected a can of coke
            totalPrice += cokePrice;

        }

        private void orderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkoutSave_Click(object sender, EventArgs e)
        {
            //opens the box below for the user to pay
            //function in here to disable the buttons for ordering products and open payment box for inserting the coins

            disableOrderZone();

            paymentZone.Visible = true;
            paymentZone.Enabled = true;
            paymentBox.Visible = true;
            paymentBox.Enabled = true;

            finalAmount.Text = "Total Amount: " + totalPrice.ToString("£0.00");

        }

        private void cancelAll_Click(object sender, EventArgs e)
        {
            //asks user if they are sure they want to cancel and remove all 

            MessageBox.Show("WARNING! So you definitely want to cancel?\n\n This will remove all items\n\n Press Cancel All to remove all items");

            // enable the Cancel All button so the user can click this button

            cancelComplete.Enabled = true;

        }

        private void confirmItems_Click(object sender, EventArgs e)
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

        // checkout.moneyPaid(totalCoinsInserted, totalPrice); 

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
            }

        }

        private void change_Click(object sender, EventArgs e)
        {
            changeDue = checkout.getChangeDue();

            change.Text = "Change: " + changeDue.ToString("£0.00");
        }

        private void collectPurchase_Click(object sender, EventArgs e)
        {
            // extra function for saving order summary to text file to be inserted here

            // this resets the vending machine after the use has collected their items and change

            listBox1.Items.Clear();
            orderSummary.Items.Clear();
            
            //reset finalamount label
            change.Text = "Change: £0.00";
            finalAmount.Text = "Total Amount: " + totalPrice.ToString("£0.00") + "\nMoney paid: " + moneyPaid.ToString("£0.00") + "\nAmount Remaining: " + totalPrice.ToString("£0.00") + "\nChange Due: " + changeDue.ToString("£0.00");
            label10.Text = "Total Price: " + totalPrice.ToString("£0.00");
            totalPrice = 0.00;


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
                Sentientvendy.VendyGameQuestions();
            }

            else
            {
                MessageBox.Show("That's okay, maybe next time.");
            }



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

    public class Checkout // keeping payment functions separate for security
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

        
        public void deductStock()
        {
            //this function is called to deduct the stock of items in vending machine and sends a notification to owner when stock is low



            //provide a saved text file of each purchase and amount paid

        }
    }

    public class Sentientvendy
    {

        //this is the vendy class - it will contain a dictionary of products, a game and a prize.
        //this class will be called when a person clicks the speak to vendy button
        //it will contain more advanced code and experiment with extra c# features; radio buttons, check boxes, list and dictionary

        //create a dictionary to store contacts

        public static void VendyGameQuestions()
        {

            Dictionary<string, bool> questions = new Dictionary<string, bool>();

            questions.Add("Is quantum mechanics a spooky action at a distance?", true);
            questions.Add("Can Einstein float?", false);
            questions.Add("Is the speed of light faster than the speed of sound?", true);
            questions.Add("Does Isaac Asimov have laws?", true);
            questions.Add("Is Everett's many worlds interpretation a theory of parallel universes?", true);
            questions.Add("Is Werner Heisenberg certain about the position and momentum of a particle?", false);

            //score - 1 point for a correct answer, 0 points for it being incorrect

            int questionScore = 0;

            //display the dictionary contents

            //foreach (KeyValuePair<string, bool> question in questions)
            //{
            //    //ask a question
            //    DialogResult answer = MessageBox.Show(question.Key, "Vendy asks, true or false?", MessageBoxButtons.YesNo);

            //    // check answer

            //    if ((answer == DialogResult.Yes && question.Value == true) || (answer == DialogResult.No && question.Value == false))
            //    {
            //        MessageBox.Show("Correct! Vendy is impressed. Well done!");
            //        questionScore++;
            //    }


            //    // this is the Tkey and Tvalue of the dictionary
            //    MessageBox.Show("Question: " + question.Key + ", Answer: " + question.Value);
            
        }

        public static void VendyHappy() //vendy gets creepy and starts insist the player gives their contact details so they can play from home
        {

       

        }

        public static void VendyAngry() //vendy gets creepy and starts insist the player gives their contact details so they can play from home
        {



        }


    }

}
