using System;
using System.Collections.Generic;

namespace Project.Core
{
    /// <summary>
    /// View model for the chat message list
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        #region Public properties
        /// <summary>
        /// List of the chat list items
        /// </summary>
        public List<ChatMessageItemViewModel> Items { get; set; }

        public static ChatMessageListViewModel Instance => new ChatMessageListViewModel();
        #endregion

        #region .ctor

        public ChatMessageListViewModel()
        {
            Items = new List<ChatMessageItemViewModel>
            {
                new ChatMessageItemViewModel
                {
                    Message="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque luctus urna sit amet ligula consequat porta. Morbi vel urna feugiat nunc consectetur aliquam quis vel leo.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ChatMessageItemViewModel
                {
                    Message="Aenean semper risus at consequat varius. ",
                    ProfilePictureRGB = "3099c5",
                    Initials ="WG",
                    SenderName = "William",
                    MessageSentTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(2.31)),
                    MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.5)),
                    SentByMe=true
                },
                new ChatMessageItemViewModel
                {
                    Message="Ut quis consectetur eros, in pellentesque sem. Integer sed eros ipsum. Curabitur convallis erat metus. \nSed lacinia venenatis imperdiet. ",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },
                new ChatMessageItemViewModel
                {
                    Message="Duis accumsan nulla eu suscipit gravida. ",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },               new ChatMessageItemViewModel
                {
                Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                ProfilePictureRGB = "3099c5",
                Initials ="PL",
                SenderName = "Parnell",
                MessageSentTime = DateTimeOffset.UtcNow,
                SentByMe = true
            },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = true
                },new ChatMessageItemViewModel
                {
                    Message="Praesent ut pulvinar mi. Aliquam eget turpis a lorem blandit porttitor sit amet et lectus. Fusce sed mattis velit.",
                    ProfilePictureRGB = "3099c5",
                    Initials ="PL",
                    SenderName = "Parnell",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },

};
        }
        #endregion
    }
}
