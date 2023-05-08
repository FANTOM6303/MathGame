using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstRandom1 : MonoBehaviour
{
    [SerializeField] Text textAnim;
    [SerializeField] int numberText = 1;
    [SerializeField] int number;

    private void Start()
    {
        StartCoroutine(Randomaiser());
    }

    private void Update()
    {
        textAnim.text = numberText.ToString();
    }
    IEnumerator Randomaiser()
    {
        while (true) 
        {
            yield return new WaitForSeconds(0.2f);
            numberText++;
            if (numberText>=13)
            {
                numberText = 1;
            }
        }
    }

}
