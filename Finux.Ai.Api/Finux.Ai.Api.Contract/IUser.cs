namespace Finux.Ai.Api.Contract
{
    using System.Security;
    using System.Threading.Tasks;

    using Finux.Ai.Api.Contract.DataClasses.Responses;

    /// <summary>
    /// The User interface.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Store additional information to an user.
        /// </summary>
        /// <param name="businessId">
        /// The business id.
        /// </param>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="sureName">
        /// The sure name.
        /// </param>
        /// <returns>
        /// The <see cref="ProfileResponse"/>.
        /// </returns>
        Task<ProfileResponse> AddProfile(string businessId, string company, string firstName, string sureName);

        /// <summary>
        /// The get profile.
        /// </summary>
        /// <returns>
        /// The <see cref="ProfileResponse"/>.
        /// </returns>
        Task<ProfileResponse> GetProfile();

        /// <summary>
        /// Change the user password.
        /// </summary>
        /// <param name="newPassword">
        /// The new password.
        /// </param>
        /// <param name="oldPassword">
        /// The old password.
        /// </param>
        /// <param name="repeatPassword">
        /// The repeat password.
        /// </param>
        /// <returns>
        /// The <see cref="ObjectResponse"/>.
        /// </returns>
        Task<ObjectResponse> ChangePassword(SecureString newPassword, SecureString oldPassword, SecureString repeatPassword);

        /// <summary>
        /// Change the user password.
        /// </summary>
        /// <param name="newPassword">
        /// The new password.
        /// </param>
        /// <param name="oldPassword">
        /// The old password.
        /// </param>
        /// <param name="repeatPassword">
        /// The repeat password.
        /// </param>
        /// <returns>
        /// The <see cref="ObjectResponse"/>.
        /// </returns>
        Task<ObjectResponse> ChangePassword(string newPassword, string oldPassword, string repeatPassword);

        /// <summary>
        /// Writes feedback to our support-team. User will be get answered via SmartAlerts.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="reply">
        /// The reply.
        /// </param>
        /// <returns>
        /// The <see cref="ObjectResponse"/>.
        /// </returns>
        Task<ObjectResponse> Feedback(string message, bool reply);
    }
}