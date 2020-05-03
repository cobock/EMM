using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputMoving : MonoBehaviour
{

    public Transform camera;
    private Vector3 targetDirection;
    private Quaternion targetRotation;
    private float w;

    // Start is called before the first frame update
    void Start()
    {
        w = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(moveHorizontal, 0, moveVertical );
        //camera.transform.position = transform.position + new Vector3(0, 0, -10);

        if (Input.GetKey(KeyCode.Y))
        {
            //w = Quaternion.Angle(transform.position, new Vector3(transform.position.x, transform.position.y+1, transform.position.y));
            //rotiere links
            //transform.Rotate(0, 1, 0);

            //targetDirection = new Vector3(sin(w), 0, cos(w));
            //targetRotation = Quarternion.LookRotation(targetDirection);
            //transform.rotation = targetRotation;

            w = w + 0.05f;

            targetDirection = new Vector3(Mathf.Sin(w), 0, Mathf.Cos(w));
            targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = targetRotation;

            //Vector3 offsetRotated = targetRotation * offsetVector;

        }

        if (Input.GetKey(KeyCode.C))
        {
            //Winkel abhängig von Input.getAxis("Horizontal")
            //w = Quaternion.Angle(???, ???);
            //rotiere rechts
            //transform.Rotate(0, -1, 0);

            w = w - 0.05f;

            targetDirection = new Vector3(Mathf.Sin(w), 0, Mathf.Cos(w));
            targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = targetRotation;
        }

        //a = so wies war
        //b = so wies werden soll
        

        //w = InputMoving.getAxis("Horizontal");

    }
}
