using UnityEngine;

public class DogManager : MonoBehaviour
{
    #region 欄位
    public Dog DogA = new Dog();
    public Dog DogB = new Dog();
    #endregion

    #region 事件
    private void Start()
    {
        DogA.name = "一";
        DogA.weight = 20.1f;
        DogA.type = "土狗";
        DogA.sex = "公";
        DogA.color = "黑";
        DogA.age = 4;

        DogB.name = "二";
        DogB.weight = 10.4f;
        DogB.type = "吉娃娃";
        DogB.sex = "母";
        DogB.color = "白";
        DogB.age = 3;

        Debug.Log(DogA.name + " 品種:" + DogA.type + " 顏色:" + DogA.color);
        Debug.Log(DogB.name + " 品種:" + DogB.type + " 顏色:" + DogB.color);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name + " 的實際年齡為" + DogA.ConvertAge());
        Debug.Log(DogB.name + " 的實際年齡為" + DogB.ConvertAge());

        DogA.Eat("肉");
        DogB.Eat("草", 100);
    }
    #endregion
}
