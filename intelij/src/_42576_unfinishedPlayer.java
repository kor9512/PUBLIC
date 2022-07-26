import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;

public class _42576_unfinishedPlayer {

    // solutionA,solutionB. Own sol.
    // str1 == str2 VS str1.equals(str2)
    // equals NPE 발생 조건 및 문자열 비교 종류  
    // -> https://codechacha.com/ko/java-string-compare/
    public String solutionA(String[] participant, String[] completion) {
        String answer = "";

        Arrays.sort(participant);
        Arrays.sort(completion);
        
        //if(participant[0] != completion[0])
        if(!(participant[0].equals(completion[0])))
        {
            answer = participant[0];
        }
        else if (!(participant[participant.length -1].equals(completion[completion.length -1])))
        //else if(participant[participant.length -1] != completion[completion.length -1])
        {
            answer = participant[participant.length -1]; 
        }
        else
        {
            int inIdx = 1;
            while (participant.length > inIdx)
            {
                //if(participant[inIdx] != completion[inIdx])
                if(!(participant[inIdx].equals(completion[inIdx])))
                {
                    answer = participant[inIdx];
                    break;
                }
                inIdx ++;
            }
        }
        return answer;
    }
         
    //List<Object> arrList = new ArrayList<>();
    // UPCASTING 해야하는 이유 https://bibi6666667.tistory.com/236 
    public String solutionB(String[] participant, String[] completion) {
        String answer = "";
        List<String> ListrPart = new ArrayList<>();
        List<String> ListrComp = new ArrayList<>();
   

        ListrPart = Arrays.asList(participant); //.ToList();
        ListrComp = Arrays.asList(completion);
        Collections.sort(ListrPart);
        Collections.sort(ListrComp);
         

        // First 비교
        if(ListrPart.get(0) != ListrComp.get(0) ) 
        {
            answer = ListrPart.get(0);
        }
        // Last 비교 
        else if(ListrPart.get(ListrPart.size()-1) != ListrComp.get(ListrComp.size()-1) )
        {
            answer = ListrPart.get(ListrPart.size()-1);
        }
        // Middle 비교 
        else
        {
            int inIdx = 1;
            while (ListrPart.size() > inIdx)
            {
                if(ListrPart.get(inIdx) != ListrComp.get(inIdx))
                {
                    answer = ListrPart.get(inIdx);
                    break;
                }
                inIdx ++;
            }
        }
        return answer;
        
    }    
    
    // HashMap
    public String solutionC(String[] participant, String[] completion) {
        String answer = "";
        HashMap<String, Integer> hm = new HashMap<>();
        for (String player : participant) hm.put(player, hm.getOrDefault(player, 0) + 1);
        for (String player : completion) hm.put(player, hm.get(player) - 1);

        for (String key : hm.keySet()) {
            if (hm.get(key) != 0){
                answer = key;
            }
        }
        return answer;
    }
    
    // Upgrade
    public String solutionD(String[] participant, String[] completion) {
        Arrays.sort(participant);
        Arrays.sort(completion);
        int i;
        for ( i=0; i<completion.length; i++){

            if (!participant[i].equals(completion[i])){
                return participant[i];
            }
        }
        return participant[i];
    }
    
    /*
    public  static  void  main(String[]  args)  { 
        _42576_unfinishedPlayer uP = new _42576_unfinishedPlayer();
        System.out.println(uP.solutionA(new String[]{"mislav", "stanko", "mislav", "ana"} 
            , new String[]{"ana", "mislav", "stanko"})); // mislav
        System.out.println(uP.solutionA(new String[]{"leo", "kiki", "eden"} 
            , new String[]{"eden", "kiki"})); // leo
            System.out.println(uP.solutionA(new String[]{"marina", "josipa", "nikola", "vinko", "filipa"} 
            , new String[]{"josipa", "filipa", "marina", "nikola"})); // vinko
        System.out.println("End");
        }
    */
    }