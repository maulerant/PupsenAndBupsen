using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCharacter : MonoBehaviour
{
    [SerializeField] private Transform _character;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_character.transform.position.x, _character.transform.position.y, transform.position.z);
    }
}
