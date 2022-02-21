namespace Assignment2.Migrations
{
    using Assignment2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.MyDatabase.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment2.MyDatabase.ApplicationDbContext context)
        {
            Trainer t1 = new Trainer() { Name= "Michael Scott", Subject= "C#" };
            Trainer t2 = new Trainer() { Name= "Pam Beesly", Subject= "Javascript" };
            Trainer t3 = new Trainer() { Name= "Jim Halpert", Subject= "JAVA" };
            Trainer t4 = new Trainer() { Name= "Dwight Schrute", Subject= "C++" };
            Trainer t5 = new Trainer() { Name= "Stanley Hudson", Subject= "JAVA" };

            List<Trainer> trainers = new List<Trainer>() {t1,t2,t3,t4,t5 };
            context.Trainers.AddRange(trainers); 
            context.SaveChanges();
        }
    }
}
