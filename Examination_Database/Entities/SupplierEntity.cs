using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Examination_Database.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    internal class SupplierEntity
    {
        [Key] public int Id { get; set; }

        public string CompanyName { get; set; } = null!;

        public string ContactName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int AdressId { get; set; }
        public AdressEntity Adress { get; set; } = null!;


    }
}
