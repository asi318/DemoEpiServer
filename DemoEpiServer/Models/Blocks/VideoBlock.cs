﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "VideoBlock", GUID = "b101daff-45dc-4602-ba9c-e6baf537cce7", Description = "")]
    public class VideoBlock : BlockData
    {
        /// <summary>
        /// Gets link of YouTube video
        /// </summary>        
        [Editable(true)]
        [Display(
            Name = "YouTube Link",
            Description = "URL link to YouTube video",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [Required]
        public virtual String YouTubeLink
        {
            get
            {
                string linkName = this["YouTubeLink"] as string;
                if (!string.IsNullOrEmpty(linkName))
                {
                    /// if given link seems to be "correct" YouTube video link, we transform it to YouTube embbed player link and return;
                    /// otherwise, return null to hide the player and container
                    if (linkName.Contains("youtube") &&
                        (linkName.Contains("/watch?v=") || linkName.Contains("/v/"))
                        )
                    {
                        linkName = linkName.Replace("/watch?v=", "/v/");
                        return linkName;
                    }
                }
                return null;
            }
            set
            {
                this["YouTubeLink"] = value;
            }
        }

        /// <summary>
        /// Heading for the video
        /// </summary>        
        [Editable(true)]
        [Display(
            Name = "Heading",
            Description = "Heading for the video",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [CultureSpecific]
        public virtual String Heading { get; set; }

        /// <summary>
        /// Descriptive text for the video
        /// </summary>        
        [Editable(true)]
        [Display(
            Name = "Video Text",
            Description = "Descriptive text for the video",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [CultureSpecific]
        public virtual XhtmlString VideoText { get; set; }

        [Editable(false)]
        public bool HasVideo
        {
            get { return !string.IsNullOrEmpty(YouTubeLink); }
        }

        [Editable(false)]
        public bool HasHeadingText
        {
            get { return ((!string.IsNullOrEmpty(Heading)) || ((VideoText != null) && (!VideoText.IsEmpty))); }
        }
    }
}