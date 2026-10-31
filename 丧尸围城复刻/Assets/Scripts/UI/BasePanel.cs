using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePanel : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private  bool isShow = false;

    protected  void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;

    }
    protected void Start()
    {
        Init();
    }

    public abstract void Init();

    protected void Update()
    {
        if (isShow&&canvasGroup.alpha!=1)
        {
            canvasGroup.alpha += Time.deltaTime;

        }
    }

    public void Show()
    {
        canvasGroup.alpha = 0;
        isShow=true;
    }

    public void Hide()
    {
        canvasGroup.alpha = 1;
    }
}
