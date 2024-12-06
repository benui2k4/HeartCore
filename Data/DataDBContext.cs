using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HeartCoreAPI.Data
{
    public class DataDBContext :DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }   


    }
}
