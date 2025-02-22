namespace DesignPattern.Flyweight;

public class FlyweightFactory
{
    private readonly Dictionary<string, FlyWeight> _flyweightDic = new Dictionary<string, FlyWeight>();
    public FlyWeight GetFlyweight(string key)
    {
        FlyWeight? flyWeight;
        if (_flyweightDic.TryGetValue(key, out flyWeight)) return flyWeight;
        flyWeight = new ConcreteFlyweight(key);
            
        _flyweightDic.Add(key, flyWeight);
        return flyWeight;
    }
}