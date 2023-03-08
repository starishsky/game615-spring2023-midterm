using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainScript : MonoBehaviour
{
    public GameObject raindrop;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("PlayerCapsule");
        

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // This will instantiate and launch 100 prefabs of the banana car.
            for (int i = 0; i < 10; i++)
            {
                GameObject rain = Instantiate(raindrop, gameObject.transform.position, Quaternion.identity);
                Rigidbody rb = rain.GetComponent<Rigidbody>();
                float rotXAmount = Random.Range(-10, -20);
                
                rain.transform.Rotate(rotXAmount, 0, 0);
                Destroy(rain, 2f);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("steve"))
        {
            Destroy(other.gameObject);
        }

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "PlayerCapsule")
    //    {
    //        Debug.Log("you died forreal");
    //        Destroy(player.gameObject);

    //    }
    //}
}
