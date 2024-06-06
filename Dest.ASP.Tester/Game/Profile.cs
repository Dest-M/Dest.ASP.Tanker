namespace Dest.ASP.Tester.Game;
public class Profile : IProfile
{
    private Dictionary<string, string> _profiles = new Dictionary<string, string>()
    {
    { "admin","admin"},
   
};

    public bool ValidateProfile(string login, string password)
    {
        if (!(_profiles.Keys.Contains(login))) { return false; }
         if   (_profiles[login] != password) return false;

        return true;
    }
}


