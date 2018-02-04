using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric
{
    abstract class DistanceMetric : Metric
    {
        double goalDistance;
        public DistanceMetric(Skeleton skeleton, double goalDistance) : base(skeleton)
        {
            this.goalDistance = goalDistance;
        }

        public override bool compare(Skeleton s)
        {
            SkeletonObject o1 = new SkeletonObject(this.skeleton);
            SkeletonObject o2 = new SkeletonObject(s);

            double dist1, dist2;
            dist1 = getDistance(o1);
            dist2 = getDistance(o2);

            return dist1 > dist2;
        }

        public double getDistance()
        {
            return getDistance(new SkeletonObject(this.skeleton));
        }

        public abstract double getDistance(SkeletonObject o);

        public override bool isGoal()
        {
            SkeletonObject o = new SkeletonObject(this.skeleton);
            double distance = getDistance(o);
            return distance > this.goalDistance;
        }

        public override double getMetric()
        {
            return this.getDistance();
        }
    }
}