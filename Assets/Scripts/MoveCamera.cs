using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private float lenght;
    private float startPos;
    public GameObject cam;
    public float effects;
      
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    //parallex when camera moove
    // Update is called once per frame
    void FixedUpdate()
    {
        float tempCam = (cam.transform.position.x * (1 - effects));
        float dist = (cam.transform.position.x * effects);

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        if(tempCam > startPos + lenght)
        {
            startPos += lenght;
        }
        else if(tempCam < startPos - lenght)
        {
            startPos -= lenght;
        }


    }

    private void Update()
    {

        Vector2 camstartpos = cam.transform.position;
        cam.transform.position = camstartpos + Vector2.right * Time.deltaTime;
    }
}
