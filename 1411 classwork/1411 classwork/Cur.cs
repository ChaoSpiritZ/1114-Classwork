using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411_classwork
{
    public class Car
    {
        public string model;
        public int year;
        public string color;
        public float height;
        public bool work;

        public Car()
        {
            this.model = "no model";
            this.year = -1;
            this.color = "no color";
            this.height = -1.0f;
            this.work = true;
        }

        public Car(string model)
        {
            this.model = model;
            this.year = -1;
            this.color = "no color";
            this.height = -1.0f;
            this.work = true;
        }

        public Car(string model, int year, string color, float height, bool work)
        {
            this.model = model;
            this.year = year;
            this.color = color;
            this.height = height;
            this.work = work;
        }

        public void Fix()
        {
            this.work = true;
        }

        public void Paint(string color)
        {
            this.color = color;
        }

        public void BadTire()
        {
            this.work = false;
            this.height = this.height * 0.8f;
        }

        public override string ToString()
        {
            return $"Cur: model: {model}, year: {year}, color: {color}, height: {height}, work:{work}";
        }
    }
}
