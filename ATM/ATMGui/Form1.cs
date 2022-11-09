using ATM;

namespace ATMGui
{
    public partial class Form1 : Form
    {
        Cardholder _currentUser;
        string state = "";
        ATMachine atm = new();
        public Form1(Cardholder currentUser)
        {
            InitializeComponent();
            lblCardholder.Text = "Card Holder";
            lblCardNumberString.Text = "Card Number";
            _currentUser = currentUser;
            lblName.Text = currentUser.FirstName + " " + currentUser.LastName;
            lblCardNumber.Text = currentUser.CardNum;
            lblBalance.Text = currentUser.Balance.ToString() + "$";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            state = "Deposit";
            lblCurrAction.Text = "Current Action: Depositing";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            state = "Withdraw";
            lblCurrAction.Text = "Current Action: Withdrawing";
        }


        private void btnPressAccept_Click(object sender, EventArgs e)
        {
            if (state.Equals("Deposit") && lblInput.Text.Length > 0)
            {
                atm.deposit(_currentUser, double.Parse(lblInput.Text));
                lblBalance.Text = _currentUser.Balance.ToString() + "$";
                MessageBox.Show("Deposited: " + lblInput.Text + "$ into account: " + _currentUser.FirstName + " " + _currentUser.LastName
                        , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInput.Text = "";
            }else if (state.Equals("Withdraw") && lblInput.Text.Length > 0)
            {
                if(atm.withdraw(_currentUser, double.Parse(lblInput.Text)))
                {
                    lblBalance.Text = _currentUser.Balance.ToString() + "$";
                    MessageBox.Show("Withdrew: " + lblInput.Text + "$ from account: " + _currentUser.FirstName + " " + _currentUser.LastName
                        , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Not enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblInput.Text = "";
                }
                
            }
            else if(lblInput.Text.Length > 0)
            {
                MessageBox.Show("You must select if you wish to deposit or withdraw", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(lblInput.Text.Length == 0 && (state.Equals("Deposit") || state.Equals("Withdraw")))
            {
                MessageBox.Show("You must specify amount to be " + state, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You must select if you wish to deposit or withdraw", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPressClear_Click(object sender, EventArgs e)
        {
            lblInput.Text = "";
        }

        private void btnPressCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPressOne_Click(object sender, EventArgs e)
        {
            lblInput.Text += "1";
        }
        private void btnPressTwo_Click(object sender, EventArgs e)
        {
            lblInput.Text += "2";
        }

        private void btnPressThree_Click(object sender, EventArgs e)
        {
            lblInput.Text += "3";
        }

        private void btnPressFour_Click(object sender, EventArgs e)
        {
            lblInput.Text += "4";
        }

        private void btnPressFive_Click(object sender, EventArgs e)
        {
            lblInput.Text += "5";
        }

        private void btnPressSix_Click(object sender, EventArgs e)
        {
            lblInput.Text += "6";
        }

        private void btnPressSeven_Click(object sender, EventArgs e)
        {
            lblInput.Text += "7";
        }

        private void btnPressEight_Click(object sender, EventArgs e)
        {
            lblInput.Text += "8";
        }

        private void btnPressNine_Click(object sender, EventArgs e)
        {
            lblInput.Text += "9";
        }

        private void btnPressDot_Click(object sender, EventArgs e)
        {
            lblInput.Text += ",";
        }

        private void btnPressZero_Click(object sender, EventArgs e)
        {
            lblInput.Text += "0";
        }

        private void btnPressZeroZero_Click(object sender, EventArgs e)
        {
            lblInput.Text += "00";
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}