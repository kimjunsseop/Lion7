public class Item
{
    public string Name;
    public int AddAtk; // 추가 공격력
    public int AddDef; // 추가 방어력

    public Item(string name, int atk, int def = 0)
    {
        Name = name;
        AddAtk = atk;
        AddDef = def;
    }
}