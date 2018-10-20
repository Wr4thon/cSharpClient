namespace Finux.Ai.Api.Contract
{
    using System.Threading.Tasks;

    /// <summary>
    /// The Client interface.
    /// </summary>
    public interface IClient : ILogin, IRegister, IUser
    {
        /// <summary>
        /// Ping -&gt; Pong.
        /// </summary>
        /// <returns>
        /// The Response.
        /// </returns>
        Task<string> Ping();
    }
}
