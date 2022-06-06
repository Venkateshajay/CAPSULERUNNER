using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform transformobject;
    public Vector3 cameraoffset;
    // Start is called before the first frame update
    void Start()
    {
        cameraoffset = transform.position - transformobject.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        Vector3 newposition = transformobject.transform.position + cameraoffset;
        transform.position = newposition;
    }

}
