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

        public void solverOLD(char whichO)
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

        public String formater(String unf)
        {
            String f;
            f = unf.Replace("\u221A", "R").Replace("\u00B2", "S").Replace("POWER", "P").Replace("OF", "O").Replace("\u00D7", "*").Replace("\u00F7", "/");
            return f;
        }

        public String solver(String eq)
        {
            int startJ = -1;
            int endK = -1;
            int counterL = 0;
            int count = eq.Length - eq.Replace("(", "").Length;
            String opn = "(";
            String cls = ")";

            //Console.WriteLine("Looking for {0} Sets", count);

            for (int i = 0; i < eq.Length; i++)
            {
                //Console.WriteLine(eq[i]);
                if (eq[i] == opn[0])
                {
                    //Console.WriteLine("Found Open");
                    counterL++;
                    if (counterL == count)
                    {
                        startJ = i;
                        //Console.WriteLine("Found Furtherthes Open: Targeting");
                    }
                }

                if ((eq[i] == cls[0]) && (startJ > 0) && (endK == -1))
                {
                    //Console.WriteLine("Found Close");
                    endK = i;
                }
            }

            if ((endK == -1) && (count == 1))
            {
                endK = eq.Length - 1;
            }

            //Console.WriteLine("Found {0} Sets of Parenthesis", counterL);
            //Console.WriteLine("Sub Equation Begins at {0} and Ends at {1}", startJ, endK);

            String solveFirst = eq.Substring(startJ, endK + 1 - startJ);
            //Console.WriteLine("Extracted: {0}", solveFirst);
            //Console.WriteLine();
            String solvedValue = mathsSolver(solveFirst);
            String returnString = eq.Replace(solveFirst, solvedValue);


            double test;

            while (double.TryParse(solvedValue, out test) == false)
            {
                // Keep Running Through Function Untill All Terms Are Calculated
                // The operands are not numbers so will cause this to be false
                //Console.WriteLine("Is It: {0}", double.TryParse(solvedValue, out test));
                solvedValue = mathsSolver(solvedValue);
                returnString = eq.Replace(solveFirst, solvedValue);
            }

            //String returnString = eq.Replace(solveFirst, solvedValue);
            //Console.WriteLine("Final String: {0}", returnString);

            if (returnString.Length == returnString.Replace("(", "").Length)
            {
                ///Console.WriteLine("Final Value Found");
                // return returnString;
            }
            else
            {
                // More Work To Be Done
                //while(returnString.Length != returnString.Replace("(","").Length){
                double t;
                while (double.TryParse(returnString, out t) == false)
                {
                    returnString = mathsSolver(returnString);

                    // Return returnString;
                }
            }

            return returnString;
        }

         public String mathsSolver(string eq)
        {
            //eq = "12*32-3";
            //eq = "R4";
            //eq = "3O27";
            //eq="5P3+201";
            String findMe = eq.Replace("(", "");
            String op;
            String ignore = ".";
            double num1 = 0;
            double num2 = 0;
            double test;
            double sol = 0;
            int num2s = 0;
            int j = 0;
            int m = 0;

            bool moreNumbers = false;


            findMe = findMe.Replace(")", "");
            //Console.WriteLine("Raw Input: {0}", findMe);

            for (int i = 0; i < findMe.Length; i++)
            {
                if (double.TryParse(findMe.Substring(i, 1), out test))
                {
                    //Console.WriteLine("ITS A NUMBER");
                }
                else
                {
                    //Console.WriteLine("ITS NOT A NUMBER");
                    if ((num2s == 0) && (findMe[i] != ignore[0]))
                    {
                        num2s = i + 1;
                    }
                    else
                    {
                        if (findMe[i] != ignore[0])
                        {
                            moreNumbers = true;
                            j = i - num2s;
                            m = i + 1; // we want to include the operand
                        }
                    }
                    // DEFINE SQUAREROOT AS R OR WHATEREVER LATTER TO MAINTAIN THE SIZE
                    if (j == 0 && (findMe[i] != ignore[0]))
                    {
                        //Console.WriteLine("Sub: {0}",findMe.Substring(0,i));
                        double.TryParse(findMe.Substring(0, i), out num1);
                        //Console.WriteLine("Num1: {0} at {1}",num1,i);
                    }
                }
            }

            if (j == 0)
            {
                j = findMe.Length - num2s;

            }

            // For things like root and squared there should be no first term

            double.TryParse(findMe.Substring(num2s, j), out num2);
            //m = (findMe.Substring(num2s,j)).Length;
            op = findMe.Substring(num2s - 1, 1);

            //Console.WriteLine("First Number: {0}, Second Number {1}, Operator is: {2}, More Terms {3}", num1, num2, op, moreNumbers);

            if (op == "+")
            {
                sol = num1 + num2;
            }
            if (op == "*")
            {
                sol = num1 * num2;
            }
            if (op == "-")
            {
                sol = num1 - num2;
            }
            if (op == "/")
            {
                sol = num1 / num2;
            }
            if (op == "S")
            {
                // Square Root
                sol = num2 * num2;
            }
            if (op == "R")
            {
                //Squared
                sol = Math.Sqrt(num2);
            }
            if (op == "O")
            {
                //Nth Root
                sol = Math.Pow(num2, 1.0 / num1);
            }

            if (op == "P")
            {
                //Power
                sol = Math.Pow(num1, num2);
            }




            //Console.WriteLine("Solved Term is: {0}", sol);
            //j = j + op.Length + m;
            //Console.WriteLine("J is: {0} OP is: {1} M is: {2}",j,op.Length,m);
            if (moreNumbers == true)
            {
                //Console.WriteLine("String length: {0},String Start {1}, Substring Length {2}", findMe.Length, m, findMe.Length - m + 1);
                //Console.WriteLine("Solved Term plus Leftovers: {0} Sub:{1}", sol, eq.Substring(m, findMe.Length - m + 1));
                String ou = eq.Substring(m, findMe.Length - m + 1);
                findMe = sol.ToString();
                findMe = findMe + ou;
                //Console.WriteLine("\nOutput Term is: {0}\n", findMe);
                // This Block Caused\s an Exception


                // If there are more terms pump back into this method

                /*if (moreNumbers == true){
                    Console.WriteLine("Parsing {0} Back Into Solver",findMe);   
                    mathsSolver(findMe);   
                }*/
            }
            else
            {
                findMe = sol.ToString();
            }
            //Console.WriteLine();

            return findMe;
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

            String formated = formater(totalDisp);
            formated = "(" + formated + ")";
            resultBox.Text = solver(formated);
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
            totalDisp = totalDisp + "x\x207F";
            // If to work out x value ie 1 2 3 4 5 6 7 8 9 0
            this.textBox.Text = totalDisp;
        }

        private void ofClick(object sender, RoutedEventArgs e)
        {
            totalDisp = totalDisp + "\u207F\u221A";
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

