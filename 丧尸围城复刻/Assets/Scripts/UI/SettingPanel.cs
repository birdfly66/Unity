using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : BasePanel
{
    [SerializeField] private Toggle musicToggle;
    [SerializeField] private Slider musicSlider;

    [SerializeField] private Toggle soundToggle;
    [SerializeField] private Slider volumeSlider;

    [SerializeField] private Button cancelButton;

    public override void Init()
    {
        cancelButton.onClick.AddListener(() =>
        {
            //将音乐数据保存到本地中
            JsonMgr.Instance.SaveData(GameDataManager.Instance.musicData, "MusicData");
            UIManager.Instance.HidePanel<SettingPanel>();
        });


        //当音乐滑块改变时，调整音乐大小并将其存储到数据中
        musicSlider.value = GameDataManager.Instance.musicData.musicValue;
        musicSlider.onValueChanged.AddListener((float value) =>
        {
            BKMusic.Instance.ChangeMusicValue(value);
            GameDataManager.Instance.SaveMusicDataValue(value);
        });

        musicToggle.isOn = GameDataManager.Instance.musicData.musicOpen;
        //当音乐按钮改变时，调整音乐按钮开光
        musicToggle.onValueChanged.AddListener((bool value) =>
        {
            BKMusic.Instance.ChangeMusicOpen(value);
            GameDataManager.Instance.SaveMusicOpen(value);
        });

       
    }

   
}
