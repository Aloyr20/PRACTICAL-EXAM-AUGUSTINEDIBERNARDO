using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] GameObject Target;
    private Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        SetTarget();
    }

    private void SetTarget()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("hit");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("hit1");
                Target.transform.position = hit.point;
            }
        }
    }
}

