using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example9
{

    [Table("Contact")]
    class PersonModel:IComparable
    {
        [Column("id")]
        [Key]
        public long? Id { get; set; }


        //these are set to link to the database field since the class is annotated to 
        //be linked to the tables 
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string TelNumber { get; set; }
        //the ? means that the value can be null within the database
        public int? Age { get; set; }


        //the entity framework requires a default empty constructor
        public PersonModel() { }


        public PersonModel(string n,string s,string t,int a)
        {
    
            this.FirstName = n;
            this.SecondName = s;
            this.TelNumber = t;
            this.Age = a;
            
        }

     

        public int CompareTo(object obj)
        {
            //sort surname by alphabetical order
            PersonModel otherPerson = (PersonModel)obj;
            
            //1. sort by surname
            if (this.SecondName != otherPerson.SecondName) return this.SecondName.CompareTo(otherPerson.SecondName);
            
            //2. sort by name
            if (this.FirstName != otherPerson.FirstName) return this.FirstName.CompareTo(otherPerson.FirstName);
            
            //3. sort by telephone number
            if (this.TelNumber != otherPerson.TelNumber) return this.TelNumber.CompareTo(otherPerson.TelNumber);
            return -1;
        }


    }
}
