using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public bool moveForward = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //irgendwie müsste der RigidBody noch diabled werden?
        if ( transform.position.z >= 5)
        {
            //transform.position -= new Vector3(0, 0, 0.1f);
            moveForward = false;
        }
        else if(transform.position.z <= -3)
        {
            moveForward = true;
            //transform.position += new Vector3(0, 0, 0.1f);
        }

        if (moveForward)
        {
            transform.position += new Vector3(0, 0, 0.1f);
            transform.Rotate(new Vector3(0, 0, 0.1f));
        }
        else
        {
            transform.position -= new Vector3(0, 0, 0.1f);
            transform.Rotate(new Vector3(0, 0, -0.1f)); //geht noch nicht(?)
        }

        transform.Rotate(new Vector3( 0, 0, UnityEngine.Random.Range(-1f, 1f)));

    }

    private void OnCollisionEnter(Collision Other)
    {
        moveForward = !moveForward;
    }
}
