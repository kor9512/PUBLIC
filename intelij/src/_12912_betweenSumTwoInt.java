public class _12912_betweenSumTwoInt {


   public long solution(int a, int b) {
      long answer = 0;
      int tmp = 0;
      if(b > a)
      {
        tmp = a;
        a = b;
        b = tmp;
      }
      for(int inIdx =b; a>=inIdx;inIdx++) answer += inIdx;

      return answer;
   }


   public  static  void  main(String[]  args)  {
      _12912_betweenSumTwoInt bs = new _12912_betweenSumTwoInt();
      System.out.println(bs.solution(3,5));
      System.out.println(bs.solution(3,3));
      System.out.println(bs.solution(5,3));
      System.out.println("answer");
   }

}