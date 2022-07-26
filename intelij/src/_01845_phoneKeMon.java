import java.util.HashSet;

public class _1845_phoneKeMon {

    public int solution(int[] nums) {
        int answer = 0;
        int inBagSize = nums.length / 2 ;
        HashSet<Integer> hs = new HashSet<Integer>();
        //HashSet<Integer> hs = new HashSet<Integer>(Arrays.asList(nums));
        for(int inRow : nums){
            hs.add(inRow);
        }

        if(hs.size() >= inBagSize)
        {
            answer = inBagSize;
        }
        else
        {
            answer = hs.size();
        }

        return answer;
    }
    

    public  static  void  main(String[]  args)  { 
        _1845_phoneKeMon pk = new _1845_phoneKeMon();
        //int[] nums = new int[]{3,1,2,3}; // 2
        //pk.solution(nums);
        System.out.println(pk.solution(new int[]{3,1,2,3})); // 2
        System.out.println(pk.solution(new int[]{3,3,3,2,2,4})); // 3
        System.out.println(pk.solution(new int[]{3,3,3,2,2,2})); // 2

        System.out.println("End");
        }

    }