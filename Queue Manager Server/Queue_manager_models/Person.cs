using System.ComponentModel.DataAnnotations;

namespace Queue_manager_models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Name} ({PhoneNumber})";
        }

    }
}
