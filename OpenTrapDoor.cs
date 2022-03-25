using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTrapDoor : MonoBehaviour
{

    public GameObject TrapDoor;
    public Camera Camera;
    public float range = 3f;
    public float open = 100f;
    public bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f"))
        {
            Shoot();
        }

        if(Input.GetKeyDown("f") & isOpen == true)
        {
            ShootTwo();
        }
    }

    void ShootTwo()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                TrapDoor.transform.eulerAngles = new Vector3(TrapDoor.transform.eulerAngles.x - 90, TrapDoor.transform.eulerAngles.y, TrapDoor.transform.eulerAngles.z);
            }
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                TrapDoor.transform.eulerAngles = new Vector3(TrapDoor.transform.eulerAngles.x + 90, TrapDoor.transform.eulerAngles.y, TrapDoor.transform.eulerAngles.z);
            }
        }
    }

}
