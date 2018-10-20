namespace Finux.Ai.Api.Contract
{
    using System.Security;

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
        LoginResponse Register(string email, SecureString password, SecureString repeatPassword);

        /// <summary>
        /// Register an user with alpha-key in FINUX.
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
        /// <param name="alphaKey">
        /// The alpha key.
        /// </param>
        /// <returns>
        /// The <see cref="LoginResponse"/>.
        /// </returns>
        LoginResponse AlphaRegister(string email, SecureString password, SecureString repeatPassword, string alphaKey);
    }
}
