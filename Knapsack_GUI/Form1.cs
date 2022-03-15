using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnapsackProblem;

namespace Knapsack_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void B_run_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tB_items.Text);
            int seed = int.Parse(tB_seed.Text);
            Problem problem = new Problem(n, seed);
            tB_instance.Text = problem.ToString();
            int cap = int.Parse(tB_capacity.Text);
            
            int[] sArray = problem.Solver(cap, n);

            tB_result.Text = "IDs:" + Environment.NewLine;
            for (int i = 0; i < n; i++)
            {
                if (sArray[i] == 0 && i!=0) //doesn't fit into backpack
                {
                }
                else
                {
                    tB_result.Text += sArray[i].ToString() + Environment.NewLine;
                }
            }
            tB_result.Text += "Final weight:";
            tB_result.Text += sArray[n].ToString() + Environment.NewLine;
            tB_result.Text += "Final value:";
            tB_result.Text += sArray[n+1].ToString();
            //tB_result.Text += sArray.Length.ToString();
        }

        private void tB_items_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            int x;
            if(int.TryParse(box.Text, out x))
            {
                box.BackColor = Color.Green;
            }
            else box.BackColor= Color.Red;
        }
    }
}
