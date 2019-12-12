namespace Alex_Game_Lib
{
    namespace Matrix
    {
		/*
		Namespace implement holds
		contracts for game engine implementations for
		Alex_Game_Lib.Matrix Implementations
		*/
        namespace implement
        {

            //Game Object Base Class Contract 
            public abstract class game_object<T> where T : Vec
            {
                public abstract T Position { get; set; }
                public abstract T Scale { get; set; }
                public abstract T Rotation { get; set; }

            }

            //Vector base class contract
            public interface Vec
            {
                float X { get; set; }
            }

			//Vector2 class contract
            public interface Vec2 : Vec
            {
                float Y { get; set; }

            }

			//Vector3 class contract
            public interface Vec3 : Vec2
            {
                float Z { get; set; }
            }
        }
    }
}
