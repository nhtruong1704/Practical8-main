using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
          anim.SetTrigger("JumpTrigger");


           // Random color generator
           Color newColor = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1.0f);

           // Set the color to a renderer or material
           Renderer renderer = GetComponent<Renderer>();
           if (renderer != null) {
               renderer.material.color = newColor;
           }

        }
    }
}
