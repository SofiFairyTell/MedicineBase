using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Entity;
//git@github.com:SofiFairyTell/courseproject_it.git HTTPS://github.com/SofiFairyTell/courseproject_it.git 
namespace courseproject_it_models
{
  // [Table("Person")]
   public class Person //освидетельствуемый
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public string Category_Person {get;set;}//категория_освидетельствуемого
        public string Arm_Status {get;set;}//
        public string Birthday {get;set;}//позже сделать через поле времени 
        //public DateTime Birtday {get;set;}
        public string Article_Trebovanie {get;set;}
        public string Article_Raspisanie {get;set;}
        public string Diagnos {get;set;}
        public string Category_Godnost {get;set;}
        public string Result {get;set;} //заключение
        public int Result_Id {get;set;}
        public string Result_Date {get;set;}
        public string Result_Prichina {get;set;}
        public string Other {get;set;}      
    }
//таблицы для подстановки значений в таблицу Освидетельствуемый
    public class Category_Godnost
    {
    	public int Id {get;set;}
    	public string Category {get;set;}
    	public string Description {get;set;}
    }
    public class Category_Person
    {
    	public string Category {get;set;}
    	public string Description {get;set;}
        public ICollection<Person> Pers_list {get; set;} //список людей выбранной категории
        public Category_Person()
            {
                Pers_list = new List<Person>();
            }
    }
    public class Result_Prichina
    {
    	public string Prichina {get;set;}
    	public string Description {get;set;}
    }
    public class Arm_Status
    {
    	public string Status {get;set;}
    	public string Description {get;set;}
        public ICollection<Person> Pers_Arm_list { get; set; }
        public Arm_Status()
            {
                Pers_Arm_list = new List<Person>();
            }

    }
  public class ResultMedContext : DbContext
        {
            public ResultMedContext()
               : base("ResultMed")
            { }

            public DbSet<Person> Persons { get; set; }
            public DbSet<Category_Person> TableCategory { get; set; }
            //public DbSet<Team> Teams {get;set;}
        }
}