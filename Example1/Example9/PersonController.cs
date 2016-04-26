using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    class PersonController
    {
        List<PersonModel> personsList = new List<PersonModel>();
        public string dbDataPath;
        SQLiteConnection m_dbConnection;

        public PersonController(string path)
        {
            dbDataPath = path;
            
            /*
            PersonModel person1 = new PersonModel(
            "Joe", "Zorg", "552211", 45);
            PersonModel person2 = new PersonModel(
            "Joe", "Borg", "552212", 46);
            PersonModel person3 = new PersonModel(
            "Joe", "Eorg", "552211", 49);*/
            m_dbConnection = new SQLiteConnection(dbDataPath);
            m_dbConnection.Open();
            string sql = "SELECT * FROM Contact";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read()){
                 PersonModel p = new PersonModel(reader["firstName"].ToString(),reader["secondName"].ToString(), reader["telNumber"].ToString(),0);
                 personsList.Add(p);
            }
            m_dbConnection.Close();

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
