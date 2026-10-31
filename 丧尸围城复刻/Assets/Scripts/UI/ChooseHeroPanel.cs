using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseHeroPanel :BasePanel
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button buyButton;
    [SerializeField] private Button leftButton;
    [SerializeField] private Button rightButton;
    [SerializeField] private Button startButton;

    public override void Init()
    {
        backButton.onClick.AddListener(() =>
        {
            UIManager.Instance.HidePanel<ChooseHeroPanel>();
            UIManager.Instance.showPanel<BeginPanel>();
        });

        buyButton.onClick.AddListener(() =>
        {

        });

        leftButton.onClick.AddListener(() =>
        {

        });

        rightButton.onClick.AddListener(() =>
        {

        });

        startButton.onClick.AddListener(() =>
        {

        });

    }

    private void Changerole()
    {

    }
}
