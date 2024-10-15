using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Complete
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double value = 0;
        bool operation_check = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_check)
                result.Clear();
            operation_check = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }



        private void operation_clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_check = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
          
            switch (operation)
            {
                case "+":
                    result.Text=(value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "×":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Clear();
            value=0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!result.Text.Contains("-"))
            {
                result.Text = result.Text.Remove(0, 1);
            }
            else
            {
                result.Text= "-"+result.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(result.Text.Length>0)
            {
                result.Text=result.Text.Remove(result.Text.Length-1, 1);
            }
      if(result.Text=="")
            {
                result.Text = "0";
            }
        }
    } }
