namespace SOLID_csharp.Interfaces
{
    public interface IEmailService
    {
        void SendMail(string email);

        bool ValidateEmail(string email);
    }
}