using Bengi.Core;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bengi
{
    /// <summary>
    /// Application implementation of IUIManager
    /// </summary>
    public class UIManager : IUIManager
    {
        public Task ShowMessageBox(MessageBoxDialogViewModel vm)
        {
            // Create a task to await the dialog closing
            var tcs = new TaskCompletionSource<bool>();
            Task.Run (() => 
                Application.Current.Dispatcher.Invoke(() => 
                {
                  try
                  {
                      var a = new DialogWindow();
                      a.DataContext = vm;
                      a.ShowDialog();
                  }
                  finally
                  {
                      tcs.TrySetResult(true);
                  }

              }));

            return tcs.Task;
        }
    }
}
