using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var user = new User();
        while (true)
        {
            Console.WriteLine("Please enter the username, or q to exit");
            var userName = Console.ReadLine();
            if (userName == "q")
            {
                break;
            }

            user.Add(userName);
            Console.WriteLine($"number of added user {user.GetUsersCount()}");
        }
    }
}

class User
{
    private List<string> _users = new List<string>();

    public void Add(string userName)
    {
        _users.Add(userName);
    }

    public int GetUsersCount()
    {
        return _users.Count;
    }
}
