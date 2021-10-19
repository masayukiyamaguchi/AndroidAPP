using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarButtonClick : MonoBehaviour
{
    public GameObject FadeSystemCanvasImage;
    public GameObject FadeSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeScene()
    {
        //FadeManager.Instance.LoadScene("Playground", 1.0f);
        FadeSystem.gameObject.SetActive(true);
        FadeSystemCanvasImage.gameObject.GetComponent<TransitionScript>().StartCoroutineFnc("Playground");
    }


}
