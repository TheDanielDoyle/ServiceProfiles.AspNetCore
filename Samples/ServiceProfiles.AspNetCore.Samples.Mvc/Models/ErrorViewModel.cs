namespace ServiceProfiles.AspNetCore.Samples.Mvc.Models;

public class ErrorViewModel
{
    public string RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}