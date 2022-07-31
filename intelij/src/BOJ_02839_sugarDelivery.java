import java.util.Scanner;

public class BOJ_02839_sugarDelivery {
//public class Main {
    //DP 적응을 위한 풀이 공부
    //https://godbell.tistory.com/26
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        int inKg = in.nextInt();
        in.close();

        int[] arr = new int[inKg+1];
        int[] defaultab = {-1, -1, -1, 1, -1, 1, 2, -1, 2, 3, 2, 3, 4, 3};

        if (inKg <= 13) {
            System.out.println(defaultab[inKg]);
            return;
        }
        else
            for (int i = 0; i <= 13; i++)
                arr[i] = defaultab[i];
            // 원문에서는 i<=7 까지 세팅

        for(int inIdx = 13; inKg >= inIdx; inIdx++)
            arr[inIdx] = 1 + Math.min(arr[inIdx - 3], arr[inIdx - 5]);

        /*
        for (int i = 8; i <= N; i++)
        {
            if(dynamic[i-5] != -1 && dynamic[i-3] != -1)
                dynamic[i] = 1 + Math.min(dynamic[i - 3], dynamic[i - 5]);
            else if(dynamic[i-5] == -1 && dynamic[i-3] != -1)
                dynamic[i] = 1 + dynamic[i-3];
            else if(dynamic[i-5] != -1 && dynamic[i-3] == -1)
                dynamic[i] = 1 + dynamic[i-5];
        }
        */

        System.out.printf("%d\n", arr[inKg]);
    }
}