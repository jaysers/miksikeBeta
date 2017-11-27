using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace miksikeDemo
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        Int16 mode = 0;
        //System.Threading.Thread.Sleep(50);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Navigate().GoToUrl("http://miksike.net.ua/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tstring;
            string t2string;
            string sumstr;
            Boolean zn1, zn2;
            Double n1d;
            Double n2d;
            Int64 sum;
            Double sumd;
            Int32 n1;
            Int32 n2;
            if (comboBox1.SelectedIndex == 0) {
                IWebElement text = Browser.FindElement(By.Id("txtTehtav"));
                IWebElement button1 = Browser.FindElement(By.Id("nr1"));
                IWebElement button2 = Browser.FindElement(By.Id("nr2"));
                IWebElement button3 = Browser.FindElement(By.Id("nr3"));
                IWebElement button4 = Browser.FindElement(By.Id("nr4"));
                IWebElement button5 = Browser.FindElement(By.Id("nr5"));
                IWebElement button6 = Browser.FindElement(By.Id("nr6"));
                IWebElement button7 = Browser.FindElement(By.Id("nr7"));
                IWebElement button8 = Browser.FindElement(By.Id("nr8"));
                IWebElement button9 = Browser.FindElement(By.Id("nr9"));
                IWebElement button0 = Browser.FindElement(By.Id("nr0"));
                IWebElement button_ok = Browser.FindElement(By.Id("OK"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++)
                {
                    tstring = text.Text;
                    if ((tstring == "Час сплив!")||((time.Text=="0")&&(level.Text=="0")))
                    {
                        break;
                    }
                    if (tstring.IndexOf("+") == -1)
                    {
                        int index = tstring.IndexOf("-");
                        int index2 = tstring.IndexOf("=");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        n2 = -Convert.ToInt32(tstring.Substring(index, index2 - index));
                        sum = n2 - n1;
                    }
                    else 
                    {
                        int index = tstring.IndexOf("+");
                        int index2 = tstring.IndexOf("=");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        n2 = Convert.ToInt32(tstring.Substring(index, index2 - index));
                        sum = n1 + n2; 
                    }
                    sumstr = Convert.ToString(sum);
                    for (int j = 0; j < sumstr.Length; j++)
                    {
                        switch (sumstr[j])
                        {
                            case '0':
                                button0.Click();
                                break;
                            case '1':
                                button1.Click();
                                break;
                            case '2':
                                button2.Click();
                                break;
                            case '3':
                                button3.Click();
                                break;
                            case '4':
                                button4.Click();
                                break;
                            case '5':
                                button5.Click();
                                break;
                            case '6':
                                button6.Click();
                                break;
                            case '7':
                                button7.Click();
                                break;
                            case '8':
                                button8.Click();
                                break;
                            case '9':
                                button9.Click();
                                break;
                        }
                    }
                    button_ok.Click();
                    progressBar1.Value++;
                    System.Threading.Thread.Sleep(1050);
                }
                progressBar1.Value = 500;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                IWebElement text = Browser.FindElement(By.Id("txtTehtav"));
                IWebElement button1 = Browser.FindElement(By.Id("nr1"));
                IWebElement button2 = Browser.FindElement(By.Id("nr2"));
                IWebElement button3 = Browser.FindElement(By.Id("nr3"));
                IWebElement button4 = Browser.FindElement(By.Id("nr4"));
                IWebElement button5 = Browser.FindElement(By.Id("nr5"));
                IWebElement button6 = Browser.FindElement(By.Id("nr6"));
                IWebElement button7 = Browser.FindElement(By.Id("nr7"));
                IWebElement button8 = Browser.FindElement(By.Id("nr8"));
                IWebElement button9 = Browser.FindElement(By.Id("nr9"));
                IWebElement button0 = Browser.FindElement(By.Id("nr0"));
                IWebElement button_ok = Browser.FindElement(By.Id("OK"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++)
                {
                    tstring = text.Text;
                    if ((tstring == "Час сплив!") || ((time.Text == "0") && (level.Text == "0")))
                    {
                        break;
                    }
                    if (tstring.IndexOf("x") == -1)
                    {
                        int index = tstring.IndexOf(":");
                        int index2 = tstring.IndexOf("=");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        n2 = Convert.ToInt32(tstring.Substring(index + 1, index2 - index - 1));
                        sum = n1 / n2;
                    }
                    else
                    {
                        int index = tstring.IndexOf("x");
                        int index2 = tstring.IndexOf("=");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        n2 = Convert.ToInt32(tstring.Substring(index + 1, index2 - index - 1));
                        sum = n1 * n2;
                    }
                    sumstr = Convert.ToString(sum);
                    for (int j = 0; j < sumstr.Length; j++)
                    {
                        switch (sumstr[j])
                        {
                            case '0':
                                button0.Click();
                                break;
                            case '1':
                                button1.Click();
                                break;
                            case '2':
                                button2.Click();
                                break;
                            case '3':
                                button3.Click();
                                break;
                            case '4':
                                button4.Click();
                                break;
                            case '5':
                                button5.Click();
                                break;
                            case '6':
                                button6.Click();
                                break;
                            case '7':
                                button7.Click();
                                break;
                            case '8':
                                button8.Click();
                                break;
                            case '9':
                                button9.Click();
                                break;
                        }
                    }
                    button_ok.Click();
                    progressBar1.Value++;
                    System.Threading.Thread.Sleep(1050);
                }
                progressBar1.Value = 500;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                IWebElement text = Browser.FindElement(By.Id("txtTehtav"));
                IWebElement button1 = Browser.FindElement(By.Id("nr1"));
                IWebElement button2 = Browser.FindElement(By.Id("nr2"));
                IWebElement button3 = Browser.FindElement(By.Id("nr3"));
                IWebElement button4 = Browser.FindElement(By.Id("nr4"));
                IWebElement button5 = Browser.FindElement(By.Id("nr5"));
                IWebElement button6 = Browser.FindElement(By.Id("nr6"));
                IWebElement button7 = Browser.FindElement(By.Id("nr7"));
                IWebElement button8 = Browser.FindElement(By.Id("nr8"));
                IWebElement button9 = Browser.FindElement(By.Id("nr9"));
                IWebElement button0 = Browser.FindElement(By.Id("nr0"));
                IWebElement button_ok = Browser.FindElement(By.Id("OK"));
                IWebElement button_c = Browser.FindElement(By.Id("cmdKoma"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++)
                {
                    tstring = text.Text;
                    if ((tstring == "Час сплив!") || ((time.Text == "0") && (level.Text == "0")))
                    {
                        break;
                    }
                    if (tstring.IndexOf("+") == -1)
                    {
                        int index = tstring.IndexOf("-");
                        int index2 = tstring.IndexOf("=");
                        n1d = Convert.ToDouble(tstring.Substring(0, index - 1));
                        n2d = -Convert.ToDouble(tstring.Substring(index + 1, index2 - 2 - index));
                        sumd = n2d - n1d;
                    }
                    else
                    {
                        int index = tstring.IndexOf("+");
                        int index2 = tstring.IndexOf("=");
                        n1d = Convert.ToDouble(tstring.Substring(0, index - 1));
                        n2d = Convert.ToDouble(tstring.Substring(index + 1, index2 - 2 - index));
                        sumd = n1d + n2d;
                    }
                    sumstr = Convert.ToString(sumd);
                    for (int j = 0; j < sumstr.Length; j++)
                    {
                        switch (sumstr[j])
                        {
                            case '0':
                                button0.Click();
                                break;
                            case '1':
                                button1.Click();
                                break;
                            case '2':
                                button2.Click();
                                break;
                            case '3':
                                button3.Click();
                                break;
                            case '4':
                                button4.Click();
                                break;
                            case '5':
                                button5.Click();
                                break;
                            case '6':
                                button6.Click();
                                break;
                            case '7':
                                button7.Click();
                                break;
                            case '8':
                                button8.Click();
                                break;
                            case '9':
                                button9.Click();
                                break;
                            case ',':
                                button_c.Click();
                                break;
                        }
                    }
                    button_ok.Click();
                    progressBar1.Value++;
                    System.Threading.Thread.Sleep(1050);
                }
                progressBar1.Value = 500;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                IWebElement text = Browser.FindElement(By.Id("txtTehtav"));
                IWebElement button1 = Browser.FindElement(By.Id("nr1"));
                IWebElement button2 = Browser.FindElement(By.Id("nr2"));
                IWebElement button3 = Browser.FindElement(By.Id("nr3"));
                IWebElement button4 = Browser.FindElement(By.Id("nr4"));
                IWebElement button5 = Browser.FindElement(By.Id("nr5"));
                IWebElement button6 = Browser.FindElement(By.Id("nr6"));
                IWebElement button7 = Browser.FindElement(By.Id("nr7"));
                IWebElement button8 = Browser.FindElement(By.Id("nr8"));
                IWebElement button9 = Browser.FindElement(By.Id("nr9"));
                IWebElement button0 = Browser.FindElement(By.Id("nr0"));
                IWebElement button_ok = Browser.FindElement(By.Id("OK"));
                IWebElement button_c = Browser.FindElement(By.Id("cmdKoma"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++)
                {
                    tstring = text.Text;
                    if ((tstring == "Час сплив!") || ((time.Text == "0") && (level.Text == "0")))
                    {
                        break;
                    }
                    if (tstring.IndexOf("x") == -1)
                    {
                        int index = tstring.IndexOf(":");
                        int index2 = tstring.IndexOf("=");
                        n1d = Convert.ToDouble(tstring.Substring(0, index - 1));
                        n2d = -Convert.ToDouble(tstring.Substring(index + 1, index2 - 2 - index));
                        sumd = n1d / n2d;
                    }
                    else
                    {
                        int index = tstring.IndexOf("x");
                        int index2 = tstring.IndexOf("=");
                        n1d = Convert.ToDouble(tstring.Substring(0, index - 1));
                        n2d = Convert.ToDouble(tstring.Substring(index + 1, index2 - 2 - index));
                        sumd = n1d * n2d;
                    }
                    sumstr = Convert.ToString(sumd);
                    for (int j = 0; j < sumstr.Length; j++)
                    {
                        switch (sumstr[j])
                        {
                            case '0':
                                button0.Click();
                                break;
                            case '1':
                                button1.Click();
                                break;
                            case '2':
                                button2.Click();
                                break;
                            case '3':
                                button3.Click();
                                break;
                            case '4':
                                button4.Click();
                                break;
                            case '5':
                                button5.Click();
                                break;
                            case '6':
                                button6.Click();
                                break;
                            case '7':
                                button7.Click();
                                break;
                            case '8':
                                button8.Click();
                                break;
                            case '9':
                                button9.Click();
                                break;
                            case ',':
                                button_c.Click();
                                break;
                        }
                    }
                    button_ok.Click();
                    progressBar1.Value++;
                    System.Threading.Thread.Sleep(1050);
                }
                progressBar1.Value = 500;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                IWebElement text = Browser.FindElement(By.Id("txtTehtav"));
                IWebElement button1 = Browser.FindElement(By.Id("nr1"));
                IWebElement button2 = Browser.FindElement(By.Id("nr2"));
                IWebElement button3 = Browser.FindElement(By.Id("nr3"));
                IWebElement button4 = Browser.FindElement(By.Id("nr4"));
                IWebElement button5 = Browser.FindElement(By.Id("nr5"));
                IWebElement button6 = Browser.FindElement(By.Id("nr6"));
                IWebElement button7 = Browser.FindElement(By.Id("nr7"));
                IWebElement button8 = Browser.FindElement(By.Id("nr8"));
                IWebElement button9 = Browser.FindElement(By.Id("nr9"));
                IWebElement button0 = Browser.FindElement(By.Id("nr0"));
                IWebElement button_ok = Browser.FindElement(By.Id("OK"));
                IWebElement button_minus = Browser.FindElement(By.Id("cmdMiinus"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++)
                {
                    tstring = text.Text;
                    if ((tstring == "Час сплив!") || ((time.Text == "0") && (level.Text == "0")))
                    {
                        break;
                    }
                    int index = tstring.IndexOf("+");
                    int index2 = tstring.IndexOf("=");
                    n1 = Convert.ToInt32(tstring.Substring(0, index));
                    if (tstring.IndexOf("(") != -1)
                    {
                        n2 = Convert.ToInt32(tstring.Substring(index + 2, index2 - 3 - index));
                    }
                    else
                    {
                        n2 = Convert.ToInt32(tstring.Substring(index + 1, index2 - 1 - index));
                    }
                    sum = n1 + n2;
                    sumstr = Convert.ToString(sum);
                    for (int j = 0; j < sumstr.Length; j++)
                    {
                        switch (sumstr[j])
                        {
                            case '0':
                                button0.Click();
                                break;
                            case '1':
                                button1.Click();
                                break;
                            case '2':
                                button2.Click();
                                break;
                            case '3':
                                button3.Click();
                                break;
                            case '4':
                                button4.Click();
                                break;
                            case '5':
                                button5.Click();
                                break;
                            case '6':
                                button6.Click();
                                break;
                            case '7':
                                button7.Click();
                                break;
                            case '8':
                                button8.Click();
                                break;
                            case '9':
                                button9.Click();
                                break;
                            case '-':
                                button_minus.Click();
                                break;
                        }
                    }
                    button_ok.Click();
                    progressBar1.Value++;
                    System.Threading.Thread.Sleep(1050);
                }
                progressBar1.Value = 500;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                IWebElement text = Browser.FindElement(By.Id("txtTehtav"));
                IWebElement button1 = Browser.FindElement(By.Id("nr1"));
                IWebElement button2 = Browser.FindElement(By.Id("nr2"));
                IWebElement button3 = Browser.FindElement(By.Id("nr3"));
                IWebElement button4 = Browser.FindElement(By.Id("nr4"));
                IWebElement button5 = Browser.FindElement(By.Id("nr5"));
                IWebElement button6 = Browser.FindElement(By.Id("nr6"));
                IWebElement button7 = Browser.FindElement(By.Id("nr7"));
                IWebElement button8 = Browser.FindElement(By.Id("nr8"));
                IWebElement button9 = Browser.FindElement(By.Id("nr9"));
                IWebElement button0 = Browser.FindElement(By.Id("nr0"));
                IWebElement button_ok = Browser.FindElement(By.Id("OK"));
                IWebElement button_minus = Browser.FindElement(By.Id("cmdMiinus"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++)
                {
                    tstring = text.Text;
                    if ((tstring == "Час сплив!") || ((time.Text == "0") && (level.Text == "0")))
                    {
                        break;
                    }
                    //tstring = text.Text;
                    if (tstring.IndexOf("(") != -1 && tstring.IndexOf("-") != 0) 
                    {
                        int index = tstring.IndexOf("-");
                        int index2 = tstring.IndexOf("=");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        n2 = Convert.ToInt32(tstring.Substring(index + 2, index2 - 3 - index));
                    }
                    else
                    {
                        if (tstring.IndexOf("-") == 0 && tstring.IndexOf("(") != -1)
                        {
                            tstring = tstring.Remove(0, 1);
                            int index = tstring.IndexOf("-");
                            int index2 = tstring.IndexOf("=");
                            n1 = -Convert.ToInt32(tstring.Substring(0, index));
                            n2 = Convert.ToInt32(tstring.Substring(index + 2, index2 - 3 - index));
                        }
                        else
                        {
                            if (tstring.IndexOf("(") == -1 && tstring.IndexOf("-") != 0)
                            {
                                int index = tstring.IndexOf("-");
                                int index2 = tstring.IndexOf("=");
                                n1 = Convert.ToInt32(tstring.Substring(0, index));
                                n2 = Convert.ToInt32(tstring.Substring(index + 1, index2 - 1 - index));
                            }
                            else
                            {
                                tstring = tstring.Remove(0, 1);
                                int index = tstring.IndexOf("-");
                                int index2 = tstring.IndexOf("=");
                                n1 = -Convert.ToInt32(tstring.Substring(0, index));
                                n2 = Convert.ToInt32(tstring.Substring(index + 1, index2 - 1 - index));
                            }
                        }
                    }
                    sum = n1 - n2;
                    sumstr = Convert.ToString(sum);
                    for (int j = 0; j < sumstr.Length; j++)
                    {
                        switch (sumstr[j])
                        {
                            case '0':
                                button0.Click();
                                break;
                            case '1':
                                button1.Click();
                                break;
                            case '2':
                                button2.Click();
                                break;
                            case '3':
                                button3.Click();
                                break;
                            case '4':
                                button4.Click();
                                break;
                            case '5':
                                button5.Click();
                                break;
                            case '6':
                                button6.Click();
                                break;
                            case '7':
                                button7.Click();
                                break;
                            case '8':
                                button8.Click();
                                break;
                            case '9':
                                button9.Click();
                                break;
                            case '-':
                                button_minus.Click();
                                break;
                        }
                    }
                    button_ok.Click();
                    //progressBar1.Value++;
                    System.Threading.Thread.Sleep(1050);
                }
               // progressBar1.Value = 500;
            }

            if (comboBox1.SelectedIndex == 6)
            {
                IWebElement text = Browser.FindElement(By.Id("txtTehtav"));
                IWebElement button1 = Browser.FindElement(By.Id("nr1"));
                IWebElement button2 = Browser.FindElement(By.Id("nr2"));
                IWebElement button3 = Browser.FindElement(By.Id("nr3"));
                IWebElement button4 = Browser.FindElement(By.Id("nr4"));
                IWebElement button5 = Browser.FindElement(By.Id("nr5"));
                IWebElement button6 = Browser.FindElement(By.Id("nr6"));
                IWebElement button7 = Browser.FindElement(By.Id("nr7"));
                IWebElement button8 = Browser.FindElement(By.Id("nr8"));
                IWebElement button9 = Browser.FindElement(By.Id("nr9"));
                IWebElement button0 = Browser.FindElement(By.Id("nr0"));
                IWebElement button_ok = Browser.FindElement(By.Id("OK"));
                IWebElement button_minus = Browser.FindElement(By.Id("cmdMiinus"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++)
                {
                    tstring = text.Text;
                    if ((tstring == "Час сплив!") || ((time.Text == "0") && (level.Text == "0")))
                    {
                        break;
                    }
                    if (tstring.IndexOf("x") == -1)
                    {
                        int index = tstring.IndexOf(":");
                        int index2 = tstring.IndexOf("=");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        if (tstring.IndexOf("(") != -1)
                        {
                            n2 = Convert.ToInt32(tstring.Substring(index + 2, index2 - 3 - index));
                        }
                        else
                        {
                            n2 = Convert.ToInt32(tstring.Substring(index + 1, index2 - 1 - index));
                        }
                        sum = n1 / n2;
                    }
                    else
                    {
                        int index = tstring.IndexOf("x");
                        int index2 = tstring.IndexOf("=");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        if (tstring.IndexOf("(") != -1)
                        {
                            n2 = Convert.ToInt32(tstring.Substring(index + 2, index2 - 3 - index));
                        }
                        else
                        {
                            n2 = Convert.ToInt32(tstring.Substring(index + 1, index2 - 1 - index));
                        }
                        sum = n1 * n2;
                    }
                    sumstr = Convert.ToString(sum);
                    for (int j = 0; j < sumstr.Length; j++)
                    {
                        switch (sumstr[j])
                        {
                            case '0':
                                button0.Click();
                                break;
                            case '1':
                                button1.Click();
                                break;
                            case '2':
                                button2.Click();
                                break;
                            case '3':
                                button3.Click();
                                break;
                            case '4':
                                button4.Click();
                                break;
                            case '5':
                                button5.Click();
                                break;
                            case '6':
                                button6.Click();
                                break;
                            case '7':
                                button7.Click();
                                break;
                            case '8':
                                button8.Click();
                                break;
                            case '9':
                                button9.Click();
                                break;
                            case '-':
                                button_minus.Click();
                                break;
                        }
                    }
                    button_ok.Click();
                    progressBar1.Value++;
                    System.Threading.Thread.Sleep(1050);
                }
                progressBar1.Value = 500;
            }

            if (comboBox1.SelectedIndex == 7)
            {
                Int64 sum1;
                Int64 sum2;
                IWebElement text1 = Browser.FindElement(By.Id("aVrd1"));
                IWebElement text2 = Browser.FindElement(By.Id("aVrd2"));
                IWebElement button1 = Browser.FindElement(By.Id("vahem"));
                IWebElement button2 = Browser.FindElement(By.Id("sama"));
                IWebElement button3 = Browser.FindElement(By.Id("rohkem"));
                IWebElement time = Browser.FindElement(By.Id("txtKell"));
                IWebElement level = Browser.FindElement(By.Id("txtTase"));
                for (int i = 0; i < 500; i++) 
                {
                    tstring = text1.Text;
                    t2string = text2.Text;
                    if ((tstring == "Час сплив!") || ((time.Text == "0") && (level.Text == "0")))
                    {
                        break;
                    }
                    if (tstring.IndexOf("+") == -1)
                    {
                        int index = tstring.IndexOf("-");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        n2 = Convert.ToInt32(tstring.Substring(index+1, tstring.Length - 1 - index));
                        sum1 = n1 - n2;
                    }
                    else
                    {
                        int index = tstring.IndexOf("+");
                        n1 = Convert.ToInt32(tstring.Substring(0, index));
                        n2 = Convert.ToInt32(tstring.Substring(index+1, tstring.Length - 1- index));
                        sum1 = n1 + n2;
                    }
                    if (t2string.IndexOf("+") == -1)
                    {
                        int index = t2string.IndexOf("-");
                        n1 = Convert.ToInt32(t2string.Substring(0, index));
                        n2 = Convert.ToInt32(t2string.Substring(index+1, t2string.Length - 1 - index));
                        sum2 = n1 - n2;
                    }
                    else
                    {
                        int index = t2string.IndexOf("+");
                        n1 = Convert.ToInt32(t2string.Substring(0, index));
                        n2 = Convert.ToInt32(t2string.Substring(index+1, t2string.Length - 1 - index));
                        sum2 = n1 + n2;
                    }
                    if (sum1 < sum2)
                    {
                        button1.Click();
                    }
                    if (sum1 == sum2)
                    {
                        button2.Click();
                    }
                    if (sum1 > sum2)
                    {
                        button3.Click();
                    }
                    System.Threading.Thread.Sleep(1050);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
