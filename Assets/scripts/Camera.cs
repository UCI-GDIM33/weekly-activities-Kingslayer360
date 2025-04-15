using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject cam;
    [SerializeField] Vector3 Offset;


    // Update is called once per frame
    void Update()
    {
        cam.transform.position = this.transform.position + Offset;
    }
}
