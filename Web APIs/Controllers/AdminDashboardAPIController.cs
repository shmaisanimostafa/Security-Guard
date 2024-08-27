using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Security_Guard.Models;
using Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using File = Shared.Models.File;


namespace Security_Guard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(Roles = "Admin")] // Protect API methods with Admin role authorization
    public class AdminDashboardApiController : ControllerBase
    {
        private readonly DBContext context;

        public AdminDashboardApiController(DBContext ctx)
        {
            context = ctx;
        }

        // GET: api/AdminDashboardApi/links
        [HttpGet("links")]
        public async Task<ActionResult<IEnumerable<Link>>> GetLinks()
        {
            var links = await context.Links.ToListAsync();
            return Ok(links);
        }

        // GET: api/AdminDashboardApi/files
        [HttpGet("files")]
        public async Task<ActionResult<IEnumerable<File>>> GetFiles()
        {
            var files = await context.Files.ToListAsync();
            return Ok(files);
        }

        // POST: api/AdminDashboardApi/links
        [HttpPost("links")]
        public async Task<ActionResult<Link>> AddLink([FromBody] Link newLink)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            newLink.DateTime = DateTime.Now;
            context.Links.Add(newLink);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLinks), new { id = newLink.Id }, newLink);
        }

        // POST: api/AdminDashboardApi/files
        [HttpPost("files")]
        public async Task<ActionResult<File>> AddFile([FromBody] File newFile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            newFile.DateTime = DateTime.Now;
            context.Files.Add(newFile);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFiles), new { id = newFile.Id }, newFile);
        }

        // DELETE: api/AdminDashboardApi/links/{id}
        [HttpDelete("links/{id}")]
        public async Task<IActionResult> DeleteLink(int id)
        {
            var link = await context.Links.FindAsync(id);

            if (link == null)
                return NotFound();

            context.Links.Remove(link);
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/AdminDashboardApi/files/{id}
        [HttpDelete("files/{id}")]
        public async Task<IActionResult> DeleteFile(int id)
        {
            var file = await context.Files.FindAsync(id);

            if (file == null)
                return NotFound();

            context.Files.Remove(file);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
