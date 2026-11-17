using ThirtyDaysDotNet.Api.Interfaces;

public class DeveloperService : IDeveloperService
{
    private readonly Guid _instanceId = Guid.NewGuid();

    public string GetDeveloperName()
    {
        return "Mubashar Yasin";
    }

    public string GetInstanceId()
    {
        return _instanceId.ToString();
    }
}
