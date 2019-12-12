 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clientSpawner : MonoBehaviour
{
    public List<Transform> clients = new List<Transform>();
    float timer = 5;
    int clientCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawner de clientes.
        timer -= 1 * Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(clients[Random.Range(0, clients.Count)], transform.position, Quaternion.identity);
            timer = 10;
        }
        
    }
}
