public class Lead
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public long PhoneNo { get; set; }
    public string Source { get; set; }
    public DateTime DateTime { get; set; }

    public bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(FirstName) ||
            string.IsNullOrWhiteSpace(LastName) ||
            string.IsNullOrWhiteSpace(Email) ||
            string.IsNullOrWhiteSpace(Source))
        {
            return false;
        }

        return true;
    }
}
