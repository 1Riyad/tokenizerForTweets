using System;
using System.Collections.Generic;
namespace TuwaiqBootcampCode_tokenizer_concept
{
    public class tokenizer_concept
    {

     static List<List<string>> tokenizerForTweets(string source)
        {
            List <List<string>> all = new List<List<string>>();

            List<string> tags = new List<string>();
            List<string> mentions = new List<string>();

            string t = "";
            int idx = 0;
            while (idx  < source.Length)
            {
                t = "";
                int x = idx + 1;
                int idxs = idx;
                if (source[idxs] =='#' && x < source.Length && !Char.IsWhiteSpace(source[x])) {
                    t += source[idxs];
                    idxs++;
                    while (idxs < source.Length && (!Char.IsWhiteSpace(source[x]) ||  !Char.IsPunctuation(source[x]))){
                        t += source[idxs];
                        idxs++;
                    }
                    tags.Add(t);
                    Console.WriteLine(t);

                }

                if (source[idxs] == '@' && x < source.Length)
                {
                    while (idxs < source.Length && (!Char.IsWhiteSpace(source[x]) || !Char.IsPunctuation(source[x])))
                    {
                        t += source[idxs];
                        idxs++;
                    }
                    mentions.Add(t);
                    Console.WriteLine(t);
                }

                //Console.WriteLine(tags.ToString());
                idx++;
               
            }
            all.Add(tags);
            all.Add(mentions);

            return all;
        }


    }
}
