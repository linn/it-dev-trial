namespace Service.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    using Domain;
    using Proxy;

    [Route("menu/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IDomainService domainService;

        private readonly IMenuService menuService;

        public SearchController()
        {
        }

        // GET menu/search
        [HttpGet]
        public ActionResult<IEnumerable<MenuItem>> Get(string searchTerm=null)
        {
            throw new NotImplementedException();
        }
    }
}
