using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEditor.VFX;
using UnityEditor.VFX.UI;

public class VFXScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject myParent = transform.parent.GetComponent<GameObject>();
        VisualEffect visualEffect = this.GetComponent<UnityEngine.VFX.VisualEffect>();
        visualEffect.SetVector4("NewColor", transform.parent.GetComponent<ColorScript>().color);
        Debug.Log("VFX new Color: " + visualEffect.GetVector4("NewColor"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
