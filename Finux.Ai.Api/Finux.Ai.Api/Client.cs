using Finux.Ai.Api.Contract;

namespace Finux.Ai.Api
{
    using System.Security;

    using Finux.Ai.Api.Contract.DataClasses;

    public class Client : IClient
    {
        public LoginResponse Register(string email, SecureString password, SecureString repeatPassword)
        {
            throw new System.NotImplementedException();
        }

        public LoginResponse AlphaRegister(string email, SecureString password, SecureString repeatPassword, string alphaKey)
        {
            throw new System.NotImplementedException();
        }

        public void AddProfile(string businessId, string company, string firstName, string sureName)
        {
            throw new System.NotImplementedException();
        }

        public void GetProfile()
        {
            throw new System.NotImplementedException();
        }

        public void ChangePassword(SecureString newPassword, SecureString oldPassword, SecureString repeatPassword)
        {
            throw new System.NotImplementedException();
        }

        public void Feedback(string message, bool reply)
        {
            throw new System.NotImplementedException();
        }

        public bool Ping()
        {
            throw new System.NotImplementedException();
        }

        public LoginResponse Login(string email, SecureString password)
        {
            throw new System.NotImplementedException();
        }
    }
}
