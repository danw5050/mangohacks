using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using Microsoft.Kinect;

namespace Microsoft.Samples.Kinect.SkeletonBasics.Exercises
{
    class RightArmLift : Metric
    {
        Skeleton skeleton;
        double goalAngle;
        public RightArmLift(Skeleton skeleton, double goalAngle) {
            this.skeleton = skeleton;
            this.goalAngle = goalAngle;
        }

        override
        public bool compare(Skeleton s2) {
            SkeletonObject o1 = new SkeletonObject(this.skeleton);
            SkeletonObject o2 = new SkeletonObject(s2);
            double angle1, angle2;
            angle1 = getAngle(o1.ElbowRight, o1.ShoulderRight, o1.ShoulderCenter);
            angle2 = getAngle(o2.ElbowRight, o2.ShoulderRight, o2.ShoulderCenter);

            return angle1 > angle2;
        }

        override
        public bool isGoal() {
            SkeletonObject o = new SkeletonObject(this.skeleton);
            double angle = getAngle(o.ElbowRight, o.ShoulderRight, o.ShoulderCenter);
            Console.WriteLine($"Current angle: {angle}");
            return angle > this.goalAngle;
        }

        private double getAngle(JointObject j1, JointObject j2, JointObject j3) {
            Vector3D v1 = new Vector3D(j2.x - j1.x, j2.y - j1.y, j2.z - j1.z);
            Vector3D v2 = new Vector3D(j2.x - j3.x, j2.y - j3.y, j2.z - j3.z);

            return Vector3D.AngleBetween(v1, v2) * 180 / Math.PI;
        }


    }
}
