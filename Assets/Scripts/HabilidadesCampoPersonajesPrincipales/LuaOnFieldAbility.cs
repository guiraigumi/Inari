using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaOnFieldAbility : MonoBehaviour
{
    private Animator anim;

    //[SerializeField] private Transform particleSpawn

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxisRaw("Vertical");
        anim.SetFloat("VelZ", z);
        
        float x = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("VelX", x);
       

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        Ability();
    }

    void Ability()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(!anim.GetBool("Lua_ability"))
            {
                anim.SetBool("Lua_ability", true);
            }
            else
            {
                anim.SetBool("Lua_ability", false);
            }

        }
            
    }



}

