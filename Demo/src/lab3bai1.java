package lab3;

import java.util.Scanner;

public class lab3bai1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("nhap mot so bat ky tu ban phim: ");
		int n = sc.nextInt();
		boolean ok = true;
		for (int i = 2; i < n - 1; i++) {
			if (n % i == 0) // % la lay phan du cua so chia vd: 4%2 so du =0
			{
				ok = false;
				System.out.println("day khong phai la so nguyen to !");
				break;
			}
			i++;
			if (n % i != 0) {
				ok = true;
				System.out.print("day la so nguyen to !");
				break;
			}

		}

	}
}
