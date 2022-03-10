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
            var res = problem.solve(cap);
            tB_result.Text = res.ToString();
        }

    }
}
