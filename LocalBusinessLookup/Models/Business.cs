namespace LocalBusiness
{
  public class Business
  {
    public int BusinessId { get; set; }
    public DateTime DateAdded { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }

    public Business()
    {
      DateAdded = DateTime.UtcNow;
    }
  }
}