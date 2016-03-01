using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> phoneBook = new List<Contact>();

            Contact p1 = new Contact("Gerry", "123");
            Contact p2 = new Contact("Test", "456");
            Contact p3 = new Contact("Test3", "789");
            //add one contact
            phoneBook.Add(p1);
            
            //add two contacts
            phoneBook.AddRange(new Contact[]{p2,p3});

            //remove the first contact
            //phoneBook.RemoveAt(0);

            

            //find the contact in the List, based on the compareTo method
            Contact ctofind = new Contact("Gerry", "");

            //write 
            Console.WriteLine(phoneBook.BinarySearch(ctofind));

            



            foreach (Contact p in phoneBook)
                Console.WriteLine(p.Name + " " + p.Telnumber);

            Console.ReadLine();
        }
    }
}
