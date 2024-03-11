namespace ATM_application
{
    public partial class Form1 : Form
    {
        private int unsuccessfulAttempts = 0;
        private const int MaxAttempts = 3;

        private decimal accountBalance = 5000;
        private int accountPin = 2567;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(amountTextBox.Text, out int amount))
            {
                amountErrorProvider.SetError(amountTextBox, "Invalid Amount!");
            }
            else
            {
                amountErrorProvider.SetError(amountTextBox, string.Empty);
            }

            if (pinTextBox.TextLength != 4)
            {
                pinErrorProvider.SetError(pinTextBox, "PIN must be 4 digits long");
            }
            else if (!int.TryParse(pinTextBox.Text, out int pin))
            {
                pinErrorProvider.SetError(pinTextBox, "Invalid PIN!");
            }
            else
            {
                pinErrorProvider.SetError(pinTextBox, string.Empty);
            }

            // Display appropriate message
            if (string.IsNullOrEmpty(amountErrorProvider.GetError(amountTextBox)) &&
                    string.IsNullOrEmpty(pinErrorProvider.GetError(pinTextBox)))
            {
                if (CheckAccountBalance(amount) && CheckPin(Convert.ToInt32(pinTextBox)))
                {
                    MessageBox.Show("Transaction successful! Thank you!");
                    unsuccessfulAttempts = 0; 
                }
                else
                {
                    unsuccessfulAttempts++;
                    MessageBox.Show("Transaction failed. Please check your amount and PIN.");

                    if (unsuccessfulAttempts >= MaxAttempts)
                    {
                        BlockCard();
                    }
                }
            }
            else
            {
                MessageBox.Show(amountErrorProvider.GetError(amountTextBox) + Environment.NewLine +
                                pinErrorProvider.GetError(pinTextBox));
            }
        }


        private bool CheckPin(int enteredPin)
        {
            if (enteredPin == accountPin)
                return true;

            else
                return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BlockCard()
        {
            MessageBox.Show("Card blocked! Please contact your bank.");
        }

        private bool CheckAccountBalance(int amount)
        {
            return accountBalance >= amount;
        }


    }
}