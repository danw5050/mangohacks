using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric {
    class LeftArmLift : AngleMetric {
        const String MetricName = "LeftArmLift";

        public LeftArmLift(Skeleton skeleton, double goalAngle) : base(skeleton, goalAngle) {
        }

        protected override double getAngle(SkeletonObject o) {
            return getAngle(o.ElbowLeft, o.ShoulderCenter, o.Spine);
        }
    }
}
