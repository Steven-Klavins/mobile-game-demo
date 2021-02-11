using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    private Transform centerBackground;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Camera
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, target.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);


        //Background Scrolling
        if (transform.position.y >= centerBackground.position.y + 10)
        {
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y + 10);
        }
        else if (transform.position.y <= centerBackground.position.y - 10)
        {
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y - 10);
        }
    }

}
