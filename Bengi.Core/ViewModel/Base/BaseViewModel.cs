using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Bengi.Core
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Implementation

        /// <summary>
        /// Event fired when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke property changed on a certain property
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Helper functions for commands
        /// <summary>
        /// Runs command if updating flag is not set.
        /// 
        /// If flag is true, function is already running, thus the action
        /// is prevented from runnning.
        ///
        /// If flag is false, then the action is run.
        ///
        /// While the command is running, the flag is set to true.
        /// Once the action is completely finished, the flag is set to false.
        /// </summary>
        /// <param name="updatingFlag"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // Getting flag value (true or false) (using extension method)
            // If flag value is true, do nothing & return.
            if (updatingFlag.Compile().Invoke()) return;

            updatingFlag.SetPropertyValue(true);

            try
            {
                // Run action passed in.
                await action();
            }
            finally
            {
                // Set the property flag to false to indicate that the command has finished.
                updatingFlag.SetPropertyValue(false);
            }
        }
        #endregion
    }
}