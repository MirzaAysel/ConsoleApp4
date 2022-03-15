namespace ConsoleApp4
{
    internal class Panda
    { 
        public string name;
        public int age;
        public string height;
       

        public Panda (string name, int age)
        {
            this.name = name;
            this.age=age;
        }

        public Panda (string name, int age, string height) : this(name, age)
        {
            this.height= height; 
            
        }



    }
     
}
    

