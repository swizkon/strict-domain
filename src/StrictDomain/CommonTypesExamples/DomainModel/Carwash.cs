using Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesExamples.DomainModel
{
    public class Carwash
    {


        public void Hire(IdentifierFor<Employee> emp)
        {
        }

        public void Assign(IdentifierFor<Employee> emp, IdentifierFor<Car> car)
        {
            long val = (long) emp;
        }

        public void Assign(long employee, long car)
        {
        }
    }
}
