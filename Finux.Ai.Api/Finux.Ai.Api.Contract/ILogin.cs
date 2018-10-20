namespace Finux.Ai.Api.Contract
{
    using System.Security;
    using System.Threading.Tasks;

    using Finux.Ai.Api.Contract.DataClasses;
    using Finux.Ai.Api.Contract.DataClasses.Responses;

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
        Task<LoginResponse> Login(string email, SecureString password);

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
        /// The <see cref="Task"/>.
        /// </returns>
        Task<LoginResponse> Login(string email, string password);
    }
}
