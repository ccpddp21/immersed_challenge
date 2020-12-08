using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSelector : NetworkedBehaviour
{
    [SerializeField] private GameObject _chairContainer;
    [SerializeField] private List<GameObject> _chairList;

    // Start is called before the first frame update
    void Start()
    {
        RecordChairs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RecordChairs()
    {
        for (int i = 0; i < _chairContainer.transform.childCount; i++)
        {
            _chairList.Add(_chairContainer.transform.GetChild(i).gameObject);
        }
    }
}
