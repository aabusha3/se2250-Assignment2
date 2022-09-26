using UnityEngine;

public static class FinalFields 
{
    //houses all the variables that reused in multiple scripts
    public static readonly float CAMERA_HEIGHT = Camera.main.orthographicSize,//the height of the viewable area
                                 CAMERA_WIDTH = CAMERA_HEIGHT * Camera.main.aspect,//the width of the viewable area
                                 RADIUS = 2.2f,//small adjestor to prevent going out of bounds
                                 SPEED = 30,//the speed of everything 
                                 ROLL_MULT = -45,//the degree that the player ship tilts at horizontal
                                 PITCH_MULT = 30;//the degree that the player ship tilts at vertically
}
