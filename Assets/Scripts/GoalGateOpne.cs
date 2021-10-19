using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GoalGateOpne : MonoBehaviourPunCallbacks
{
    public GameObject PortalRedOpen;
    public GameObject PortalRedIdle;
    public GameObject PortalRedClose;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            photonView.RPC(nameof(RPCOnTriggerEnter), RpcTarget.All);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            photonView.RPC(nameof(RPCOnTriggerExit), RpcTarget.All);
        }
    }



    [PunRPC]
    public void RPCOnTriggerEnter() 
    {
            PortalRedOpen.SetActive(true);
            Invoke("PortalOpen", 0.7f);
    }

    public void PortalOpen()
    {
        PortalRedOpen.SetActive(false);
        PortalRedIdle.SetActive(true);
    }

    [PunRPC]
    public void RPCOnTriggerExit()
    {
        PortalRedClose.SetActive(true);
        PortalRedIdle.SetActive(false);
        Invoke("PortalClose", 0.7f);
    }

    public void PortalClose()
    {
        PortalRedClose.SetActive(false);
    }







}
