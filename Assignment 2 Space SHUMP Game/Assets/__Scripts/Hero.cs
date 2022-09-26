using UnityEngine;

public class Hero : MonoBehaviour
{
    // Update is called once per frame to move the player based on input
    void Update()
    {
        //pull in info from Input class
        float axisX = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Vertical");

        //change transform.pos basic on the axes
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow)
            || Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
            pos.y += axisY * FinalFields.SPEED * Time.deltaTime;
           
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow) 
            || Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            pos.x += axisX * FinalFields.SPEED * Time.deltaTime;
         
        transform.position = pos;

        //rotate the ship to make it feel more dynamic
        transform.rotation = Quaternion.Euler(axisY * FinalFields.PITCH_MULT, axisX * FinalFields.ROLL_MULT, 0);
    }

    //destroy the player ship and the enemy ship
    void OnTriggerEnter(Collider collided)
    {
        Destroy(collided.gameObject);
        Destroy(gameObject);
    }
}
