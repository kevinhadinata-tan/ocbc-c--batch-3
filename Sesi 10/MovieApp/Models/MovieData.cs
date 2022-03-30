namespace MovieApp.Models
{
    public class MovieData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        
        // [DataType(DataType.Date)]
        // [Column(TypeName = "Date")]
        public string releaseDate { get; set; }
    }
}