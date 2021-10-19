using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    [SerializeField]
    private Material _transitionIn;

    void Start()
    {
        
    }

    public void StartCoroutineFnc(string scene)
    {
        StartCoroutine(BeginTransition(scene));
    }

    IEnumerator BeginTransition(string scene)
    {
        yield return Animate(_transitionIn, 1);
        SceneManager.LoadScene(scene);
        this.gameObject.GetComponent<TransitionScript02>().StartCoroutineFnc();

    }

    /// <summary>
    /// time秒かけてトランジションを行う
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    IEnumerator Animate(Material material, float time)
    {
        GetComponent<Image>().material = material;
        float current = 0;
        while (current < time)
        {
            material.SetFloat("_Alpha", current / time);
            yield return new WaitForEndOfFrame();
            current += Time.deltaTime;
        }
        material.SetFloat("_Alpha", 1);

    }

    

}
