//planning notes

//1. Create lots of click buttons for each product and include price  [COMPLETE]
//2. build ability to add product to the items added once clicked the choose me button.
//3. build ability to remove items from the list box
//4. deduct selections from quantity in machine. Include bool to assess if product is empty or full and subtract quantity from the stock once purchase is made
//5. add functionality to add each item to list box once selected and display it in list box
//6. order summary shows the list of products and saves to a text file
//7. Set the checkout button to freeze everything but payment zone

//EXTRA. extra create a chat option - sentience feature (if user just wants a chat). also can build in logic to choose products
        //this could be a rand operator - nested inf statements on a loop. a random product selector implying the machine is sentient
        //could have a built in game function - sentient vending machine asks if you wanna play a game - can win prizes

using System.Collections.Specialized;
using System.Numerics;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // This will display items selected and once user finished they will click on checkout and price total is displayed.
            //it should group items together and display a quantity


        }



        private void butterfinger_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Butterfinger selected");  // Confirms user selected the butterfinger 


            // Add the butterfinger to the list box and update the total price


        }

        private void Mars_Click(object sender, EventArgs e)
        {
            //variable for amount inside vending machine




            MessageBox.Show("Mars selected"); // Confirms user selected a Mars bar 

            // Add the Mars bar to the list box and update the total price


            //deduct the amount of mars bars in the machine by 1. include bool to check if empty


        }

        private void Tonys_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Tony's selected");//confirms  user selected Tony's chocolonely

            // Add Tony bar to the list box and update the total price

        }

        private void Coke_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Coke Selected"); // confirms user selected a can of coke

            // Add coke to the list box and update the total price

        }

        private void speakVendy_Click(object sender, EventArgs e)
        {
            //conversation with vendy with choices which culminates in a game and a prize if user wins
            //use rand() for: game, a prize of a random product select


        }

        private void orderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This prints stored items in a vector as a summary. Add up the total price of items in the vector and displays after checkout clicked





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

        //Questions for tutorial

        //1. does the code need to be divided into classes. Is this similar to C++?
        //2. Could i separate the payment area on the vending machine as two separate classes?
        //3. if not that box then what do i use

    }
}
