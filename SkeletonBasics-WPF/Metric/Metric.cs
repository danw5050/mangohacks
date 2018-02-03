using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric
{
    abstract class Metric
    {
        public abstract bool isGoal();

        public abstract bool compare(Skeleton s);
    }
}
