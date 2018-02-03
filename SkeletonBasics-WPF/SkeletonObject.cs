using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{
        [SerializableAttribute]
        class SkeletonObject
        {

            public JointObject Head { get; set; }
            public JointObject ShoulderCenter { get; set; }
            public JointObject ShoulderLeft { get; set; }
            public JointObject ShoulderRight { get; set; }
            public JointObject Spine { get; set; }
            public JointObject HipCenter { get; set; }
            public JointObject HipLeft { get; set; }
            public JointObject HipRight { get; set; }

            public JointObject ElbowLeft { get; set; }
            public JointObject WristLeft { get; set; }
            public JointObject HandLeft { get; set; }

            public JointObject ElbowRight { get; set; }
            public JointObject WristRight { get; set; }
            public JointObject HandRight { get; set; }

            public JointObject KneeLeft { get; set; }
            public JointObject AnkleLeft { get; set; }
            public JointObject FootLeft { get; set; }

            public JointObject KneeRight { get; set; }
            public JointObject AnkleRight { get; set; }
            public JointObject FootRight { get; set; }

            public SkeletonObject(Skeleton skeleton)
            {
                this.Head = new JointObject(skeleton.Joints[JointType.Head]);
                this.ShoulderCenter = new JointObject(skeleton.Joints[JointType.ShoulderCenter]);
                this.ShoulderLeft = new JointObject(skeleton.Joints[JointType.ShoulderLeft]);
                this.ShoulderRight = new JointObject(skeleton.Joints[JointType.ShoulderRight]);
                this.Spine = new JointObject(skeleton.Joints[JointType.Spine]);
                this.HipCenter = new JointObject(skeleton.Joints[JointType.HipCenter]);
                this.HipLeft = new JointObject(skeleton.Joints[JointType.HipLeft]);
                this.HipRight = new JointObject(skeleton.Joints[JointType.HipRight]);

                this.ElbowLeft = new JointObject(skeleton.Joints[JointType.ElbowLeft]);
                this.WristLeft = new JointObject(skeleton.Joints[JointType.WristLeft]);
                this.HandLeft = new JointObject(skeleton.Joints[JointType.HandLeft]);

                this.ElbowRight = new JointObject(skeleton.Joints[JointType.ElbowRight]);
                this.WristRight = new JointObject(skeleton.Joints[JointType.WristRight]);
                this.HandRight = new JointObject(skeleton.Joints[JointType.HandRight]);

                this.KneeLeft = new JointObject(skeleton.Joints[JointType.KneeLeft]);
                this.AnkleLeft = new JointObject(skeleton.Joints[JointType.AnkleLeft]);
                this.FootLeft = new JointObject(skeleton.Joints[JointType.FootLeft]);

                this.KneeRight = new JointObject(skeleton.Joints[JointType.KneeRight]);
                this.AnkleRight = new JointObject(skeleton.Joints[JointType.AnkleRight]);
                this.FootRight = new JointObject(skeleton.Joints[JointType.FootRight]);
            }
        }

        [SerializableAttribute]
        public class JointObject
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }

            public JointObject(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public JointObject(Joint joint)
            {
                this.x = joint.Position.X;
                this.y = joint.Position.Y;
                this.z = joint.Position.Z;
            }
        }

}
