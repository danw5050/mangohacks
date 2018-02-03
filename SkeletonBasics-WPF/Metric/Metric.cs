using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric
{
    abstract class Metric {
        protected Skeleton skeleton;

        public Metric(Skeleton skeleton) {
            this.skeleton = skeleton;
        }

        public abstract bool isGoal();

        public abstract bool compare(Skeleton s);

        public void setSkeleton(Skeleton s) {
            this.skeleton = s;
        }
    }
}
