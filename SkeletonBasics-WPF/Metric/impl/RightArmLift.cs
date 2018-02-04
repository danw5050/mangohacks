using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric
{
    class RightArmLift : AngleMetric
    {

        public RightArmLift(Skeleton skeleton, double goalAngle) : base(skeleton, goalAngle) {
        }

        public override string getMetricName()
        {
            return "RightArmLift";
        }

        protected override double getAngle(SkeletonObject o) {
            return getAngle(o.ElbowRight, o.ShoulderCenter, o.Spine);
        }




    }
}
