using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management
{
    public class Util
    {
        public static string TaoMaHoaDon(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] randomArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomArray);
        }
    }
}
