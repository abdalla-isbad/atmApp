using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace atmApp
{
    public partial class Summon : Form
    {

        
        




        public Summon()
        {
            InitializeComponent();

            
        }
        private void start() 
        {
            var atmForm = new Form1();

            

            atmForm.ShowDialog();
        }

        private void Summon_Load(object sender, EventArgs e)
        {

        }
        private void summonATM() 
        {
            if (InvokeRequired) 
            {
                this.Invoke(new Action(() => start()));
            }
        }

            private void summonBtn_Click(object sender, EventArgs e)
        {


            //Thread[] ATM = new Thread[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    ATM[i] = new Thread(summonATM);
            //    ATM[i].Start();
            //}
            Thread[] ATM = new Thread[2];
            
            

            for(int i = 0;i < 2; i++) 
            {
                ATM[i] = new Thread(() => start());
                ATM[i].Start();
            }

            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thread[] ATM = new Thread[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    ATM[i] = new Thread(summonATM);
            //    ATM[i].Start();

            //}



      


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread[] ATM = new Thread[2];



            for (int i = 0; i < 2; i++)
            {
                ATM[i] = new Thread(() => start());
                ATM[i].Start();
            }

            

        }
    }
}

