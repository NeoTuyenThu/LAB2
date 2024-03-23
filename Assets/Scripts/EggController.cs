using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    public GameObject Egg;
  

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("ground"))
        {
            Instantiate (EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, .1f);
            Destroy (this, 0.1f);
        }
        if (col.gameObject.name.Equals("Farmer"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject,0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("box"))
        {
            Destroy(gameObject, 0.1f);
            Destroy (this, 0.1f);
        }
    }
}
