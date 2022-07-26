public class _12937_OddOrEven {

    public String solution(int num) {
        String answer = "";
        if( (num & 1) != 1)
        {
            answer = "Even";
        }
        else
        {
            answer = "Odd";
        }
        return answer;
    }

   public  static  void  main(String[]  args)  {
      _12937_OddOrEven oe = new _12937_OddOrEven();
      System.out.println(oe.solution(0));
      System.out.println(oe.solution(1));
      System.out.println(oe.solution(2));
      System.out.println(oe.solution(3));
      System.out.println(oe.solution(4));
      System.out.println("answer");
   }

}