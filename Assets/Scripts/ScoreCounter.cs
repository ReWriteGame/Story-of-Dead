using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text output;

    [SerializeField] private float score = 0;
    [SerializeField] private float maxScore;
    [SerializeField] private float minScore = 0;




    public UnityEvent changeScoreEvent;
    public UnityEvent takeAwayScoreEvent;
    public UnityEvent addScoreEvent;
    public UnityEvent isMinScoreEvent;
    public UnityEvent isMaxScoreEvent;



    public float Score { get => score; private set => score = value; }

    void Start()
    {
        updateScore();
    }

   
    public void updateScore()
    {
        output.text = $"{score}";
    }
    public void add(float value)
    {
        if (value < 0) return;

        //health = health > data.maxHealthPerHeal ? data.maxHealthPerHeal : health;
        score = (score + value) >= maxScore ? maxScore : (score + value);

        // Events
        changeScoreEvent?.Invoke();
        addScoreEvent?.Invoke();
        if (score >= maxScore) isMaxScoreEvent?.Invoke();
        //changeHP?.Invoke(data.HP);
        //healthEvent?.Invoke(health);
    }

    public void takeAway(float value)
    {
        if (value < 0) return;
        score = (score - value) <= minScore ? minScore : (score - value);

        // Events
        changeScoreEvent?.Invoke();
        takeAwayScoreEvent?.Invoke();
        if (score <= minScore) isMinScoreEvent?.Invoke();
        //changeHP?.Invoke(data.HP);
        //damageEvent?.Invoke(health);
    }

    //public void checkMaxScore()
    //{

    //}

    private void OnEnable()
    {
        changeScoreEvent.AddListener(updateScore);
    }
    private void OnDisable()
    {
        changeScoreEvent.RemoveListener(updateScore);

    }
}
 //todo дописать проверки на вылет за мин макс
