using UnityEngine;

public class Food : MonoBehaviour
{
    public GameManager gameManager;  // Reference to the GameManager

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cat"))  // When the Cat collides with food
        {
            if (gameManager != null)  // Check if gameManager reference is assigned
            {
                gameManager.FoodCollected();  // Notify GameManager that food was collected
            }
            else
            {
                Debug.LogError("GameManager reference is missing on the Food object!");
            }

            Destroy(gameObject);  // Destroy the food
        }
    }
}
