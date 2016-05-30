using System.Text;

namespace PM4P
{
    class EncodingData
    {
        /*
         * functions set of encoding chars
         * here you find every functions responsible
         * encoding data from our website, it is 
         * important functions cause propably every
         * website has own type of encoding
         * there will be many functions as many
         * encoding for languages exists
        */

        //polish, czech, slovak, hungarian, slovene, serbian, croatian, bosnian and albanian
        public string EncodeDataUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1250"), Encoding.GetEncoding("Windows-1250"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }

        //Cyrilic alphabets
        public string EncodeDataFromCyrilictoUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1251"), Encoding.GetEncoding("Windows-1251"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }

        //Western lanugages
        public string EncodeDataWestUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1252"), Encoding.GetEncoding("Windows-1252"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }

        //Greek
        public string EncodeDataGreekUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1253"), Encoding.GetEncoding("Windows-1253"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }

        //Turkish
        public string EncodeDataTurkishUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1254"), Encoding.GetEncoding("Windows-1254"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }

        //Hebrew
        public string EncodeDataHebrewUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1255"), Encoding.GetEncoding("Windows-1255"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }

        //Arabic
        public string EncodeDataArabicUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1256"), Encoding.GetEncoding("Windows-1256"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }

        //Baltic languages
        public string EncodeDataBalticUTF8(string data)
        {
            byte[] znaki = Encoding.Convert(Encoding.GetEncoding("Windows-1257"), Encoding.GetEncoding("Windows-1257"), Encoding.Default.GetBytes(data));

            return Encoding.UTF8.GetString(znaki);
        }
    }
}