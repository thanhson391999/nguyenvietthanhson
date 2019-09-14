package lab3;
import java.util.Arrays;
import java.util.Scanner;
public class lab3bai3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("nhap so phan tu trong mang:");
		int n=sc.nextInt();
		int[] a = new int[n];
		for (int i=0 ; i<n ; i++)
		{
			System.out.print("so thu "+i+":");
			a[i]=sc.nextInt();
		}
		//tim so nho nhat
		int min=a[0];
		for (int i=0;i<a.length;i++)
		{
			if (a[i]<min)
			{
				min=a[i];
			}
		}
		System.out.println("so nho nhat trong mang la: "+min);
		// sap xep
				Arrays.sort(a);
				System.out.println("mang sap xep theo thu tu tang dan: ");
				show(a);
				System.out.println("");
		//tinh tb cong cac phan tu chia het cho 3
				int tong=0;
				int dem=0;
		for (int i=0;i<a.length;i++)
		{
			if (a[i]%3==0)
			{
				
				 tong=tong + a[i];
				 dem++;
				 System.out.println("tong"+tong);
				 System.out.println("dem"+dem);
				}
		}
			float tb = (float)tong/dem;
			System.out.print("tong tb la: "+tb);

		}
	public static void a(int[] a)
	{
		int temp=a[0];
		for(int i=0;i< a.length-1;i++)
		{
			for(int j=i+1;j<a.length;j++)
			{
				if (a[i]>a[j])
				{
					temp=a[j];
					a[j]=a[i];
					a[i]=temp;
				}
			}
		}
	}
	public static void show(int[] a)
	{
		for (int i=0;i<a.length;i++)
			System.out.print(a[i]+ " ");
	}
	

}
