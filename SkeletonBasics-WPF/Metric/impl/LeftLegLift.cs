using System;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric
{
    class LeftLegLift : DistanceMetric {

        public LeftLegLift(Skeleton skeleton, double goalDistance) : base(skeleton, goalDistance) {
        }

        public override double getDistance(SkeletonObject o)
        {
            double leftFootHeight = o.AnkleLeft.y;
            double rightFootHeight = o.AnkleRight.y;

            return leftFootHeight - rightFootHeight;
        }

        public override string getMetricName()
        {
            return "LeftLegLift";
        }
        
    }
}
