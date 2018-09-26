using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public abstract class Shape
    {
        private string myId;

        public Shape(string s)
        {
            Id = s;
        }

        public string Id //类型
        {
            get
            {
                return myId;
            }

            set
            {
                myId = value;
            }
        }


        public abstract double Area //面积,抽象属性
        {
            get;
        }

        public virtual void Draw() //绘制,虚方法
        {
            Console.WriteLine("Draw Shape Icon");
        }

        public override string ToString() // 覆盖object的虚方法
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }
    }

    //三角形类
    public class Triangle : Shape
    {
        private int baseside;//底边
        private int height;//高
        private double angle;//角

        public Triangle(int baseside,int height,double angle, string id)
            : base(id)
        {
            this.baseside = baseside;
            this.height = height;
            this.angle = angle;
        }

        public override double Area	//实现面积
        {
            get
            {
                return this.baseside * this.height;
            }
        }

        public override void Draw() //覆盖绘制方法
        {
            Console.WriteLine("Draw Triangle:" + this.baseside + "," + this.height + "," + this.angle);
        }
    }

    // 圆类
    public class Circle : Shape
    {
        private int myRadius; //半径

        public Circle(int radius, string id)
            : base(id)
        {
            myRadius = radius;
        }

        public override double Area  //实现面积
        {
            get
            {
                return myRadius * myRadius * System.Math.PI;
            }
        }

        public override void Draw() //覆盖绘制方法
        {
            Console.WriteLine("Draw Circle:" + myRadius);
        }

    }

    //正方形类
    public class Square : Shape
    {
        private int mySide; //边长

        public Square(int side, string id)
            : base(id)
        {
            mySide = side;
        }

        public override double Area	//实现面积
        {
            get
            {
                return mySide * mySide;
            }
        }

        public override void Draw() //覆盖绘制方法
        {
            Console.WriteLine("Draw 4 Side:" + mySide);
        }
    }

    //矩形类
    public class Rectangle : Shape
    {
        private int myWidth;
        private int myHeight;

        public Rectangle(int width, int height, string id)
            : base(id)
        {
            myWidth = width;
            myHeight = height;
        }

        public override double Area
        {
            get
            {
                return myWidth * myHeight;
            }
        }

        public override void Draw() //覆盖绘制方法
        {
            Console.WriteLine("Draw Rectangle");
        }

    }

    //测试
    public class TestClass
    {
        public static void Main()
        {
            Shape[] shapes =
         {
            new Triangle (12,5,34,"Triangle #1"), 
            new Circle(4, "Circle #1"),
            new Square(4, "Square #1"),            
            new Rectangle( 3, 4, "Rectangle #1")
         };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }

        }
    }

}
