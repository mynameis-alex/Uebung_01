using UnityEngine;

public class TeleportationController: MonoBehaviour
{

    //Variables, connected via editor
    public GameObject start;

    //Variables, only used by this Controller
    //...


    private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.CompareTag("Player") == true) {
            collider.transform.position = start.gameObject.transform.position;
        }
    }

}
