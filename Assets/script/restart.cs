using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class restart : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI button;
    // Start is called before the first frame update
    public void Onclickresatrt()
    {
        SceneManager.LoadScene("start");
    }
}
