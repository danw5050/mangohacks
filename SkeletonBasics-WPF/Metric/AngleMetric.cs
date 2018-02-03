using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;
using System.Windows.Media.Media3D;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Metric {
    abstract class AngleMetric : Metric {
        protected double goalAngle;

        public AngleMetric(Skeleton skeleton, double goalAngle) : base(skeleton) {
            this.goalAngle = goalAngle;
        }


        override
        public bool isGoal() {
            SkeletonObject o = new SkeletonObject(this.skeleton);
            double angle = getAngle(o);
            return angle > this.goalAngle;
        }

        override
        public bool compare(Skeleton s2) {
            SkeletonObject o1 = new SkeletonObject(this.skeleton);
            SkeletonObject o2 = new SkeletonObject(s2);
            double angle1, angle2;
            angle1 = getAngle(o1);
            angle2 = getAngle(o2);

            return angle1 > angle2;
        }

        public double getAngle() {
            return getAngle(new SkeletonObject(this.skeleton));
        }
        protected abstract double getAngle(SkeletonObject o);

        protected double getAngle(JointObject j1, JointObject j2, JointObject j3) {
            Vector3D v1 = new Vector3D(j2.x - j1.x, j2.y - j1.y, j2.z - j1.z);
            Vector3D v2 = new Vector3D(j2.x - j3.x, j2.y - j3.y, j2.z - j3.z);

            return Vector3D.AngleBetween(v1, v2);
        }
    }
}
