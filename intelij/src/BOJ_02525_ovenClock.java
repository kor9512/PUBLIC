import java.util.Scanner;

public class BOJ_02525_ovenClock {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int inHour = in.nextInt();
        int inMin = in.nextInt();
        int inPlusMin = in.nextInt();

        in.close();
        inHour += (inMin + inPlusMin)/60;
        inHour = inHour % 24;
        inMin = (inMin + inPlusMin) % 60;

        System.out.printf("%d %d \n", inHour, inMin);
        //System.out.println(inHour +" "+ inMin);
    }
}