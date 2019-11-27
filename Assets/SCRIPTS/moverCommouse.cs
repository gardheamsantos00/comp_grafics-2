using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCommouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward* 2000f);
        transform.localScale += new Vector3(1, 7, 1);

    }

}
