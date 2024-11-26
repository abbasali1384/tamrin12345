using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abbas
{
    public class coded
    {   
        
        public int key ;
        public void Encoding(string payame, string filename)
        {

            key %= 52;
            StringBuilder text = new StringBuilder();
            int indexencodenumber = 0;
            char x;
            for (int i = 0; i < payame.Length; i++)
            {
                if (char.IsUpper(payame[i]))
                {

                    indexencodenumber = 'A' + (key + payame[i] - 'A') % 26;
                    x = Convert.ToChar(indexencodenumber);
                    text.Append(x);
                }
                else
                {
                    indexencodenumber = 'a' + (key + payame[i] - 'a') % 26;
                    x = Convert.ToChar(indexencodenumber);
                    text.Append(x);
                }
            }
            StreamWriter sw = File.CreateText(filename);
            sw.WriteLine(text.ToString());
            sw.Close();

        }
        public void keymaker1(string mabda, string maghsad)
        {
            int mab = 0, magh = 0;
            for (int i = 0; i < mabda.Length - 1; i++)
            {
                if (char.IsUpper(mabda[i]))
                    mab += mabda[i] - 'A';
                else
                    mab += mabda[i] - 'a';

            }
            for (int i = 0; i < maghsad.Length - 1; i++)
            {
                if (char.IsUpper(maghsad[i]))
                    magh += maghsad[i] - 'A';
                else
                    magh += maghsad[i] - 'a';
            }
            key = (mab * magh) / (mab + magh);
        }
        public void keymaker2(string mabda, string maghsad)
        {



            for (int i = 0; i < mabda.Length - 1; i++)
            {
                if (char.IsUpper(mabda[i]))
                    key += mabda[i] - 'A';
                else
                    key += mabda[i] - 'a';

            }

            for (int i = 0; i < maghsad.Length - 1; i++)
            {
                if (char.IsUpper(maghsad[i]))
                    key +=  maghsad[i] - 'A';
                else
                    key +=  maghsad[i] - 'a';

            }


        }
        public void decoding ( string filename )
        {
          
            key  %= 52;
            StringBuilder textFile = new StringBuilder();
            StreamReader sR = new StreamReader(filename);
            string text = sR.ReadToEnd();
            sR.Close();
            Console.WriteLine(text);
            for (int i = 0; i < text.Length; i++)
            {
                
                    if (char.IsUpper(text[i]))
                    {
                       
                        textFile.Append(Convert.ToChar('A' + (52 - key + (text[i] - 'A')) % 26));
                    }
                    else
                    {
                      
                        textFile.Append(Convert.ToChar('a' + (52 - key + (text[i] - 'a')) % 26));
                    }   
            }

            StreamWriter sw = File.CreateText(filename);
            sw.WriteLine(textFile.ToString());
            sw.Close();
        }
    }

}
