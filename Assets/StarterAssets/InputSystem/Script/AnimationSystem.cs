using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSystem : MonoBehaviour
{
    private int _animIDTest;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animIDTest = Animator.StringToHash("Test");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            _animator.SetBool(_animIDTest, true);
        }    
    }





}
