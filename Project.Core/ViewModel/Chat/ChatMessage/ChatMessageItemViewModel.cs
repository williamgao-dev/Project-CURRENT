using System;

namespace Project.Core
{
    /// <summary>
    /// A view model for a chat message item in a chat thread
    /// </summary>
    public class ChatMessageItemViewModel : BaseViewModel
    {
        #region Public properties
        /// <summary>
        /// Returns an instance of this class
        /// </summary>
        public static ChatMessageItemViewModel Instance => new ChatMessageItemViewModel();

        /// <summary>
        /// Profile picture colour
        /// </summary>
        public string ProfilePictureRGB { get; set; }

        /// <summary>
        /// Initials to show on the profile picture
        /// </summary>
        public string Initials { get; set; } = "WG";

        /// <summary>
        /// True of the message is sent by this client
        /// </summary>
        public bool SentByMe { get; set; }

        /// <summary>
        /// Is the message selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// Sender of the message
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// The message to display
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Whether the message was read
        /// </summary>
        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

        /// <summary>
        /// Time the message was read
        /// </summary>
        public DateTimeOffset MessageReadTime { get; set; }

        /// <summary>
        /// Time the message was sent
        /// </summary>
        public DateTimeOffset MessageSentTime { get; set; }

        #endregion

        #region ctor
        public ChatMessageItemViewModel()
        {
            Message = "I'm about to wipe the old server, we need to update the old server";
            ProfilePictureRGB = "3099c5";
            Initials = "PL";
            SenderName = "Parnell";
            MessageSentTime = DateTimeOffset.UtcNow;
            MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.5));
            SentByMe = true;
        }
        #endregion
    }

    /// <summary>
    /// Design model for a chat message item in a chat thread
    /// </summary>
    public class ChatMessageItemDesigniewModel : ChatMessageItemViewModel
    {

    }
}
