namespace Service.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    using Domain;
    using Proxy;

    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IDomainService domainService;

        private readonly IMenuService menuService;

        public MenuController()
        {
        }

        // GET api/menu
        [HttpGet]
        public ActionResult<IEnumerable<MenuItem>> Get(string searchTerm=null)
        {
            throw new NotImplementedException();
        }
    }
}
