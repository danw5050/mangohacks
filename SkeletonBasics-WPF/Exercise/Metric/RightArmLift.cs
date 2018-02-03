using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Exercises
{
    class RightArmLift : Metric
    {
        SkeletonObject skeleton;
        double goalAngle;
        public RightArmLift(SkeletonObject skeleton, double goalAngle) {
            this.skeleton = skeleton;
            this.goalAngle = goalAngle;
        }

        override
        public bool compare(SkeletonObject o) {
            double angle1, angle2;
            angle1 = getAngle(this.skeleton.ElbowRight, this.skeleton.ShoulderRight, this.skeleton.ShoulderCenter);
            angle2 = getAngle(o.ElbowRight, o.ShoulderRight, o.ShoulderCenter);

            return angle1 > angle2;
        }

        override
        public bool isGoal() {
            return getAngle(this.skeleton.ElbowRight, this.skeleton.ShoulderRight, this.skeleton.ShoulderCenter) > this.goalAngle;
        }

        private double getAngle(JointObject j1, JointObject j2, JointObject j3) {
            Vector3D v1 = new Vector3D(j2.x - j1.x, j2.y - j1.y, j2.z - j1.z);
            Vector3D v2 = new Vector3D(j2.x - j3.x, j2.y - j3.y, j2.z - j3.z);

            return Vector3D.AngleBetween(v1, v2);
        }


    }
}
