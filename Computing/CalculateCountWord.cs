using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using Microsoft.EntityFrameworkCore;
using ParserPages.Models;

namespace ParserPages.Computing
{
    public class CalculateCountWord
    {
        List<string> Separators =
              new List<string>() { " ", ",", ".", "!", "\"", "?", ";", ":", "[", "]", "(", ")", "\n", "\r", "\t" };

        
        public List<StaticItem> TextAndCountList = new List<StaticItem>();
       
        ParserPageContext _ct;
        public static async Task<string> GetHtmlSourceCodeAsync(string uri)
        {
            var httpClient = new HttpClient();
            try
            {
                var htmlSource = await httpClient.GetStringAsync(uri);
                return htmlSource;
            }
            catch (HttpRequestException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{nameof(HttpRequestException)}: {e.Message}");
                return null;
            }
        }

        public  async Task FindByAttributeAsync(string _url, ParserPageContext ct)
        {
            /* string url = "http://www.pythonscraping.com/pages/warandpeace.html";*/
            _ct = ct;
            
            var html = await GetHtmlSourceCodeAsync(_url);
            if (!string.IsNullOrWhiteSpace(html))
            {
                var parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(html);

                var tags = document.QuerySelectorAll("*");
                foreach (var tag in tags)
                {

                    FillListWithTextInTag(tag.TextContent, _url);
                }
            }
            else
            {
                Console.WriteLine("No html source code returned.");
            }
            
        }

        void FillListWithTextInTag(string text, string address)
        {
            
            string[] words = ReplaceSeparators(text);
            foreach (var word in words)
            {
                if (word != "")
                {

                    if (TextAndCountList.Count > 0)
                    {
                        int index = TextAndCountList.FindIndex(x => x.Word == word);
                        if (index > 0)
                        {
                            TextAndCountList[index].Frequency = TextAndCountList[index].Frequency + 1;
                        }
                        else 
                        {
                            StaticItem newItem = new StaticItem();
                            newItem.PageAddress = address;
                            newItem.Frequency = 1;
                            newItem.Word = word;
                            TextAndCountList.Add(newItem);
                        }

                    }
                    else
                    {
                        StaticItem newItem = new StaticItem();
                        newItem.PageAddress = address;
                        newItem.Frequency = 1;
                        newItem.Word = word;
                        TextAndCountList.Add(newItem);
                    }

                }
            }


        }

        string[] ReplaceSeparators(string text)
        {
            string[] listWords = new string[text.Split(" ").Length];
            if (text != "")
            {

                listWords = text.Split(" ");
                foreach (var word in listWords)
                {
                    foreach (var separator in Separators)
                    {
                        word.Replace(separator, "");
                    }
                }
                return listWords;
            }
            return listWords;
        }
    }
}
