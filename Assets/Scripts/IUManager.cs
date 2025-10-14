using UnityEngine;
using DG.Tweening;
using System;

public class IUManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject itemMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.Instance.OnMainMenu += ActivateMenu;
        GameManager.Instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.Instance.OnARPosition += ActivateARPosition;
    }

    private void ActivateMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f).SetEase(Ease.OutBack);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f).SetEase(Ease.OutBack);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f).SetEase(Ease.OutBack);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBack);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBack);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBack);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBack);
    }

    private void ActivateItemsMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutBack);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutBack);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutBack);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.InBack);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.InBack);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
    }

    private void ActivateARPosition()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutBack);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutBack);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutBack);

        itemMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBack);
        itemMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.InBack);
        itemMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.InBack);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.InBack);
    }
}
