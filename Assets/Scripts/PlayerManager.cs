using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject lua;
    [SerializeField] private GameObject ruhe;

    /*private bool luaUnlocked = true;
    public bool ruheUnlocked = false;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            Vector3 lastPosition = ruhe.transform.position;
            lua.transform.position = lastPosition;
            lua.SetActive(true);
            ruhe.SetActive(false);
            Debug.Log("funciona?");
        }

        if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            Vector3 lastPosition = lua.transform.position;
            ruhe.transform.position = lastPosition;
            lua.SetActive(false);
            ruhe.SetActive(true);
        }
    }
}
