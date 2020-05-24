using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript : MonoBehaviour
{

    public Transform myPrefab;
    public int anzahl;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i<=anzahl; i++)
        {
         Transform prefab =  Instantiate(myPrefab, new Vector3(UnityEngine.Random.Range(-10f, 10f), 0f, UnityEngine.Random.Range(-10f, 10f)), myPrefab.rotation);
            prefab.GetComponent<ColorScript>().color = color;
            Debug.Log("Prefab color: " + prefab.GetComponent<ColorScript>().color);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
