namespace Domain
{
    using System.Collections.Generic;

    public interface IDomainService
    {
        IEnumerable<MenuItem> SearchMenu(Menu menu, string searchTerm);
    }
}
