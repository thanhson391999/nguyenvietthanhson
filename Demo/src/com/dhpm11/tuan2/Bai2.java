package com.dhpm11.tuan2;
import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
public class Bai2 extends JFrame {
	public Bai2() {
		setTitle("First Swing");
		setVisible(true);
		setSize(300,300); //het hang xuong dong
		//setSize(600,300);//du hang thi khong xuong dong
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		getContentPane().setBackground(Color.BLACK);
		JPanel pnFlow = new JPanel();
		pnFlow.setLayout(new FlowLayout());
		pnFlow.setBackground(Color.PINK);
		JButton btn1=new JButton("FlowLayout");
		JButton btn2=new JButton("Add các control");
		JButton btn3=new JButton("Trên 1 dòng");
		JButton btn4=new JButton("Hết chỗ chứa");
		JButton btn5=new JButton("Thì xuống dòng");
		pnFlow.add(btn1);pnFlow.add(btn2);
		pnFlow.add(btn3);pnFlow.add(btn4);
		pnFlow.add(btn5);
		Container con=getContentPane();
		con.add(pnFlow);
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Bai2();
	}
}

