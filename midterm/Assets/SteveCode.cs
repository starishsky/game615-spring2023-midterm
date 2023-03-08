using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveCode : MonoBehaviour
{
    public Rigidbody rb;
    float moveSpeed = 50f;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Time.deltaTime * moveSpeed, 0, 0, Space.Self);
        GameObject player = GameObject.Find("PlayerCapsule");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("rock"))
        {
            gameObject.transform.Rotate(0, 180, 0, Space.World);
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerCapsule")
        {
            Debug.Log("you died forreal");
            Destroy(player.gameObject);

        }
    }

}
