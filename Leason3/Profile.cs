using Leason3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Leason3
{
    public class Profile
    {
        public string fullname = "Шакиров Артём Ринатович";
        public int height = 170;
        public float weightfloat = 40.123f;
        public double weightdouble = 40.1234238514132481;
        public bool Gender = false;
        public DateTime birthday = new DateTime(2007, 4, 2);
        public Color color = Color.FromArgb(0, 255, 0, 0);
    }
}