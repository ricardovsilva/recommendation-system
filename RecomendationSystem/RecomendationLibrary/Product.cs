//-----------------------------------------------------------------------
// <copyright file="Product.cs">
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
    /// This class represent any product.
    /// It's still in development yet, by now
    /// you will only retrieve the name of product.
    /// The main idea is in future put other informations
    /// and make this one abstract class.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string Name { get; set; }
    }
}
