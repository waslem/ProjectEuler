using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace ProjectEuler22
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = ConfigurationManager.AppSettings["filelocation"];

            Stopwatch watch = new Stopwatch();
            watch.Start();
            List<Name> names = LoadNames(fileLocation);
            ScoreNames(ref names);
            int total = CalculateTotalScore(names);
            watch.Stop();

            Console.WriteLine("answer: {0}", total);
            Console.WriteLine("Time: {0}", watch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static int CalculateTotalScore(List<Name> names)
        {
            int total = 0;
            for (int i = 0; i < names.Count; i++)
            {
                total += names[i].Score;
            }

            return total;
        }

        public static void ScoreNames(ref List<Name> names)
        {

            for (int i = 0; i < names.Count; i++)
			{
			    Char[] stringToScore = names[i].NameString.ToCharArray();
                int sum = 0;

                foreach (var letter in stringToScore)
                {
                    sum +=ScoreLetter(letter);
                }

                names[i].Score = sum * (i + 1);   
			}
        }

        public static int ScoreLetter(char letter)
        {
            int result = (int)(letter - 64);
            return result;
        }

        public static List<Name> LoadNames(string path)
        {
            List<Name> names = new List<Name>();
            List<string> nameStringsList = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    //split the line by comma which separates the name.
                    nameStringsList = line.Split(',').ToList();
                }
            }

            // sort alphabetical
            nameStringsList.Sort();

            foreach (var item in nameStringsList)
            {
                names.Add(new Name { NameString = item, Score = 0 });
            }

            for (int i = 0; i < names.Count; i++)
            {
                names[i].NameString = names[i].NameString.Trim(new Char[] { ' ', '/', '"' });
            }

            return names;
        }
    }
}
