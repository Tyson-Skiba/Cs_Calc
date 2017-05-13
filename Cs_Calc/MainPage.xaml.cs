using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Cs_Calc
{
    /// <summary>
    /// Page for Calculator APP
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string input = string.Empty;
        string x = string.Empty;
        string y = string.Empty;
        char operation;
        double result = 0.0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "1";
            this.textBox.Text += input;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "2";
            this.textBox.Text += input;

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "3";
            this.textBox.Text += input;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "4";
            this.textBox.Text += input;

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "5";
            this.textBox.Text += input;

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "6";
            this.textBox.Text += input;

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "7";
            this.textBox.Text += input;

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "8";
            this.textBox.Text += input;

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "9";
            this.textBox.Text += input;

        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "0";
            this.textBox.Text += input;

        }

        private void buttonP_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonM_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonX_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonD_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {

            this.textBox.Text = " ";
            input += ".";
            this.textBox.Text += input;
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            y = input;
            double num1, num2;

            double.TryParse(x, out num1);
            double.TryParse(y, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox.Text = result.ToString();
                }
                else
                {
                    textBox.Text = "DIV/Zero!";
                }

            }
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
        }
    }
}

