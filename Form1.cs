using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace atmApp
{
    public partial class Form1 : Form
    {

        private Account activeAccount = null;
        private int screen, pinAttempts = 0;
        private string pin, pinTochange, tempPin, customDeposit = null;
        bool cPin, enteredFirst = false;

      
        
        

        public Form1()
        {

            InitializeComponent();




        }
        private Account findAccount(ComboBox accountList)
        {


            string selected = this.accountList.GetItemText(this.accountList.SelectedItem);

            for (uint i = 0; i < Program.ac.Length; i++)
            {
                if (Program.ac[i].getAccountNum().ToString() == selected)
                  

                return Program.ac[i];
            }
            Debug.WriteLine("manipulate");
            return null;
        }

            
        
        

        public static void loadAccounts(ComboBox accountList)
        {

            
            foreach (Account account in Program.ac)
            {
                accountList.Items.Add(account.accountNum);
            }

        }


        private void insertBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Fuck You");
            Debug.WriteLine("Fuck YOU");


           
        }
        private void accountList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void dispOptions()
        {
            pinPanel.Visible = false;
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
            optionsPanel.Visible = true;
            
            
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
            accountList.Text = "--Choose a bank card--";
            loadAccounts(accountList);
            


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void accountList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (accountList.SelectedIndex > 0)
            {
                insertBtn.Enabled = true;
            }
            else
            {
                insertBtn.Enabled = false;
            }
        }

        private void insertBtn_Click_1(object sender, EventArgs e)
        {
            accountList.Enabled = false;
            insertBtn.Enabled = false;

            activeAccount = this.findAccount(accountList);
            getpin();
            Debug.WriteLine(activeAccount.accountNum);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (accountList.SelectedIndex >= 0)
            {
                insertBtn.Enabled = true;
            }
            else
            {
                insertBtn.Enabled = false;
            }
        }

        private void optionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void getpin() 
        {
            screen = 1;
            insertPanel.Visible = false;
            pinPanel.Visible = true;
            

        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            switch (screen) 
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += oneBtn.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += oneBtn.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += oneBtn.Text;
                        customDeposit += Int32.Parse(oneBtn.Text);
                    }
                    break;
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += twoBtn.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += twoBtn.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += twoBtn.Text;
                        customDeposit += Int32.Parse(twoBtn.Text);
                    }
                    break;
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += threeBtn.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += threeBtn.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += threeBtn.Text;
                        customDeposit += Int32.Parse(threeBtn.Text);
                    }
                    break;
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += fourBtn.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += fourBtn.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += fourBtn.Text;
                        customDeposit += Int32.Parse(fourBtn.Text);
                    }
                    break;
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += fiveBtn.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += fiveBtn.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += fiveBtn.Text;
                        customDeposit += Int32.Parse(fiveBtn.Text);
                    }
                    break;
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += sixBtn.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += sixBtn.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += sixBtn.Text;
                        customDeposit += Int32.Parse(sixBtn.Text);
                    }
                    break;
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += sevenBtn.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += sevenBtn.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += sevenBtn.Text;
                        customDeposit += Int32.Parse(sevenBtn.Text);
                    }
                    break;
            }
        }

        private void eightButtton_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += eightButtton.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += eightButtton.Text;
                        newPinLbl.Text += "*";
                    }
                    break;

                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += eightButtton.Text;
                        customDeposit += Int32.Parse(eightButtton.Text);
                    }
                    break;
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4) { 
                    pin += nineButton.Text;
                    pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += nineButton.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3)
                    {
                        customDepositLbl.Text += nineButton.Text;
                        customDeposit += Int32.Parse(nineButton.Text);
                    }
                    break;
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length < 4)
                    {
                        pin += zeroButton.Text;
                        pinLbl.Text += "*";
                    }
                    break;
                case 9:
                    if (newPinLbl.Text.Length < 4)
                    {
                        pinTochange += zeroButton.Text;
                        newPinLbl.Text += "*";
                    }
                    break;
                case 6:
                case 7:
                    if (customDepositLbl.Text.Length <= 3) 
                    {
                        customDepositLbl.Text += zeroButton.Text;
                        customDeposit += Int32.Parse(zeroButton.Text);
                    }
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length > 0) 
                    { 
                    pin = pin.Remove(pin.Length - 1);
                    pinLbl.Text =pinLbl.Text.Remove(pinLbl.Text.Length - 1);
                    }
                    break;
            }

        }

        private void refreshATM() 
        {
            if (screen == 1||screen == 2)
            {
                pinAttempts = 0;
                screen = 0;
                insertPanel.Visible = true;
                pinPanel.Visible = false;
                optionsPanel.Visible = false;
                insertBtn.Enabled = true;
                accountList.Refresh();
                accountList.Enabled = true;
                fourDigLbl.Text = "";
                fourDigLblTwo.Text = "";
                fourDigLbl.Refresh();
                fourDigLblTwo.Refresh();
                pin = "";
                pinLbl.Text = "";
                pinLbl.Refresh();
            }
        }

        private void pinPanel_Paint(object sender, PaintEventArgs e)
        {
            if (pinAttempts > 2)
            {
                refreshATM();

            }
        }

        private void checkBalance() 
        {
            screen = 3;
            optionsPanel.Visible = false;
            currentBalancePanel.Visible = true;
            balanceLbl.Text = "£"+activeAccount.balance.ToString();

        }
        private void customAmount(bool isWithdraw)
        {
            if (!isWithdraw)
            { 
            screen = 6; }
            else { screen= 7; }

            depositPanel.Visible = false;
            customAmountPanel.Visible = true;
            customDeposit = null;


        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                    refreshATM();
                    break;
            }
        }

        private void returnToMenu() 
        {
            
        }

        private void rightBtmBtn_Click(object sender, EventArgs e)
        {
            switch(screen) 
            {
                case 2:
                    refreshATM();
                    break;
                case 7:
                case 3:
                case 5:
                    currentBalancePanel.Visible = false;
                    depositPanel.Visible = false;
                    optionsPanel.Visible = true;
                    screen = 2;
                    break;
                case 10:
                    transactionPanel.Visible = false;
                    optionsPanel.Visible = true;
                    screen = 2;
                    break;

                




            }
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
        }

        private void leftBtmBtn_Click(object sender, EventArgs e)
        {
            switch (screen) 
            {
                case 2:
                    screen= 3;
                    checkBalance();
                    break;
                case 5:
                    confirmDeposit(50,false);
                    break;
                case 7:
                    if (activeAccount.balance >= 50)
                    {
                        confirmDeposit(50, true);
                    }
                    else
                    {
                        depositPanel.Visible = false;
                        noFundsPanel.Visible = true;
                        noFundsLbl.Refresh();
                        Thread.Sleep(1550);
                        depositPanel.Visible = true;
                        noFundsPanel.Visible = false;
                    }
                    break;
            }
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
        }
        private void changePin() 
        {
            
            pinPanel.Visible = false;
            changePinPanel.Visible = true;
            screen = 9;
        }
        private void deposit() 
        {
            
            optionsPanel.Visible = false;
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
            depositPanel.Visible = true;
            
           
        }

        private void rightTopBtn_Click(object sender, EventArgs e)
        {
            switch (screen) 
            {
                case 2:
                    screen= 5;
                    deposit();
                    break;

                case 5:
                    confirmDeposit(100,false);
                    break;
                case 7:
                    if (activeAccount.balance >= 100)
                    {
                        confirmDeposit(100, true);
                    }
                    else
                    {
                        depositPanel.Visible = false;
                        noFundsPanel.Visible = true;
                        noFundsLbl.Refresh();
                        Thread.Sleep(1550);
                        depositPanel.Visible = true;
                        noFundsPanel.Visible = false;
                    }
                    break;
                
                    deposit();
            }
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
        }
        public void logTransaction(string type, int amount, int balanceAfter)
        {
            int user = activeAccount.accountNum;


        }

        private void rightMidBtn_Click(object sender, EventArgs e)
        {
            switch (screen) 
            {
                case 2:
                    cPin = true;
                    optionsPanel.Visible= false;
                    pinPanel.Visible = true;
                    pin = "";
                    pinLbl.Text = "";
                    screen= 4;

                    
                    
                    break;

                case 5:
                    customAmount(false);
                    break;
                case 7:
                    customAmount(true);
                    break;


            }
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void confirmDepositPanel_Paint(object sender, PaintEventArgs e)
        {
            transactionLbL.Visible = true;
            
        }

        private void processAction() 
        {
            confirmDepositPanel.Refresh();
            progressBar1.Visible = true;
            

            progressBar1.Value = 0;
            depositPanel.Visible = false;
            customAmountPanel.Visible = false;
            confirmDepositPanel.Visible = true;

            while (progressBar1.Value != progressBar1.Maximum)
            {
                Thread.Sleep(100);
                progressBar1.PerformStep();

            }
            progressBar1.Visible = false;
            successLbl.Text = "SUCCESS";

            successLbl.Refresh();
            Thread.Sleep(300);
            
            confirmDepositPanel.Visible = false;
            customAmountPanel.Visible= false;
            screen = 2;
            optionsPanel.Visible = true;
            progressBar1.Refresh();
            transactionLbL.Visible = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void confirmDeposit(int amount, bool isWithdraw) 
        {
            
            Thread.Sleep(1500);
            if (isWithdraw == true && activeAccount.balance >= amount)
            {
                using (StreamWriter sw = new StreamWriter(activeAccount.accountNum + ".log", true))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd-MM-yyyy") + "," + "OUT" + "," + amount + "," + (activeAccount.balance - amount));
                }
                Thread.BeginCriticalRegion();
                activeAccount.balance -= amount;
                processAction();
                Thread.EndCriticalRegion();
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(activeAccount.accountNum + ".log", true))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd-MM-yyyy") +","+ "IN" + "," + amount + "," + (activeAccount.balance + amount));
                }
                Thread.BeginCriticalRegion();
                activeAccount.balance += amount;
                processAction();
                Thread.EndCriticalRegion();
            }
            
        }

        private void transactionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmWithdrawl(int amount) 
        {

        }

        private void leftTopBtn_Click(object sender, EventArgs e)
        {
            switch (screen) 
            {
                case 5:
                    
                    confirmDeposit(10,false);
                    break;
                case 2:
                    screen = 7;
                    deposit();

                    this.depositPanel.Invalidate();
                    this.depositPanel.Update();
                    this.depositPanel.Refresh();
                    Application.DoEvents();
                    break;
                case 7:
                    if (activeAccount.balance >= 10)
                    {
                        confirmDeposit(10,true);
                    }
                    else
                    {
                        depositPanel.Visible = false;
                        noFundsPanel.Visible = true;
                        noFundsLbl.Refresh();
                        Thread.Sleep(1550);
                        depositPanel.Visible = true;
                        noFundsPanel.Visible = false;
                    }
                    break;


            }
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
        }

        private void leftMidBtn_Click(object sender, EventArgs e)
        {
            switch(screen) 
            {

                case 2:
                    screen = 10;
                    displayRecentTransactions();
                    break;
                case 5:
                    confirmDeposit(20,false);
                    break;
                case 7:
                    if (activeAccount.balance >= 20)
                    {
                        confirmDeposit(20, true);
                    }
                    else
                    {
                        depositPanel.Visible = false;
                        noFundsPanel.Visible = true;
                        noFundsLbl.Refresh();
                        Thread.Sleep(1550);
                        depositPanel.Visible = true;
                        noFundsPanel.Visible = false;
                    }
                    break;
            }
            groupBox1.Refresh();
            groupBox1.CreateGraphics();
        }

        private void displayRecentTransactions()
        {

            foreach (var line in File.ReadLines(activeAccount.accountNum + ".log"))
            {
                transactionTable.Rows.Add(line.Split(','));
            }
            
            optionsPanel.Visible = false;
            transactionPanel.Visible = true;
        }

        private void enterBTN_Click(object sender, EventArgs e)
        {
            switch (screen)
            {
                case 1:
                case 4:
                    if (pinLbl.Text.Length == 4)
                    {
                        if (pin == activeAccount.pin.ToString())
                        {
                            Debug.WriteLine("it's the same fucking pin");
                            if (cPin) 
                            {
                                changePin();
                            }
                            else
                            {
                                screen = 2;
                                pin = "";
                                dispOptions();
                            }

                        }
                        else if (pinAttempts!=3)
                        {
                            pinAttempts++;
                            fourDigLbl.Text = "INVALID PIN";
                            Debug.WriteLine("PIN IS "+activeAccount.pin);
                            fourDigLblTwo.Text = pinAttempts + "/3 ATTEMPTS";
                            fourDigLbl.Refresh();
                            fourDigLblTwo.Refresh();
                            pin = "";
                            pinLbl.Text = "";
                            pinLbl.Refresh();
                        }

                    }
                    else if (pin.Length != 4)
                    {
                        Debug.WriteLine("less than 4");
                        fourDigLbl.Text = "ENTER 4 DIGITS";
                        fourDigLbl.Refresh();
                        Thread.Sleep(750);
                        fourDigLbl.Text = "";

                    }
                    
                    break;

                case 6:
                    if (customDeposit != null)
                    {
                        int toDeposit = Int32.Parse(customDeposit);
                        if (toDeposit >= 5 && toDeposit % 5 == 0 && toDeposit <= 995)
                        { confirmDeposit(toDeposit,false); }
                        else
                        {
                            invalidDepositLbl.Visible = true;
                            invalidDepositLbl.Refresh();
                            Thread.Sleep(800);
                            invalidDepositLbl.Visible = false;
                            customDeposit = null;
                            customDepositLbl.Text = "";
                        }
                    }
                    else 
                    {
                        invalidDepositLbl.Visible = true;
                        invalidDepositLbl.Refresh();
                        Thread.Sleep(800);
                        invalidDepositLbl.Visible = false;
                        customDeposit = null;
                        customDepositLbl.Text = "";
                    }
                    customDeposit = null;
                    customDepositLbl.Text = "";
                    break;

                    case 7:
                    if (customDeposit != null)
                    {
                        int toDeposit = Int32.Parse(customDeposit);
                        if (toDeposit >= 5 && toDeposit % 5 == 0 && toDeposit <= 995&&toDeposit<=activeAccount.balance)
                        { confirmDeposit(toDeposit, true); }
                        else
                        {
                            invalidDepositLbl.Visible = true;
                            invalidDepositLbl.Refresh();
                            Thread.Sleep(800);
                            invalidDepositLbl.Visible = false;
                            customDeposit = null;
                            customDepositLbl.Text = "";
                        }
                    }
                    else
                    {
                        invalidDepositLbl.Visible = true;
                        invalidDepositLbl.Refresh();
                        Thread.Sleep(800);
                        invalidDepositLbl.Visible = false;
                        customDeposit = null;
                        customDepositLbl.Text = "";
                    }
                    customDeposit = null;
                    customDepositLbl.Text = "";

                    break;

                case 9:
                    if (newPinLbl.Text.Length == 4) 
                    {
                        
                        if (!enteredFirst)
                        {
                            enteredFirst = true;
                            tempPin = pinTochange;
                            changePinPromptLbl.Text = "ENTER PIN AGAIN: ";
                            changePinPromptLbl.Refresh();

                            pinTochange = "";
                            newPinLbl.Text = "";
                            newPinLbl.Refresh();
                        }
                        else 
                        {
                            if(tempPin==pinTochange) 
                            {
                                activeAccount.pin = Int32.Parse(pinTochange);
                                changeStatusLbl.Visible = true;
                                changeStatusLbl.Refresh();
                                Thread.Sleep(1000);
                                changeStatusLbl.Visible = false;

                                
                            }

                            else
                            {
                                changePinPromptLbl.Text = "PINS DO NOT MATCH";
                                changePinPromptLbl.Refresh();
                                Thread.Sleep(1500);

                               
                            }

                            tempPin = "";
                            pinTochange = "";
                            newPinLbl.Text = "";
                            enteredFirst = false;
                            changePinPromptLbl.Text = "ENTER PIN: ";
                            cPin = false;
                            changePinPanel.Visible = false;
                            optionsPanel.Visible = true;
                            screen = 2;
                        }
                        
                    }


                    break;

            }

            groupBox1.Refresh();
            groupBox1.CreateGraphics();
        }
    }

   


}