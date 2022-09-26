using UnityEngine;

public class BoundsCheck : MonoBehaviour
{
    // LateUpdate is called at the last update cycle
    void LateUpdate()
    {
        Vector3 pos = transform.position;//gets current position

        //shifts pos by a slight amount preventing the object from leaving the camera's boarders
        if(pos.x > FinalFields.CAMERA_WIDTH - FinalFields.RADIUS)
            pos.x = FinalFields.CAMERA_WIDTH - FinalFields.RADIUS;

        if (pos.x < FinalFields.RADIUS - FinalFields.CAMERA_WIDTH)
            pos.x = FinalFields.RADIUS - FinalFields.CAMERA_WIDTH;

        if (pos.y > FinalFields.CAMERA_HEIGHT - FinalFields.RADIUS)
            pos.y = FinalFields.CAMERA_HEIGHT - FinalFields.RADIUS;

        if (pos.y < 1.5f* FinalFields.RADIUS - FinalFields.CAMERA_HEIGHT)
            pos.y = 1.5f * FinalFields.RADIUS - FinalFields.CAMERA_HEIGHT;

        transform.position = pos;//sets new position
    }
}
