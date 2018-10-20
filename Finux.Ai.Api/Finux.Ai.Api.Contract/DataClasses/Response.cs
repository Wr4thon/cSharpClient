namespace Finux.Ai.Api.Contract.DataClasses
{
    using System.Net;

    /// <summary>
    /// The login response.
    /// </summary>
    /// <typeparam name="TResponseType"> The Response data Type</typeparam>
    public class Response<TResponseType>
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public TResponseType Data { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public HttpStatusCode Code { get; set; }
    }
}