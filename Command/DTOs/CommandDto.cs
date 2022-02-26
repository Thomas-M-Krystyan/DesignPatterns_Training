﻿using Command_Service.Commands.Enums;
using System.ComponentModel.DataAnnotations;

namespace Command_Web.DTOs
{
    /// <summary>
    /// The DTO model used to pass user input from the main view.
    /// </summary>
    public sealed class CommandDto
    {
        /// <summary>
        /// Used to change text foreground color.
        /// </summary>
        [Required]
        public ForegroundColorsEnum ForegroundColor { get; set; }

        /// <summary>
        /// Used to change text background color.
        /// </summary>
        [Required]
        public BackgroundColorsEnum BackgroundColor { get; set; }

        /// <summary>
        /// Used to change the font weight.
        /// </summary>
        [Required]
        public bool IsFontBold { get; set; }
    }
}
