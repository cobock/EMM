using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonBehaviour : MonoBehaviour, IVirtualButtonEventHandler
{
    private Vector3 targetDirection;
    private Quaternion targetRotation;
    private float w;
    public GameObject player;
    public int step;

    private bool buttonUp;
    private bool buttonLeft;
    private bool buttonRight;
    private bool buttonDown;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "up":
                Debug.Log("up");
                buttonUp = true;
                break;
            case "left":
                Debug.Log("left");
                buttonLeft = true;
                break;
            case "right":
                buttonRight = true;
                break;
            case "down":
                Debug.Log("down");
                buttonDown = true;
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "up":
                Debug.Log("up");
                buttonUp = false; 
                break;
            case "left":
                Debug.Log("left");
                buttonLeft = false;
                break;
            case "right":
                Debug.Log("right");
                buttonRight = false;
                break;
            case "down":
                Debug.Log("down");
                buttonDown = false;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        w = 0;
        //Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for( int i = 0; i < vbs.Length; ++i){
            //Register with the virtualbuttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);}
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonDown)
        {
            player.transform.Translate(0, step, 0);
        }

        if (buttonLeft)
        {
            player.transform.Rotate(0, 0, step);
        }

        if (buttonRight)
        {
            player.transform.Rotate(0, 0, -step);
        }

        if (buttonUp)
        {
            player.transform.Translate(0, -step, 0);
        }
    }
}
