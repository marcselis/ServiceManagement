using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceManagement.Api
{
    /// <summary>
    /// Represents the result of a build
    /// </summary>
    public class BuildResult
    {
        /// <summary>
        /// The service this build was for
        /// </summary>
        [Required]
        public string Service { get; set; } = "";
        /// <summary>
        /// The component of this service that was built
        /// </summary>
        [Required]
        public string Component { get; set; } = "";
        /// <summary>
        /// The list of packages that were used during the build
        /// </summary>
        public List<PackageReference> Packages { get; } = new List<PackageReference>();
    }
}