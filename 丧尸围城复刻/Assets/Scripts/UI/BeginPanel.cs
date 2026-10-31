using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginPanel : BasePanel
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button settingButton;
    [SerializeField] private Button quitButton;
    public override void Init()
    {
        //点击开始按钮
        startButton.onClick.AddListener(() =>
        {

        });

        //点击设置按钮
        settingButton.onClick.AddListener(() =>
        {
            UIManager.Instance.showPanel<SettingPanel>();
        });

        //点击退出按钮
        quitButton.onClick.AddListener(() =>
        {
            //退出游戏
            Application.Quit();
        });
    }
}
