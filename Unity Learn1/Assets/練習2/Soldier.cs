using UnityEngine;

public class Soldier
{
    public int exp;
    public int lv;

    /// <summary>
    /// 設定經驗值 計算經驗值為:等級 * 10
    /// </summary>
    /// <returns>傳回計算後的經驗值</returns>
    public int GetExp()
    {
        exp = lv * 10;
        return exp;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="getExp"></param>
    public void SetExp(int getExp)
    {
        exp = getExp;
    }
}

