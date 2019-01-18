using System.Security;

namespace Project.Core
{
    /// <summary>
    /// Interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        SecureString SecurePassword { get; }
    }
}
