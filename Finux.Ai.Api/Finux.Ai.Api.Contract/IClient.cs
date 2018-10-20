namespace Finux.Ai.Api.Contract
{
    /// <summary>
    /// The Client interface.
    /// </summary>
    public interface IClient : ILogin, IRegister, IUser
    {
        /// <summary>
        /// Ping -&gt; Pong.
        /// </summary>
        /// <returns>
        /// The Success state.
        /// </returns>
        bool Ping();
    }
}
