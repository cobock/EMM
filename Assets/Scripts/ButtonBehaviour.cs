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


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "up":
                Debug.Log("up");
                player.transform.Translate(0, -step, 0);
                break;
            case "left":
                Debug.Log("left");
                player.transform.Rotate(0, 0, step);
                break;
            case "right":
                Debug.Log("right");
                player.transform.Rotate(0,0,-step);
                break;
            case "down":
                Debug.Log("down");
                player.transform.Translate(0, step, 0);
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
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
        
    }
}
