using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //called before Update() randimize the initial start of the angle change
    void Start()
    { 
        if (tag == "Enemy_1")
        {
            int direction = Random.Range(0, 2);
            switch (direction)
            {
                case 0: RotateZDeg(45f);
                    break;
                case 1: RotateZDeg(-45f);
                    break;
            }
        }
    }

    // LateUpdate is called as the last update cycle as to avoid any input delays for the player
    void LateUpdate()
    {    
        if (tag == "Enemy_1" && (transform.position.x > FinalFields.CAMERA_WIDTH 
            || transform.position.x < -FinalFields.CAMERA_WIDTH))
            RotateZDeg(-90f);//rotates the ship by 90 degrees when it reaches either horizontal edge

        transform.Translate(Vector2.down * FinalFields.SPEED * Time.deltaTime);//moves the ship downwards in a constant speed

        if(transform.position.y < -(FinalFields.CAMERA_HEIGHT + FinalFields.RADIUS) 
            || transform.position.y > (FinalFields.CAMERA_HEIGHT + FinalFields.RADIUS))
            Destroy(gameObject);//destroys the ship when it goes out of bounds on the y-axis
    }

    //applies a rotation on the z axis by zAngle degrees 
    void RotateZDeg(float zAngle)
    {
        transform.Rotate(0, 0, zAngle);
    }
}
