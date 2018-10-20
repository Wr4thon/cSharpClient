namespace Finux.Ai.Api.Contract.DataClasses {
    /// <summary>
    /// The register data.
    /// </summary>
    public class RegisterData
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        public string RefreshToken { get; set; }
    }
}