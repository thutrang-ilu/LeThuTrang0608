using Microsoft.EntityFrameworkCore;
using LeThuTrang0608.Models;
namespace LeThuTrang0608.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
