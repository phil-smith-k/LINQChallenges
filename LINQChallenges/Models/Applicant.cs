using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges.Models
{
    public class Applicant
    {
        public Applicant()
        {

        }

        public Applicant(
            string firstName, 
            string lastName,
            DateTime dateApplied,
            int yearsOfWorkExperience, 
            string positionApplied, 
            Range<decimal> salaryRange)
        {
            FirstName = firstName;
            LastName = lastName;
            DateApplied = dateApplied;
            YearsOfWorkExperience = yearsOfWorkExperience;
            PositionApplied = positionApplied;
            SalaryRange = salaryRange;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateApplied { get; set; }
        public int YearsOfWorkExperience { get; set; }
        public string PositionApplied { get; set; }

        public Range<decimal> SalaryRange { get; set; }
    }
}
