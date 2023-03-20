using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmApp
{
     class ATM
    {
            private Account[] ac;
            private Account activeAccount = null;

            public ATM(Account[] ac) 
            {
                this.ac = ac;
                while (true) 
                {
                    activeAccount = this.findAccount();

                    if (activeAccount != null)
                    {
                        //if the account is found check the pin 
                        if (activeAccount.checkPin(this.promptForPin()))
                        {
                            //if the pin is a match give the options to do stuff to the account (take money out, view balance, exit)
                            dispOptions();
                        }
                    }
                    else
                    {   //if the account number entered is not found let the user know!
                        Console.WriteLine("no matching account found.");
                    }
                }
            }

            private Account findAccount()
            {
                Console.WriteLine("enter your account number..");

                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < this.ac.Length; i++)
                {
                    if (ac[i].getAccountNum() == input)
                    {
                        return ac[i];
                    }
                }

                return null;
            }

            private int promptForPin()
            {
                Console.WriteLine("enter pin:");
                String str = Console.ReadLine();
                int pinNumEntered = Convert.ToInt32(str);
                return pinNumEntered;
            }

            private void dispOptions()
            {
                Console.WriteLine("1> take out cash");
                Console.WriteLine("2> balance");
                Console.WriteLine("3> exsit");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    dispWithdraw();
                }
                else if (input == 2)
                {
                    dispBalance();
                }
                else if (input == 3)
                {


                }
                else
                {

                }

            }

            private void dispWithdraw()
            {
                Console.WriteLine("1> 10");
                Console.WriteLine("2> 50");
                Console.WriteLine("3> 500");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 0 && input < 4)
                {

                    //opiton one is entered by the user
                    if (input == 1)
                    {

                        //attempt to decrement account by 10 punds
                        if (activeAccount.decrementBalance(10))
                        {
                            //if this is possible display new balance and await key press
                            Console.WriteLine("new balance " + activeAccount.getBalance());
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                        else
                        {
                            //if this is not possible inform user and await key press
                            Console.WriteLine("insufficent funds");
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                    }
                    else if (input == 2)
                    {
                        if (activeAccount.decrementBalance(50))
                        {
                            Console.WriteLine("new balance " + activeAccount.getBalance());
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("insufficent funds");
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                    }
                    else if (input == 3)
                    {
                        if (activeAccount.decrementBalance(500))
                        {
                            Console.WriteLine("new balance " + activeAccount.getBalance());
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("insufficent funds");
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                    }
                }
            }

            private void dispBalance()
            {
                if (this.activeAccount != null)
                {
                    Console.WriteLine(" your current balance is : " + activeAccount.getBalance());
                    Console.WriteLine(" (prese enter to continue)");
                    Console.ReadLine();
                }
            }

    }
}
