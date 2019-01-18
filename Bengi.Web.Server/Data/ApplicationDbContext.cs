using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bengi.Web.Server
{
    /// <summary>
    /// The database representation model for this application
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Public properties
        // DbSet: Table - uses the SettingsDataModel class for the columns, and the table is called Settings.
        // To access this table, ApplicationDbContext.Settings
        public DbSet<SettingsDataModel> Settings { get; set; }
        #endregion

        #region .ctor
        /// <summary>
        /// Default constructor, expecting database options passed in
        /// </summary>
        /// <param name="options">Database context options, passes in the ConnectionString</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<SettingsDataModel>().HasIndex(a => a.Name).IsUnique(true);
        }

    }
}
