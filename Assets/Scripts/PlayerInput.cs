using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public KeyCode key1;
    bool pressed1 = false;
        public KeyCode key2;
    bool pressed2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    } 
        //----- Key 1 -----
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key1))
		{
			pressed1 = true;
            
			
			//gameObject.GetComponent<AudioSource>().Play(); // (transform.position.x > 40 && transform.position.x < -40)
		}

		if (pressed1 && transform.position.x > -40){
        Debug.Log("pressed1");
                    transform.position += new Vector3(-1, 0, 0);
        }

		if (Input.GetKeyUp(key1))
		{

            pressed1 = false;
			
			//gameObject.GetComponent<AudioSource>().Play();
		}
        //----- Key 2 -----
        if (Input.GetKeyDown(key2))
		{
			pressed2 = true;
			
			//gameObject.GetComponent<AudioSource>().Play();
		}

		if (pressed2 && transform.position.x < 40){
                    Debug.Log("pressed2");
                    transform.position += new Vector3(1, 0, 0);

		}

		if (Input.GetKeyUp(key2))
		{
            pressed2 = false;
			
			//gameObject.GetComponent<AudioSource>().Play();
		}
        
    }
}
