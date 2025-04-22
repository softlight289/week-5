using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //below is the character controller input! 
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * 3 * Time.deltaTime);
        }
        else if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * 3 * Time.deltaTime);
        }
        else if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }
        else if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.back * 3 * Time.deltaTime);
        }
    }

    public void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Coin") {
            Destroy(col.gameObject);
        }
    }
}
