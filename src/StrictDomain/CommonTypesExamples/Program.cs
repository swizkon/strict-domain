using CommonTypesExamples.DomainModel;
using Practices;
using System;

namespace CommonTypesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            long carId,empId;
             carId = empId = rnd.Next();

            IdentifierFor<Employee> employeeIdentifier = (empId);

            employeeIdentifier = (Guid.NewGuid());

            var carIdentifier = new IdentifierFor<Car>(carId);

            var carwash = new Carwash();

            carwash.Hire(employeeIdentifier);

            carwash.Assign(empId, carId);
            carwash.Assign(carId, empId);

            Console.WriteLine(employeeIdentifier);
            Console.WriteLine((long)employeeIdentifier);
            
            Console.WriteLine(carIdentifier);
            Console.WriteLine((long)carIdentifier);

            Console.WriteLine(employeeIdentifier.Equals(employeeIdentifier));

            Console.WriteLine(employeeIdentifier.Equals(carIdentifier));

            Console.WriteLine(employeeIdentifier == employeeIdentifier);

            // Console.ReadLine();
        }
    }
}
