using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager 
{
    private static UIManager instance=new UIManager();
    public static UIManager Instance => instance;

    private Transform canvasTransform;
    private UIManager()
    {
        //单例创建时创建一个Canvas用于设置面板的存放
        //创建
        GameObject canvas = GameObject.Instantiate(Resources.Load<GameObject>("Canvas"));
        canvasTransform = canvas.transform;
        GameObject.DontDestroyOnLoad(canvas);
        
    }
    private Dictionary<string,BasePanel> panelDic=new Dictionary<string,BasePanel>();

    public T showPanel<T>() where T : BasePanel 
    {
        string panelName=typeof(T).Name;
        //如果字典里已经有面板显示了则直接返回即可
        if(panelDic.ContainsKey(panelName) )
        {
            return panelDic[panelName] as T;
        }
        //字典里没有面板则动态创建一个用来显示并保存在字典里面
        GameObject panelObj=GameObject.Instantiate(Resources.Load<GameObject>(panelName),canvasTransform,false);
        BasePanel panel=panelObj.GetComponent<BasePanel>();
        panel.Show();
        panelDic[panelName]=panel;
        return panel as T;

    }

    //隐藏面板如果
    public void HidePanel<T>()where T : BasePanel
    {
        string panelName = typeof(T).Name;
        if (panelDic.ContainsKey(panelName))
        {
            GameObject.Destroy(panelDic[panelName].gameObject);
            panelDic.Remove(panelName);
        }

    }

    //获取面板
    public T getPanel<T>() where T:BasePanel
    {
        string panelName=typeof(T).Name;
        if (panelDic.ContainsKey(panelName))
        {
            return panelDic[panelName] as T;
        }
        return null;
    }
}
