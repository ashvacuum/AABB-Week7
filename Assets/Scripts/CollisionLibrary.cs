public static class CollisionLibrary
{
     public static bool DidCollide(Shape shape, BoxCollision box)
    {
        return true;
    }

    public static bool DidCollide(BoxCollision box1, BoxCollision box2)
    {
        return true;
    }
    public static bool DidCollide(SphereCollision sphere,BoxCollision box )
    {
        return true;
    }

    private static bool BoxCheck(float minA, float maxA, float minB, float maxB)
    {
        return maxA >= minB && minA <= maxB;
    }
}
