namespace Finux.Ai.Api.Contract
{
    using System.Security;
    using System.Threading.Tasks;

    using Finux.Ai.Api.Contract.DataClasses.Responses;

    /// <summary>
    /// The Register interface.
    /// </summary>
    public interface IRegister
    {
        /// <summary>
        /// Register an user in FINUX.
        /// </summary>
        /// <param name="email">
        /// The email.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="repeatPassword">
        /// The repeat Password.
        /// </param>
        /// <returns>
        /// The <see cref="LoginResponse"/>.
        /// </returns>
        Task<LoginResponse> Register(string email, SecureString password, SecureString repeatPassword);

        /// <summary>
        /// Register an user in FINUX.
        /// </summary>
        /// <param name="email">
        /// The email.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="repeatPassword">
        /// The repeat password.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<LoginResponse> Register(string email, string password, string repeatPassword);
    }
}
