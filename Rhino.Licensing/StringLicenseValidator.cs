namespace Rhino.Licensing
{
    /// <summary>
    /// Validates content of a license file
    /// </summary>
    public class StringLicenseValidator : AbstractLicenseValidator
    {
        /// <summary>
        /// Creates a new instance of <seealso cref="StringLicenseValidator"/>
        /// </summary>
        /// <param name="publicKey">public key</param>
        /// <param name="license">license content</param>
        /// <param name="enableDiscovery">Whether to enable the client discovery server to detect duplicate licenses used on the same network.</param>
        public StringLicenseValidator(string publicKey, string license, bool enableDiscovery = true)
            : base(publicKey, enableDiscovery)
        {
            License = license;
        }

        /// <summary>
        /// License content
        /// </summary>
        protected override string License
        {
            get; set;
        }
    }
}