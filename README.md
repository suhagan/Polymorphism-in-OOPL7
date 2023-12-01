# Polymorphism-in-OOPL7

# About the task

This is a school workshop assignment where we have practiced using polymorphism in object-oriented programming. The task is largely about devising a structure for polymorphism.

# What have I done here

- [ ] We have learned to create a class that will work as a ParentClass to the other classes and those classes will inherit from it. The class is called `GeoMetry{ }` and it has a method called `Area()` and its `return` type is a double.
- [ ] I have also learned to create five other classes which are ChildClass to the GeoMetry class, and they are named - `RecTangle`, `SquAre`, `CirCle`, `ParalleLogram` and `ElliPse`. And they also have a method called `Area().`
- [ ] Learned to set own special properties to each class, for example:
    
     ```csharp
     public class Circle{
          public double Radius {get; set;}
     }
     ```
    
- [ ] In all ChildClasses we have practiced overriding the `Area()` method with different implementations because the area of a circle is not calculated the same way as the area of a square.
- [ ] All ChildClasses have a constructor to provide values to the properties. I have learned to provide a fixed value setting through the constructor's parameter. For example:
    
     ```csharp
     public CirCle(double raDius)
        {
            circleRadius = raDius;
        }

     public static void main[]
     {
       GeoMetry[] shapes = new GeoMetry[5];
       ...
       ...
       shapes[2] = new CirCle(4);
       ...
       ...  
     }
     ```
    
- [ ] In the Main() method we have created an object reference from the GeoMetry class and it has pointed to objects from each class.
      for example:

      ```csharp
     public Circle
        {
           circleRadius = radiUs;
        }

     public static void main[]
        {
           GeoMetry[] shapes = new GeoMetry[5];
           shapes[0] = new RecTangle(6, 13);
           shapes[1] = new SquAre(5);
           shapes[2] = new CirCle(4);
           shapes[3] = new ParalleLogram(7, 4);
           shapes[4] = new ElliPse(5, 3);
           
        }
     ```

     - [ ] In this assignment I have tried to see the output in different ways, other than the assignment's requirement.
