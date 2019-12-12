using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customer : MonoBehaviour
{
    public GameObject target;
    public List<string> arms = new List<string>();
	bool taken = false;
	public Text nana;
    
    

    private bool arrive = false;
    private bool candado = true;
    private float speed = 0.1f;
    private float startTime;
    private float journeyLength;

    // Start is called before the first frame update
    void Start()
    {
	    nana.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform.position);
        if (!arrive)
        {
            if (candado)
            {
                startTime = Time.time;
                journeyLength = Vector3.Distance(gameObject.transform.position, target.transform.position);
                candado = !candado;
            }
            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(gameObject.transform.position, target.transform.position, fractionOfJourney);
        }
        //Click para tomar pedido
        if (Input.GetMouseButtonDown(0))
        {
        	
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

	        if (Physics.Raycast(ray, out hit, 1000))
	        {
		        Debug.Log(hit.collider.name);
                // whatever tag you are looking for on your game object
		        if (hit.collider.tag == "c")
                {
			        Debug.Log(arms[0]);
			        nana.text = arms[0];
			        nana.enabled = true;
	                taken = true;
	                Destroy(gameObject);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        arrive = !arrive;
    }
}
