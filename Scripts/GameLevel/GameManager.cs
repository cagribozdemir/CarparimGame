using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject baslaImage;
    void Start()
    {
        if (PlayerPrefs.HasKey("hangiOyun"))
        {
            //Debug.Log(PlayerPrefs.GetString("hangiOyun"));
        }

        StartCoroutine(baslaYaziRoutine());

    }

    IEnumerator baslaYaziRoutine()
    {
        baslaImage.GetComponent<RectTransform>().DOScale(1.3f, 0.5f);
        yield return new WaitForSeconds(0.6f);
        baslaImage.GetComponent<RectTransform>().DOScale(0f, 0.5f).SetEase(Ease.InBack);
        baslaImage.GetComponent<CanvasGroup>().DOFade(0f, 1f);
        yield return new WaitForSeconds(0.6f);

        OyunaBasla();
    }

    void OyunaBasla()
    {
        Debug.Log("oyun basladi");
    }

}
