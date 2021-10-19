using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventDetector : MonoBehaviour
{

    public GameObject EffectBox;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PunchiEffect() 
    {
        InstantiateObject();
    }

    private void InstantiateObject()
    {
        GameObject Obj;
        Obj = (GameObject)Resources.Load("Magichit");
        Instantiate(Obj, EffectBox.transform.position, Quaternion.identity, EffectBox.transform);

    }

}
