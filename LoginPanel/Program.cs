namespace LoginPanel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin LoginPanel = new Admin(true, "Admin.Panel", "", "");
            LoginPanel.UsersInfo();
        }
    }
}