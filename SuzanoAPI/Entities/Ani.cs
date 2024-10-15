namespace SuzanoAPI.Entities
{
    public class Ani
    {
        public string Phone { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Cliente_id { get; set; }

        public virtual Cliente? Cliente { get; set; }
    }
}
