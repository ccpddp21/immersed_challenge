using MLAPI;
using MLAPI.Spawning;
using MLAPI.Transports.UNET;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RoomDetailEntry : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _displayNameText;
    [SerializeField] private TextMeshProUGUI _professorText;
    [SerializeField] private TextMeshProUGUI _descriptionText;

    private string _address;
    private int _port;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRoomDetails(string displayName, string professor, string description, string address, int port)
    {
        _displayNameText.text = displayName;
        _professorText.text = professor;
        _descriptionText.text = description;
        _address = address;
        _port = port;
    }

    public void JoinRoom()
    {
        Debug.Log(NetworkingManager.Singleton.LocalClientId);
        // NetworkingManager.Singleton.StopHost();
        SceneManager.LoadScene("Lecture Hall");
        GameObject.FindGameObjectWithTag("Room Manager").GetComponent<RoomInitializer>().SpawnPlayerObject();
        NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectAddress = "127.0.0.1"; //takes string
        NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectPort = _port;
        NetworkingManager.Singleton.StartClient();
        NetworkingManager.Singleton.NetworkConfig.NetworkedPrefabs[0].Prefab.GetComponent<NetworkedObject>().SpawnAsPlayerObject(NetworkingManager.Singleton.ServerClientId);
        Debug.Log(NetworkingManager.Singleton.IsClient);
        Debug.Log(NetworkingManager.Singleton.IsConnectedClient);

        

        
    }
}
