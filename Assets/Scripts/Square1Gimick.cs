using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Square1Gimick : MonoBehaviourPunCallbacks
{
    public GameObject SqareBox01;
    public GameObject SqareBox02;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            photonView.RPC(nameof(RPCOntriggerEnterGimic01), RpcTarget.All);
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            photonView.RPC(nameof(RPCOntriggerExitGimic01), RpcTarget.All);
        }        
    }

    [PunRPC]
    public void RPCOntriggerEnterGimic01() 
    {
            SqareBox01.SetActive(true);
            SqareBox02.SetActive(false);
    }

    [PunRPC]
    public void RPCOntriggerExitGimic01()
    {
            SqareBox01.SetActive(false);
            SqareBox02.SetActive(true);
    }



}
