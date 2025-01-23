using UnityEngine;
using UnityEngine.SceneManagement;  // To manage scene loading

public class GameManager : MonoBehaviour
{
    public int foodCollected = 0;   // Tracks how many pieces of food were collected
    public int totalFoodInLevel = 1;  // Adjust according to your level's food amount
    public GameObject level2FoodPrefab; // Prefab of different food for level 2

    void Start()
    {
        // Ensure food items exist for this level
        SpawnLevelFood();
    }

    public void FoodCollected()
    {
        foodCollected++;

        // If all food is collected, proceed to the next level or change food for next level
        if (foodCollected >= totalFoodInLevel)
        {
            // Trigger level up (this can also just be scene change if needed)
            LevelUp();
        }
    }

    void LevelUp()
    {
        // Option 1: Load next scene (Assumes you have "Level2" scene loaded in Build settings)
        SceneManager.LoadScene("Level2");

        // Option 2: To spawn a new food item directly for level 2
        SpawnLevelFood();
    }

    void SpawnLevelFood()
    {
        // Make sure there’s no leftover food
        if (foodCollected < totalFoodInLevel)
        {
            // Instantiate the new food for level 2 at a specific position
            Instantiate(level2FoodPrefab, new Vector2(5f, 0), Quaternion.identity);
        }
    }
}
