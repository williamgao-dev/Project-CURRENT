using System.Collections.Generic;

namespace Project.Core
{
    public class ChatListViewModel : BaseViewModel
    {
        #region Public properties
        /// <summary>
        /// List of the chat list items
        /// </summary>
        public List<ChatListItemViewModel> Items { get; set; }
        public static ChatListViewModel Instance => new ChatListViewModel();

        #endregion

        #region .ctor
        public ChatListViewModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "NZ",
                    Message = "In congue magna sed ex porta tincidunt.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },
                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "DW",
                    Message = "Im pretty cool",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "In congue magna sed ex porta tincidunt. ",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Morbi vehicula tortor augue, vel varius nulla posuere nec.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },
                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "282b30",
                    NewContentAvailable = false
                },
            };

        }
        #endregion


    }


    public class ChatListDesignViewModel : ChatListViewModel
    {
        #region Instance
        public static ChatListDesignViewModel Instance => new ChatListDesignViewModel();
        #endregion

        #region Public constructor
        public ChatListDesignViewModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "NZ",
                    Message = "In congue magna sed ex porta tincidunt.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },
                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "DW",
                    Message = "Im pretty cool",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "In congue magna sed ex porta tincidunt. ",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Morbi vehicula tortor augue, vel varius nulla posuere nec.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },
                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },                new ChatListItemViewModel
                {
                    Name="William",
                    Initials = "WG",
                    Message = "Nulla aliquam feugiat finibus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    ProfilePictureRgb = "ACADAF",
                    NewContentAvailable = false
                },
            };
        }
        #endregion
    }
}
