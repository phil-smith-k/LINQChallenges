using LINQChallenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    class Program
    {
        private static IEnumerable<string> _strings = Lists.StringList;
        private static IEnumerable<int> _ints = Lists.IntList;
        private static IEnumerable<Applicant> _applicantList = Lists.ApplicantList;

        static void Main(string[] args)
        {
                         // replace this method call to test your solution
            var result = LongStrings();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        // 1. Use the LINQ Where() method to return only the strings that are longer than 8 characters
        public static IEnumerable<string> LongStrings()
        {
            return _strings;
        }


        // 2. Use the LINQ Where() method to return only strings that are exactly 6 characters long
        public static IEnumerable<string> Only6LetterStrings()
        {
            return _strings;
        }


        // 3. Use the LINQ Where() method to return only the strings that begin with the letter 's'
        public static IEnumerable<string> OnlySWords()
        {
            return _strings;
        }


        // 4. Use the LINQ Select() method to return each string and how long it is in the following format:
        // Example: If the list comprised of three strings: "tree", "garage", "great"
        // The return string list would look as follows:
        // "tree is 4 letters long", "garage is 6 letters long", "great is 5 letters long" 
        public static IEnumerable<string> WordsAndTheirLengths()
        {
            return _strings;
        }


        // 5. Use the LINQ Where() method to return all integers that are less than 10,000
        public static IEnumerable<int> IntegersLessThanTenThousand()
        {
            return _ints;
        }


        // 6. Use the LINQ Where() method to return all integers that are greater than 50,000 but less than 100,000
        public static IEnumerable<int> IntegersBetweenRange()
        {
            return _ints;
        }


        // 7. Use the LINQ Select() method to return every integer as a negative number
        // Example: If the list comprised of three integers (4, -20, 17) 
        // the return int list would look as follows: 
        // -4, -20, -17
        public static IEnumerable<int> IntegersAsNegativeNumbers()
        {
            return _ints;
        }


        // 8. Use the LINQ Where() method to return all the applicants that have more than 5 years of experience
        public static IEnumerable<Applicant> AllMoreExperiencedApplicants()
        {
            return _applicantList;
        }


        // 9. Use the LINQ Where method to return all applicants that are applying for the "Senior Graphic Designer" role
        public static IEnumerable<Applicant> AllSeniorGraphicDesigners()
        {
            return _applicantList;
        }


        // BONUS: Chain LINQ methods together to return the full names, in order by last name, of
        // all applicants whose salary range exceeds 90k
        // (either there lower or upper bound is greater than 90k)

        // Result should like this:
        // Kristen Applebees
        // Jeremy Bowes 
        // etc...
        public static IEnumerable<string> AllExpensiveApplicants()
        {
                   // change this to _applicants.Where etc..
            return Enumerable.Empty<string>();
        }
    }
}
