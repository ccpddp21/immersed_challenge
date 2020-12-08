using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairIndicator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().materials = new Material[] { Instantiate(this.GetComponent<MeshRenderer>().materials[0]) as Material };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
