using System.Data.Entity;

namespace FrameWorkCF.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return $"Nome: {Name}\nPhone: {Phone}\nMail: {Mail}";
        }
    }
}
