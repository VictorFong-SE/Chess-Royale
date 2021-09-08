using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    private float speed = .25f;
    private float zoom = 1.5f;
    private Vector3 origin;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        camera.orthographicSize += Input.GetAxis("Mouse ScrollWheel") * -zoom;

        if (Input.GetMouseButtonDown(0)) {
            origin = Input.mousePosition;
            Debug.Log("Click and drag");
            return;
        }

        if (!Input.GetMouseButton(0)) return;
        Vector3 pos = camera.ScreenToViewportPoint(Input.mousePosition - origin);
        Vector3 mov = new Vector3(pos.x * speed, pos.y * speed, 0);
        camera.transform.Translate(mov, Space.World);
    }
}
