using System.ComponentModel.DataAnnotations;

namespace Queue_manager_models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }
        public int Name { get; set; }
        public int PhoneNumber { get; set;}


    }
}
