using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CoroutineTesting : MonoBehaviour
{
   public CanvasGroup fadeCanvasGroup;
   public float fadeSpeed = 1f;
   public int sceneToLoadIndex;
   public void FadeAndLoadScene()
   {
       StartCoroutine(FadeAndLoadSceneRoutine());
   }
   IEnumerator FadeAndLoadSceneRoutine()
   {
       float alpha = 0f;
       while (alpha < 1f)
       {
           alpha += fadeSpeed * Time.deltaTime;
           fadeCanvasGroup.alpha = alpha;
           yield return null;
       }
       yield return new WaitForSeconds(0.5f);
       SceneManager.LoadScene(sceneToLoadIndex);
   }
}