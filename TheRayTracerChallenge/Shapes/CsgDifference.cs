namespace TheRayTracerChallenge.Shapes
{
    public class CsgDifference : AbstractCsg
    {
        public CsgDifference(IShape left, IShape right) : base(left, right)
        {
        }

        public override bool IntersectionAllowed(bool leftHit, bool insideLeft, bool insideRight)
        {
            return (leftHit && ! insideRight) || (!leftHit && insideLeft);
        }
    }
}