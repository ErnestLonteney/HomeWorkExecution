namespace Essencial.Task_1._2
{
    // Прямокутник
    class Rectangle(double side1, double side2)
    {  
        public double Area => GetArea();  
        
        public double Perimetr => GetPerimetr();       

        private double GetArea() => side1 * side2;

        private double GetPerimetr() => 2 * (side1 + side2);        
    }
}
