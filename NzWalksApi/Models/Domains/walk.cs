namespace NzWalksApi.Models.Domains
{
    public class walk
    {
        public Guid Id { get; set; }
        public String Description { get; set; }
        public String Name   { get; set; }
        public string? WalkImageUrl { get; set; }

        public Guid DificultyID { get; set; }
        public Guid RegionId { get; set; }

        //navigation property
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
