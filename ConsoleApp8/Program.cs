using System;

namespace ConsoleApp10 // https://blog.hexabrain.net/137
{
    class misco
    {
        public String age;
        public String sex;
        public String height;
        public String name;

        public void hello()
        {
            Console.WriteLine("안녕하세요.");
        }
    }
    class progarm
    {
        static void main(String[] args)
        {
            misco misco = new misco();
            misco.name = "안동건";
            misco.sex = "남자";
            misco.height = "170";
            misco.age = "18";

            misco.hello();

            Console.WriteLine("{0}는 {1}이며 {2}살이며 {3}cm이다", misco.name, misco.sex, misco.age, misco.height);
        }
    }
}
