using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI管理相关
/// </summary>
public class UImaneger : MonoBehaviour
{
    //单例模式
    public static UImaneger instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public Image healthBar;//角色血条
    /// <summary>
    /// 更新血条
    /// </summary>
    /// <param name="curAmount"></param>
    /// <param name="maxAmount"></param>
    public void UpdateHealthBar(int curAmount,int maxAmount)
    {
        healthBar.fillAmount = (float)curAmount / (float)maxAmount;
    }
}
