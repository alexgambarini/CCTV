using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAT : MonoBehaviour

{
    // public Vector3 lookAtPoint = Vector3.zero;
        public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.LookAt(new Vector3(target.Vector3.x, target.Vector3.x, target.Vector3.x));
                transform.LookAt(target);
                transform.Rotate(0, 180, 0, Space.Self);
    }
}
