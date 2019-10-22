using System.ComponentModel.DataAnnotations;

namespace ServiceManagement.Api
{
    /// <summary>
    /// Represents a package that was used during a build
    /// </summary>
    public class PackageReference
    {
        /// <summary>
        /// The name of the package that was used
        /// </summary>
        [Required]
        public string Name { get; set; } = "";
        /// <summary>
        /// The version of the package that was used
        /// </summary>
        [Required]
        public string Version { get; set; } = "";
    }
}