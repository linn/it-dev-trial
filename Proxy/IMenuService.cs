namespace Proxy
{
    using Domain;
    
    public interface IMenuService
    {
        // a method to GET the menu.json and deserialize into an object of the Menu class
        Menu GetMenu(string url);
    }
}
