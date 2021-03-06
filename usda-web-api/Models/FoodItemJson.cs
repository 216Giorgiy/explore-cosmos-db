using UsdaCosmos;
using MongoDB.Bson;

namespace UsdaCosmosJson
{
    public class FoodItemJson
    {
        public string Id { get; set; }

        public string FoodGroupId { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public static FoodItemJson FromFoodItem(FoodItem foodItem)
        {
            return new FoodItemJson
            {
                Id = foodItem.FoodId,
                ShortDescription = foodItem.ShortDescription,
                Description = foodItem.Description,
                FoodGroupId = foodItem.FoodGroupId
            };
        }

        public static FoodItemJson FromFoodItem(BsonDocument doc)
        {
            return new FoodItemJson
            {
                Id = doc["_id"].AsString,
                ShortDescription = doc["ShortDescription"].AsString,
                Description = doc["Description"].AsString,
                FoodGroupId = doc["FoodGroupId"].AsString
            };
        }
    }
}