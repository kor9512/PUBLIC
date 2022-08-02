public class _12940_GcdNLcm {
   
   public int[] solution(int n, int m) {
      int[] answer = {0,0};
      int inGcd = 0;

      if(n > m)
      {
         inGcd = Euclidean(n,m);
      }
      else
      {
         inGcd = Euclidean(m,n);
      }
      answer[0] = inGcd;
      answer[1] = n*m/inGcd;

      return answer;
  }
  public int Euclidean(int n, int m){
      int inTmpGcd = 1;
      int inMod = 1;
      // Euclidean
      /* 
           a. 두 수 A, B 중 큰 수, 작은 수를 판별한다.
           b. 큰 수를 작은 수로 나누어 나머지를 구한다.
           if 나머지가 0 : 작은 수가 최대공약수    
           if 나머지가 0이 아니면 : 나누기 반복 
      */

      // n > m
      do {
         inMod = n % m;  
         n = m;
         m = inMod;       
      } while (inMod != 0);      
      inTmpGcd = m=n;
      return inTmpGcd; 
  }

  public static void main(String[]  args)  { 
      _12940_GcdNLcm GNL = new _12940_GcdNLcm();
      System.out.println(GNL.solution(3,12)); // 3,12     
      System.out.println(GNL.solution(2,5)); // 1,10     
      System.out.println("End");
   }

   
}