namespace Software41.BackgroundCheck.Repository.EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Software41.BackgroundCheck.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<Software41.BackgroundCheck.Repository.EF.BackgroundCheckContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Software41.BackgroundCheck.Repository.EF.BackgroundCheckContext context)
        {
            context.Set<Applicant>().AddOrUpdate(a => a.FirstName,
                        new Applicant
                        {
                            FirstName = "David",
                            LastName = "OBrien",
                            MiddleName = "Michael"
                        },
                        new Applicant
                        {
                            FirstName = "Ben",
                            LastName = "Runchey",
                            MiddleName = "Mort"
                        },
                        new Applicant
                        {
                            FirstName = "Alan",
                            LastName = "Turing",
                            MiddleName = "Arthur"
                        },
                        new Applicant
                        {
                            FirstName = "Charles",
                            LastName = "Babbage",
                            MiddleName = "John"
                        });
        }
    }
}
