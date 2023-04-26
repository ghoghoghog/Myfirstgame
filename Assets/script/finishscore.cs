using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class finishscore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        // score2 클래스의 인스턴스를 참조합니다.
        score2 scoreManager = score2.Instance;

        // score2 클래스의 인스턴스가 null이 아닌 경우 myScore 값을 가져옵니다.
        if (scoreManager != null)
        {
            int myScore = scoreManager.myScore;
            text.text = "myscore: " + myScore;
            // 가져온 myScore 값을 사용합니다.
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
