using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairIndicator : MonoBehaviour
{
    private Material[] _temp;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().materials = new Material[] { Instantiate(this.GetComponent<MeshRenderer>().materials[0]) as Material };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColorToWaiting()
    {
        _temp = this.GetComponent<MeshRenderer>().materials;
        _temp[0].color = Color.white;
        this.GetComponent<MeshRenderer>().materials = _temp;
    }

    public void ChangeColorToActive()
    {
        _temp = this.GetComponent<MeshRenderer>().materials;
        _temp[0].color = Color.green;
        this.GetComponent<MeshRenderer>().materials = _temp;
    }

    public void ChangeColorToInactive()
    {
        _temp = this.GetComponent<MeshRenderer>().materials;
        _temp[0].color = Color.yellow;
        this.GetComponent<MeshRenderer>().materials = _temp;
    }
}
