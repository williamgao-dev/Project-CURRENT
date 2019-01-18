using System.ComponentModel.DataAnnotations;

namespace Project.Web.Server
{
    /// <summary>
    /// Each property in this class represents a column on the Settings table
    /// </summary>
    public class SettingsDataModel
    {
        /// <summary>
        /// Unique id for this entry (primary key)
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// Settings name, required
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// Settings value
        /// </summary>
        [Required]
        [MaxLength(2048)]
        public string Value { get; set; }

    }
}
