using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengi.Core
{
    /// <summary>
    /// UI manager that handles any UI interaction in the application
    /// </summary>
    public interface IUIManager
    {
        Task ShowMessageBox(MessageBoxDialogViewModel vm);
    }
}
