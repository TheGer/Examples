using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example12
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Hello");
            RunExample();
            Console.ReadKey();

            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());*/
        }

        public static void RunExample()
        {
            using (var context = new ContactContext())
            {
                var contacts = from a in context.Contact
                               where a.FirstName.StartsWith("G")
                               orderby a.FirstName
                               select a;

                foreach (var c in contacts)
                {
                    Console.WriteLine(c.Id + " " + c.FirstName);
                }
            }

            // ### Add a db record
            
            using (var context = new ContactContext())
            {
                context.Configuration.ValidateOnSaveEnabled = false;
                context.Contact.Add(
                    new Contact
                    {
                        FirstName = "Gerard",
                        SecondName = "Said",
                        TelNumber = "1234",
                    });
                context.SaveChanges();
            }

            
        }


    }

    
    public class Contact
    {
        [Column("id")]
        [Key]
        public long? Id { get; set; }

       public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string TelNumber { get; set; }


    }

    class ContactContext : DbContext
    {
        public DbSet<Contact> Contact { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Contact>()
        .Property(c => c.Id)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }

   
    

}
