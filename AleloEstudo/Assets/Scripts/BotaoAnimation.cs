using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoAnimation : MonoBehaviour {


	public Transform EndPosistion;
    public Transform StartPosition;
    

	public float Speed ;

	void Start() {
		// StartCoroutine (MoveOverSeconds (gameObject, EndPosistion.transform.position, Speed));
		// StartCoroutine(Breath()); // Breathing
        // startTime = Time.time;
        // journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update() {
        // float distCovered = (Time.time - startTime) * speed;
        // float fracJourney = distCovered / journeyLength;
        // transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
    }

    private bool objectCanAnimate = true;
    public void EntrouFocus(){
        Debug.Log("Entrou focus");
        if (objectCanAnimate){
            StartCoroutine (MoveForward (gameObject, EndPosistion.transform.position, AnimationTimeSeconds));
        }
        
		// StartCoroutine(Breath());

        // StartCoroutine(IncreaseSize());

    }

    public void SaiuFocus(){
        Debug.Log("Saiu focus");
        StartCoroutine (MoveBackwards (gameObject, StartPosition.transform.position, AnimationTimeSeconds));
        // StartCoroutine(DecreaseSize());
    }

public IEnumerator MoveOverSpeed (GameObject objectToMove, Vector3 end, float speed){
     // speed should be 1 unit per second
     while (objectToMove.transform.position != end)
     {
         objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, end, speed * Time.deltaTime);
         yield return new WaitForEndOfFrame ();
     }
 }

  public IEnumerator MoveForward (GameObject objectToMove, Vector3 end, float seconds)
 {
     objectCanAnimate = false;
     float elapsedTime = 0;
     Vector3 startingPos = objectToMove.transform.position;
     while (elapsedTime < seconds)
     {
         objectToMove.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
         elapsedTime += Time.deltaTime;
         yield return new WaitForEndOfFrame();
     }
    //  objectToMove.transform.position = end;
    objectCanAnimate = true;
     
 }

 public IEnumerator MoveBackwards (GameObject objectToMove, Vector3 end, float seconds)
 {
     float elapsedTime = 0;
     Vector3 startingPos = objectToMove.transform.position;
     while (elapsedTime < seconds)
     {
         objectToMove.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
         elapsedTime += Time.deltaTime;
         yield return new WaitForEndOfFrame();
     }
    //  objectToMove.transform.position = end;
     objectCanAnimate = false;
 }



private float _currentScale = InitScale;
 public const float TargetScale = 1.5f;
 public const float InitScale = 1f;
 public const int FramesCount = 100;
 public const float AnimationTimeSeconds = 0.5f;
 private float _deltaTime = AnimationTimeSeconds/FramesCount;
 private float _dx = (TargetScale - InitScale)/FramesCount;
 private bool _upScale = true;

 private IEnumerator IncreaseSize(){
 while (_upScale)
         {
             _currentScale += _dx;
             if (_currentScale > TargetScale)
             {
                 _upScale = false;
                 _currentScale = TargetScale;
             }
             transform.localScale = Vector3.one * _currentScale;
             yield return new WaitForSeconds(_deltaTime);
         }
 }

 private IEnumerator DecreaseSize(){
         while (!_upScale)
         {
             _currentScale -= _dx;
             if (_currentScale < InitScale)
             {
                 _upScale = true;
                 _currentScale = InitScale;
             }
             transform.localScale = Vector3.one * _currentScale;
             yield return new WaitForSeconds(_deltaTime);
         }
 }
 
 private IEnumerator Breath()
 {
     while (true)
     {
         while (_upScale)
         {
             _currentScale += _dx;
             if (_currentScale > TargetScale)
             {
                 _upScale = false;
                 _currentScale = TargetScale;
             }
             transform.localScale = Vector3.one * _currentScale;
             yield return new WaitForSeconds(_deltaTime);
         }
 
         while (!_upScale)
         {
             _currentScale -= _dx;
             if (_currentScale < InitScale)
             {
                 _upScale = true;
                 _currentScale = InitScale;
             }
             transform.localScale = Vector3.one * _currentScale;
             yield return new WaitForSeconds(_deltaTime);
         }
     }
 }
 

 
}
