using System.Collections.Generic;
using System.Data.Entity;
using WebApplication7.Models;

namespace WebApplication7.DataAccess
{
    public class PeopleInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            context.People.AddRange(new List<Person>
            {
                new Person
                {
                    FullName = "Ernar Myrzahmetov",
                    PhoneNumber = "+77075559988"
                },
                new Person
                {
                    FullName = "Kuanysh Nurmuhammedov",
                    PhoneNumber = "+77016697766"
                },
                new Person
                {
                    FullName = "Zhanara Zhuanyshbaeva",
                    PhoneNumber = "+77012479964"
                }
            });
        }
    }
}