public class BoxCollision : Shape
{
    public float Length;
    public float Width;

    public float minX
    {
        get { }
    }
    public float maxX;

    public float minY;
    public float maxY;

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
