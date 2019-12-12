namespace Alex_Game_Lib
{
    namespace Matrix
    {
		
		
        /*
		Vector Namespace holds three vector structs 
		----------------------------------
		Vector => a one dimensional vector
		Vector2 => a two dimensional vector
		Vector3 => a three dimensional vector
		
		Vectors 1-3 include 
		=> Operator overloads for
			=> addition
			=> subtraction
		*/
        namespace Vector
        {
            using implement;
            //declare Vector with one Dimensions
            public struct Vector : Vec
            {
                //variable declaration
                float x;


                public Vector(float x = 0)
                {
                    this.x = x;
                }

                public float X
                {
                    get { return x; }
                    set { x = value; }
                }

                public static Vector operator +(Vector a, Vector b)
                {
                    return new Vector(a.X + b.X);
                }

                public static Vector operator -(Vector a, Vector b)
                {
                    return new Vector(a.X - b.X);
                }

            }

            //declare Vector with two Dimensions
            public struct Vector2 : Vec2
            {
                float x;
                float y;

                public Vector2(float x = 0, float y = 0)
                {
                    this.x = x;
                    this.y = y;
                }

                public float X
                {
                    get { return x; }
                    set { x = value; }
                }

                public float Y
                {
                    get { return y; }
                    set { y = value; }
                }

                public static Vector2 operator +(Vector2 a, Vector2 b)
                {
                    return new Vector2(a.X + b.X, a.Y + b.Y);
                }

                public static Vector2 operator -(Vector2 a, Vector2 b)
                {
                    return new Vector2(a.X - b.X, a.Y - b.Y);
                }

            }

            //declare Vector with three Dimensions
            public struct Vector3 : Vec3
            {
                float x;
                float y;
                float z;

                public Vector3(float x = 0, float y = 0, float z = 0)
                {
                    this.x = x;
                    this.y = y;
                    this.z = z;
                }

                public float X
                {
                    get { return x; }
                    set { x = value; }
                }

                public float Y
                {
                    get { return y; }
                    set { y = value; }
                }

                public float Z
                {
                    get { return z; }
                    set { z = value; }
                }

                public static Vector3 operator +(Vector3 a, Vector3 b)
                {
                    return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
                }

                public static Vector3 operator -(Vector3 a, Vector3 b)
                {
                    return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
                }
            }

        }
    }
}