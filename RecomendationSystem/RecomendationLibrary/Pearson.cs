//-----------------------------------------------------------------------
// <copyright file="Pearson.cs">
//     Copyright (c) Ricardo da Verdade Silva. All rights reserved.
// </copyright>
// <author>Ricardo da Verdade Silva</author>
// <references> Joel Cogley arcticle http://www.codeproject.com/articles/221865/Collaborative-Filters-How-To-build-a-recommendatio </refrence>
//-----------------------------------------------------------------------
namespace RecomendationLibrary
{
    using System.Collections.Generic;

    /// <summary>
    /// This class contains calculations methods of Pearson.
    /// </summary>
    public abstract class Pearson
    {
        /// <summary>
        /// "The Correlation Score is a measure of how well two sets
        ///  of data fit on a straight line. One interesting aspect 
        /// of the Pearson Score is that it corrects for grade inflation.
        ///  That is, if one product has consistently higher scores than 
        /// another, there can still be a perfect correlation — if the difference 
        /// between the ratings is consistent." 
        /// <a href="http://www.codeproject.com/articles/221865/Collaborative-Filters-How-To-build-a-recommendatio">
        /// Description by Joel Cogley taken on 29 june 2014.
        /// </a>
        /// </summary>
        /// <param name="productRecommendation1">First product to compare.</param>
        /// <param name="product2">Second product to compare.</param>
        /// <returns>Returns double value with pearson correlating score
        /// between two products passed by parameter.
        /// </returns>
        public static double CorrelationScore(Dictionary<Product, List<Recommendation>> productRecommendations, Dictionary<Product, List<Recommendation>> product2)
        {
        }
    }
}
