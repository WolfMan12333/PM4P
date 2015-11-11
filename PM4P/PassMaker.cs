using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PM4P
{
    class PassMaker
    {
        private long MinLength;
        private long MaxLength;

        public PassMaker()
        {
            long MinLength = 2;
            long MaxLength = 1000000;
            this.MinLength = MinLength;
            this.MaxLength = MaxLength;
        }

        public string MakingPassword(long LimitLength, int LengthFile, string data)
        {
            //variables
            MessageBoxButtons button = MessageBoxButtons.OK;
            char[] window_cypher = new char[LimitLength];
            string message;
            string caption;

            //check the true limit of value
            if (LimitLength > LengthFile)
            {
                message = "Max Length of pass is too high! Please, change it.";
                caption = "Problem with Max Length of password!";
                MessageBox.Show(message, caption, button);
                return "";
            }
            else if (LimitLength < this.MinLength)
            {
                message = "Min Length of pass is too low! Please, change it.";
                caption = "Problem with Min Length of password!";
                MessageBox.Show(message, caption, button);
                return "";
            }
            else
            {
                //calculate n!
                int silnia = 1;
                for (int i = 1; i <= window_cypher.Length; ++i)
                    silnia *= i;

                List<string> listpass = new List<string>();
                int l;
                //begin of first loop
                for (int i = 0; i <= LengthFile; ++i)
                {
                    for (int item = 0; item < window_cypher.Length; ++item)
                    {
                        l = i + 1;
                        if (i == 0)
                        {       
                            window_cypher[item] = data[i];
                        }
                        else
                        {
                            if (l >= data.Length)
                                break;
                            else
                            { 
                                window_cypher[item] = data[l];
                            }
                        }
                        ++i;
                    }

                    //begin of second loop
                    for (int j = 0; j < silnia; j++) //n = window_cypher => n!
                    {
                        //begin of third loop
                        for (int indeks = 0; indeks <= LengthFile; ++indeks)
                        {
                            int counting = LengthFile - 1;

                            if (counting == 0)
                                break;

                            char sz = window_cypher[indeks];
                            int liczba = indeks + 1;

                            if (liczba >= data.Length)
                                break;

                            if (liczba >= window_cypher.Length)
                                break;
                            else
                            {
                                window_cypher[indeks] = window_cypher[liczba];
                                window_cypher[liczba] = sz;
                            }

                            foreach (var a in window_cypher)
                            {
                                listpass.Add(a.ToString());
                            }

                            --counting;
                        }// end of third loop
                    }//end of second loop
                }//end of first loop

                int length = window_cypher.Length;
                data = "";
                foreach (var a in listpass)
                {
                    if(length == 0)
                    {
                        data += Environment.NewLine;
                        length = window_cypher.Length;
                    }
                        data += a;
                        --length;
               }
                return data;
            } // end else 
        }//end of MakingPassword function

        public string MakingPassword2(long MaxLength, long MinLength, int LengthFile, string data)
        {
            //variables
            MessageBoxButtons button = MessageBoxButtons.OK;
            char[] window_cypher = new char[MinLength];

            //check the true limit of value
            if (MaxLength > LengthFile)
            {
                string message = "Max Length of pass is too high! Please, change it.";
                string caption = "Problem with Max Length of password!";
                MessageBox.Show(message, caption, button);
                return "";
            }
            else if (MinLength < this.MinLength)
            {
                string message = "Min Length of pass is too low! Please, change it.";
                string caption = "Problem with Min Length of password!";
                MessageBox.Show(message, caption, button);
                return "";
            }
            else
            {
                List<string> listpass = new List<string>();
                int l;
                for (long js = MinLength; js <= MaxLength; ++js)
                {
                    //new window_cypher depends from js
                    window_cypher = new char[js];
                    
                    //calculate n!
                    int silnia = 1;
                    for (int i = 1; i <= window_cypher.Length; ++i)
                        silnia *= i;

                    //begin of first loop
                    for (int i = 0; i <= LengthFile; ++i)
                    {
                        //algorithm of input data to window_cypher from textbox
                        for (int item = 0; item < window_cypher.Length; ++item)
                        {
                            l = i + 1;
                            if (i == 0)
                                window_cypher[item] = data[i];
                            else
                            {
                                if (l >= data.Length)
                                    break;
                                else
                                    window_cypher[item] = data[l];
                            }
                            ++i;
                        }

                            //begin of second loop
                            for (int j = 0; j < silnia; ++j) //n = window_cypher => n!
                            {
                                //algorithm of mix
                                //begin of third loop
                                for (int indeks = 0; indeks <= LengthFile; ++indeks)
                                {
                                    int counting = LengthFile - 1;

                                    if (counting == 0)
                                        break;

                                    char sz = window_cypher[indeks];
                                    int liczba = indeks + 1;

                                    if (liczba >= data.Length)
                                        break;

                                    if (liczba >= window_cypher.Length)
                                        break;
                                    else
                                    {
                                        window_cypher[indeks] = window_cypher[liczba];
                                        window_cypher[liczba] = sz;
                                    }

                                    foreach (var a in window_cypher)
                                    {
                                        listpass.Add(a.ToString());
                                    }

                                    --counting;
                                }// end of third loop
                            }//end of second loop
                    }//end of first loop 
                }//end of minlength to maxlength loop

                int length;
                data = " ";

                for (long item = MinLength; item <= MaxLength; ++item)
                {
                    window_cypher = new char[Int32.Parse(item.ToString())];
                    length = window_cypher.Length;

                    foreach (var a in listpass)
                    {
                        if (length == 0)
                        {
                            data += Environment.NewLine;
                            length = window_cypher.Length;
                        }
                        data += a;
                        --length;
                    }//end of second loop
                }///end of first loop of writing pass in textbox
                return data;
            }//end of else
        }//end of MakingPassword2 function
    }//end class 
}//end namespace