namespace Simple_API_template;

public enum Role { admin, user }
public interface IAuthenticator
{
    Role? Authenticate(string username, string password);
}