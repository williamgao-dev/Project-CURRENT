using System;
using System.Windows;
using System.Windows.Input;
using Project.Core;

namespace Project
{
    /// <summary>
    ///     ViewModel for the custom window chrome
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {

        #region Private members

        /// <summary>
        ///     The window this viewmodel controls
        /// </summary>
        private readonly Window mWindow;

        /// <summary>
        ///     The radius of the edges of the window
        /// </summary>
        private readonly int mWindowCornerRadius = 10;

        /// <summary>
        ///     The height of the title bar
        /// </summary>
        private readonly int mTitleHeight = 42;

        #endregion

        #region Public properties

        /// <summary>
        ///     Thw minimum height of the window
        /// </summary>
        public int WindowMinimumHeight { get; set; } = 600;

        /// <summary>
        ///     The minimum width of the iwndow
        /// </summary>
        public int WindowMinimumWidth { get; set; } = 600;

        /// <summary>
        ///     The header text of the program
        /// </summary>
        public string HeaderText { get; set; } = "Welcome";


        /// <summary>
        ///     The radius of the curved edges around the corners of the window
        /// </summary>
        public CornerRadius WindowCornerRadius => new CornerRadius(mWindowCornerRadius);

        /// <summary>
        ///     The height of the title bar(int)
        /// </summary>
        public int TitleHeight => mTitleHeight;

        public bool IsWindowMaximised => mWindow.WindowState == WindowState.Maximized;

        /// <summary>
        ///     The height of the title bar (GridLength)
        /// </summary>
        public GridLength TitleHeightGridLength => new GridLength(mTitleHeight + 6);
        /// <summary>
        /// Whether the dimmed overlay is visible or not. True if it is.
        /// E.g. when the window is activated, this will be false, and when the window is deactivated
        /// </summary>
        public bool DimmedOverlayVisible { get; set; }

        /// <summary>
        /// True if the settings menu is visible. Obtained from ApplicationViewModel
        /// </summary>
        public bool SettingsMenuVisible
        {
            get => IoCContainer.ApplicationViewModel.SettingsMenuVisible;
            set => IoCContainer.ApplicationViewModel.SettingsMenuVisible = value;
        }

        #endregion

        #region Commands

        /// <summary>
        ///     Menu command that pops up when the icon is clicked.
        /// </summary>
        public ICommand IconMenuCommand { get; set; }

        /// <summary>
        ///     The command that runs when the minimize button is clicked
        /// </summary>
        public ICommand MinimiseCommand { get; set; }

        /// <summary>
        ///     The command that runs when the maximise button is clicked.
        /// </summary>
        public ICommand MaximiseCommand { get; set; }

        /// <summary>
        ///     The command that runs when the close button is clicked.
        /// </summary>
        public ICommand CloseCommand { get; set; }

        #endregion

        #region .ctor

        /// <summary>
        ///     Main constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += UpdateProperties;
            MinimiseCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximiseCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            IconMenuCommand = new RelayCommand(() =>
            {
                SystemCommands.ShowSystemMenu(mWindow, !IsWindowMaximised ? GetMousePos() : new Point(10, 10));
            });
        }

        #endregion

        #region Helpers

        /// <summary>
        ///     Updates window properties, called on each window state change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProperties(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(WindowCornerRadius));
        }

        /// <summary>
        ///     Returns a point that gives the current mouse position
        /// </summary>
        /// <returns></returns>
        private Point GetMousePos()
        {
            var position = Mouse.GetPosition(mWindow);
            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }

        #endregion
    }
}