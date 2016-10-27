using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace DictionaryBot
{
    public class Dictionary
    {
        public static async Task<string> GetMeaningAsync(string InputWord)
        {
            try
            {
                //word search API call
                string serviceURL = $"https://aplet123-wordnet-search-v1.p.mashape.com/master?word={InputWord}";
                string ResultInJSN;
                using (WebClient client = new WebClient())
                {
                    //set headers to authorize your call
                    client.Headers["Accept"] = "application/json";
                    //create your own app key from market.mashape.com
                    client.Headers["X-Mashape-Key"] = "H6ATRwp7KimshiDjfa1sybRYNrW0p1VLolcjsnXUDT8zSnS6lf";
                    
                   return ResultInJSN = await client.DownloadStringTaskAsync(serviceURL);
                }
            }
            catch (WebException ex)
            {
                //handle your exception here  
                throw ex;
            }
        }
    }
}