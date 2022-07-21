public class TEST {
    class  AAA {
        int  a  =  10;
        void  d()  {
        System.out.print("Hi"); 
        }       
     }

    public  class  BBB  extends  AAA {
         a  =  20;
         void  d()  {
        System.out.print("Hello");
     }
     public  static  void  main(String[]  args)  { 
        AAA  obj  =  new  BBB();
        obj.d();
        System.out.print(obj.a); 
        }
     }

}
