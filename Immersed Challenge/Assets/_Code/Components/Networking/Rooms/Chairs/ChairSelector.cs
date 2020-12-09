using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSelector : NetworkedBehaviour
{
    [SerializeField] private GameObject[] _studentSpawnPoints;

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
        _studentSpawnPoints = GameObject.FindGameObjectsWithTag("Student Spawn");
    }

    public Vector3 SelectChair()
    {
        int rand = Random.Range(0, _studentSpawnPoints.Length - 1);
        return _studentSpawnPoints[rand].transform.position;
    }
}
