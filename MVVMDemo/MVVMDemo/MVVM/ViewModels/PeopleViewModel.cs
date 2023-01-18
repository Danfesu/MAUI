using MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVVM.ViewModels
{
    class PeopleViewModel
    {
        public List<Person> People { get; set; } = new List<Person>();

        public PeopleViewModel()
        {
            People.Add(new Person() { Name = "Jhon", Age = 42, Married = true, BirthDate = new DateTime(2000, 08, 05), Lunchtime = new TimeSpan(10, 02, 32), Weight = 24 });
            People.Add(new Person() { Name = "Mary", Age = 35, Married = false, BirthDate = new DateTime(2000, 08, 05), Lunchtime = new TimeSpan(10, 02, 32), Weight = 24 });
            People.Add(new Person() { Name = "Bob", Age = 25, Married = true, BirthDate = new DateTime(2000, 08, 05), Lunchtime = new TimeSpan(10, 02, 32), Weight = 24 });
            People.Add(new Person() { Name = "Jane", Age = 22, Married = false, BirthDate = new DateTime(2000, 08, 05), Lunchtime = new TimeSpan(10, 02, 32), Weight = 24 });
            People.Add(new Person() { Name = "Jack", Age = 18, Married = true, BirthDate = new DateTime(2000, 08, 05), Lunchtime = new TimeSpan(10, 02, 32), Weight = 24 });

        }
    }
}
