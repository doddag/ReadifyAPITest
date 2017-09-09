using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyAPI.Controllers.api
{
    public class ReverseWordsController : ApiController
    {
        // Get /api/Readify/"this is a test"
        [System.Web.Http.HttpGet]
        [System.Web.Http.ActionName("ReverseWords")]
        public string ReverseWords(string sentence)
        {
            string newSentance = "";
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.None);
            if (words.Length > 0)
            {
                foreach (var word in words)
                {
                    if (!string.IsNullOrEmpty(newSentance))
                        newSentance += " ";

                    newSentance += new string(word.Reverse().ToArray());
                }
            }

            return newSentance;
        }
    }
}
