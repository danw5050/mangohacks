using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric {
    class LeftLegLift : AngleMetric {
        public LeftLegLift(Skeleton skeleton, double goalAngle) : base(skeleton, goalAngle) {
        }

        protected override double getAngle(SkeletonObject o) {
            return getAngle(o.AnkleLeft, o.HipCenter, o.HipRight);
        }
    }
}
