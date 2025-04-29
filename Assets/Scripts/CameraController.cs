using System.Numerics;
using UnityEngine;

public class CameraController: MonoBehaviour {

    public GameObject ball;
    private float offsetX;
    private float y;
    private float offsetZ;

    void Start() {
        offsetX = transform.position.x - ball.transform.position.x;
        y = transform.position.y; //always keep the same height of camera, only update x/z movement
        offsetZ = transform.position.z - ball.transform.position.z;
    }

    void LateUpdate() {
        
        float x = ball.transform.position.x + offsetX;
        float z = ball.transform.position.z + offsetZ;

        transform.position = new UnityEngine.Vector3(x, y, z);
    
    }
}
