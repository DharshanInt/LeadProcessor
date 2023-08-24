public class QueueService
{
    public Lead GetLeadFromQueue()
    {
        // Mocking getting the lead
        return new Lead 
        {
            FirstName = "RandomFirstName",
            LastName = "RandomLastName",
            Email = "random@test.com",
            PhoneNo = 1234567890,
            Source = "Facebook",
            DateTime = DateTime.Now
        };
    }
}
