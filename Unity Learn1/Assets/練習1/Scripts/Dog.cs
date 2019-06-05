using UnityEngine;

//屬性序列化 可以顯示在Unity屬性面板上
[System.Serializable]
public class Dog
{
    #region 欄位
    public string name;
    public string type;
    public string sex;
    public string color;

    public int age;

    public float weight;
    #endregion
    #region 方法
    /// <summary>
    /// 狗狗叫的方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + ":汪汪");
    }
    /// <summary>
    /// 轉換狗狗年齡方法
    /// </summary>
    /// <returns>狗狗年齡*7</returns>
    public int ConvertAge()
    {
        return age * 7;
    }
    /// <summary>
    /// 吃方法
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="speed">吃飯速度</param>
    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + " 正在吃" + food + " 吃飯速度:" + speed);
    }
    /// <summary>
    /// 吃方法多載
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="count">份量</param>
    public void Eat(string food, int count)
    {
        Debug.Log(name + " 正在吃" + food + " 份量" + count);
    }
    #endregion
}