using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Exercises
{
    class Exercise
    {
        private List<Metric> metrics;
        protected Exercise(List<Metric> metrics)
        {
            this.metrics = metrics;
        }

        public bool isPassing()
        {
            foreach (Metric m in this.metrics)
            {
                if (!m.isPassing())
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
