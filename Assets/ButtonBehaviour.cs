using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonBehaviour : MonoBehaviour, IVirtualButtonEventHandler
{
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "up":
                break;
            case "left":
                break;
            case "right":
                break;
            case "down":
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
