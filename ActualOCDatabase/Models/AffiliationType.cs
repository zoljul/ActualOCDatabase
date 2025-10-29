namespace ActualOCDatabase.Models
{
    // Use : byte to store as TINYINT in SQL Server (saves space). Change values/names to match your domain.
    public enum AffiliationType : byte
    {
        Luna = 0,
        Birchy = 1,
        Kureq = 2,
        Mixed = 3,
        Other = 4
    }
}