using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wise_waste
{
    public class UserSession
{
    private static UserSession instance;

    public int UserId { get; private set; }

    private UserSession()
    {
        // Private constructor to prevent external instantiation
    }

    public static UserSession Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UserSession();
            }
            return instance;
        }
    }

    public void SetUserId(int userId)
    {
        UserId = userId;
    }
}

}
