using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Bengi.Core
{
    public class ChatListItemViewModel : BaseViewModel
    {
        #region Public properties
        /// <summary>
        /// Display name of the user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Latest message for this chat
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// User initials to show as the default user profile picture (e.g William Gao => WG)
        /// </summary>
        public string Initials { get; set; }
        /// <summary>
        /// RGB values in hex for the background folor for the profile picture, such as FF00FF for Red + Blue without yellow.
        /// In WPF, this will get converted into a <see cref="SolidColorBrush"/>
        /// </summary>
        public string ProfilePictureRgb { get; set; }
        /// <summary>
        /// Determines if there is new content available for the user to view, and thus turns on or off the red bar on the left of each ChatListItem's view.
        /// </summary>
        public bool NewContentAvailable { get; set; }
        /// <summary>
        /// Determines whether the current ChatListItem is selected or not
        /// </summary>
        public bool IsSelected { get; set; }
        #endregion

        #region Public commands
        public ICommand OpenMessageCommand { get; set; }
        #endregion

        #region Public constructor
        public ChatListItemViewModel()
        {
            OpenMessageCommand = new RelayCommand(OpenMessage);
        }
        #endregion

        #region Command methods
        private void OpenMessage()
        {
            ApplicationViewModel.GoToPage(ApplicationPage.Chat, new ChatMessageListViewModel
            {
                Items = new List<ChatMessageItemViewModel>
                {
                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },                    new ChatMessageItemViewModel
                    {
                        Message = Message,
                        Initials = Initials,
                        MessageSentTime = DateTime.UtcNow,
                        ProfilePictureRGB = "ffffff",
                        SenderName = "William",
                        SentByMe = true
                    },
                }
            });
        }
        #endregion
    }

    public class ChatListItemDesignViewModel : ChatListItemViewModel
    {
        #region Instance
        public static ChatListItemDesignViewModel Instance => new ChatListItemDesignViewModel();
        #endregion

        #region Public constructor
        public ChatListItemDesignViewModel()
        {
            Name = "Design time name";
            Message = "This is a message. This message should be shown in design time";
            Initials = "WG";
            ProfilePictureRgb = "ff0000";
            NewContentAvailable = true;
            IsSelected = true;
        }
        #endregion

    }
}
