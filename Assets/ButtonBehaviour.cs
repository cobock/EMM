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


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "up":
                Debug.Log("up");
                player.transform.position = transform.position + new Vector3(-10, 0, 0);
                break;
            case "left":
                Debug.Log("left");
                w = w + 0.05f;

                targetDirection = new Vector3(Mathf.Sin(w), 0, Mathf.Cos(w));
                targetRotation = Quaternion.LookRotation(targetDirection);
                player.transform.rotation = targetRotation;

                break;
            case "right":
                Debug.Log("right");
                w = w - 0.05f;

                targetDirection = new Vector3(Mathf.Sin(w), 0, Mathf.Cos(w));
                targetRotation = Quaternion.LookRotation(targetDirection);
                player.transform.rotation = targetRotation;
                break;
            case "downX":
                Debug.Log("downX");
                player.transform.position = transform.position + new Vector3(20, 0, 0);
                break;
            case "downY":
                Debug.Log("downY");
                player.transform.position = transform.position + new Vector3(0, 20, 0);
                break;
            case "downZ":
                Debug.Log("downZ");
                player.transform.position = transform.position + new Vector3(0, 0, 20);
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
        //SearchforallChildrenfromthisImageTargetwithtypeVirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for( int i = 0; i < vbs.Length; ++i){
            //RegisterwiththevirtualbuttonsTrackableBehaviour
            vbs[i].RegisterEventHandler(this);}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
