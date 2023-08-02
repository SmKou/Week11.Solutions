namespace DoctorOffice.Models;

public class Provider
{
    public int ProviderId { get; set; }
    public string ProviderName { get; set; }

    public int ProviderAuthId { get; set; }
    public ProviderAuth ProviderAuth { get; set; }

    public int ProviderAcctId { get; set; }
    public ProviderAcct ProviderAcct { get; set; }
}