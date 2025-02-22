namespace DesignPattern.Flyweight;

public class UnSharedConcreteFlyweight(IEnumerable<FlyWeight> flyWeights) : FlyWeight
{
    private IEnumerable<FlyWeight> _flyweights=flyWeights;

    public override void Operation(string extrinsicState)
    {
        foreach (var flyWeight in _flyweights)
        {
            flyWeight.Operation(extrinsicState);
        }
    }
}