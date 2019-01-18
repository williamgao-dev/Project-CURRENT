using System.Windows.Input;

namespace Project.Core
{
    /// <summary>
    /// View model for a text input control
    /// </summary>
    public class TextInputViewModel : BaseViewModel
    {
        #region Public properties
        /// <summary>
        /// The label for this text input control.
        /// e.g. Username, Password, Email
        /// </summary>
        public string LabelText { get; set; }
        /// <summary>
        /// The confirmed, saved text
        /// </summary>
        public string SavedText { get; set; }
        /// <summary>
        /// Original text
        /// </summary>
        public string EditingText { get; set; }
        /// <summary>
        /// True if the text box is being edited
        /// </summary>
        public bool Editing { get; set; }
        #endregion

        #region Public commands
        /// <summary>
        /// Begins editing text input
        /// </summary>
        public ICommand EditCommand { get; set; }
        /// <summary>
        /// Cancels edit
        /// </summary>
        public ICommand CancelEditCommand { get; set; }
        /// <summary>
        /// Saves the edit
        /// </summary>
        public ICommand SaveEditCommand { get; set; }
        #endregion

        #region Public constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public TextInputViewModel()
        {
            // Create commands
            EditCommand = new RelayCommand(Edit);

            CancelEditCommand = new RelayCommand(CancelEdit);

            SaveEditCommand = new RelayCommand(Save);
        }

        /// <summary>
        /// Constructor requiring label of this text input control to be passed in
        /// </summary>
        /// <param name="label"></param>
        public TextInputViewModel(string label) : this()
        {
            // Set the label of this text input control to the label passed in
            LabelText = label;
        }
        #endregion

        #region Command methods
        /// <summary>
        /// Called when save command is run
        /// </summary>
        private void Save()
        {
            // TODO: Save
            Editing = false;
            SavedText = EditingText;
        }

        /// <summary>
        /// Called when cancel command is run
        /// </summary>
        private void CancelEdit()
        {
            Editing = false;
            EditingText = SavedText;
        }

        /// <summary>
        /// Called when edit command is run
        /// </summary>
        private void Edit()
        {
            Editing = true;
        }
        #endregion
    }

    public class TextInputDesignViewModel : TextInputViewModel
    {
        #region Instance
        /// <summary>
        /// Returns a single instance of this view model
        /// </summary>
        public static TextInputDesignViewModel Instance => new TextInputDesignViewModel();
        #endregion

        #region Public constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public TextInputDesignViewModel()
        {
            EditingText = "Design time text";
            LabelText = "Design Label";
        }
        #endregion
    }
}
