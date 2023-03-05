using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ERP_APP.Model;

namespace ERP_APP.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public DesignationController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: api/Designation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblDesignation>>> GetTblDesignation()
        {
            return await _context.TblDesignation.ToListAsync();
        }

    }
}
