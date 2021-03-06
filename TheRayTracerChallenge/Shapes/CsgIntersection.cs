namespace TheRayTracerChallenge.Shapes
{
    public class CsgIntersection : AbstractCsg
    {
        public CsgIntersection(IShape left, IShape right) : base(left, right)
        {
        }

        public override bool IntersectionAllowed(bool leftHit, bool insideLeft, bool insideRight)
        {
            return (leftHit && insideRight) || (!leftHit && insideLeft);
        }
    }
}