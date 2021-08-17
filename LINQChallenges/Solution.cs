using LINQChallenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    class Solution
    {

        #region Fields
        private static IEnumerable<string> _strings = Lists.StringList;
        private static IEnumerable<int> _ints = Lists.IntList;
        private static IEnumerable<Applicant> _applicantList = Lists.ApplicantList;
        #endregion


        #region Challenge #1
        // 1. Use the LINQ Where() method to return only the strings that are longer than 8 characters
        public static IEnumerable<string> LongStrings()
        {
            return _strings.Where(s => s.Length > 8);
        }
        #endregion


        #region Challenge #2
        // 2. Use the LINQ Where() method to return only strings that are exactly 6 characters long
        public static IEnumerable<string> Only6LetterStrings()
        {
            return _strings.Where(s => s.Length == 6);
        }
        #endregion


        #region Challenge #3
        // 3. Use the LINQ Where() method to return only the strings that begin with the letter 's'
        public static IEnumerable<string> OnlySWords()
        {
            var option1 = _strings.Where(s => s[0] == 's');

            var option2 = _strings.Where(s => s.First() == 's');

            var option3 = _strings.Where(s => {
                var firstChar = s?.FirstOrDefault();
                return firstChar == 's' || firstChar == 'S';
            });

            var option4 = _strings.Where(s => Char.ToLower(s.First()) == 's');

            return option4;
        }
        #endregion


        #region Challenge #4
        // 4. Use the LINQ Select() method to return each string and how long it is in the following format:
        // Example: If the list comprised of three strings: "tree", "garage", "great"
        // The return string list would look as follows:
        // "tree is 4 letters long", "garage is 6 letters long", "great is 5 letters long" 
        public static IEnumerable<string> WordsAndTheirLengths()
        {
            return _strings.Select(s => $"{s} is {s.Length} letters long.");
        }
        #endregion


        #region Challenge #5
        // 5. Use the LINQ Where() method to return all integers that are less than 10,000
        public static IEnumerable<int> IntegersLessThanTenThousand()
        {
            return _ints.Where(i => i < 10_000);
        }
        #endregion


        #region Challenge #6
        // 6. Use the LINQ Where() method to return all integers that are greater than 50,000 but less than 100,000
        public static IEnumerable<int> IntegersBetweenRange()
        {
            return _ints.Where(i => i > 50_000 && i < 100_000);
        }
        #endregion


        #region Challenge #7
        // 7. Use the LINQ Select() method to return every integer as a negative number
        // Example: If the list comprised of three integers (4, -20, 17) 
        // the return int list would look as follows: 
        // -4, -20, -17
        public static IEnumerable<int> IntegersAsNegativeNumbers()
        {
            var option1 = _ints.Select(i => i > 0 ? -i : i);

            var option2 = _ints.Select(i => -1 * Math.Abs(i));

            var option3 = _ints.Select(i => -Math.Abs(i));

            return option3;
        }
        #endregion


        #region Challenge #8
        // 8. Use the LINQ Where() method to return all the applicants that have more than 5 years of experience
        public static IEnumerable<Applicant> AllMoreExperiencedApplicants()
        {
            return _applicantList.Where(a => a.YearsOfWorkExperience > 5);
        }
        #endregion


        #region Challenge #9
        // 9. Use the LINQ Where method to return all applicants that are applying for the "Senior Graphic Designer" role
        public static IEnumerable<Applicant> AllSeniorGraphicDesigners()
        {
            return _applicantList.Where(a => a.PositionApplied == "Senior Graphic Designer");
        }
        #endregion


        #region Bonus
        // BONUS: Chain LINQ methods together to return the full names, in order by last name, of
        // all applicants whose salary range exceeds 90k
        // (either there lower or upper bound is greater than 90k)
        public static IEnumerable<string> AllExpensiveApplicants()
        {
            return _applicantList
                .Where(x => x.SalaryRange.LowerBound > 90_000 || x.SalaryRange.UpperBound > 90_000)
                .OrderBy(x => x.LastName)
                .Select(x => $"{x.FirstName} {x.LastName}");
        }
        #endregion
    }
}
