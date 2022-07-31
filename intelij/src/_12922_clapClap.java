public class _12922_clapclap {
    public String solution(int n) {
        String answer = "";
        StringBuilder sb = new StringBuilder();
        for(int inIdx=0; n > inIdx;inIdx++)
        {
            // 0도 제대로 짝수 취급 받는게 맞겠지?
            switch(inIdx & 1){
                case 0:
                    sb.append("수");
                    break;
                case 1:
                    sb.append("박");
                    break;
                default :
                    break;

            }
        }
        //sb.append("문자열 ").append("연결");
        answer = sb.toString();
        return answer;
    }

    

    public  static  void  main(String[]  args)  {
        _12922_clapclap cl = new _12922_clapclap();
        System.out.println(cl.solution(1));
        System.out.println(cl.solution(2));
        System.out.println(cl.solution(3));
        System.out.println(cl.solution(4));

        System.out.println("End");
        }
    
    }