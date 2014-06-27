//-----------------------------------------------------------------------
// <copyright file="Recommendation.cs">
//     Copyright (c) Ricardo da Verdade Silva. All rights reserved.
// </copyright>
// <author>Ricardo da Verdade Silva</author>
//-----------------------------------------------------------------------
namespace RecomendationLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This class represents recommendation of user.
    /// </summary>
    public class Recommendation
    {
        /// <summary>
        /// Gets or sets the name of person who rated something.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public double Rating { get; set; }
    }
}
