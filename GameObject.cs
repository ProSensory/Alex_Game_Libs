namespace Alex_Game_Lib
{
    using Matrix.implement;
    using Matrix.Vector;

	/*
	GameObjects in Alex_Game_Lib is
	any information about a point inside of 3D Space
	*/
    public class GameObject : game_object<Vector3>
    {
		/*
		holds a vector [x,y,z] for each of the three values
		position, scale, and rotation.
		*/
        Vector3 position;
        Vector3 scale;
        Vector3 rotation;

        public override Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public override Vector3 Scale
        {
            get { return scale; }
            set { scale = value; }
        }
        public override Vector3 Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }
    }


}