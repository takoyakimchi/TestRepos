// hello

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sub(int a, int b)
        {
            return a - b;
        }
        
        private int add(int a, int b)
        {
            return a + b;
        }

        private int multiply(int a, int b)
        {
            return a * b;
        }

        private int div(int a, int b)
        {
            return a / b;
        }

        private void showErrorMsg()
        {
            MessageBox.Show("Error1!");
        }
    }
}
// hello
