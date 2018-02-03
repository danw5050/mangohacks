using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Exercises
{
    class Exercise
    {
        private List<Metric> metrics;
        protected Exercise(List<Metric> metrics)
        {
            this.metrics = metrics;
        }

        public bool isGoal()
        {
            foreach (Metric m in this.metrics)
            {
                if (!m.isGoal())
                {
                    return false;
                }
            }
            return true;
        }

        public bool compare(Skeleton o) {
            return false;
        }

        
    }
}
