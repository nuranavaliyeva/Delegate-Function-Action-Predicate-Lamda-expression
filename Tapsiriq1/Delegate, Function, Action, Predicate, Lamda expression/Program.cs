using Delegate__Function__Action__Predicate__Lamda_expression.Models;

namespace Delegate__Function__Action__Predicate__Lamda_expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>

           {
               new Person {Name = "Relax", Surname = "Valiyeva", Age = 19 },
               new Person {Name = "Ebilhesen", Surname = "Hesenov", Age= 20 },
               new Person {Name = "Elvin", Surname = "Ceferquliyev", Age = 24}


           };
           List<Person> searched1= People.FindAll(s => s.Name == "Relax");


            List<Person> searched2 = People.FindAll(s => s.Surname.EndsWith("ova"));

            List<Person> searched3 = People.FindAll(s => s.Surname.EndsWith("ov"));
            List<Person> searched4 = People.FindAll(s => s.Age >= 20);




            //searched1.ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
            //searched2.ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
            //searched3.ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
            //searched4.ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));

        }
    }
}
