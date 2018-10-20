namespace Finux.Ai.Api.Contract {
    using System.Security;

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
        void AddProfile(string businessId, string company, string firstName, string sureName);

        /// <summary>
        /// The get profile.
        /// </summary>
        void GetProfile();

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
        void ChangePassword(SecureString newPassword, SecureString oldPassword, SecureString repeatPassword);

        /// <summary>
        /// Writes feedback to our support-team. User will be get answered via SmartAlerts..
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="reply">
        /// The reply.
        /// </param>
        void Feedback(string message, bool reply);
    }
}