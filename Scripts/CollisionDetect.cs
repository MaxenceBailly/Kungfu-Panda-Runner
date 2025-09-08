using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionFx;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());
    }

    IEnumerator CollisionEnd()
    {
        collisionFx.Play();
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        mainCamera.GetComponent<Animator>().Play("CollisionCam");
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
