/* Message to futre self, this project is far from execptional, it is not unique. It was and is 
 * still a learning exercise. I used this to learn about structure and the correct names of things
 * Version Control: Git
 * Location:        GitHub
 * Language:        C#
 * Framework:       .Net
 * Target:          UWP
 * App Name:        C# Calculator
 * App Type:        Calculator
 * */

// Access parts of the .Net framework
using System;                                                       // Standard
// This enables me to access a class without the namespace ie Console.WriteLine("TEXT");
// This is instead of writing System.Console.WriteLine("TEST")
using System.Collections.Generic;                                   // Standard
using System.IO;                                                    // Standard
using System.Linq;                                                  // Standard
using System.Runtime.InteropServices.WindowsRuntime;                // Standard

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// Namespace, The top structure
// Example: Namespace.Class.Class.Class
namespace Cs_Calc
{
    // Access Modifiers
    // Partial: Split Class, Can be used else where
    // Sealed: Prevent others classes from inherinting it
    // Scope Public: Any Code can Access This Class
    // Inheretance: MainPage inherites from Page
    
    public sealed partial class MainPage : Page
    {
        string input = string.Empty;
        string display = string.Empty;
        string x = string.Empty;
        //string x = "0";
        string y = string.Empty;                // Initialise String Values for input, display, x and y
        char operation;                         // Declare a char to be used for the operand (+,-<x<div)
        double result = 0.0;                    // Initialise the double precison floating point value (decimal) to 0;
        double runningTotal = 0.0;

        

        public MainPage()
        {
            this.InitializeComponent();
            

            button1.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button2.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button3.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button4.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button5.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button6.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button7.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button8.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button9.Background = new SolidColorBrush(Windows.UI.Colors.White);
            button0.Background = new SolidColorBrush(Windows.UI.Colors.White);


            button16.Background = new SolidColorBrush(Windows.UI.Colors.DarkGray);
            button17.Background = new SolidColorBrush(Windows.UI.Colors.DarkOrange);
        }

        public void solver(char whichO)
        {
            y = input;
            double num1, num2;

            double.TryParse(x, out num1);      // Convert String x to Double num1
            double.TryParse(y, out num2);      // This is like atoi

            button16.Background = new SolidColorBrush(Windows.UI.Colors.DarkGray);

            if (whichO == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
                resut.Text = result.ToString();
                x = result.ToString();         // Convert to string values for display

            }
            else if (whichO == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
                x = result.ToString();
            }
            else if (whichO == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
                x = result.ToString();
            }
            else if (whichO == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox.Text = result.ToString();
                    x = result.ToString();
                }
                else
                {
                    textBox.Text = "DIV/Zero!";
                }

            }
            
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
            display += "9";
            //this.textBox.Text += input;
            this.textBox.Text = display;

        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "0";
            display += "0";
            // this.textBox.Text += input;
            this.textBox.Text = display;

        }

        private void buttonP_Click(object sender, RoutedEventArgs e)
        {
            // PLUS
            x = input;
            operation = '+';
            //solver('+');
            display += "+";
            this.textBox.Text = display;
            input = string.Empty;
        }

        private void buttonM_Click(object sender, RoutedEventArgs e)
        {
            // MINUS
            x = input;
            operation = '-';
            //solver('-');
            input = string.Empty;
        }

        private void buttonX_Click(object sender, RoutedEventArgs e)
        {
            // Multiply
            x = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonD_Click(object sender, RoutedEventArgs e)
        {
            // Divide
            x = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            // Dot Point
            this.textBox.Text = " ";
            input += ".";
            this.textBox.Text += input;
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            // Solve
            y = input;
            double num1, num2;

            double.TryParse(x, out num1);
            double.TryParse(y, out num2);

            button16.Background = new SolidColorBrush(Windows.UI.Colors.DarkGray);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
                resut.Text = result.ToString();
                
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
            resut.Text = "";
            display = "";
            x = "0";
            //display.Text = "";
        }
    }
}

