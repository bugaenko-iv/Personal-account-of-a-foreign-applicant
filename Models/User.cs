using System.ComponentModel.DataAnnotations;

namespace Личный_кабинет_иностранного_абитуриента.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
