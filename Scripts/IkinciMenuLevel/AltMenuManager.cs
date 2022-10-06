using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class AltMenuManager : MonoBehaviour
{
    [SerializeField] GameObject altMenuPaneli;
    void Start()
    {
        altMenuPaneli.GetComponent<CanvasGroup>().DOFade(1, 1f);
        altMenuPaneli.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBack);
    }

    public void HangiOyunAcilsin(string hangiOyun)
    {
        PlayerPrefs.SetString("hangiOyun", hangiOyun);
        SceneManager.LoadScene("GameLevel");
    }

    public void GeriDon()
    {
        SceneManager.LoadScene("MenuLevel");
    }
}
