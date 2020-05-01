//--------------------------------------------------------------------------
// 
//  Copyright (c) Microsoft Corporation.  All rights reserved. 
// 
//  File: Robot.cs
//
//--------------------------------------------------------------------------

using System.Threading;
using System.Windows.Shapes;

namespace AntisocialRobots
{
    /// <summary>Represents one robot.</summary>
    internal class Robot
    {
        private static int id = 0;

        public Robot()
        {
            Interlocked.Increment(ref id);
            ID = id;
        }

        public int ID;

        /// <summary>The visual element used to represent the robot on the screen.</summary>
        public Ellipse Element;

        /// <summary>The current location of the robot within the room.</summary>
        public RoomPoint Location;

        /// <summary>The game frame in which this robot was last moved.</summary>
        public int LastMovedFrame;

        public int LongRunning
        {
            get
            {
                Thread.Sleep(5000);
                return 5;
            }
        }

        public override string ToString()
        {
            return "ID: " + ID + " LastMovedFrame: " + LastMovedFrame;
        }
    }
}
