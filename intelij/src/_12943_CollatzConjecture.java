public class _12943_CollatzConjecture {
   /*
   1-1. 입력된 수가 짝수라면 2로 나눕니다. 
   1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더합니다. 
   2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다. 

   num은 1 이상 8,000,000 미만인 정수

   주어진 수가 1인 경우에는 0을, 작업을 500번 반복할 때까지 1이 되지 않는다면 –1을 반환
   */
  public int solution(int num) {
   long lnCollatz = num;
   int inIdx = 0;

   while(lnCollatz != 1 && inIdx < 500){
      if(lnCollatz % 2 == 0) lnCollatz /= 2;
      else lnCollatz = 3*lnCollatz +1;
      inIdx++;
   }

   if(inIdx == 500) inIdx = -1;
   
   return inIdx;
   }
  

   public static void main(String[]  args)  { 
      _12943_CollatzConjecture cc = new _12943_CollatzConjecture();
      System.out.println(cc.solution(1)); // 0
      System.out.println(cc.solution(6)); // 8
      System.out.println(cc.solution(16)); // 4
      System.out.println(cc.solution(626331)); // -1

      System.out.println("End");
   }

}