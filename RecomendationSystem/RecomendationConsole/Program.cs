using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecomendationLibrary;

namespace RecomendationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRecommendations = Dictionary<Product, List<Recommendation>>();
            productRecommendations = GetStaticProductRecommendations();
        }

        /// <summary>
        /// This method returns one list of recommendation with values filled.
        /// </summary>
        /// <returns>Returns list of recommendation with some values filled.</returns>
        public static Dictionary<Product, List<Recommendation>> GetStaticProductRecommendations()
        {
            var recommendation = new List<Recommendation>();
            var productRecommendations = new Dictionary<Product, List<Recommendation>>();

            recommendation.Add(new Recommendation() { Name = "Wile E Coyote", Rating = 4.5 });
            recommendation.Add(new Recommendation() { Name = "Bugs Bunny", Rating = 2.5 });
            recommendation.Add(new Recommendation() { Name = "Elmer Fudd", Rating = 5.0 });
            recommendation.Add(new Recommendation() { Name = "Foghorn Leghorn", Rating = 2.0 });
            productRecommendations.Add("ACME Industrial Rocket Pack", recommendation);

            recommendation = new List<Recommendation>();
            recommendation.Add(new Recommendation() { Name = "Wile E Coyote", Rating = 5.0 });
            recommendation.Add(new Recommendation() { Name = "Bugs Bunny", Rating = 3.5 });
            recommendation.Add(new Recommendation() { Name = "Elmer Fudd", Rating = 1.0 });
            recommendation.Add(new Recommendation() { Name = "Foghorn Leghorn", Rating = 3.5 });
            recommendation.Add(new Recommendation() { Name = "Daffy Duck", Rating = 1.0 });
            productRecommendations.Add("ACME Super Sling Shot", recommendation);

            recommendation = new List<Recommendation>();
            recommendation.Add(new Recommendation() { Name = "Wile E Coyote", Rating = 1.0 });
            recommendation.Add(new Recommendation() { Name = "Bugs Bunny", Rating = 3.5 });
            recommendation.Add(new Recommendation() { Name = "Elmer Fudd", Rating = 5.0 });
            recommendation.Add(new Recommendation() { Name = "Foghorn Leghorn", Rating = 4.0 });
            recommendation.Add(new Recommendation() { Name = "Daffy Duck", Rating = 4.0 });
            productRecommendations.Add("ACME X-Large Catapult", recommendation);

            recommendation = new List<Recommendation>();
            recommendation.Add(new Recommendation() { Name = "Bugs Bunny", Rating = 3.5 });
            recommendation.Add(new Recommendation() { Name = "Elmer Fudd", Rating = 4.0 });
            recommendation.Add(new Recommendation() { Name = "Foghorn Leghorn", Rating = 5.0 });
            recommendation.Add(new Recommendation() { Name = "Daffy Duck", Rating = 2.5 });
            productRecommendations.Add("ACME Super Glue", recommendation);

            recommendation = new List<Recommendation>();
            recommendation.Add(new Recommendation() { Name = "Bugs Bunny", Rating = 3.5 });
            recommendation.Add(new Recommendation() { Name = "Elmer Fudd", Rating = 4.0 });
            recommendation.Add(new Recommendation() { Name = "Foghorn Leghorn", Rating = 5.0 });
            productRecommendations.Add("ACME Jet Powered Roller Skates", recommendation);
        }
    }
}
