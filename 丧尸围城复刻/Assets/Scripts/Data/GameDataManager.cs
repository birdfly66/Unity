using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager 
{
   private static GameDataManager instance=new GameDataManager();

    public static GameDataManager Instance => instance;

    public MusicData musicData;
    public List<roleInfo> roleInfos;
    public PlayerData playerData;
    private GameDataManager() 
    {
        musicData = JsonMgr.Instance.LoadData<MusicData>("MusicData");
        roleInfos = JsonMgr.Instance.LoadData<List<roleInfo>>("roleInfo");
        playerData = JsonMgr.Instance.LoadData<PlayerData>("PlayerData");
    }


    /// <summary>
    /// 存储音量大小
    /// </summary>
    /// <param name="value"></param>
    public void SaveMusicDataValue(float value)
    {
        musicData.musicValue= value;
    }

    /// <summary>
    /// 存储音量开关
    /// </summary>
    /// <param name="open"></param>
    public void SaveMusicOpen(bool open)
    {
        musicData.musicOpen= open;
    }
}
