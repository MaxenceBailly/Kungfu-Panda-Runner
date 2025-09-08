using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] AudioSource coinFx;

    void OnTriggerEnter(Collider other)
    {
        coinFx.Play();
        MasterLevelInfo.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
