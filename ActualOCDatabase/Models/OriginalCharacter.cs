using System.ComponentModel.DataAnnotations;

namespace ActualOCDatabase.Models
{
    public class OriginalCharacter
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? NickName { get; set; }

        public AffiliationType Affiliation { get; set; } = AffiliationType.Luna;

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
