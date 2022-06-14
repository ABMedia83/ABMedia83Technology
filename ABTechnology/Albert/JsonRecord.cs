﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert
{
    /// <summary>
    /// A record designed for setting up a Json File  Type 
    /// </summary>
    public abstract record JsonRecord
    {

      
  

        /// <summary>
        /// Get or set the Format Name 
        /// </summary>
        public string? FormatName { get; init; }
        /// <summary>
        /// Get or set the Description of the format 
        /// </summary>
        public string? FormatDescription { get; init; }

        /// <summary>
        /// Get or set the Author's name 
        /// </summary>
        public string? FormatAuthor { get; init; }
    }
}
