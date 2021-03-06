﻿using App.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Events.Shop.Image
{
    public class ImageCreateEvent : Event
    {
        public ImageCreateEvent(Guid imageId, string imageLink, string profileImage)
        {
            ImageId = imageId;
            ImageLink = imageLink;
            ProfileImage = profileImage;
        }
        public Guid ImageId { get; set; }
        public string ImageLink { get; set; }
        public string ProfileImage { get; set; }
    }
}

