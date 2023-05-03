using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector3.up * 5 * Time.deltaTime);
    }

}
