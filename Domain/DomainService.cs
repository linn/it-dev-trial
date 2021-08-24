namespace Domain
{
    using System;
    using System.Collections.Generic;

    public class DomainService : IDomainService
    {
        public IEnumerable<MenuItem> SearchMenu(Menu menu, string searchTerm)
        {
            throw new NotImplementedException();
        }

        // this is just to make sure tests are running
        public bool Test()
        {
            return true;
        }
    }
}
