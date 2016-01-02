namespace MNKINO.Services
{
    public interface IMailService
    {
        bool SendMail(string from,string replyTo, string body);
    }
}
