using System.Collections.Generic;

namespace Domain
{
    public interface IDomainService
    {
        IEnumerable<MenuItem> SearchMenu(Menu menu, string searchTerm);
    }
}
