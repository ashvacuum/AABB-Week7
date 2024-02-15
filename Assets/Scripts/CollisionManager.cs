using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    Shape MainCharacter;

    private void Update()
    {
        var Colliders = FindObjectsOfType<Shape>();

        foreach (var c in Colliders)
        {
            if (MainCharacter == c) continue;
            CheckCollision(MainCharacter, c);
        }
    }

    private bool CheckCollision(Shape shapeA, Shape shapeB)
    {


        return false;
    }
}
