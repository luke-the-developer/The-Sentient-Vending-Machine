//planning notes

//1. Create lots of click buttons for each product and include price  [COMPLETE]
//3. build ability to remove items from the list box or cancel all items from the list box
//4. add functionality to add each item to list box once selected and display it in list box [COMPLETE]
//5. order summary shows the list of products and saves to a text file
//6. Set the checkout button to freeze everything but payment zone
//7. Add a function to group same items together display quantity and then show in order summary also totaling the price with each item added (function calculateOrderSummary)
//8. Work out calculations for total price amount of items then display in total checkout area under amount due. Coins entered lowers amount. (functions moneyPaid) 
//9. Add a drag drop function to allow money to be inserted into the vending machine [COMPLETE]

//EXTRA. extra create a chat option - sentience feature (if user just wants a chat). also can build in logic to choose products
        //this could be a rand operator - nested inf statements on a loop. a random product selector implying the machine is sentient
        //could have a built in game function - sentient vending machine asks if you wanna play a game - can win prizes

using System.Collections.Specialized;
using System.Numerics;
using System.Security.Policy;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        // add more classes such as basket for items selected and a checkout class holding payment methods
        // private Checkout checkout = new Checkout(); // this allows access to the checkout class and variables contained to this form1

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

        }

        //price of the products

        const double butterfingerPrice = 1.50;
        const double marsPrice = 1.40;
        const double tonysPrice = 1.60;
        const double cokePrice = 1.20;

        double totalPrice = 0.00; // this holds the total price which will be caluclated for all items chosen

        // amount of stock available in vendy
        //will need to deduct the stock amount and give calculation for amount left in vending machine
        const int butterfingerQuantity = 20;
        const int marsQuantity = 20;
        const int tonysQuantity = 20;
        const int cokeQuantity = 20;


        // function to add quantity of items, group them and calculate price for order summary. I Call this function in the confirm items (finish button) click event
        //experiment here with a list of items from tutorial and can use a dictionary to store. 
        private void calculateOrderSummary()
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void butterfinger_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("Butterfinger " + butterfingerPrice.ToString("£0.00")); // Add the butterfinger to the list box and update the total price
            MessageBox.Show("Butterfinger added to your order");  // Confirms user selected the butterfinger 
            totalPrice += butterfingerPrice;  // Updates the total price with the price of the butterfinger using assignment operator

            // group or sort more than one of the same item together and then display this in the list box

            // check stock

            int tonysChosen = 0;

        }

        private void Mars_Click(object sender, EventArgs e)
        {
            //variable for amount inside vending machine

            listBox1.Items.Add("Mars " + marsPrice.ToString("£0.00"));
            MessageBox.Show("Mars added to your order");
            totalPrice += marsPrice;

            // group more than one of the same item together and then display this in the list box

            int marsChosen = 0;

        }

        private void Tonys_Click(object sender, EventArgs e)
        {


            listBox1.Items.Add("Tony's " + tonysPrice.ToString("£0.00"));
            MessageBox.Show("Tony's added to your order");//confirms  user selected Tony's chocolonely
            totalPrice += tonysPrice;


          

        }

        private void Coke_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Coke" + cokePrice.ToString("£0.00"));
            MessageBox.Show("Coke Selected"); // confirms user selected a can of coke
            totalPrice += cokePrice;

        }

        private void speakVendy_Click(object sender, EventArgs e)
        {
            //conversation with vendy with choices which culminates in a game and a prize if user wins
            //use rand() for: game, a prize of a random product select


        }

        private void orderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This prints stored items in a list as a summary. Add up the total price of items in the list and displays after finish is clicked



        }

        private void checkoutSave_Click(object sender, EventArgs e)
        {
            //opens the box below for the user to pay
        }

        private void cancelAll_Click(object sender, EventArgs e)
        {
            //asks user if they are sure they want to cancel and remove all 

            MessageBox.Show("WARNING! So you definitely want to cancel?\n\n This will remove all items ");

            //this allows the user to remove all items regardless of what they selected and how far along they are

        }

        private void confirmItems_Click(object sender, EventArgs e)
        {



        }

     
        //these are the drag drop functions to allow the insert of money into the machine
        private void twoPound_mouseDown(object sender, MouseEventArgs e)
        {

            twoPound.DoDragDrop(twoPoundCoin.ToString(), DragDropEffects.Copy);

            MessageBox.Show("You have inserted £2.00");
        }

        private void onePound_mouseDown(object sender, MouseEventArgs e)
        {

            onePound.DoDragDrop(onePoundCoin.ToString(), DragDropEffects.Copy);

            MessageBox.Show("You have inserted £1.00");
        }

        private void fiftyP_mouseDown(object sender, MouseEventArgs e)
        {

            fiftyP.DoDragDrop(fiftyPCoin.ToString(), DragDropEffects.Copy);
            MessageBox.Show("You have inserted 0.50");
        }

        private void twentyP_mouseDown(object sender, MouseEventArgs e)
        {
            twentyP.DoDragDrop(twentyPCoin.ToString(), DragDropEffects.Copy);

            MessageBox.Show("You have inserted 0.20");
        }

        private void tenP_mouseDown(object sender, MouseEventArgs e)
        {

            tenP.DoDragDrop(tenPCoin.ToString(), DragDropEffects.Copy);
            MessageBox.Show("You have inserted £0.10");
        }

        private void fiveP_mouseDown(object sender, MouseEventArgs e)
        {
            fiveP.DoDragDrop(fivePCoin.ToString(), DragDropEffects.Copy);
            MessageBox.Show("You have inserted £0.05");
        }

        private void twoP_mouseDown(object sender, MouseEventArgs e)
        {
            twoP.DoDragDrop(twoPCoin.ToString(), DragDropEffects.Copy);
            MessageBox.Show("You have inserted £0.02");
        }

        private void oneP_mouseDown(object sender, MouseEventArgs e)
        {
            oneP.DoDragDrop(onePCoin.ToString(), DragDropEffects.Copy);
            MessageBox.Show("You have inserted £0.01");
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paymentBox.AllowDrop = true;
        }

       

     
    }

    public class Checkout
    {

        public void moneyPaid() // calculates the money paid by user from coins inserted 
        {
        
        }

        private void calculateChange()
        {

        }


     
    }
}
