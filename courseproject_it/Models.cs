using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
//git@github.com:SofiFairyTell/courseproject_it.git HTTPS://github.com/SofiFairyTell/courseproject_it.git 
namespace Result_models
{
  [Table("Освидетельствуемый")]
   public class Person //освидетельствуемый
    {
        /*Общие данные об освидетельствуемом*/
        public int Id { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public string Birthday {get;set;}//позже сделать через поле времени 
        
        /*Категории*/
        public string Category_Person {get;set;}//категория_освидетельствуемого
        public string Arm_Status {get;set;}//
        
        //public DateTime Birtday {get;set;}
        /*Все что связано с диагнозом*/
        public string Article_Trebovanie {get;set;}
        public string Article_Raspisanie {get;set;}
        public string Diagnos {get;set;}
        public string Category_Godnost {get;set;}
        public string Result {get;set;} //заключение
        public int Result_Id {get;set;}
        public string Result_Date {get;set;}
        public string Result_Prichina {get;set;}
        public string Other {get;set;}   

        /*Списки для создания таблиц*/
        public ICollection<Category_Godnost> Godnost_list {get; set;} //список людей выбранной категории
        public ICollection<Category_Person> Category_list {get; set;} //список людей выбранной категории
        public ICollection<Arm_Status> Pers_Arm_list { get; set; }       
        public ICollection<Result_Prichina> ResPrich_list { get; set; }
        public Person()
            {
                Godnost_list = new List<Category_Godnost>();
                Category_list = new List<Category_Person>();
                Pers_Arm_list = new List<Arm_Status>();
                ResPrich_list = new List<Result_Prichina>();
            }   
   
    }

//таблицы для подстановки значений в таблицу Освидетельствуемый
    [Table("Категория годности")]
    public class Category_Godnost
    {
    	public int Id {get;set;}
    	public string Category {get;set;}
    	public string Description {get;set;}
        public Person Person;
    }
    [Table("Категория освидетельствуемого")]
    public class Category_Person
    {
    	public int Id {get;set;}
        public string Category {get;set;}
    	public string Description {get;set;}
        public Person Person;
    }
    [Table("Воинское звание")]
    public class Arm_Status
    {
        public int Id {get;set;}
        public string Status {get;set;}
        public string Description {get;set;}
        public Person Person;
    }
    [Table("Причинно-следственные связи")]
    public class Result_Prichina
    {
    	public int Id {get;set;}
        public string Prichina {get;set;}
    	public string Description {get;set;}
        public Person Person;
    }

  public class ResultMedContext : DbContext
        {
            public ResultMedContext()
               : base("ResultMed")
            { }

            public DbSet<Person> Persons { get; set; }
          //public DbSet<Category_Person>  { get; set; }
            //public DbSet<Team> Teams {get;set;}
        }
}