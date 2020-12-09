using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMenuController : MonoBehaviour
{
    [SerializeField] private GameObject _roomDetailPanelPrefab;
    [SerializeField] private GameObject _roomEntryContainer;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Canvas>().worldCamera = GameObject.FindObjectOfType<Camera>();
        Debug.Log(GameObject.FindObjectOfType<Camera>() == null);
    }

    void LateUpdate()
    {
        if (this.GetComponent<Canvas>().worldCamera == null)
        {
            this.GetComponent<Canvas>().worldCamera = GameObject.FindObjectOfType<Camera>();
        }
    }

    public void AddEntries(Room[] rooms)
    {
        foreach (Room room in rooms)
        {
            GameObject entry = GameObject.Instantiate(_roomDetailPanelPrefab, _roomEntryContainer.transform);
            _roomDetailPanelPrefab.transform.localScale = new Vector3(1, 1, 1);

            RoomDetailEntry rde = _roomDetailPanelPrefab.GetComponent<RoomDetailEntry>();
            rde.SetRoomDetails(room.displayName, string.Join(", ", room.professors.ToArray()), room.description);
        }
        
    }
}
