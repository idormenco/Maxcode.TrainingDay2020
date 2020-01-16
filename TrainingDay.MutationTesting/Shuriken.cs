using System;

public class Shuriken:IEquatable<Shuriken>
{
    public byte Damage { get; }

    public Shuriken(byte damage)
    {
        Damage = damage;
    }

    public bool Equals(Shuriken other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Damage == other.Damage;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Shuriken) obj);
    }

    public override int GetHashCode()
    {
        return Damage.GetHashCode();
    }
}