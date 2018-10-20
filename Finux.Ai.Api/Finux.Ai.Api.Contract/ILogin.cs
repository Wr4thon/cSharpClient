namespace Finux.Ai.Api.Contract
{
    using System.Security;

    using Finux.Ai.Api.Contract.DataClasses;

    /// <summary>
    /// The Login interface.
    /// </summary>
    public interface ILogin
    {
        /// <summary>
        /// Returns an access- and refreshToken for valid and existing login-credentials.
        /// </summary>
        /// <param name="email">
        /// The email.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// The <see cref="LoginResponse"/>.
        /// </returns>
        LoginResponse Login(string email, SecureString password);
    }
}
