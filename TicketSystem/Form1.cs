using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicketSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GameTransaction CurrentTransaction = new GameTransaction();
        List<GameTransaction> TransactionList = new List<GameTransaction>();
        

        private void LoadToCartListBox() //unfinished
        {
            ListBox.Items.Clear();
            ListBox.Items.Add("Order Name: " + transactionNameTextBox.Text);
            ListBox.Items.Add("Number of Premium Seats: " + CurrentTransaction.NumOfPremiumSeats);
            ListBox.Items.Add("Number of Regular Seats: " + CurrentTransaction.NumOfRegularSeats);
            ListBox.Items.Add("Total: " + CurrentTransaction.TotalPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(transactionNameTextBox.Text == "")
            {
                MessageBox.Show("Field is empty, please insert a value");
            }
            else
            {
                CurrentTransaction.TransactionName = transactionNameTextBox.Text;
                LoadToCartListBox();
            }
        }

        private void addOneRegButton_Click(object sender, EventArgs e)
        {
            CurrentTransaction.NumOfRegularSeats += 1;
            LoadToCartListBox();
        }

        private void addOnePreButton_Click(object sender, EventArgs e)
        {
            CurrentTransaction.NumOfPremiumSeats += 1;
            LoadToCartListBox();
        }

        private void removeOneRegButton_Click(object sender, EventArgs e)
        {
            if(CurrentTransaction.NumOfRegularSeats == 0)
            {
                MessageBox.Show("Item cannot be removed from cart");
            }
            else if (CurrentTransaction.NumOfRegularSeats > 0)
            {
                CurrentTransaction.NumOfRegularSeats -= 1;
                LoadToCartListBox();
            }
        }

        private void removeOnePreButton_Click(object sender, EventArgs e)
        {
            if (CurrentTransaction.NumOfPremiumSeats == 0)
            {
                MessageBox.Show("Item cannot be removed from cart");
            }
            else if (CurrentTransaction.NumOfPremiumSeats > 0)
            {
                CurrentTransaction.NumOfPremiumSeats -= 1;
                LoadToCartListBox();
            }
        }

        private void addCurrentTransactionButton_Click(object sender, EventArgs e)
        {
            if (CurrentTransaction.TotalPrice > 0)
            {
                TransactionList.Add(CurrentTransaction);
            }
            else if (CurrentTransaction.TotalPrice == 0)
            {
                MessageBox.Show("cannot Add Order, no tickets selected");
            }

            transactionNameTextBox.Text = "";
                CurrentTransaction = new GameTransaction();
                ListBox.Items.Clear();

            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamWriter myOutPutStream = new StreamWriter("game.txt"))
                {
                    foreach (GameTransaction item in TransactionList)
                    {
                        myOutPutStream.WriteLine(item.ToString());
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error writing file: " + ex.Message);
            }
        }
    }
}
