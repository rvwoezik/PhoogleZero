namespace PhoogleZero.Emailing
{
    public interface IEmailTemplateProvider
    {
        string GetDefaultTemplate(int? tenantId);
    }
}
