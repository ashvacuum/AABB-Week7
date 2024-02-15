using UnityEngine;

public class SphereCollision : Shape
{
    public float Length;
    public float Width;

    public BoxCollision(float length, float width)
    {
        Length = length;
        Width = width;
    }

    protected override void DrawCollider()
    {
        base.DrawCollider();
    }

    public float
}
