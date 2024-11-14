namespace testapp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("enter password: ");  
        string password = Console.ReadLine();

        bool isAdmin = Program.LoginAdmin(username, password);

        if(isAdmin)
        {
            Console.WriteLine("logged in");
            ShowUserInfo(username);
        }
        else
        {
            Console.WriteLine("can not log in");
        }

        Logout();
    }

    static bool LoginAdmin(string name, string password)
    {
        if(name == "admin" && password == "admin")
        {
            return true;
        }
        return false;
    }

    static void ShowUserInfo(string username)
    {
        Console.WriteLine("you are " + username);
    }
      
    static void Logout()
    {
        Console.WriteLine("logged out");
    }
}
