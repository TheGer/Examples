using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    class PersonController
    {
        List<PersonModel> personsList = new List<PersonModel>();

        public PersonController()
        {
            PersonModel person1 = new PersonModel(
            "Joe", "Zorg", "552211", 45);
            PersonModel person2 = new PersonModel(
            "Joe", "Borg", "552212", 46);
            PersonModel person3 = new PersonModel(
            "Joe", "Eorg", "552211", 49);

            personsList.Add(person1);
            personsList.Add(person2);
            personsList.Add(person3);
        }

        public List<PersonModel> getPersons()
        {
            return personsList;
        }

        public void addPerson(PersonModel personToAdd)
        {
            personsList.Add(personToAdd);
        }

        public void updatePerson(PersonModel personToUpdate)
        {
            PersonModel currentPerson = personsList.Find(person => person.Telnumber == personToUpdate.Name && person.Surname == personToUpdate.Surname);
            currentPerson = personToUpdate;

            
        }

        public void deletePerson(PersonModel personToDelete)
        {
            PersonModel currentPerson = personsList.Find(person => person.Telnumber == personToDelete.Telnumber);
            personsList.Remove(currentPerson);
        }

        public void findPerson(PersonModel personToFind)
        {
            PersonModel currentPerson = personsList.Find(person => person.Telnumber == personToFind.Telnumber);
            
        }

        public void sortPersons()
        {
            personsList.Sort();
        }

    }
}
