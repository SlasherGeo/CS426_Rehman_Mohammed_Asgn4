using UnityEngine;

public class billboard : MonoBehaviour
{
    [SerializeField]
    private Camera mainCam;

    Transform tran;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tran = mainCam.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + tran.forward);
    }
}
