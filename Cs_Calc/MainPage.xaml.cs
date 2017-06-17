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
        String totalDisp = string.Empty;
        

        public MainPage()
        {
            this.InitializeComponent();
            

            
        }

        public void solver(char whichO)
        {
            /*y = input;
            double num1, num2;

            double.TryParse(x, out num1);      // Convert String x to Double num1
            double.TryParse(y, out num2);      // This is like atoi

            

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
            */
        }

        private void oneClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "1";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "1";
            this.textBox.Text = totalDisp;
        }

        private void twoClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "2";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "2";
            this.textBox.Text = totalDisp;

        }

        private void threeClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "3";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "3";
            this.textBox.Text = totalDisp;

        }

        private void fourClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "4";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "4";
            this.textBox.Text = totalDisp;
        }

        private void fiveClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "5";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "5";
            this.textBox.Text = totalDisp;
        }

        private void sixClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "6";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "6";
            this.textBox.Text = totalDisp;
        }

        private void sevenClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "7";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "7";
            this.textBox.Text = totalDisp;
        }

        private void eightClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "8";
            //this.textBox.Text += input;
            totalDisp = totalDisp + "8";
            this.textBox.Text = totalDisp;
        }

        private void nineClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "9";
            display += "9";
            //this.textBox.Text += input;
            //this.textBox.Text = display;
            totalDisp = totalDisp + "9";
            this.textBox.Text = totalDisp;
        }

        private void zeroClick(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "0";
            display += "0";
            // this.textBox.Text += input;
            //this.textBox.Text = display;
            totalDisp = totalDisp + "9";
            this.textBox.Text = totalDisp;

        }

        private void plusClick(object sender, RoutedEventArgs e)
        {
            // PLUS
            x = input;
            operation = '+';
            //solver('+');
            display += "+";
            //this.textBox.Text = display;
            input = string.Empty;
            totalDisp = totalDisp + "+";
            this.textBox.Text = totalDisp;
        }

        private void minusClick(object sender, RoutedEventArgs e)
        {
            // MINUS
            x = input;
            operation = '-';
            //solver('-');
            input = string.Empty;
            totalDisp = totalDisp + "-";
            this.textBox.Text = totalDisp;
        }

        private void multiplyClick(object sender, RoutedEventArgs e)
        {
            // Multiply
            x = input;
            operation = '*';
            input = string.Empty;
            totalDisp = totalDisp + "\u00D7";
            this.textBox.Text = totalDisp;
        }

        private void divideClick(object sender, RoutedEventArgs e)
        {
            // Divide
            x = input;
            operation = '/';
            input = string.Empty;
            totalDisp = totalDisp + "\u00F7";
            this.textBox.Text = totalDisp;
        }

        private void dotClick(object sender, RoutedEventArgs e)
        {
            // Dot Point
            this.textBox.Text = " ";
            input += ".";
            this.textBox.Text += input;
            totalDisp = totalDisp + ".";
            this.textBox.Text = totalDisp;
        }

        private void solveClick(object sender, RoutedEventArgs e)
        {
            // Solve
            y = input;
            double num1, num2;

            double.TryParse(x, out num1);
            double.TryParse(y, out num2);

            //button16.Background = new SolidColorBrush(Windows.UI.Colors.DarkGray);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
                resultBox.Text = result.ToString();
                
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
            resultBox.Text = result.ToString();
        }

        private void rootClick(object sender, RoutedEventArgs e)
        {
            totalDisp = totalDisp + "\u221A";
            this.textBox.Text = totalDisp;
        }

        private void squareClick(object sender, RoutedEventArgs e)
        {
            totalDisp = totalDisp + "\u00B2";
            this.textBox.Text = totalDisp;
        }

        private void powerClick(object sender, RoutedEventArgs e)
        {
            totalDisp = totalDisp + "\u00F7";
            // If to work out value ie 1 2 3 4 5 6 7 8 9 0
            this.textBox.Text = totalDisp;
        }

        private void ofClick(object sender, RoutedEventArgs e)
        {
            totalDisp = totalDisp + "\u00F7";
            // If to work out value ie 1 2 3 4 5 6 7 8 9 0
            this.textBox.Text = totalDisp;
        }

        private void backspaceClick(object sender, RoutedEventArgs e)
        {

        }

        private void engClick(object sender, RoutedEventArgs e)
        {
            totalDisp = totalDisp + "\u00F7";
            // If to work out value ie 1 2 3 4 5 6 7 8 9 0
            this.textBox.Text = totalDisp;
        }

        private void clearAllClick(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
            resultBox.Text = "";
            display = "";
            x = "0";
            totalDisp = string.Empty;
            //display.Text = "";
        }
    }
}

