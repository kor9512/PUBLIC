import java.util.Arrays;
import java.util.Scanner;

//public class Main {
public class BOJ_02480_tripleDice {
    public static int[] swap(int[] arr, int idx, int idy){
        int temp = arr[idx];
        arr[idx] = arr[idy];
        arr[idy] = temp;
        return arr;
    }
    public static void main(String[] args) {
        int[] arr = new int[3];//{0,0,0};
        Scanner in = new Scanner(System.in);
        arr[0] = in.nextInt();
        arr[1] = in.nextInt();
        arr[2] = in.nextInt();
        in.close();

        Arrays.sort(arr);
        /*
        if(arr[0] > arr[1]) swap(arr, 0,1);
        if(arr[1] > arr[2]) swap(arr,1,2);
        if(arr[0] > arr[1]) swap(arr,0,1);
        */
        int inResult=0;
        int inEqaul =0;
        for(int inIdx =1; arr.length >inIdx;inIdx++){
            if(arr[inIdx] == arr[inIdx -1]) inEqaul++;
        }
        switch (inEqaul)
        {
            case 0:
                inResult = arr[2] * 100;
                break;
            case 1:
                inResult = 1000 + (arr[1] * 100);
                break;
            case 2:
                inResult = 10000 + (arr[1] * 1000) ;
                break;
            default:
                break;
        }
        System.out.printf("%d \n", inResult );
    }
}