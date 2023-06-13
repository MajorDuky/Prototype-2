using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{

    public Slider hungerSlider;
    public int amountToBeFed;
    private int currentFedAmount;
    private LivesAndScoreCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
        counter = GameObject.Find("Counter").GetComponent<LivesAndScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimals(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if(currentFedAmount >= amountToBeFed)
        {
            counter.IncreaseScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
