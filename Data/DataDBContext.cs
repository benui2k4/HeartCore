using HeartCoreAPI.Models;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HeartCoreAPI.Data
{
    public class DataDBContext :DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<DoctorProfile> DoctorProfiles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<LoginAttempt> LoginAttempts { get; set; }
        public DbSet<AdminLog> AdminLogs { get; set; }
    }
}
