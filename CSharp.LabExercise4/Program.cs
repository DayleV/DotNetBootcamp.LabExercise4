using System;

namespace CSharp.LabExercise4
{
    interface IShape
    {
        string Name { get; set; }

        void ComputeArea();

        void DisplayArea();
    }

    abstract class BaseShape
    {
        public string Name { get; set; }
        public decimal Area { get; set; }
        public decimal FirstEntry { get; set; }
        public decimal SecondEntry { get; set; }
        public void DisplayArea()
        {            
            Console.WriteLine($"{Name} Area: {Area}");
        }
    }

    class Circle: BaseShape, IShape
    {
        public Circle(decimal radius)
        {
            this.Name = "Circle";
            this.FirstEntry = radius;
        }
        public void ComputeArea()
        {
            this.Area = Math.Round(Convert.ToDecimal(Math.PI) * (this.FirstEntry * this.FirstEntry),2);            
        }
    }

    class Square : BaseShape, IShape
    {
        public Square(decimal side)
        {
            this.Name = "Square";
            this.FirstEntry = side;
        }
        public void ComputeArea()
        {
            this.Area = this.FirstEntry * this.FirstEntry;
        }
    }

    class Rectangle : BaseShape, IShape
    {
        public Rectangle(decimal length, decimal width)
        {
            this.Name = "Rectangle";
            this.FirstEntry = length;
            this.SecondEntry = width;
        }
        public void ComputeArea()
        {
            this.Area = this.FirstEntry * this.SecondEntry;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(3);
            circle.ComputeArea();
            circle.DisplayArea();

            IShape square = new Square(5);
            square.ComputeArea();
            square.DisplayArea();

            IShape rectangle = new Rectangle(3,5);
            rectangle.ComputeArea();
            rectangle.DisplayArea();

            IOperators addOperator = new AddOperator();
            addOperator.Compute(10, 5);

            IOperators subtractOperator = new SubtractOperator();
            subtractOperator.Compute(10, 5);

            IOperators multipleOperator = new MultiplyOperator();
            multipleOperator.Compute(10, 5);

            IOperators divideOperator = new DivideOperator();
            divideOperator.Compute(10, 5);
        }
    }

    interface IOperators
    {
        void Compute(decimal firstOperand, decimal secondOperand);
    }

    class AddOperator: IOperators
    {
        public void Compute(decimal firstOperand, decimal secondOperand)
        {
            decimal result = firstOperand + secondOperand;
            Console.WriteLine($"The Sum of {firstOperand} and {secondOperand} is {result}");
        }

    }

    class SubtractOperator : IOperators
    {
        public void Compute(decimal firstOperand, decimal secondOperand)
        {
            decimal result = firstOperand - secondOperand;
            Console.WriteLine($"The Difference of {firstOperand} and {secondOperand} is {result}");
        }

    }

    class MultiplyOperator : IOperators
    {
        public void Compute(decimal firstOperand, decimal secondOperand)
        {
            decimal result = firstOperand * secondOperand;
            Console.WriteLine($"The Product of {firstOperand} and {secondOperand} is {result}");
        }

    }

    class DivideOperator : IOperators
    {
        public void Compute(decimal firstOperand, decimal secondOperand)
        {
            decimal result = firstOperand / secondOperand;
            Console.WriteLine($"The Quotient of {firstOperand} and {secondOperand} is {result}");
        }

    }
}
