using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 6) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("destroy_trigger")){
            Destroy(gameObject);
        }
    }
}
