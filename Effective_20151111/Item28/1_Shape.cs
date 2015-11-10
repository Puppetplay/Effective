using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item28
{
    class _1_Shape
    {
        public void Func1()
        {
            Circle c = new Circle(new PointF(3.0f, 0), 5.0f);
            ComputeArea(c);
            Flatten(c);

            //Circle c2 = new Circle(new PointF(3.0f, 0), 5.0f);
            //Flatten(new Ellipse(c2));

            //Circle c3 = new Circle(new PointF(3.0f, 0), 5.0f);
            //Ellipse e = new Ellipse(c3);
            // Flatten(new Ellipse(c3));


        }

        public double ComputeArea(Ellipse e)
        {
            // e넓이 구하기
            return 3;
        }

        public void Flatten(Ellipse e)
        {
            e.R1 /= 2;
            e.R2 *= 2;
        }
    }

    public class Shape
    {
        public virtual void Draw()
        {

        }
    }

    public class Circle : Shape
    {
        private PointF _center;
        private float _radius;

        public float R1
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle() : this(PointF.Empty, 0)
        {

        }

        public Circle(PointF c, float r)
        {
            _center = c;
            _radius = r;
        }

        public override void Draw()
        {

        }

        static public implicit operator Ellipse(Circle c)
        {
            return new Ellipse(c._center, c._center, c._radius, c._radius);
        }

        //static public explicit operator Ellipse(Circle c)
        //{
        //    return new Ellipse(c._center, c._center, c._radius, c._radius);
        //}
    }

    public class Ellipse : Shape
    {
        private PointF _center1;
        private PointF _center2;

        private float _radius1;
        private float _radius2;

        public float R1
        {
            get { return _radius1; }
            set { _radius1 = value; }
        }

        public float R2
        {
            get { return _radius2; }
            set { _radius2 = value; }
        }

        //public Ellipse(Circle c)
        //{
        //    _radius1 = c.R1;
        //    _radius2 = c.R1;
        //}

        public Ellipse() : this(PointF.Empty, PointF.Empty, 0, 0)
        {

        }

        public Ellipse(PointF c1, PointF c2, float r1, float r2)
        {
            _center1 = c1;
            _center2 = c2;
            _radius1 = r1;
            _radius2 = r2;
        }


        public override void Draw()
        {

        }
    }
}
