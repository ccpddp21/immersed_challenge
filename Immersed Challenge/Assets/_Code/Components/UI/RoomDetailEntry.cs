using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoomDetailEntry : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _displayNameText;
    [SerializeField] private TextMeshProUGUI _professorText;
    [SerializeField] private TextMeshProUGUI _descriptionText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRoomDetails(string displayName, string professor, string description)
    {
        this._displayNameText.text = displayName;
        this._professorText.text = professor;
        this._descriptionText.text = description;
    }
}
