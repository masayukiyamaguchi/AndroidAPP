using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Photon.Pun;

public class Gmic02 : MonoBehaviourPunCallbacks
{
    public GameObject Stairs01;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<StarterAssetsInputs>().test)
            {
                photonView.RPC(nameof(RPCGmic02DoneFnc), RpcTarget.All);
            }
        }
    }


    [PunRPC]
    private void RPCGmic02DoneFnc() 
    {
        Stairs01.SetActive(true);
        this.gameObject.transform.parent.gameObject.SetActive(false);
    }




}
