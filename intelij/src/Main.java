import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int A = in.nextInt();
        String B = in.next();

        in.close();

        // 조사식을 통해 B.charAt(2)과 B.charAt(2) - '0' 비교
        // 문자 1 -> ASCII 49 -> 문자 0 ASCII 48
        System.out.println(A * (B.charAt(2) - '0'));
        System.out.println(A * (B.charAt(1) - '0'));
        System.out.println(A * (B.charAt(0) - '0'));
        System.out.println(A * Integer.parseInt(B));

    }
}