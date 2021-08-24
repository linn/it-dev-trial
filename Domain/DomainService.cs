namespace Domain
{
    using System.Collections.Generic;

    public class DomainService : IDomainService
    {
        public IEnumerable<MenuItem> SearchMenu(Menu menu, string searchTerm)
        {
            return new List<MenuItem> { new MenuItem { Title = "title" } }; 
        }

        // this is just to make sure tests are running
        public bool Test()
        {
            return true;
        }
    }
}
