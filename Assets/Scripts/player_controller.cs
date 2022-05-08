using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    private int count;
    public GameObject door;
    public GameObject mona;
    public Material green;
    void Start()
    {
        count = 4;
        mona.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OpenDoor()
    {
        door.gameObject.GetComponent<Light>().color = green.color;
        mona.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            if(count >= 5)
            {
                OpenDoor();
            }
        }
    }
}
