using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Exercises
{
    abstract class Metric
    {
        public abstract bool isGoal();

        public abstract bool compare(SkeletonObject s);
    }
}
