using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contiroller : MonoBehaviour
{
   public GameObject VideoWarning = null;  
   public GameObject Characters = null;
   
   public void Start()
   {
    VideoWarning.SetActive(false);
    Characters.SetActive(false);
    //ShowCharacters();
    StartCoroutine(WaitBeforeShow());
   }

   private void ShowCharacters()
   {
    VideoWarning.SetActive(true);
    Characters.SetActive(true);
   }

  private IEnumerator WaitBeforeShow()
   {
    VideoWarning.SetActive(true);
     yield return new WaitForSeconds(22);
     Characters.SetActive(true);
   }
}

