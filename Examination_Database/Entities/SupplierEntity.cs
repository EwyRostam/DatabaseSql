using System.ComponentModel.DataAnnotations;

namespace Examination_Database.Entities
{
    internal class SupplierEntity
    {
        [Key] public int Id { get; set; }

        public string CompanyName { get; set; } = null!;
    }
}
