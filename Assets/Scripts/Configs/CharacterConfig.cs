using UnityEngine;

// Scriptable Objects configurable by the player
[CreateAssetMenu(fileName = "CharacterConfig", menuName = "ScriptableObjects/Character", order = 1)]

public class CharacterConfig : ScriptableObject
{
    // Public variables are accessible directly in the inspector
    public int health;
    public float moveSpeed;
    public float jumpingPower;
}
