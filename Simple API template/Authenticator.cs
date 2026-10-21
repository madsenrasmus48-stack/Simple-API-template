using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Simple_API_template;

public class SimpleAuthenticator : IAuthenticator
{
    public Role? Authenticate(string username, string password)
    {
        if (username == "admin" && password == "1234")
        {
            return Role.admin;
        }
        else if (username == "user" && password == "1234")
        {
            return Role.user;
        }
        else
        {
            return null;
        }
    }
}
