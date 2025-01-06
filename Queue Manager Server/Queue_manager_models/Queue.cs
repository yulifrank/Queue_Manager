using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_manager_models
{
    public class Queue
    {
        public int QueueId { get; set; }
        public List<Person> People { get; set; }

        public Queue(int queueId)
        {
            QueueId = queueId;
            People = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public Person RemovePerson()
        {
            if (People.Count > 0)
            {
                var person = People[0];
                People.RemoveAt(0);
                return person;
            }
            return null;
        }

        // פונקציה שמחזירה את מספר האנשים בתור
        public int GetQueueLength()
        {
            return People.Count;
        }
    }

}
