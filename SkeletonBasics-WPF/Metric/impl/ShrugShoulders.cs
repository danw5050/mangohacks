using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric.impl
{
    class ShrugShoulders : DistanceMetric
    {
        public ShrugShoulders(Skeleton skeleton, double goalDistance) : base(skeleton, goalDistance)
        {
        }

        public override double getDistance(SkeletonObject o)
        {
            double shoulderHeight = (o.ShoulderLeft.y + o.ShoulderRight.y) / 2;
            double neckHeight = o.ShoulderCenter.y;

            return neckHeight - shoulderHeight;
        }
    }
}