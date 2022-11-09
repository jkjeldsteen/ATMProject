using ATM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMGui
{
    public partial class Form2 : Form
    {
        private List<Cardholder> _cardHolders;
        string debitCardNum = "";
        Cardholder currentUser;
        public Form2(List<Cardholder> cardHolders)
        {
            _cardHolders = cardHolders;
            InitializeComponent();
            lblInfoText.Text = "Insert Credit/Debit Card";
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(lblInfoText.Text.Equals("Insert Credit/Debit Card"))
            {
                debitCardNum = txtInput.Text;
                currentUser = _cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                if (currentUser != null) { lblInfoText.Text = "Insert PIN"; txtInput.Text = ""; }
                else { MessageBox.Show("Incorrect Card number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if(lblInfoText.Text.Equals("Insert PIN")){
                int pin = int.Parse(txtInput.Text);
                if(currentUser.Pin == pin) { Form1 form1 = new Form1(currentUser); form1.Show(); }
                else { MessageBox.Show("Incorrect PIN!!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            }
        }
    }
}
