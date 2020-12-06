using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _verticalValue, _horizontalValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _verticalValue = Input.GetAxis("Vertical");
        _horizontalValue = Input.GetAxis("Horizontal");

        if (_verticalValue != 0)
        {
            this.transform.localPosition += (this.transform.forward * _verticalValue * Time.deltaTime);
        }
        
        if (_horizontalValue != 0)
        {
            this.transform.localPosition += (this.transform.right * _horizontalValue * Time.deltaTime);
        }
    }
}
