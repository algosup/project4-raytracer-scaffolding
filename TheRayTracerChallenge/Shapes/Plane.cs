using System;

namespace TheRayTracerChallenge.Shapes
{
    public class Plane : AbstractShape
    {
        private Tuple normal = Helper.CreateVector(0, 1, 0);

        public override Tuple NormalAtLocal(Tuple worldPoint, Intersection hit=null) => normal;
        
        public override Bounds Box  => new Bounds{PMin = Helper.CreatePoint(double.NegativeInfinity,0, double.NegativeInfinity), PMax = Helper.CreatePoint(double.PositiveInfinity,0, double.PositiveInfinity)}; 

        public override Intersections IntersectLocal(Ray ray)
        {
            // if ray is // to plane => no intersection
            if (Math.Abs(ray.Direction.Y) < Helper.Epsilon)
            {
                return new Intersections();
            }

            var t = -ray.Origin.Y / ray.Direction.Y;
            return new Intersections(new [] {new Intersection(t, this)});
        }
    }
}