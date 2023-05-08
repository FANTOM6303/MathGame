using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RundomCklik20 : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject obj1_;
    [SerializeField] GameObject obj2_;
    [SerializeField] GameObject obj3_;
    [SerializeField] GameObject obj4_;
    [SerializeField] GameObject obj5_;
    [SerializeField] int numberText = 0;
    [SerializeField] int number;


    private void Start()
    {
        StartCoroutine(RandomCount());
        obj.SetActive(true);
        obj1_.SetActive(false);
        obj2_.SetActive(false);
        obj3_.SetActive(false);
        obj4_.SetActive(false);
        obj5_.SetActive(false);

    }

    IEnumerator RandomCount()
    {
        yield return new WaitForSeconds(0);
        obj1_.GetComponent<Text>().text = Random.Range(1, 21).ToString();
        string obj_ = obj1_.GetComponent<Text>().text;
        obj2_.GetComponent<Text>().text = obj_;
        obj3_.GetComponent<Text>().text = obj_;
        obj4_.GetComponent<Text>().text = obj_;
        obj5_.GetComponent<Text>().text = obj_;
    }
    private void OnMouseDown()
    {
        obj.SetActive(false);
        obj1_.SetActive(true);
        obj2_.SetActive(true);
        obj3_.SetActive(true);
        obj4_.SetActive(true);
        obj5_.SetActive(true);
    }

}
