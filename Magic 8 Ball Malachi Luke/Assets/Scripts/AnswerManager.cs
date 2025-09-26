using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerManager : MonoBehaviour
{

    public List<string> answers;
    public TextMeshProUGUI AnswerText;
    public KeyCode AnswerKey;
    private float lastFortuneTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        lastFortuneTime -= Time.deltaTime;

        if (lastFortuneTime <= 0)
        {
            if (Input.GetKey(AnswerKey))
            {
                GiveAnswer();

                lastFortuneTime = 1;
            }
            

        }


    }

    void GiveAnswer()
    {
        int rand = Random.Range(0, answers.Count);
        AnswerText.SetText(answers[rand]);
    }
}
