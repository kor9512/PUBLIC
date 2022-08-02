public class _70128_dotProduct {
    public int solution(int[] a, int[] b) {
        int answer = 0;
        for(int inIdx=0; a.length > inIdx ; inIdx++)
        {
            answer += a[inIdx]*b[inIdx];
        }
        return answer;
    }
    

    public  static  void  main(String[]  args)  { 
        _70128_dotProduct dp = new _70128_dotProduct();
        System.out.println(dp.solution(new int[]{1,2,3,4} 
                                    , new int[]{-3,-1,0,2})); // 3 
        System.out.println(dp.solution(new int[]{-1,0,1} 
                                    , new int[]{1,0,-1})); // -2 
                                    
        System.out.println("End");
        }

    }