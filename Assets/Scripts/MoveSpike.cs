using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpike : MonoBehaviour
{
    [SerializeField] private Transform endPosition;
    [SerializeField] private ScoreCounter scoreCounter;

    private Transform currentPosition;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = GetComponent<Transform>().position;
        currentPosition = GetComponent<Transform>();
    }


    private void OnEnable()
    {
        scoreCounter.changeScoreEvent.AddListener(MovePosition);
    }
    private void OnDisable()
    {
        scoreCounter.changeScoreEvent.RemoveListener(MovePosition);

    }

    public void MovePosition()
    {
        Vector3 tempPoint = Vector3.Lerp(endPosition.position, startPosition,  scoreCounter.Score / 100);
        StartCoroutine(moveOverSecondsCor(currentPosition, tempPoint, 1));
    }

    public IEnumerator moveOverSecondsCor(Transform objectToMove, Vector3 end, float seconds)
    {
        float elapsedTime = 0;
        Vector3 startingPos = objectToMove.position;
        while (elapsedTime < seconds)
        {
            objectToMove.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        objectToMove.position = end;
    }
}
