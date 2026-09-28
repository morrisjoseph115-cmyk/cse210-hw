using System.Security.Cryptography.X509Certificates;

class Circle
{
    public double _radius;


    public double GetArea()
    {
        return _radius * _radius * 3.14159;
    }
}