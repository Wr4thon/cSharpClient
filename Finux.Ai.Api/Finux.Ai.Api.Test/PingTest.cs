using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Finux.Ai.Api.Test
{
    using Finux.Ai.Api.Contract;

    /// <summary>
    /// The ping test.
    /// </summary>
    [TestClass]
    public class PingTest
    {
        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        public IClient Client { get; set; }

        /// <summary>
        /// The initialize.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this.Client = new Client();
        }

        /// <summary>
        /// The ping pong test.
        /// </summary>
        [TestMethod]
        public void PingPongTest()
        {

        }
    }
}
