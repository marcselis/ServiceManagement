using System;
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
        /// When this build has run
        /// </summary>
        public DateTime BuiltOn { get; set; }

        /// <summary>
        /// The component of this service that was built
        /// </summary>
        [Required]
        public string Component { get; set; } = "";

        /// <summary>
        /// The list of packages that were used during the build
        /// </summary>
        public List<PackageReference> Packages { get; } = new List<PackageReference>();

        /// <summary>
        /// The service this build was for
        /// </summary>
        [Required]
        public string Service { get; set; } = "";

        /// <summary>
        /// The .NET frameworks used in this build
        /// </summary>
        public List<string> TargetFrameworks { get; } = new List<string>();
    }
}