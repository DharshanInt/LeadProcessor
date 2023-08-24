public class LeadProcessorService
{
    private readonly IStorageService _storageService;
    private readonly QueueService _queueService;

    public LeadProcessorService(IStorageService storageService, QueueService queueService)
    {
        _storageService = storageService;
        _queueService = queueService;
    }

    public void ProcessLead()
    {
        var lead = _queueService.GetLeadFromQueue();
        if (lead.IsValid())
        {
            _storageService.StoreLead(lead);
        }
    }
}
