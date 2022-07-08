using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryGameA : MonoBehaviour
{
   public GameObject VideoGame = null;
   public GameObject Character = null;

    public void Start()
   {
    VideoGame.SetActive(false);
    Character.SetActive(false);
    //ShowCharacters();
    StartCoroutine(WaitBeforeShow());
   }

   private void ShowCharacters()
   {
    VideoGame.SetActive(true);
    Character.SetActive(true);
   }

  private IEnumerator WaitBeforeShow()
   {
    VideoGame.SetActive(true);
     yield return new WaitForSeconds(51);
     Character.SetActive(true);
     VideoGame.SetActive(false);
   }
}
