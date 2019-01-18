using System.Security;

namespace Bengi.Core
{
    /// <summary>
    /// Interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        SecureString SecurePassword { get; }
    }
}
