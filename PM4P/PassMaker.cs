using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;


/*
 *Lower link is aboute Thread and IsBackground
 * link: https://msdn.microsoft.com/en-us/library/system.threading.thread.isbackground(v=vs.110).aspx
 */
namespace PM4P
{
    class PassMaker
    {
        //zmienne globalne
        private long MinLength;
        private long MaxLength;
        private long LimitLength;
        private int LengthFile;
        private string data;
        
        //konstruktor
        public PassMaker()
        {
            long MinLength = 2;
            long MaxLength = 1000000;
            this.MinLength = MinLength;
            this.MaxLength = MaxLength;
        }

        //pobranie parametrów i przekazanie do zmiennych
        public void getparam(long limitlen, int lenf, string dt)
        {
            LimitLength = limitlen;
            LengthFile = lenf;
            data = dt;
        }

        //uruchomienie wątku(w trybie wykonania procesu w tle)
        public void runfunction()
        {
            Thread obj = new Thread(threadattack);
            
            obj.IsBackground = true;
            obj.Start();
        }

        //zwrócenie wartości 
        public string retvalue()
        {
            return MakingPassword(LimitLength, LengthFile, data);
        }

        private void threadattack(Object obj)
        {
            retvalue();
        }

        //główna funkcja tworzenia listy o stałej długości
        private string MakingPassword(long LimitLength, int LengthFile, string data)
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
                listpass = FirstLoopMix(silnia, LengthFile, window_cypher, data, listpass);

                return ReturnData(listpass, window_cypher);
            } // end else 
        }//end of MakingPassword function

        //function of second loop
        private List<string> FirstLoopMix(int silnia, int LengthFile, char[] window_cypher, string data, List<string> listpass)
        {
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
                    ThirdLoopMix(LengthFile, window_cypher, data, listpass);
                }//end of second loop 
            }//end of first loop

            return listpass;
        }

        //function of third loop
        private List<string> ThirdLoopMix(int LengthFile, char[] window_cypher, string data, List<string> listpass)
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

            return listpass;
        }

        //zwrot danych 
        private string ReturnData(List<string> lista, char[] window_cypher)
        {
            string data = "";
            int length = window_cypher.Length;

            foreach(var a in lista)
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
        }

        //***********************************************************************************************************
        public void getparam2(long maxlen, long minlen, int lenf, string dt)
        {
            MaxLength = maxlen;
            MinLength = minlen;
            LengthFile = lenf;
            data = dt;
        }

        public void runfunction2()
        {
            Thread obj = new Thread(threadattack2);
            
            obj.IsBackground = true;
            obj.Start();            
        }

        private void threadattack2(Object obj)
        {
            retvalue2();
        }

        public string retvalue2()
        {
            return MakingPassword2(MaxLength, MinLength, LengthFile, data);
        }

        private string MakingPassword2(long MaxLength, long MinLength, int LengthFile, string data)
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
                int l = 0;
                for (long js = MinLength; js <= MaxLength; ++js)
                {
                    //new window_cypher depends from js
                    window_cypher = new char[js];
                    
                    //calculate n!
                    int silnia = 1;
                    for (int i = 1; i <= window_cypher.Length; ++i)
                        silnia *= i;

                    FirstLoopMix2(LengthFile, window_cypher, l, data, silnia, listpass);
                }//end of minlength to maxlength loop

                data = " ";

                return ReturnData2(window_cypher, listpass, data, MinLength, MaxLength);
                //return data;
            }//end of else
        }//end of MakingPassword2 function

        //function of first and second loop
        private List<string> FirstLoopMix2(int LengthFile, char[] window_cypher, int l, string data, int silnia, List<string> listpass)
        {
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
                    ThirdLoopMix2(LengthFile, window_cypher, data, listpass);
                }//end of second loop
            }//end of first loop 

            return listpass;
        }

        //function of third loop
        private List<string> ThirdLoopMix2(int LengthFile, char[] window_cypher, string data, List<string> listpass)
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

            return listpass;
        }

        //function return data
        private string ReturnData2(char[] window_cypher, List<string> listpass, string data, long MinLength, long MaxLength)
        {
            int length;

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
        }
    }//end class 
}//end namespace